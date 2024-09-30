using Application.Request.JobPostActivity;
using Application.Response;

namespace Application.Interface
{
    public interface IJobPostActivityService
    {
        Task<ApiResponse> AddNewJobPostActivityAsync(JobPostActivityRequest request);
        Task<ApiResponse> UpdateJobPostActivityAsync(JobPostActivityUpdateRequest request);

    }
}
