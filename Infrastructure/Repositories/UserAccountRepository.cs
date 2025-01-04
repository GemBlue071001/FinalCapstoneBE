using Application.Repository;
using Application.Request.JobPost;
using Application.Request.User;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Infrastructure.Repositories
{
    public class UserAccountRepository : GenericRepository<UserAccount>, IUserAccountRepository
    {
        public UserAccountRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<List<UserAccount>> FindTalent(FindTalentRequest request)
        {
            try
            {
                IQueryable<UserAccount> query = _context.Users.
                Include(x => x.SeekerSkillSets)
               .ThenInclude(x => x.SkillSet)
               .Include(x => x.EducationDetails);

                if (!string.IsNullOrEmpty(request.Keyword))
                {
                    query = query.Where(x => x.SeekerSkillSets.Any(skill => skill.SkillSet.Name.ToLower().Contains(request.Keyword.ToLower()))
                                            || x.EducationDetails.Any(education => education.Degree.ToLower().Contains(request.Keyword)));
                }
                /*if (!string.IsNullOrEmpty(request.SkillSet))
                {
                    string skillSet = request.SkillSet.ToLower();
                    query = query.Where(x =>
                        x.SeekerSkillSets.Any(skill => skill.SkillSet.Name.ToLower().Contains(skillSet))
                    );
                }*/

                if (request.SkillSets != null && request.SkillSets.Any())
                {
                    query = query.Where(x => x.SeekerSkillSets.Any(skill => request.SkillSets.Any(set => skill.SkillSet.Name.ToLower().Contains(set.ToLower()))));
                }
                if (!string.IsNullOrEmpty(request.Degree))
                {
                    string degree = request.Degree.ToLower();
                    query = query.Where(x =>
                        x.EducationDetails.Any(education => education.Degree.ToLower().Contains(degree))
                    );
                }
                if (request.SkillSetFilters != null && request.SkillSetFilters.Any())
                {
                    var skillSetFilters = request.SkillSetFilters
                        .Where(f => !string.IsNullOrEmpty(f.SkillSet) && !string.IsNullOrEmpty(f.ProficiencyLevel))
                        .ToList();

                    // Apply filter for each SkillSetFilter
                    foreach (var filter in skillSetFilters)
                    {
                        string skillSet = filter.SkillSet.ToLower();
                        string proficiencyLevel = filter.ProficiencyLevel.ToLower();

                        query = query.Where(x =>
                            x.SeekerSkillSets.Any(skill =>
                                skill.SkillSet.Name.ToLower().Contains(skillSet) &&
                                skill.ProficiencyLevel.ToLower() == proficiencyLevel
                            )
                        );
                    }
                }
                var result = await query
                   .Skip((request.PageIndex - 1) * request.PageSize)
                   .Take(request.PageSize)
                   //.OrderByDescending(x => x.ExpiryDate)
                   //.Where(x => x.ExpiryDate > DateTime.Now)
                   .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public async Task<int> CountTotalPaging(FindTalentRequest request)
        {
            try
            {
                IQueryable<UserAccount> query = _context.Users.
                Include(x => x.SeekerSkillSets)
               .ThenInclude(x => x.SkillSet)
               .Include(x => x.EducationDetails);

                if (!string.IsNullOrEmpty(request.Keyword))
                {
                    query = query.Where(x => x.SeekerSkillSets.Any(skill => skill.SkillSet.Name.ToLower().Contains(request.Keyword.ToLower()))
                                            || x.EducationDetails.Any(education => education.Degree.ToLower().Contains(request.Keyword)));
                }
                /*if (!string.IsNullOrEmpty(request.SkillSet))
                {
                    string skillSet = request.SkillSet.ToLower();
                    query = query.Where(x =>
                        x.SeekerSkillSets.Any(skill => skill.SkillSet.Name.ToLower().Contains(skillSet))
                    );
                }*/

                if (request.SkillSets != null && request.SkillSets.Any())
                {
                    query = query.Where(x => x.SeekerSkillSets.Any(skill => request.SkillSets.Any(set => skill.SkillSet.Name.ToLower().Contains(set.ToLower()))));
                }
                if (!string.IsNullOrEmpty(request.Degree))
                {
                    string degree = request.Degree.ToLower();
                    query = query.Where(x =>
                        x.EducationDetails.Any(education => education.Degree.ToLower().Contains(degree))
                    );
                }
                if (request.SkillSetFilters != null && request.SkillSetFilters.Any())
                {
                    var skillSetFilters = request.SkillSetFilters
                        .Where(f => !string.IsNullOrEmpty(f.SkillSet) && !string.IsNullOrEmpty(f.ProficiencyLevel))
                        .ToList();

                    // Apply filter for each SkillSetFilter
                    foreach (var filter in skillSetFilters)
                    {
                        string skillSet = filter.SkillSet.ToLower();
                        string proficiencyLevel = filter.ProficiencyLevel.ToLower();

                        query = query.Where(x =>
                            x.SeekerSkillSets.Any(skill =>
                                skill.SkillSet.Name.ToLower().Contains(skillSet) &&
                                skill.ProficiencyLevel.ToLower() == proficiencyLevel
                            )
                        );
                    }
                }
                var result = await query
                                        .CountAsync();

                return result;

               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
