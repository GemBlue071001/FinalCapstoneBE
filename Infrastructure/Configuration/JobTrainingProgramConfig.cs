using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class JobTrainingProgramConfig : IEntityTypeConfiguration<JobTrainingProgram>
    {
        public void Configure(EntityTypeBuilder<JobTrainingProgram> builder)
        {
            builder.HasOne(o => o.Job)
                   .WithMany(o => o.JobTrainingPrograms)
                   .HasForeignKey(o => o.JobId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.TrainingProgram)
               .WithMany(o => o.JobTrainingPrograms)
               .HasForeignKey(o => o.TrainingProgramId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
