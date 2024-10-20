using Application.Request.JobPostActivity;
using Application.Response;
using Domain.Entities;

namespace Application.Interface
{
    public interface IJobPostActivityService
    {
        Task<ApiResponse> AddNewJobPostActivityAsync(JobPostActivityRequest request);
        Task<ApiResponse> UpdateJobPostActivityAsync(JobPostActivityUpdateRequest request);
        Task<List<Notification>> GetNotificationsByCompanyId(int applicationId, bool isRead);
        Task<List<Notification>> GetNotificationsByEmployerId(int useId, bool isRead);

    }
}
