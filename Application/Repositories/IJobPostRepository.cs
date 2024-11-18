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
    }
}
