using Application.Interface;
using Application.Request.JobPost;
using Application.Response;
using Application.Response.JobPost;
using AutoMapper;
using Domain.Entities;
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
                await _unitOfWork.JobPosts.AddAsync(jobPost);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk();
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
                var jobPosts = await _unitOfWork.JobPosts.GetAllAsync(null);
                var jobPostsResponse = _mapper.Map<List<JobPostResponse>>(jobPosts);

                return new ApiResponse().SetOk(jobPostsResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }

        }
    }
}
