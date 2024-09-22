using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class JobTypeRepository : GenericRepository<JobType>, IJobTypeRepository
    {
        public JobTypeRepository(AppDbContext context) : base(context)
        {

        }
    }
}
