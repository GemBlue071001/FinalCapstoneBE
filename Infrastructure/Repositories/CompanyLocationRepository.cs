using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class CompanyLocationRepository : GenericRepository<CompanyLocation> , ICompanyLocationRepository
    {
        public CompanyLocationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
