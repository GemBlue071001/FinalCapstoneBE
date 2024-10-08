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
    public class JobPostConfig : IEntityTypeConfiguration<JobPost>
    {
        public void Configure(EntityTypeBuilder<JobPost> builder)
        {
            builder.HasOne(o => o.UserAccount)
                .WithMany(o => o.JobPosts)
                .HasForeignKey(o => o.UserId);

            builder.HasMany(o => o.JobPostActivitys)
                .WithOne(o => o.JobPost)
                .HasForeignKey(o => o.JobPostId);

            builder.HasMany(o => o.JobSkillSets)
                .WithOne(o => o.JobPost)
                .HasForeignKey(o => o.JobPostId);

            builder.HasOne(o => o.Company)
                .WithMany(o => o.JobPosts)
                .HasForeignKey(o => o.CompanyId);

            builder.HasOne(o => o.JobType)
                .WithMany(o => o.JobPosts)
                .HasForeignKey(o => o.JobTypeId);

            //builder.HasOne(o => o.JobLocation)
            //    .WithMany(o => o.JobPosts)
            //    .HasForeignKey(o => o.JobLocationId);

        }
    }
}
