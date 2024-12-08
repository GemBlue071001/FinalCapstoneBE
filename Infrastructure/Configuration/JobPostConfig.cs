using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pgvector;

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
            
            builder.HasMany(o => o.JobPostBenefits)
              .WithOne(o => o.JobPost)
              .HasForeignKey(o => o.JobPostId);

            //// Định nghĩa chỉ mục HNSW cho trường Embedding
            //builder.HasIndex(j => j.Embedding)
            //    .HasMethod("hnsw")
            //    .HasOperators("vector_l2_ops")
            //    .HasStorageParameter("m", 16)
            //    .HasStorageParameter("ef_construction", 64);

            //    var vectorConverter = new ValueConverter<Vector, float[]>(
            //    v => v.ToArray(),        // Convert Vector to float[]
            //    v => new Vector(v)       // Convert float[] back to Vector
            //);


            //builder
            //.Property(j => j.Embedding)
            //.HasColumnType("vector(384)");
        }
    }
}
