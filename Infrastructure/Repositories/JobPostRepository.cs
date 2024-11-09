using Application.Repositories;
using Application.Request.JobPost;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class JobPostRepository : GenericRepository<JobPost>, IJobPostRepository
    {
        public JobPostRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<JobPost>> SearchJobPosts(SearchJobPostRequest request)
        {
            try
            {
                IQueryable<JobPost> query = _context.JobPosts
                    .Include(jp => jp.JobType)
                    .Include(jp => jp.JobLocations)
                        .ThenInclude(x => x.Location)
                    .Include(jp => jp.Company)
                    .Include(jp => jp.JobSkillSets)
                        .ThenInclude(jssk => jssk.SkillSet);

                // Existing single-value string checks
                if (!string.IsNullOrEmpty(request.JobType))
                {
                    query = query.Where(x => x.JobType.Name.ToLower().Contains(request.JobType.ToLower()));
                }

                if (!string.IsNullOrEmpty(request.JobTitle))
                {
                    query = query.Where(x => x.JobTitle.ToLower().Contains(request.JobTitle.ToLower()));
                }

                if (!string.IsNullOrEmpty(request.Location))
                {
                    query = query.Where(x => x.JobLocations.Any(location => location.StressAddressDetail.ToLower().Contains(request.Location.ToLower())));
                }

                if (!string.IsNullOrEmpty(request.City))
                {
                    query = query.Where(x => x.JobLocations.Any(jl => jl.Location.City.ToLower().Contains(request.City.ToLower())));
                }

                if (!string.IsNullOrEmpty(request.CompanyName))
                {
                    query = query.Where(x => x.Company.CompanyName.ToLower().Contains(request.CompanyName.ToLower()));
                }

                if (!string.IsNullOrEmpty(request.SkillSet))
                {
                    query = query.Where(x => x.JobSkillSets.Any(skill => skill.SkillSet.Name.ToLower().Contains(request.SkillSet.ToLower())));
                }

                // New array property checks
                if (request.JobTypes != null && request.JobTypes.Any())
                {
                    query = query.Where(x => request.JobTypes.Any(type => x.JobType.Name.ToLower().Contains(type.ToLower())));
                }

                if (request.JobTitles != null && request.JobTitles.Any())
                {
                    query = query.Where(x => request.JobTitles.Any(title => x.JobTitle.ToLower().Contains(title.ToLower())));
                }

                if (request.Locations != null && request.Locations.Any())
                {
                    query = query.Where(x => x.JobLocations.Any(location => request.Locations.Any(loc => location.StressAddressDetail.ToLower().Contains(loc.ToLower()))));
                }

                if (request.Cities != null && request.Cities.Any())
                {
                    query = query.Where(x => x.JobLocations.Any(jl => request.Cities.Any(city => jl.Location.City.ToLower().Contains(city.ToLower()))));
                }

                if (request.CompanyNames != null && request.CompanyNames.Any())
                {
                    query = query.Where(x => request.CompanyNames.Any(company => x.Company.CompanyName.ToLower().Contains(company.ToLower())));
                }

                if (request.SkillSets != null && request.SkillSets.Any())
                {
                    query = query.Where(x => x.JobSkillSets.Any(skill => request.SkillSets.Any(set => skill.SkillSet.Name.ToLower().Contains(set.ToLower()))));
                }

                // Existing code for salary and experience filters
                if (request.MinSalary != null && request.MinSalary > 0)
                {
                    query = query.Where(x => x.Salary >= request.MinSalary);
                }

                if (request.MaxSalary != null && request.MaxSalary > 0)
                {
                    query = query.Where(x => x.Salary <= request.MaxSalary);
                }

                if (request.Experience != null)
                {
                    query = query.Where(x => request.Experience >= x.ExperienceRequired);
                }

                if (query != null)
                {
                    var result = await query.ToListAsync();
                    return result ?? new List<JobPost>();
                }
                return query.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
