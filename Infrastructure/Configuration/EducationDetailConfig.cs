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
    public class EducationDetailConfig : IEntityTypeConfiguration<EducationDetail>
    {
        public void Configure(EntityTypeBuilder<EducationDetail> builder)
        {
            builder.HasOne(o => o.SeekerProfile)
                  .WithMany(o => o.EducationDetails)
                  .HasForeignKey(o => o.SeekerProfileId);
        }
    }
}
