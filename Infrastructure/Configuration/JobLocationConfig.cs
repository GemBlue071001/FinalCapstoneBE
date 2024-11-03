using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class JobLocationConfig : IEntityTypeConfiguration<JobLocation>
    {
        public void Configure(EntityTypeBuilder<JobLocation> builder)
        {
            builder.HasOne(o => o.JobPost)
                .WithMany(o => o.JobLocations)
                .HasForeignKey(o => o.JobPostId);

            builder.HasOne(o => o.Location)
                 .WithMany(o => o.JobLocations)
                 .HasForeignKey(o => o.LocationId);
        }
    }
}
