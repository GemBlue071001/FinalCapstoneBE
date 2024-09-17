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
    public class SkillSetConfig : IEntityTypeConfiguration<SkillSet>
    {
        public void Configure(EntityTypeBuilder<SkillSet> builder)
        {
            builder.HasMany(o => o.JobSkillSets)
               .WithOne(o => o.SkillSet)
               .HasForeignKey(o => o.SkillSetId);

            builder.HasMany(o => o.SeekerSkillSets)
               .WithOne(o => o.SkillSet)
               .HasForeignKey(o => o.SkillSetId);
        }
    }
}
