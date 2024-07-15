using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AssessmentSubmitionsRepository : GenericRepository<AssessmentSubmition> , IAssessmentSubmitionsRepository
    {
        public AssessmentSubmitionsRepository(AppDbContext context) : base(context)
        {
        }
    }
}
