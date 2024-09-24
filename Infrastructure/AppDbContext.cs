using Domain.Entities;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserAccount> Users { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<SeekerProfile> SeekerProfile { get; set; }
        public DbSet<JobLocation> JobLocations { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<SkillSet> SkillSets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new BusinessStreamConfig());
            modelBuilder.ApplyConfiguration(new CompanyConfig());
            modelBuilder.ApplyConfiguration(new EducationDetailConfig());
            modelBuilder.ApplyConfiguration(new ExperienceDetailConfig());
            modelBuilder.ApplyConfiguration(new JobLocationConfig());
            modelBuilder.ApplyConfiguration(new JobPostActivityConfig());
            modelBuilder.ApplyConfiguration(new JobPostConfig());
            modelBuilder.ApplyConfiguration(new JobSkillSetConfig());
            modelBuilder.ApplyConfiguration(new JobTypeConfig());
            modelBuilder.ApplyConfiguration(new SeekerProfileConfig());
            modelBuilder.ApplyConfiguration(new SeekerSkillSetConfig());
            modelBuilder.ApplyConfiguration(new SkillSetConfig());
        }

    }
}
