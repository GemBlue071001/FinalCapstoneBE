using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class UserAccountServiceRepository : GenericRepository<UserAccountService>, IUserAccountServiceRepository
    {
        public UserAccountServiceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
