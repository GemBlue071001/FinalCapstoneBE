using Application;
using Application.Repositories;
using Application.Repository;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        public IUserAccountRepository UserAccounts { get; }
        public IJobPostRepository JobPosts { get; }
        public ISeekerProfileRepository SeekerProfiles { get; set; }
        public IJobLocationRepository JobLocations { get; set; }
        public IJobTypeRepository JobTypes { get; set; }
        public ICompanyRepository Companys { get; set; }
        public ISkillSetRepository SkillSets { get; set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UserAccounts = new UserAccountRepository(context);
            JobPosts = new JobPostRepository(context);
            SeekerProfiles = new SeekerProfileRepository(context);
            JobLocations = new JobLocationRepository(context);
            JobTypes = new JobTypeRepository(context);
            Companys = new CompanyRepository(context);
            SkillSets = new SkillSetRepository(context);
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
