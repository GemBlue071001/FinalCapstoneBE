using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class AssessmentRepository : GenericRepository<Assessment>, IAssessmentRepository
    {
        public AssessmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
