using Application.Repositories;
using Application.Repository;

namespace Application
{
    public interface IUnitOfWork
    {
        public IUserAccountRepository UserAccounts { get; }
        public IJobPostRepository JobPosts { get; }
        public IJobLocationRepository JobLocations { get; }
        public IJobTypeRepository JobTypes { get; }
        public ICompanyRepository Companys { get; }
        public IEducationDetailRepository EducationDetails { get; }
        public IExperienceDetailRepository ExperienceDetails { get; }
        public ISkillSetRepository SkillSets { get; }
        public IBusinessStreamRepository BusinessStreams { get; }
        public IJobSkillSetRepository JobSkillSets { get; }
        public IJobPostActivityRepository JobPostActivities { get; }
        public ICVRepository CVs { get; }
        public ISeekerSkillSetRepository SeekerSkillSets { get; }
        public IFollowCompanyRepository FollowCompanies { get;  }
        public INotifcationRepository Notifcations { get; }
        public IEmailTemplateRepository EmailTemplates { get; }
        public IEmailVerificationRepository EmailVerifications { get; }
        public Task SaveChangeAsync();
    }
}
