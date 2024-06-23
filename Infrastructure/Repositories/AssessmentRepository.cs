using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AssessmentRepository : GenericRepository<Assessment>, IAssessmentRepository
    {
        public AssessmentRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<List<Assessment>> GetAllAssessment()
        {
            IQueryable<Assessment> query = _db;
            return await query
                   .Include(x => x.Owner)
                  
                   .ToListAsync();
        }

    }
}
