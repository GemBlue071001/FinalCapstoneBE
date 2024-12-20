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
    public class JobPostActivityCommentConfig : IEntityTypeConfiguration<JobPostActivityComment>
    {
        public void Configure(EntityTypeBuilder<JobPostActivityComment> builder)
        {
            builder.HasOne(o => o.JobPostActivity)
                   .WithMany(o => o.JobPostActivityComments)
                   .HasForeignKey(o => o.JobPostActivityId);
        }
    }
}
