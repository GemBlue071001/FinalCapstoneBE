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
    public class BenefitConfig : IEntityTypeConfiguration<Benefit>
    {
        public void Configure(EntityTypeBuilder<Benefit> builder)
        {
            builder.HasMany(o => o.SeekerBenefits)
              .WithOne(o => o.Benefit)
              .HasForeignKey(o => o.BenefitId);

            builder.HasMany(o => o.JobPostBenefits)
             .WithOne(o => o.Benefit)
             .HasForeignKey(o => o.BenefitId);
        }
    }
}
