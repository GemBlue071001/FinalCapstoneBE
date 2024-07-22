using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public  class UserMeetingConfig : IEntityTypeConfiguration<UserMeeting>
    {
        public void Configure(EntityTypeBuilder<UserMeeting> builder)
        {
            builder.HasOne(o => o.Meeting)
                   .WithMany(o => o.UserMeetings)
                   .HasForeignKey(o => o.MeetingId);

            builder.HasOne(o => o.User)
               .WithMany(o => o.UserMeetings)
               .HasForeignKey(o => o.UserId);

            //builder.HasQueryFilter(a => !a.User.IsDeleted);

        }
    }
}
