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
    public class AttendanceConfig : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasOne(o => o.User)
              .WithMany(o => o.Attendances)
              .HasForeignKey(o => o.UserId);

            builder.HasOne(o => o.CampaignJob)
               .WithMany(o => o.Attendances)
               .HasForeignKey(o => o.CampaignJobId);
        }
    }
}
