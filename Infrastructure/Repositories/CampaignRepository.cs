using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Infrastructure.Repositories
{
    public class CampaignRepository : GenericRepository<Campaign>, ICampaignRepository
    {
        public CampaignRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Campaign>> GetAllCampaign()
        {
            IQueryable<Campaign> query = _db;
            return await query
                   .Include(x => x.CampaignJobs)
                       .ThenInclude(x => x.Job)
                   .ToListAsync();
        }
    }
}
