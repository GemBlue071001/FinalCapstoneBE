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
    public class ProgramKPIConfig : IEntityTypeConfiguration<ProgramKPI>
    {
        public void Configure(EntityTypeBuilder<ProgramKPI> builder)
        {
            builder.HasOne(o => o.KPI)
                   .WithMany(o => o.ProgramKPI)
                   .HasForeignKey(o => o.KPIId);

            builder.HasOne(o => o.TrainingProgram)
               .WithMany(o => o.ProgramKPI)
               .HasForeignKey(o => o.TrainingProgramId);
        }
    }
}
