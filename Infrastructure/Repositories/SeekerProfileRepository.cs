using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SeekerProfileRepository: GenericRepository<SeekerProfile>, ISeekerProfileRepository
    {
        public SeekerProfileRepository(AppDbContext context) : base(context)
        {
        }
    }
}
