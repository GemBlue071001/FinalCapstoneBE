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
    public class ResourceRepository : GenericRepository<Resource>, IResourceRepository
    {
        public ResourceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
