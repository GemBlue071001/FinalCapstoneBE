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
    public class JobPostActivityConfig : IEntityTypeConfiguration<JobPostActivity>
    {
        public void Configure(EntityTypeBuilder<JobPostActivity> builder)
        {
            builder.HasOne(o => o.JobPost)
                .WithMany(o => o.JobPostActivitys)
                .HasForeignKey(o => o.JobPostId);

            builder.HasOne(o => o.UserAccount)
               .WithMany(o => o.JobPostActivitys)
               .HasForeignKey(o => o.UserId);

            builder.Property(o => o.Status)
                .HasConversion<int>();
        }
    }
}
