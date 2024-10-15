using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class NotificationConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder
                .HasOne(n => n.UserAccount)
                .WithMany(o => o.Notifications)
                .HasForeignKey(o => o.ReceiverId);

            builder
                .HasOne(n => n.JobPostActivity)
                .WithMany(o => o.Notifications)
                .HasForeignKey(o => o.JobPostActivityId);
        }
    }
}
