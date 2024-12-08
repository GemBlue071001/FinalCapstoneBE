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
    public class SeekerBenefitConfig : IEntityTypeConfiguration<SeekerBenefit>
    {
        public void Configure(EntityTypeBuilder<SeekerBenefit> builder)
        {
            builder.HasOne(o => o.UserAccount)
              .WithMany(o => o.SeekerBenefits)
              .HasForeignKey(o => o.UserId);

            builder.HasOne(o => o.Benefit)
             .WithMany(o => o.SeekerBenefits)
             .HasForeignKey(o => o.BenefitId);
        }
    }
}
