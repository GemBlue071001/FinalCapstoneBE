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
        
    }
}
