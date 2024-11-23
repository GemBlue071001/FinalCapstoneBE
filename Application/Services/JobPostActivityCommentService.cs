using Application.Extensions;
using Application.Interface;
using Application.Request.JobPostActivityComment;
using Application.Response;
using Application.Response.JobPostActivityComment;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class JobPostActivityCommentService : IJobPostActivityCommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;
        public JobPostActivityCommentService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }
        public async Task ResetJobPostActivityCommentIdSequenceAsync()
        {
            // Get the sequence name for the JobPostActivityComment.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"JobPostActivityComments\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the JobPostActivityComments table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"JobPostActivityComments\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }
        public async Task<ApiResponse> AddNewJobPostActivityCommentAsync(JobPostActivityCommentRequest jobPostActivityCommentRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                await ResetJobPostActivityCommentIdSequenceAsync();
                var jobPostActivity = await _unitOfWork.JobPostActivities.GetAsync(x => x.Id == jobPostActivityCommentRequest.JobPostActivityId);
                if (jobPostActivity == null)
                {
                    return apiResponse.SetBadRequest("Not found JobPostActivityId : " + jobPostActivityCommentRequest.JobPostActivityId);
                }
                var jobPostActivityComment = _mapper.Map<JobPostActivityComment>(jobPostActivityCommentRequest);
                await _unitOfWork.JobPostActivityComments.AddAsync(jobPostActivityComment);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Add Success");
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetAllJobPostActivityCommentAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                //var jobPostActivities = await _unitOfWork.JobPostActivities.GetAllAsync(null);
                var jobPostActivityComments = await _unitOfWork.JobPostActivityComments.GetAllAsync(null, x => x.Include(x => x.JobPostActivity));
                var jobPostActivityCommentResponse = _mapper.Map<List<JobPostActivityCommentResponse>>(jobPostActivityComments);
                return apiResponse.SetOk(jobPostActivityCommentResponse);
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetAllJobPostActivityCommentByJobPostActivityIdAsync(JobPostCommentViewRequest request)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var jobPostActivityComments = await _unitOfWork.JobPostActivityComments.GetAllAsync(x => x.JobPostActivityId == request.Id, x => x.Include(x => x.JobPostActivity));
                var jobPostActivityCommentResponse = jobPostActivityComments.Select(x => new JobPostActivityCommentOfJobPostActivityResponse
                {
                    Id = x.Id,
                    CommentDate = x.CommentDate,
                    CommentText = x.CommentText,
                    Rating = x.Rating,
                }).ToList();
                return apiResponse.SetOk(jobPostActivityCommentResponse.ToPaginationResponse(request.PageIndex, request.PageSize));
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> DeleteJobPostActivityCommentByIdAsync(int id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var jobPostActivityComment = await _unitOfWork.JobPostActivityComments.GetAsync(x => x.Id == id);
                if (jobPostActivityComment == null)
                {
                    return apiResponse.SetNotFound("Can not found JobPostActivityComments id: " + id);
                }
                await _unitOfWork.JobPostActivityComments.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
                return apiResponse.SetOk("Delete Success");
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> UpdateJobPostActivityCommentByIdAsync(UpdateJobPostActivityCommentRequest updateJobPostActivityCommentRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var jobPostActivityComment = await _unitOfWork.JobPostActivityComments.GetAsync(x => x.Id == updateJobPostActivityCommentRequest.Id);
                if(jobPostActivityComment == null)
                {
                    return apiResponse.SetNotFound("Can not found JobPostActivityComments id: " + updateJobPostActivityCommentRequest.Id);
                }
                _mapper.Map(updateJobPostActivityCommentRequest, jobPostActivityComment);
                await _unitOfWork.SaveChangeAsync();
                return apiResponse.SetOk("Update Success");
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
    }
}
