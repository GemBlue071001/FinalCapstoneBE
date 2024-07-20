using Application.Repository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserAccountRepository : GenericRepository<UserAccount>, IUserAccountRepository
    {
        public UserAccountRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<TrainingProgram>> GetTrainingProgramsByUserId(int userId)
        {
            var user = await _context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.CampaignJob)
                    .ThenInclude(cj => cj.Job)
                        .ThenInclude(j => j.JobTrainingPrograms)
                            .ThenInclude(jt => jt.TrainingProgram)
                                .ThenInclude(x => x.ProgramKPI)
                                    .ThenInclude(x => x.KPI)
                 .Include(u => u.CampaignJob)
                    .ThenInclude(cj => cj.Job)
                        .ThenInclude(j => j.JobTrainingPrograms)
                            .ThenInclude(jt => jt.TrainingProgram)
                                .ThenInclude(x => x.TrainingProgramResources)
                                    .ThenInclude(x => x.Resource)


                .FirstOrDefaultAsync();

            if (user?.CampaignJob?.Job == null)
            {
                return new List<TrainingProgram>();
            }

            var trainingPrograms = user.CampaignJob.Job.JobTrainingPrograms
                .Select(jt => jt.TrainingProgram)
                .Where(tp => tp != null) // Ensure no null values
                .Distinct()
                .ToList();

            return trainingPrograms!;
        }

    }
}
