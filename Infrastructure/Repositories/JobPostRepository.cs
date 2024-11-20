using Application.Repositories;
using Application.Request.JobPost;
using DocumentFormat.OpenXml.InkML;
using Domain.Entities;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Pgvector;

namespace Infrastructure.Repositories
{
    public class JobPostRepository : GenericRepository<JobPost>, IJobPostRepository
    {
        public JobPostRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<JobPost>> GetJobPostsAsync()
        {
            IQueryable<JobPost> query = _context.JobPosts
                    .Include(jp => jp.JobType)
                    .Include(jp => jp.JobLocations)
                        .ThenInclude(x => x.Location)
                    .Include(jp => jp.Company)
                    .Include(jp => jp.JobSkillSets)
                        .ThenInclude(jssk => jssk.SkillSet)
                    .Select(x => new JobPost
                    {
                        Benefits = x.Benefits,
                        CompanyId = x.CompanyId,
                        ExperienceRequired = x.ExperienceRequired,
                        Company = x.Company,
                        FollowJobs = x.FollowJobs,
                        ImageURL = x.ImageURL,
                        Id = x.Id,
                        JobDescription = x.JobDescription,
                        JobLocations = x.JobLocations,
                        JobPostActivitys = x.JobPostActivitys,
                        JobSkillSets = x.JobSkillSets,
                        JobPostReviewStatus = x.JobPostReviewStatus,
                        JobTitle = x.JobTitle,
                        IsDeleted = x.IsDeleted,
                        QualificationRequired = x.QualificationRequired,
                        ExpiryDate = x.ExpiryDate,
                        JobType = x.JobType,
                        JobTypeId = x.JobTypeId,
                        PostingDate = x.PostingDate,
                        JobLocationId = x.JobLocationId,
                        Salary = x.Salary,
                    });
            return await query.ToListAsync();
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

                // Initialize an empty predicate for OR logic (false by default)
                var predicate = PredicateBuilder.New<JobPost>(false);

                // Add OR conditions for single-value string properties
                if (!string.IsNullOrEmpty(request.JobType))
                {
                    predicate = predicate.Or(x => x.JobType.Name.ToLower().Contains(request.JobType.ToLower()));
                }

                if (!string.IsNullOrEmpty(request.JobTitle))
                {
                    predicate = predicate.Or(x => x.JobTitle.ToLower().Contains(request.JobTitle.ToLower()));
                }

                if (!string.IsNullOrEmpty(request.Location))
                {
                    predicate = predicate.Or(x => x.JobLocations.Any(location => location.StressAddressDetail.ToLower().Contains(request.Location.ToLower())));
                }

                if (!string.IsNullOrEmpty(request.City))
                {
                    predicate = predicate.Or(x => x.JobLocations.Any(jl => jl.Location.City.ToLower().Contains(request.City.ToLower())));
                }

                if (!string.IsNullOrEmpty(request.CompanyName))
                {
                    predicate = predicate.Or(x => x.Company.CompanyName.ToLower().Contains(request.CompanyName.ToLower()));
                }

                if (!string.IsNullOrEmpty(request.SkillSet))
                {
                    predicate = predicate.Or(x => x.JobSkillSets.Any(skill => skill.SkillSet.Name.ToLower().Contains(request.SkillSet.ToLower())));
                }

                // Add OR conditions for array-based properties
                if (request.JobTypes != null && request.JobTypes.Any())
                {
                    predicate = predicate.Or(x => request.JobTypes.Any(type => x.JobType.Name.ToLower().Contains(type.ToLower())));
                }

                if (request.JobTitles != null && request.JobTitles.Any())
                {
                    predicate = predicate.Or(x => request.JobTitles.Any(title => x.JobTitle.ToLower().Contains(title.ToLower())));
                }

                if (request.Locations != null && request.Locations.Any())
                {
                    predicate = predicate.Or(x => x.JobLocations.Any(location => request.Locations.Any(loc => location.StressAddressDetail.ToLower().Contains(loc.ToLower()))));
                }

                if (request.Cities != null && request.Cities.Any())
                {
                    predicate = predicate.Or(x => x.JobLocations.Any(jl => request.Cities.Any(city => jl.Location.City.ToLower().Contains(city.ToLower()))));
                }

                if (request.CompanyNames != null && request.CompanyNames.Any())
                {
                    predicate = predicate.Or(x => request.CompanyNames.Any(company => x.Company.CompanyName.ToLower().Contains(company.ToLower())));
                }

                if (request.SkillSets != null && request.SkillSets.Any())
                {
                    predicate = predicate.Or(x => x.JobSkillSets.Any(skill => request.SkillSets.Any(set => skill.SkillSet.Name.ToLower().Contains(set.ToLower()))));
                }

                // Add OR conditions for salary and experience filters
                if (request.MinSalary != null && request.MinSalary > 0)
                {
                    predicate = predicate.Or(x => x.Salary >= request.MinSalary);
                }

                if (request.MaxSalary != null && request.MaxSalary > 0)
                {
                    predicate = predicate.Or(x => x.Salary <= request.MaxSalary);
                }

                if (request.Experience != null)
                {
                    predicate = predicate.Or(x => request.Experience >= x.ExperienceRequired);
                }

                // Apply the OR predicate to the query
                query = query.Where(predicate);

                var result = await query.ToListAsync();
                return result ?? new List<JobPost>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<JobPost> GetJobPostsByIdAsync(int jobPostId)
        {
            IQueryable<JobPost> query = _context.JobPosts
                   .Include(x => x.Company)
                  .Include(x => x.JobLocations)
                  .ThenInclude(x => x.Location)
                 .Include(x => x.JobType)
                 .Include(x => x.JobSkillSets)
                      .ThenInclude(x => x.SkillSet)
                        .Where(jp => jp.Id == jobPostId)
                    .Select(x => new JobPost
                    {
                        Benefits = x.Benefits,
                        CompanyId = x.CompanyId,
                        ExperienceRequired = x.ExperienceRequired,
                        Company = x.Company,
                        FollowJobs = x.FollowJobs,
                        ImageURL = x.ImageURL,
                        Id = x.Id,
                        JobDescription = x.JobDescription,
                        JobLocations = x.JobLocations,
                        JobPostActivitys = x.JobPostActivitys,
                        JobSkillSets = x.JobSkillSets,
                        JobPostReviewStatus = x.JobPostReviewStatus,
                        JobTitle = x.JobTitle,
                        IsDeleted = x.IsDeleted,
                        QualificationRequired = x.QualificationRequired,
                        ExpiryDate = x.ExpiryDate,
                        JobType = x.JobType,
                        JobTypeId = x.JobTypeId,
                        PostingDate = x.PostingDate,
                        JobLocationId = x.JobLocationId,
                        Salary = x.Salary,
                    });
            return await query.FirstOrDefaultAsync();
        }
         public async Task<List<JobPost>> GetAllJobPostPending()
        {
            IQueryable<JobPost> query = _context.JobPosts
                    .Include(x => x.Company)
                    .Include(x => x.JobLocations)
                    .ThenInclude(x => x.Location)
                    .Include(x => x.JobType)
                    .Include(x => x.JobSkillSets)
                    .ThenInclude(x => x.SkillSet)
                     .Where(x => x.JobPostReviewStatus == JobPostReviewStatus.Pending)
                     .Select(x => new JobPost
                    {
                        Benefits = x.Benefits,
                        CompanyId = x.CompanyId,
                        ExperienceRequired = x.ExperienceRequired,
                        Company = x.Company,
                        FollowJobs = x.FollowJobs,
                        ImageURL = x.ImageURL,
                        Id = x.Id,
                        JobDescription = x.JobDescription,
                        JobLocations = x.JobLocations,
                        JobPostActivitys = x.JobPostActivitys,
                        JobSkillSets = x.JobSkillSets,
                        JobPostReviewStatus = x.JobPostReviewStatus,
                        JobTitle = x.JobTitle,
                        IsDeleted = x.IsDeleted,
                        QualificationRequired = x.QualificationRequired,
                        ExpiryDate = x.ExpiryDate,
                        JobType = x.JobType,
                        JobTypeId = x.JobTypeId,
                        PostingDate = x.PostingDate,
                        JobLocationId = x.JobLocationId,
                        Salary = x.Salary,
                    });
            return await query.ToListAsync();
        }
        public async Task<List<JobPost>> GetJobPostsByListIdAsync(List<int> jobPostIds)
        {
            IQueryable<JobPost> query = _context.JobPosts
                   .Include(x => x.Company)
                      .Include(x => x.JobLocations)
                          .ThenInclude(x => x.Location)
                      .Include(x => x.JobType)
                      .Include(x => x.JobSkillSets)
                          .ThenInclude(x => x.SkillSet)
                        .Where(x => jobPostIds.Contains(x.Id))
                    .Select(x => new JobPost
                    {
                        Benefits = x.Benefits,
                        CompanyId = x.CompanyId,
                        ExperienceRequired = x.ExperienceRequired,
                        Company = x.Company,
                        FollowJobs = x.FollowJobs,
                        ImageURL = x.ImageURL,
                        Id = x.Id,
                        JobDescription = x.JobDescription,
                        JobLocations = x.JobLocations,
                        JobPostActivitys = x.JobPostActivitys,
                        JobSkillSets = x.JobSkillSets,
                        JobPostReviewStatus = x.JobPostReviewStatus,
                        JobTitle = x.JobTitle,
                        IsDeleted = x.IsDeleted,
                        QualificationRequired = x.QualificationRequired,
                        ExpiryDate = x.ExpiryDate,
                        JobType = x.JobType,
                        JobTypeId = x.JobTypeId,
                        PostingDate = x.PostingDate,
                        JobLocationId = x.JobLocationId,
                        Salary = x.Salary,
                    });
            return await query.ToListAsync();
        }
    }
    
}
