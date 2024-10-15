using Application.Repositories;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class NotificationRepository : GenericRepository<Notification>, INotifcationRepository
    {
        public NotificationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
