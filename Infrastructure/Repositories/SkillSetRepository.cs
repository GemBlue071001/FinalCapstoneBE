using Application.Repositories;
using Domain.Entities;


namespace Infrastructure.Repositories
{
    public class SkillSetRepository : GenericRepository<SkillSet>, ISkillSetRepository
    {
        public SkillSetRepository(AppDbContext context) : base(context)
        {

        }
    }
}
