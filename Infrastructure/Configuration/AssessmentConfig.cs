
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

            builder.HasOne(o => o.TrainingProgram)
               .WithMany(o => o.Assessments)
               .HasForeignKey(o => o.TrainingProgramId);

            builder.HasMany(o => o.AssessmentSubmitions)
               .WithOne(o => o.Assessment)
               .HasForeignKey(o => o.AssessmentId);

            //builder.HasQueryFilter(a => !a.Owner.IsDeleted);
        }
    }
}
