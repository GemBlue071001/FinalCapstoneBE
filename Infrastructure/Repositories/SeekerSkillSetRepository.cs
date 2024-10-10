using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class SeekerSkillSetRepository : GenericRepository<SeekerSkillSet>, ISeekerSkillSetRepository
    {
        public SeekerSkillSetRepository(AppDbContext context) : base(context)
        {
        }
    }
}
