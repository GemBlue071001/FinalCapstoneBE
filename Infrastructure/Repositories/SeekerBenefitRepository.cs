using Application.Repositories;
using Application.Repository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SeekerBenefitRepository: GenericRepository<SeekerBenefit>, ISeekerBenefitRepository
    {
        public SeekerBenefitRepository(AppDbContext context) : base(context)
        {
        }
    }
}
