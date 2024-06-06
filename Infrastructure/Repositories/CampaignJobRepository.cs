using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CampaignJobRepository : GenericRepository<CampaignJob>, ICampaignJobRepository
    {
        public CampaignJobRepository(AppDbContext context) : base(context)
        {
        }
    }
}
