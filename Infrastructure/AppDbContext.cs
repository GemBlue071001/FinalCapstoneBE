using Domain.Entities;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserAccount> Users { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        //public DbSet<SeekerProfile> SeekerProfile { get; set; }
        public DbSet<JobLocation> JobLocations { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<SkillSet> SkillSets { get; set; }
        public DbSet<BusinessStream> BusinessStreams { get; set; }
        public DbSet<JobPostActivity> JobPostActivities { get; set; }
        public DbSet<JobSkillSet> JobSkillSets { get; set; }
        public DbSet<SeekerSkillSet> SeekerSkillSets { get; set; }
        public DbSet<EducationDetail> EducationDetails { get; set; }
        public DbSet<ExperienceDetail> ExperienceDetails { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<FollowCompany> FollowCompanys { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<EmailVerification> EmailVerifications { get; set; }


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
            //modelBuilder.ApplyConfiguration(new SeekerProfileConfig());
            modelBuilder.ApplyConfiguration(new SeekerSkillSetConfig());
            modelBuilder.ApplyConfiguration(new SkillSetConfig());
            modelBuilder.ApplyConfiguration(new CVConfig());
            modelBuilder.ApplyConfiguration(new ReviewConfig());
            modelBuilder.ApplyConfiguration(new LocationConfig());
            modelBuilder.ApplyConfiguration(new FollowCompanyConfig());
            modelBuilder.ApplyConfiguration(new NotificationConfig());
            modelBuilder.ApplyConfiguration(new EmailTemplateConfig());
            modelBuilder.ApplyConfiguration(new EmailVerificationsConfig());
        }

    }
}
