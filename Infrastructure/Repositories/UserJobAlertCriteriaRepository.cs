using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserJobAlertCriteriaRepository : GenericRepository<UserJobAlertCriteria>, IUserJobAlertCriteriaRepository
    {
        public UserJobAlertCriteriaRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Dictionary<int, List<JobPost>>> GetMatchingJobsForAllUsersAsync()
        {
            try
            {
                List<UserJobAlertCriteria> allCriteria = await _context.UserJobAlertCriterias
                                                        //.Include(x => x.Location)
                                                        //.Include(x => x.SkillSet)
                                                        //.Include(x => x.JobType)
                                                        .ToListAsync();

                var result = new Dictionary<int, List<JobPost>>();

                foreach (var criteria in allCriteria)
                {
                    var query = _context.JobPosts
                                .Include(j => j.JobType)
                                .Include(j => j.Company)
                                .Include(j => j.JobLocations)
                                .Include(j => j.JobSkillSets)
                                .ThenInclude(js => js.SkillSet)
                                .Include(j => j.UserAccount)
                                .AsQueryable();

                    if (!string.IsNullOrEmpty(criteria.JobTile))
                        query = query.Where(job => job.JobTitle.Contains(criteria.JobTile));

                    if (criteria.LocationId.HasValue)
                        query = query.Where(j => j.JobLocations.Any(l => l.LocationId == criteria.LocationId.Value));

                    if (criteria.SkillSetId.HasValue)
                        query = query.Where(j => j.JobSkillSets.Any(s => s.SkillSetId == criteria.SkillSetId.Value));

                    if (criteria.JobTypeId.HasValue)
                        query = query.Where(j => j.JobTypeId == criteria.JobTypeId.Value);

                    query = query.Where(j => !j.IsDeleted && j.ExpiryDate >= DateTime.UtcNow);

                    // Get the matching jobs for this criteria
                    var matchingJobs = await query.ToListAsync();

                    // Check if the user already has entries in the dictionary
                    if (result.ContainsKey(criteria.UserId!.Value))
                    {
                        // Append new matches to existing list
                        result[criteria.UserId.Value].AddRange(matchingJobs);
                    }
                    else
                    {
                        // Initialize with new list of matching jobs
                        result[criteria.UserId.Value] = new List<JobPost>(matchingJobs);
                    }
                }

                // Remove duplicate jobs for each user (if needed)
                foreach (var userId in result.Keys)
                {
                    result[userId] = result[userId].Distinct().ToList();
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
