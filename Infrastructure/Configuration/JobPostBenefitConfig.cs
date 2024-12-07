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
    public class JobPostBenefitConfig : IEntityTypeConfiguration<JobPostBenefit>
    {
        public void Configure(EntityTypeBuilder<JobPostBenefit> builder)
        {
            builder.HasOne(o => o.JobPost)
             .WithMany(o => o.JobPostBenefits)
             .HasForeignKey(o => o.JobPostId);

            builder.HasOne(o => o.Benefit)
             .WithMany(o => o.JobPostBenefits)
             .HasForeignKey(o => o.BenefitId);
        }
    }
}
