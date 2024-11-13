using Application.Repository;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IJobPostActivityRepository : IGenericRepository<JobPostActivity>
    {
        Task<List<JobPostActivity>> SelectTop100MatchApplications();
    }
}
