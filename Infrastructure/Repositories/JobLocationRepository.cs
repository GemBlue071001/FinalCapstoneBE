using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class JobLocationRepository : GenericRepository<JobLocation>, IJobLocationRepository
    {
        public JobLocationRepository(AppDbContext context) : base(context)
        {

        }
    }
}
