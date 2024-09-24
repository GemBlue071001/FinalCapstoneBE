using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class ExperienceDetailRepository : GenericRepository<ExperienceDetail> , IExperienceDetailRepository
    {
        public ExperienceDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}
