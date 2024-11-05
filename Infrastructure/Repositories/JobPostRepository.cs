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
                //.Where(jp => jp.JobPostReviewStatus == JobPostReviewStatus.Accepted);

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
                    return result ?? [];
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
