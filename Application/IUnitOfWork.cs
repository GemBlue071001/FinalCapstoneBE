using Application.Repositories;
using Application.Repository;

namespace Application
{
    public interface IUnitOfWork
    {
        public IUserAccountRepository UserAccounts { get; }
        public IJobPostRepository JobPosts { get; }
        public ISeekerProfileRepository SeekerProfiles { get; }
        public IJobLocationRepository JobLocations { get; }
        public IJobTypeRepository JobTypes { get; }
        public ICompanyRepository Companys { get; }
        public IEducationDetailRepository EducationDetails { get; }
        public IExperienceDetailRepository ExperienceDetails { get; }
        public ISkillSetRepository SkillSets { get; }
        public IJobSkillSetRepository JobSkillSets { get;  }
        public IBusinessStreamRepository BusinessStreams { get;  }
        public Task SaveChangeAsync();
    }
}
