using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TrainingProgramResourceRepository : GenericRepository<TrainingProgramResource>, ITrainingProgramResourceRepository
    {
        public TrainingProgramResourceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
