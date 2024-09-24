using Application.Repositories;
using Application.Repository;

namespace Application
{
    public interface IUnitOfWork
    {
        public IUserAccountRepository UserAccounts { get; }
        public IJobPostRepository JobPosts { get; }
        public ISeekerProfileRepository SeekerProfiles { get; }
        public IJobLocationRepository JobLocations { get; set; }
        public IJobTypeRepository JobTypes { get; set; }
        public ICompanyRepository Companys { get; set; }
        public Task SaveChangeAsync();
    }
}
