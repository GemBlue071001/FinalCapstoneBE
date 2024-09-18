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
    public class JobTypeConfig : IEntityTypeConfiguration<JobType>
    {
        public void Configure(EntityTypeBuilder<JobType> builder)
        {
            builder.HasMany(o => o.JobPosts)
               .WithOne(o => o.JobType)
               .HasForeignKey(o => o.JobTypeId);

            builder.HasData
                (
                  new JobType
                  {
                      Id = 1,
                      Name = "Full Time",
                      Description = "A Full Time Job"
                  },
                  new JobType
                  {
                      Id = 2,
                      Name = "Part Time",
                      Description = "A Part Time Job"
                  },
                  new JobType
                  {
                      Id = 3,
                      Name = "Remote",
                      Description = "A Remote Job"
                  }
                );
        }
    }
}
