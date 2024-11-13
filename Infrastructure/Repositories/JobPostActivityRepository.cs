using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class JobPostActivityRepository : GenericRepository<JobPostActivity>, IJobPostActivityRepository
    {
        public JobPostActivityRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<JobPostActivity>> SelectTop100MatchApplications()
        {
            var entities = await _context.JobPostActivities.ToListAsync();
            var top100 = entities
                .OrderByDescending(entity => 
                    JsonDocument.Parse(entity.AnalyzedResult)
                    .RootElement.GetProperty("match_details")
                    .GetProperty("scores")
                    .GetProperty("experience_match")
                    .GetDouble())
                .Take(100)
                .ToList();
            return top100;
        }
    }
}
