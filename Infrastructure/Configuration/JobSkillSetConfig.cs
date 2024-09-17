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
    public class JobSkillSetConfig : IEntityTypeConfiguration<JobSkillSet>
    {
        public void Configure(EntityTypeBuilder<JobSkillSet> builder)
        {
            builder.HasOne(o => o.JobPost)
               .WithMany(o => o.JobSkillSets)
               .HasForeignKey(o => o.JobPostId);

            builder.HasOne(o => o.SkillSet)
               .WithMany(o => o.JobSkillSets)
               .HasForeignKey(o => o.SkillSetId);
        }
    }
}
