﻿using Application.Interface;
using Application.Request.JobPost;
using Application.Response;
using Application.Response.JobPost;
using Application.Response.User;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Hangfire;
using Application.MyBackgroundJob;
using Application.Response.JobPostActivityComment;
using Application.Extensions;
using Newtonsoft.Json;
using Application.Response.AnalyzedResult;
using System.Text;
using Domain;
using Microsoft.Extensions.Options;

namespace Application.Services
{
    public class JobPostService : IJobPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ApiSettings _apiSettings;

        public JobPostService(IUnitOfWork unitOfWork, IMapper mapper, IEmailService emailService, IOptions<AppSettings> appSettings)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _emailService = emailService;
            _apiSettings = appSettings.Value.ApiSettings;
        }


        public async Task<ApiResponse> AddNewJobPostAsync(JobPostRequest jobPostRequest)
        {
            try
            {
                await ResetJobPostIdSequenceAsync();
                var jobPost = _mapper.Map<JobPost>(jobPostRequest);
                var company = await _unitOfWork.Companys.GetAsync(c => c.Id == jobPostRequest.CompanyId);
                if (company == null)
                {
                    return new ApiResponse().SetBadRequest("Company not found");
                }
                var jobType = await _unitOfWork.JobTypes.GetAsync(jt => jt.Id == jobPostRequest.JobTypeId);
                if (jobType == null)
                {
                    return new ApiResponse().SetBadRequest("Job type not found");
                }

                var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == jobPostRequest.UserId);
                if (user == null)
                {
                    return new ApiResponse().SetBadRequest("User not found");
                }
                if (user.PremiumExpireDate < DateTime.Now)
                {
                    user.IsPremium = false;
                    await _unitOfWork.SaveChangeAsync();
                    return new ApiResponse().SetBadRequest("User must be Premium to post");
                }
                var skillSets = await _unitOfWork.SkillSets.GetAllAsync(u => jobPostRequest.SkillSetIds.Contains(u.Id));
                if (jobPostRequest.SkillSetIds.Count != skillSets.Count)
                {
                    return new ApiResponse().SetBadRequest("Job Skill Set Id is invalid!");
                }

                var listJobPostSkillSet = new List<JobSkillSet>();
                foreach (var skillSet in skillSets)
                {
                    listJobPostSkillSet.Add(new JobSkillSet
                    {
                        SkillSetId = skillSet.Id,
                        JobPost = jobPost
                    });
                }
                jobPost.JobSkillSets = listJobPostSkillSet;
                jobPost.Company = company;
                jobPost.JobType = jobType;
                jobPost.UserAccount = user;
                jobPost.CreatedDate = DateTime.UtcNow;
                jobPost.PostingDate = DateTime.UtcNow;
                jobPost.JobPostReviewStatus = JobPostReviewStatus.Pending;

                // Generate a vector for the job post

                await _unitOfWork.JobPosts.AddAsync(jobPost);
                await _unitOfWork.SaveChangeAsync();


                // Call Hangfire to send emails after job post creation
                BackgroundJob.Enqueue<EmailJob>(emailJob => emailJob.SendEmailsToFollowers(jobPostRequest.CompanyId, jobPost.JobTitle));

                return new ApiResponse().SetOk(jobPost.Id);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }


        public async Task<ApiResponse> GetJobPostAsync()
        {
            try
            {

                //var jobPosts = await _unitOfWork.JobPosts.GetAllAsync(j => j.Embedding != null, x => x.Include(x => x.Company)
                //                                                                  .Include(x => x.JobLocations)
                //                                                                        .ThenInclude(x => x.Location)
                //                                                                  .Include(x => x.JobType)
                //                                                                  .Include(x => x.JobSkillSets)
                //                                                                        .ThenInclude(x => x.SkillSet));
                var jobPosts = await _unitOfWork.JobPosts.GetJobPostsAsync();

                var jobPostsResponse = _mapper.Map<List<JobPostResponse>>(jobPosts);

                return new ApiResponse().SetOk(jobPostsResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }

        }


        public async Task<ApiResponse> AddSkillSetToJobPost(JobPostSkillSetRequest jobPostSkillSetRequest)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var jobPostSkillSet = await _unitOfWork.JobSkillSets.GetAsync(x => x.SkillSetId == jobPostSkillSetRequest.SkillSetId &&
                                                                                   x.JobPostId == jobPostSkillSetRequest.JobPostId);
                if (jobPostSkillSet != null)
                {
                    return response.SetBadRequest($"Skill Set already exist in this Job Post !!");
                }

                var skillSet = await _unitOfWork.SkillSets.GetAsync(x => x.Id == jobPostSkillSetRequest.SkillSetId);
                if (skillSet == null)
                {
                    return response.SetBadRequest($"Skill set id {jobPostSkillSetRequest.SkillSetId} is not found !!");
                }

                var jobpost = await _unitOfWork.SkillSets.GetAsync(x => x.Id == jobPostSkillSetRequest.JobPostId);
                if (skillSet == null)
                {
                    return response.SetBadRequest($"Job post id {jobPostSkillSetRequest.JobPostId} is not found !!");
                }

                await _unitOfWork.JobSkillSets.AddAsync(new JobSkillSet
                {
                    //SkillLevelRequired = jobPostSkillSetRequest.SkillLevelRequired,
                    SkillSetId = jobPostSkillSetRequest.SkillSetId,
                    JobPostId = jobPostSkillSetRequest.JobPostId
                });
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk("Add Skill Set To Job Post Success !!");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> GetJobSeekerByJobPost(int jobPostId)
        {
            // Fetch JobPostActivities including related UserAccount and AnalyzedResult column
            var jobPostAct = await _unitOfWork.JobPostActivities.GetAllAsync(
                x => x.JobPostId == jobPostId,
                x => x.Include(x => x.UserAccount)
                      .Include(x => x.CV)
                      .Include(x => x.JobPostActivityComments!)
            );

            var candidateResponses = jobPostAct.Select(x =>
            {
                // Deserialize AnalyzedResult JSON column data
                AnalyzedResultResponse analyzedResult;
                if (string.IsNullOrEmpty(x.AnalyzedResult))
                {
                    // If AnalyzedResult is null or empty, initialize with a default empty object
                    analyzedResult = new AnalyzedResultResponse();
                }
                else
                {
                    // Deserialize the JSON string into the AnalyzedResultResponse object
                    try
                    {
                        analyzedResult = JsonConvert.DeserializeObject<AnalyzedResultResponse>(x.AnalyzedResult);
                    }
                    catch (Exception ex)
                    {
                        // Log the error for debugging and initialize with default empty object
                        Console.WriteLine("Deserialization error: " + ex.Message);
                        analyzedResult = new AnalyzedResultResponse();
                    }
                }

                return new CandidateResponse
                {
                    Id = x.UserAccount.Id,
                    FirstName = x.UserAccount.FirstName,
                    LastName = x.UserAccount.LastName,
                    Email = x.UserAccount.Email,
                    PhoneNumber = x.UserAccount.PhoneNumber,
                    CVId = x.CvId,
                    CVPath = x.CV?.Url ?? string.Empty,
                    JobPostActivityId = x.Id,
                    Status = x.Status.ToString(),
                    JobPostActivityComments = x.JobPostActivityComments!.Select(comment => new JobPostActivityCommentResponse
                    {
                        Id = comment.Id,
                        CommentDate = comment.CommentDate,
                        CommentText = comment.CommentText,
                        Rating = comment.Rating,
                    }).ToList(),
                    AnalyzedResult = analyzedResult // Assign the deserialized or default object
                };
            }).ToList();

            return new ApiResponse().SetOk(candidateResponses);
        }



        public async Task<ApiResponse> GetJobPostById(int jobPostId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                /* var jobPost = await _unitOfWork.JobPosts.GetAsync(x => x.Id == jobPostId, x => x.Include(x => x.Company)
                                                                                                 .Include(x => x.JobLocations)
                                                                                                     .ThenInclude(x => x.Location)
                                                                                                 .Include(x => x.JobType)
                                                                                                 .Include(x => x.JobSkillSets)
                                                                                                     .ThenInclude(x => x.SkillSet));*/
                var jobPost = await _unitOfWork.JobPosts.GetJobPostsByIdAsync(jobPostId);
                if (jobPost == null)
                {
                    return response.SetBadRequest("Can not found jobPost Id: " + jobPostId);
                }
                var jobPostResponse = _mapper.Map<JobPostResponse>(jobPost);
                return response.SetOk(jobPostResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> SearchJobs(SearchJobPostRequest searchJobPostRequest)
        {
            var jobPosts = await _unitOfWork.JobPosts.SearchJobPosts(searchJobPostRequest);
            var result = _mapper.Map<List<JobPostResponse>>(jobPosts ?? []);
            return new ApiResponse().SetOk(result.ToPaginationResponse(searchJobPostRequest.PageIndex, searchJobPostRequest.PageSize));
        }

        public async Task<ApiResponse> UpdateStatusJobPost(int id, JobPostReviewStatus status)
        {
            var post = await _unitOfWork.JobPosts.GetAsync(post => post.Id == id);

            if (post == null)
            {
                return new ApiResponse().SetNotFound();
            }

            post.JobPostReviewStatus = status;
            await _unitOfWork.SaveChangeAsync();
            return new ApiResponse().SetOk(post);
        }

        public async Task<ApiResponse> UpdateJobPost(int id, JobPostRequest request)
        {
            var jobPost = await _unitOfWork.JobPosts.GetAsync(post => post.Id == id, x => x.Include(p => p.JobSkillSets));

            if (jobPost == null)
            {
                return new ApiResponse().SetNotFound();
            }

            jobPost.JobTitle = request.JobTitle;
            jobPost.JobDescription = request.JobDescription;
            jobPost.Salary = request.Salary;
            jobPost.ExpiryDate = request.ExpiryDate;
            jobPost.ExperienceRequired = request.ExperienceRequired;
            jobPost.QualificationRequired = request.QualificationRequired;
            jobPost.Benefits = request.Benefits;
            jobPost.JobTypeId = request.JobTypeId;
            jobPost.ImageURL = request.ImageURL;

            //replace all skill set
            var validSkillIds = new List<int>();

            foreach (var newId in request.SkillSetIds)
            {
                var skillSet = await _unitOfWork.SkillSets.GetAsync(s => s.Id == newId);
                if (skillSet != null)
                {
                    validSkillIds.Add(skillSet.Id);
                }
            }

            if (validSkillIds.Count >= 0)
            {
                jobPost.JobSkillSets?.Clear();

                jobPost.JobSkillSets?.AddRange(validSkillIds.Select(skillId => new JobSkillSet
                {
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    JobPostId = id,
                    SkillSetId = skillId,
                }).ToList());
            }

            //re-submit rejected post
            if (jobPost.JobPostReviewStatus == JobPostReviewStatus.Rejected)
            {
                jobPost.JobPostReviewStatus = JobPostReviewStatus.Pending;
            }

            await _unitOfWork.SaveChangeAsync();
            return new ApiResponse().SetOk();
        }
        public async Task<ApiResponse> GetAllJobPostPending()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                /* var jobPosts = await _unitOfWork.JobPosts.GetAllAsync(x => x.JobPostReviewStatus == JobPostReviewStatus.Pending, x => x.Include(x => x.Company)
                                                                                   .Include(x => x.JobLocations)
                                                                                         .ThenInclude(x => x.Location)
                                                                                   .Include(x => x.JobType)
                                                                                   .Include(x => x.JobSkillSets)
                                                                                         .ThenInclude(x => x.SkillSet));*/
                var jobPosts = await _unitOfWork.JobPosts.GetAllJobPostPending();
                var jobPostsResponse = _mapper.Map<List<JobPostResponse>>(jobPosts);
                return new ApiResponse().SetOk(jobPostsResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> SeedsData()
        {   
            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory).FullName;

            string jsonPath = Path.Combine(parentDirectory, "jobPostData.json");
            string jsonContent = File.ReadAllText(jsonPath);
            List<JobPost> jobs = JsonConvert.DeserializeObject<List<JobPost>>(jsonContent);
            await _unitOfWork.JobPosts.AddRangeAsync(jobs);
            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetOk();
        }
        public async Task ResetJobPostIdSequenceAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            // Get the sequence name for the JobPosts.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"JobPosts\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the JobPosts table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"JobPosts\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }
        public async Task<ApiResponse> SearchJobIdsAsync(string query)
        {
            using (var httpClient = new HttpClient())
            {
                ApiResponse apiResponse = new ApiResponse();
                // Chuẩn bị body của request
                var searchRequest = new { query = query };
                string searchJsonRequestBody = JsonConvert.SerializeObject(searchRequest);
                var searchContent = new StringContent(searchJsonRequestBody, Encoding.UTF8, "application/json");

                // Gửi yêu cầu tới API
                var searchResponse = await httpClient.PostAsync(_apiSettings.JobsSearch, searchContent);

                // Xử lý lỗi nếu API trả về lỗi
                if (!searchResponse.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error from Job Search API: {searchResponse.ReasonPhrase}");
                }

                // Đọc và parse kết quả trả về
                var searchResponseContent = await searchResponse.Content.ReadAsStringAsync();
                var searchResponseJson = JsonConvert.DeserializeObject<dynamic>(searchResponseContent);

                // Lấy danh sách IDs
                List<int> ids =((IEnumerable<dynamic>)searchResponseJson.ids).Select(id => (int)id).ToList();

                var jobPosts = await FetchJobPostsByIdsAsync(ids);

                return apiResponse.SetOk(jobPosts);
            }
        }
        public async Task<List<JobPostResponse>> FetchJobPostsByIdsAsync(List<int> ids)
        {
            if (ids == null || ids.Count == 0)
            {
                return new List<JobPostResponse>();
            }

            // Lấy dữ liệu từ database dựa trên danh sách IDs
            /* var jobPosts = await _unitOfWork.JobPosts.GetAsync(
                 x => ids.Contains(x.Id), // Filter theo IDs
                 x => x.Include(x => x.Company)
                       .Include(x => x.JobLocations)
                           .ThenInclude(x => x.Location)
                       .Include(x => x.JobType)
                       .Include(x => x.JobSkillSets)
                           .ThenInclude(x => x.SkillSet)
             );*/
            var jobPosts = await _unitOfWork.JobPosts.GetJobPostsByListIdAsync(ids);
            // Nếu không tìm thấy job posts
            if (jobPosts == null)
            {
                return new List<JobPostResponse>();
            }

            // Map dữ liệu sang DTO
            return _mapper.Map<List<JobPostResponse>>(jobPosts);
        }

        
    


}
}
