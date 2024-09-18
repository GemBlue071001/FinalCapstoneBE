using Application.Repositories;
using Application.Repository;

namespace Application
{
    public interface IUnitOfWork
    {
        public IUserAccountRepository UserAccounts { get; }
        public IJobPostRepository JobPosts { get; }
        public Task SaveChangeAsync();
    }
}
