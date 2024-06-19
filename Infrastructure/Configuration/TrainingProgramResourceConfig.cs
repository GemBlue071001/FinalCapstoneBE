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
    public class TrainingProgramResourceConfig : IEntityTypeConfiguration<TrainingProgramResource>
    {
        public void Configure(EntityTypeBuilder<TrainingProgramResource> builder)
        {
            builder.HasOne(o => o.TrainingProgram)
                   .WithMany(o => o.TrainingProgramResources)
                   .HasForeignKey(o => o.TrainingProgramId);

            builder.HasOne(o => o.Resource)
               .WithMany(o => o.TrainingProgramResources)
               .HasForeignKey(o => o.ResourceId);
        }
    }
}
