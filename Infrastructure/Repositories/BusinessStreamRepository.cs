using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BusinessStreamRepository : GenericRepository<BusinessStream>, IBusinessStreamRepository
    {
        public BusinessStreamRepository(AppDbContext context) : base(context)
        {

        }
    }
}
