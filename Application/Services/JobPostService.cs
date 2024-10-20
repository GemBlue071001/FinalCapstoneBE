using Application.Interface;
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

namespace Application.Services
{
    public class JobPostService : IJobPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public JobPostService(IUnitOfWork unitOfWork, IMapper mapper, IEmailService emailService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _emailService = emailService;
        }


        public async Task<ApiResponse> AddNewJobPostAsync(JobPostRequest jobPostRequest)
        {
            try
            {
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
                await _unitOfWork.JobPosts.AddAsync(jobPost);
                await _unitOfWork.SaveChangeAsync();

                // Gọi Hangfire để xử lý việc gửi email sau khi job post được tạo thành công
                BackgroundJob.Enqueue<EmailJob>(emailJob => emailJob.SendEmailsToFollowers(jobPostRequest.CompanyId, jobPost));

                return new ApiResponse().SetOk("Create Success! Emails will be sent to followers.");
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
                var jobPosts = await _unitOfWork.JobPosts.GetAllAsync(null, x => x.Include(x => x.Company)
                                                                                  .Include(x => x.JobLocations)
                                                                                        .ThenInclude(x => x.Location)
                                                                                  .Include(x => x.JobType)
                                                                                  .Include(x => x.JobSkillSets)
                                                                                        .ThenInclude(x => x.SkillSet));

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
            // Fetch JobPostActivities including the related UserAccount
            var jobPostAct = await _unitOfWork.JobPostActivities.GetAllAsync(
                x => x.JobPostId == jobPostId,
                x => x.Include(x => x.UserAccount)
                      .Include(x => x.CV)
                      .Include(x=>x.JobPostActivityComments!)
            );

            // Map JobPostActivity to CandidateResponse
            var candidateResponses = jobPostAct.Select(x => new CandidateResponse
            {
                Id = x.UserAccount.Id,
                UserName = x.UserAccount.UserName,
                FirstName = x.UserAccount.FirstName,
                LastName = x.UserAccount.LastName,
                Email = x.UserAccount.Email,
                PhoneNumber = x.UserAccount.PhoneNumber,
                CVId = x.CvId,
                CVPath = x.CV?.Url ?? string.Empty, // Assuming CV has a property 'Path'
                JobPostActivityId = x.Id,
                Status = x.Status.ToString(),
                JobPostActivityComments = x.JobPostActivityComments!.Select(x=> new JobPostActivityCommentResponse
                {
                    Id=x.Id,
                    CommentDate = x.CommentDate,
                    CommentText = x.CommentText,
                    Rating = x.Rating,
                }).ToList()
            }).ToList();

            // Return the mapped CandidateResponse list
            return new ApiResponse().SetOk(candidateResponses);
        }



        public async Task<ApiResponse> GetJobPostById(int jobPostId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var jobPost = await _unitOfWork.JobPosts.GetAsync(x => x.Id == jobPostId, x => x.Include(x => x.Company)
                                                                                                .Include(x => x.JobLocations)
                                                                                                    .ThenInclude(x => x.Location)
                                                                                                .Include(x => x.JobType)
                                                                                                .Include(x => x.JobSkillSets)
                                                                                                    .ThenInclude(x => x.SkillSet));
                if (jobPost == null)
                {
                    return response.SetBadRequest("Can not found jobPost Id" + jobPostId);
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
    }
}
