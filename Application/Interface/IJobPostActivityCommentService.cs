using Application.Request.JobPostActivityComment;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IJobPostActivityCommentService
    {
        Task<ApiResponse> AddNewJobPostActivityCommentAsync(JobPostActivityCommentRequest jobPostActivityCommentRequest);
        Task<ApiResponse> GetAllJobPostActivityCommentAsync();
        Task<ApiResponse> DeleteJobPostActivityCommentByIdAsync(int id);
        Task<ApiResponse> GetAllJobPostActivityCommentByJobPostActivityIdAsync(int jobPostActivity);

    }
}
