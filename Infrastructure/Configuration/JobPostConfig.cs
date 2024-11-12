﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            // Định nghĩa chỉ mục HNSW cho trường Embedding
            builder.HasIndex(j => j.Embedding)
                .HasMethod("hnsw")
                .HasOperators("vector_l2_ops")
                .HasStorageParameter("m", 16)
                .HasStorageParameter("ef_construction", 64);
        }
    }
}
