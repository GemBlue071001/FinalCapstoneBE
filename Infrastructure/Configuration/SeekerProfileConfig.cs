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
    public class SeekerProfileConfig : IEntityTypeConfiguration<SeekerProfile>
    {
        public void Configure(EntityTypeBuilder<SeekerProfile> builder)
        {
            builder.HasOne(o => o.UserAccount)
               .WithMany(o => o.SeekerProfiles)
               .HasForeignKey(o => o.UserId);

            builder.HasMany(o => o.ExperienceDetails)
                .WithOne(o => o.SeekerProfile)
                .HasForeignKey(o => o.SeekerProfileId);

            builder.HasMany(o => o.SeekerSkillSets)
               .WithOne(o => o.SeekerProfile)
               .HasForeignKey(o => o.SeekerProfileId);

            builder.HasMany(o => o.EducationDetails)
               .WithOne(o => o.SeekerProfile)
               .HasForeignKey(o => o.SeekerProfileId);
        }
    }
}
