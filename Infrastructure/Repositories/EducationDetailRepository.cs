using Application.CustomExceptions;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class EducationDetailRepository : GenericRepository<EducationDetail>, IEducationDetailRepository
    {
        public EducationDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}
