using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TrainingProgramRepository : GenericRepository<TrainingProgram>, ITrainingProgramRepository
    {
        public TrainingProgramRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<List<TrainingProgram>> GetAllTrainingProgram()
        {
            IQueryable<TrainingProgram> query = _db;
            return await query
                   .Include(x => x.JobTrainingPrograms)
                       .ThenInclude(x => x.Job)
                   .Include(x => x.TrainingProgramResources)
                       .ThenInclude(x => x.Resource)
                   .ToListAsync();
        }
    }
}
