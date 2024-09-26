using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class JobSkillSetRepository : GenericRepository<JobSkillSet>,IJobSkillSetRepository
    {
        public JobSkillSetRepository(AppDbContext context) : base(context)
        {
        }
    }
}
