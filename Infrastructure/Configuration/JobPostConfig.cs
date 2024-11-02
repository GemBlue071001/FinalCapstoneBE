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

            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory).FullName;

            string jsonPath = Path.Combine(parentDirectory, "jobPostData.json"); // Replace with your path
            string jsonContent = File.ReadAllText(jsonPath);
            List<JobPost> jobs = JsonConvert.DeserializeObject<List<JobPost>>(jsonContent);
            foreach (JobPost job in jobs)
            {
                job.JobLocations = null;
            }
            builder.HasData(jobs);
        }
    }
}
