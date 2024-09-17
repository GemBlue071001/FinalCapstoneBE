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
    public class ExperienceDetailConfig : IEntityTypeConfiguration<ExperienceDetail>
    {
        public void Configure(EntityTypeBuilder<ExperienceDetail> builder)
        {
            builder.HasOne(o => o.SeekerProfile)
                 .WithMany(o => o.ExperienceDetails)
                 .HasForeignKey(o => o.SeekerProfileId);
        }
    }
}
