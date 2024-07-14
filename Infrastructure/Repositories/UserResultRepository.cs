using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class UserResultRepository : GenericRepository<UserResult> , IUserResultRepository
    {
        public UserResultRepository(AppDbContext context) : base(context)
        {
        }
    }
}
