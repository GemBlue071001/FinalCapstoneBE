using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration
{
    public class EducationDetailConfig : IEntityTypeConfiguration<EducationDetail>
    {
        public void Configure(EntityTypeBuilder<EducationDetail> builder)
        {
            builder.HasOne(o => o.UserAccount)
                  .WithMany(o => o.EducationDetails)
                  .HasForeignKey(o => o.UserId);
        }
    }
}
