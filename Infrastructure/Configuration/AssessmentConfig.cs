
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    internal class AssessmentConfig : IEntityTypeConfiguration<Assessment>
    {
        public void Configure(EntityTypeBuilder<Assessment> builder)
        {
            builder.HasOne(o => o.Owner)
               .WithMany(o => o.Assessments)
               .HasForeignKey(o => o.UserId);           
        }
    }
}
