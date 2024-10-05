using Application.Interface;
using Application.Request.JobPost;
using Application.Response;
using Application.Response.JobPost;
using Application.Response.User;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class JobPostService : IJobPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public JobPostService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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
                var jobLocation = await _unitOfWork.JobLocations.GetAsync(jl => jl.Id == jobPostRequest.JobLocationId);
                if (jobLocation == null)
                {
                    return new ApiResponse().SetBadRequest("Job location not found");
                }
                var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == jobPostRequest.UserId);
                if (user == null)
                {
                    return new ApiResponse().SetBadRequest("User not found");
                }
                var skillSets = await _unitOfWork.SkillSets.GetAllAsync(u => jobPostRequest.SkillSetIds.Contains(u.Id));
                if (jobPostRequest.SkillSetIds.Count != skillSets.Count)
                {
                    return new ApiResponse().SetBadRequest("Job Skill Set Id is invalid !");
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
                jobPost.JobLocation = jobLocation;
                jobPost.UserAccount = user;
                await _unitOfWork.JobPosts.AddAsync(jobPost);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk("Create Success !!");
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
                                                                                  .Include(x => x.JobLocation)
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
                await _unitOfWork.JobSkillSets.AddAsync(new JobSkillSet
                {
                    //SkillLevelRequired = jobPostSkillSetRequest.SkillLevelRequired,
                    SkillSetId = jobPostSkillSetRequest.SkillSetId,
                    JobPostId = jobPostSkillSetRequest.JobPostId
                });
                return response.SetOk("Add Skill Set To Job Post Success !!");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetJobSeekerByJobPost(int jobPostId)
        {
            var jobPostAct = await _unitOfWork.JobPostActivities.GetAllAsync(x => x.JobPostId == jobPostId, x => x.Include(x => x.UserAccount));
            var users = jobPostAct.Select(x => x.UserAccount).ToList();

            var usersResponse = _mapper.Map<List<UserResponse>>(users);

            return new ApiResponse().SetOk(usersResponse);

        }
        public async Task<ApiResponse> GetJobPostById(int jobPostId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var jobPost = await _unitOfWork.JobPosts.GetAsync(x => x.Id == jobPostId, x => x.Include(x => x.Company)
                                                                                                .Include(x => x.JobLocation)
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

    }
}
