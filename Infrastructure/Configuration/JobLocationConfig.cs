﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.HasMany(o => o.JobPosts)
                .WithOne(o => o.JobLocation)
                .HasForeignKey(o => o.JobLocationId);

            builder.HasData(new JobLocation
            {
                Id = 1,
                City = "HCM",
                Country = "VietNam",
                District = "District 9",
                State = "state",
                StressAddress = "521 Le Van Si Stress",
                PostCode = "123",
                
            });
        }
    }
}