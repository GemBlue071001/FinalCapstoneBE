using Application.Repository;
using Application.Request.JobPost;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IJobPostRepository : IGenericRepository<JobPost>
    {
        Task<List<JobPost>> SearchJobPosts(SearchJobPostRequest request);
        Task<List<JobPost>> GetJobPostsAsync();
        Task<JobPost> GetJobPostsByIdAsync(int jobPostId);
        Task<List<JobPost>> GetAllJobPostPending();
        Task<List<JobPost>> GetJobPostsByListIdAsync(List<int> jobPostIds);
        Task<int> CountTotalPaging(SearchJobPostRequest request);

    }
}
