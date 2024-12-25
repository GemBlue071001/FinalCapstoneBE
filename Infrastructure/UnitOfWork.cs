using Application;
using Application.Repositories;
using Application.Repository;
using Application.Services;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        public IUserAccountRepository UserAccounts { get; }
        public IJobPostRepository JobPosts { get; }
        public IJobLocationRepository JobLocations { get; }
        public IJobTypeRepository JobTypes { get; }
        public ICompanyRepository Companys { get; }
        public IEducationDetailRepository EducationDetails { get; }
        public IExperienceDetailRepository ExperienceDetails { get; }
        public IBusinessStreamRepository BusinessStreams { get; }
        public ISkillSetRepository SkillSets { get; }
        public IJobSkillSetRepository JobSkillSets { get; }
        public IJobPostActivityRepository JobPostActivities { get; }
        public ICVRepository CVs { get; }
        public ISeekerSkillSetRepository SeekerSkillSets { get; }
        public IFollowCompanyRepository FollowCompanies { get; }
        public INotifcationRepository Notifcations { get; }
        public IEmailTemplateRepository EmailTemplates { get; }
        public IEmailVerificationRepository EmailVerifications { get; }
        public IFollowJobRepository FollowJobs { get; }
        public IReviewRepository Reviews { get; }
        public IJobPostActivityCommentRepository JobPostActivityComments { get; }
        public ISubscriptionRepository Subscriptions { get; }
        public IUserJobAlertCriteriaRepository UserJobAlertCriterias { get; }
        public IBenefitRepository Benefits { get; }
        public ISeekerBenefitRepository SeekerBenefits { get; }
        public IJobPostBenefitRepository JobPostBenefits { get; }
        public IUserAccountServiceRepository UserServices { get; }

        //public IFeedBackRepository FeedBacks { get; }
        public IServiceRepository Services { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UserAccounts = new UserAccountRepository(context);
            JobPosts = new JobPostRepository(context);
            JobLocations = new JobLocationRepository(context);
            JobTypes = new JobTypeRepository(context);
            Companys = new CompanyRepository(context);
            EducationDetails = new EducationDetailRepository(context);
            ExperienceDetails = new ExperienceDetailRepository(context);
            SkillSets = new SkillSetRepository(context);
            JobSkillSets = new JobSkillSetRepository(context);
            BusinessStreams = new BusinessStreamRepository(context);
            JobPostActivities = new JobPostActivityRepository(context);
            CVs = new CVRepository(context);
            Reviews = new ReviewRepository(context);
            SeekerSkillSets = new SeekerSkillSetRepository(context);
            FollowCompanies = new FollowCompanyRepository(context);
            Notifcations = new NotificationRepository(context);
            EmailTemplates = new EmailTemplateRepository(context);
            EmailVerifications = new EmailVerificationRepository(context);
            FollowJobs = new FollowJobRepository(context);
            JobPostActivityComments = new JobPostActivityCommentRepository(context);
            Subscriptions = new SubscriptionRepository(context);
            UserJobAlertCriterias = new UserJobAlertCriteriaRepository(context);
            Benefits = new BenefitRepository(context);
            SeekerBenefits = new SeekerBenefitRepository(context);
            JobPostBenefits = new JobPostBenefitRepository(context);
            //FeedBacks = new FeedBackRepository(context);
            Services = new ServiceRepository(context);
            UserServices = new UserAccountServiceRepository(context);
        }

        public async Task SaveChangeAsync()
        {
            try
            {
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<T> ExecuteScalarAsync<T>(string sql)
        {
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                try
                {
                    if (command.Connection!.State != System.Data.ConnectionState.Open)
                    {
                        await command.Connection.OpenAsync();
                    }

                    command.CommandText = sql;
                    var result = await command.ExecuteScalarAsync();
                    return (T)Convert.ChangeType(result, typeof(T));
                }
                finally
                {
                    if (command.Connection!.State == System.Data.ConnectionState.Open)
                    {
                        await command.Connection.CloseAsync();
                    }
                }
            }
        }

        public async Task ExecuteRawSqlAsync(string sql)
        {
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                try
                {
                    if (command.Connection.State != System.Data.ConnectionState.Open)
                    {
                        await command.Connection.OpenAsync();
                    }

                    command.CommandText = sql;
                    await command.ExecuteNonQueryAsync();
                }
                finally
                {
                    if (command.Connection.State == System.Data.ConnectionState.Open)
                    {
                        await command.Connection.CloseAsync();
                    }
                }
            }
        }

    }
}
