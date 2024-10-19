using Application.Interface;
using Domain.Entities;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Application.MyBackgroundJob
{
    public class EmailJob
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmailService _emailService;
        private readonly ILogger<EmailJob> _logger;

        public EmailJob(IUnitOfWork unitOfWork, IEmailService emailService, ILogger<EmailJob> logger)
        {
            _unitOfWork = unitOfWork;
            _emailService = emailService;
            _logger = logger;
        }

        [AutomaticRetry(Attempts = 2)]
        public async Task SendEmailsToFollowers(int companyId, JobPost jobPost)
        {
            var company = await _unitOfWork.Companys.GetAsync(c => c.Id == companyId);
            if (company == null)
            {
                throw new Exception("Company not found");
            }

            var followers = await _unitOfWork.FollowCompanies.GetAllAsync(f => f.CompanyId == companyId, x => x.Include(x => x.UserAccount));
            if (followers != null && followers.Count > 0)
            {
                var followerEmails = followers.Select(f => f.UserAccount.Email).ToList();
                var emailContent = await _unitOfWork.EmailTemplates.GetAsync(x => x.Name.Equals("Job Opportunity Email"));

                foreach (var userEmail in followerEmails)
                {
                    await _emailService.SendMail(userEmail!, emailContent.EmailContent, $"{userEmail}", company.CompanyName, jobPost.JobTitle);
                }
            }
        }

        [AutomaticRetry(Attempts = 2)]
        public async Task TestJob()
        {
            var company = await _unitOfWork.Companys.GetAsync(c => c.Id == 3);
            _logger.LogInformation($"TRINH TAMMMMMMMMMMMMMMM {company.CompanyName}");
        }
    }

}
