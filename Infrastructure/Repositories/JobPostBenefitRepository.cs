using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class JobPostBenefitRepository : GenericRepository<JobPostBenefit>, IJobPostBenefitRepository
    {
        public JobPostBenefitRepository(AppDbContext context) : base(context)
        {
        }
    }
}
