using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MeetingRepository : GenericRepository<Meeting>, IMeetingRepository
    {
        public MeetingRepository(AppDbContext context) : base(context)
        {
        }
    }
}
