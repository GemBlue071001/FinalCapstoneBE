
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class CVConfig : IEntityTypeConfiguration<CV>
    {
        public void Configure(EntityTypeBuilder<CV> builder)
        {
            builder.HasOne(o => o.UserAccount)
               .WithMany(o => o.CVs)
               .HasForeignKey(o => o.UserId);


            builder.HasMany(o => o.JobPostActivitys)
                .WithOne(o => o.CV)
                .HasForeignKey(o => o.CvId);
        }
    }
}
