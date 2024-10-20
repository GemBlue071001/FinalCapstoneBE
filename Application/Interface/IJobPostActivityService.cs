using Application.Request.JobPostActivity;
using Application.Response;
using Domain.Entities;

namespace Application.Interface
{
    public interface IJobPostActivityService
    {
        Task<ApiResponse> AddNewJobPostActivityAsync(JobPostActivityRequest request);
        Task<ApiResponse> UpdateJobPostActivityAsync(JobPostActivityUpdateRequest request);
        Task<List<Notification>> GetNotifications(int useId, bool isRead);
        Task<bool> ReadNotification(int id);
        Task ReadAllNotification(int userId);
    }
}
