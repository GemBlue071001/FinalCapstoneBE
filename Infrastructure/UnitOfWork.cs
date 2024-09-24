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
        public ISeekerProfileRepository SeekerProfiles { get; }
        public IJobLocationRepository JobLocations { get;  }
        public IJobTypeRepository JobTypes { get;  }
        public ICompanyRepository Companys { get;  }
        public IEducationDetailRepository EducationDetails { get; }
        public IExperienceDetailRepository ExperienceDetails { get; }
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
            EducationDetails = new EducationDetailRepository(context);
            ExperienceDetails = new ExperienceDetailRepository(context);
            SkillSets = new SkillSetRepository(context);
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
