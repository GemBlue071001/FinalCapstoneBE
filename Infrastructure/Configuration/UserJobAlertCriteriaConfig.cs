using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class UserJobAlertCriteriaConfig : IEntityTypeConfiguration<UserJobAlertCriteria>
    {
        public void Configure(EntityTypeBuilder<UserJobAlertCriteria> builder)
        {
            builder.HasOne(o => o.UserAccount)
              .WithMany(o => o.UserJobAlertCriterias)
              .HasForeignKey(o => o.UserId);

            builder.HasOne(o => o.JobType)
              .WithMany(o => o.UserJobAlertCriterias)
              .HasForeignKey(o => o.JobTypeId);

            builder.HasOne(o => o.Location)
              .WithMany(o => o.UserJobAlertCriterias)
              .HasForeignKey(o => o.LocationId);

            builder.HasOne(o => o.SkillSet)
              .WithMany(o => o.UserJobAlertCriterias)
              .HasForeignKey(o => o.SkillSetId);

        }
    }
}
