using Application.Request.JobPost;
using Application.Response;

namespace Application.Interface
{
    public interface IJobPostService
    {
        Task<ApiResponse> AddNewJobPostAsync(JobPostRequest jobPostRequest);
        Task<ApiResponse> GetJobPostAsync();
        Task<ApiResponse> AddSkillSetToJobPost(JobPostSkillSetRequest jobPostSkillSetRequest);
        Task<ApiResponse> GetJobSeekerByJobPost(int jobPostId);
        Task<ApiResponse> GetJobPostById(int jobPostId);
        Task<ApiResponse> SearchJobs(SearchJobPostRequest searchJobPostRequest);
    }
}
