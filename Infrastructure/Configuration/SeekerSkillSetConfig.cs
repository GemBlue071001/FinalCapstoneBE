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
    public class SeekerSkillSetConfig : IEntityTypeConfiguration<SeekerSkillSet>
    {
        public void Configure(EntityTypeBuilder<SeekerSkillSet> builder)
        {
            builder.HasOne(o => o.SeekerProfile)
              .WithMany(o => o.SeekerSkillSets)
              .HasForeignKey(o => o.SeekerProfileId);

            builder.HasOne(o => o.SkillSet)
             .WithMany(o => o.SeekerSkillSets)
             .HasForeignKey(o => o.SkillSetId);
        }
    }
}
