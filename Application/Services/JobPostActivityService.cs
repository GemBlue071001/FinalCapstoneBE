using Application.Interface;
using Application.Request.JobLocation;
using Application.Request.JobPost;
using Application.Request.JobPostActivity;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class JobPostActivityService : IJobPostActivityService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public JobPostActivityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddNewJobPostActivityAsync(JobPostActivityRequest jobPostActivityRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == jobPostActivityRequest.UserId);
                if (user == null)
                {
                    return new ApiResponse().SetBadRequest("User not found");
                }
                var jobPosts = await _unitOfWork.JobPosts.GetAllAsync(o => jobPostActivityRequest.JobPostIds.Contains(o.Id));
                if (jobPostActivityRequest.JobPostIds.Count != jobPosts.Count) 
                {
                    return new ApiResponse().SetBadRequest("Job Post Id is invalid !");
                }
                var listJobPostActivity = new List<JobPostActivity>();
                foreach (var jobPost in jobPosts) 
                {
                    listJobPostActivity.Add(new JobPostActivity
                    {
                        Status = JobPostActivityStatus.Applied,
                        ApplicationDate = DateTime.Now,
                        JobPostId = jobPost.Id,
                        UserAccount = user,

                    });
                }
                user.JobPostActivitys = listJobPostActivity;
                await _unitOfWork.UserAccounts.AddAsync(user);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Create Success !!");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
    }
}
