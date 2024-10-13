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
        public IJobLocationRepository JobLocations { get;  }
        public IJobTypeRepository JobTypes { get;  }
        public ICompanyRepository Companys { get;  }
        public IEducationDetailRepository EducationDetails { get; }
        public IExperienceDetailRepository ExperienceDetails { get; }
        public IBusinessStreamRepository BusinessStreams { get;  }
        public ISkillSetRepository SkillSets { get; }
        public IJobSkillSetRepository JobSkillSets { get;  }
        public IJobPostActivityRepository JobPostActivities { get; }
        public ICVRepository CVs { get;  }
        public ISeekerSkillSetRepository SeekerSkillSets { get; }
        public IFollowCompanyRepository FollowCompanies { get;  }
        public INotifcationRepository Notifcations { get;  }
        public IEmailTemplateRepository EmailTemplates { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UserAccounts = new UserAccountRepository(context);
            JobPosts = new JobPostRepository(context);
            JobLocations = new JobLocationRepository(context);
            JobTypes = new JobTypeRepository(context);
            Companys = new CompanyRepository(context);
            EducationDetails = new EducationDetailRepository(context);
            ExperienceDetails = new ExperienceDetailRepository(context);
            SkillSets = new SkillSetRepository(context);
            JobSkillSets = new JobSkillSetRepository(context);
            BusinessStreams = new BusinessStreamRepository(context);
            JobPostActivities = new JobPostActivityRepository(context);
            CVs = new CVRepository(context);
            SeekerSkillSets = new SeekerSkillSetRepository(context);
            FollowCompanies = new FollowCompanyRepository(context);
            Notifcations = new NotificationRepository(context);
            EmailTemplates = new EmailTemplateRepository(context);
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
