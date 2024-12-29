using Application.EmailTemplates;
using Application.Interface;
using Application.Request.UserJobAlertCriteria;
using Application.Response;
using Application.Response.UserJobAlertCriteria;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class UserJobAlertCriteriaService : IUserJobAlertCriteriaService
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public readonly IEmailService _emailService;

        public UserJobAlertCriteriaService(IUnitOfWork unitOfWork, IMapper mapper, IEmailService emailService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _emailService = emailService;
        }
        public async Task ResetUserJobAlertCriteriaIdSequenceAsync()
        {
            var x = await _unitOfWork.UserJobAlertCriterias.CountAsync();
            if (x <= 0) 
                return;
            ApiResponse apiResponse = new ApiResponse();
            // Get the sequence name for the UserJobAlertCriteria.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"UserJobAlertCriterias\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the UserJobAlertCriterias table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"UserJobAlertCriterias\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }
        public async Task<ApiResponse> AddNewAlertCriteriaAsync(UserJobAlertCriteriaRequest criteriaRequest)
        {
            try
            {
                await ResetUserJobAlertCriteriaIdSequenceAsync();
                var criteria = _mapper.Map<UserJobAlertCriteria>(criteriaRequest);
                await _unitOfWork.UserJobAlertCriterias.AddAsync(criteria);
                await _unitOfWork.SaveChangeAsync();
                await ProcessMatchingJob();
                return new ApiResponse().SetOk();
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> DeleteAlertCriteriaByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var criteria = await _unitOfWork.UserJobAlertCriterias.GetAsync(c => c.Id == id);
                if (criteria == null)
                {
                    return response.SetNotFound("Cannot find UserJobAlertCriteria with ID: " + id);
                }

                await _unitOfWork.UserJobAlertCriterias.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk(criteria);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetAllAlertCriteriaAsync(int userId)
        {
            try
            {
                var criteriaList = await _unitOfWork.UserJobAlertCriterias.GetAllAsync(c => c.UserId == userId,
                                                                                       x => x.Include(x => x.SkillSet!)
                                                                                              .Include(x => x.JobType!)
                                                                                              .Include(x => x.Location!));
                var response = _mapper.Map<List<UserJobAlertCriteriaResponse>>(criteriaList);

                return new ApiResponse().SetOk(response);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> ProcessMatchingJob()
        {
            try
            {
                var matchingJobs = await _unitOfWork.UserJobAlertCriterias.GetMatchingJobsForAllUsersAsync();
                if (matchingJobs != null && matchingJobs.Count > 0) {
                    await SendMatchingJobsEmail(matchingJobs);
                }

                return new ApiResponse().SetOk(matchingJobs);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
                throw;
            }
        }

        private async Task SendMatchingJobsEmail(Dictionary<int, List<JobPost>> matchingJobs)
        {
            foreach (var matchingJob in matchingJobs)
            {
                //var user = matchingJob.Value?.ToList().FirstOrDefault()?.UserAccount;
                var userId = matchingJob.Key;
                var user = await _unitOfWork.UserAccounts.GetAsync(x=>x.Id == userId);

                var jobs = matchingJob.Value ?? [];
                var content = MatchingJobsEmailTemplate.MatchingJobs;
                var jobsHtml = "";

                foreach (var job in jobs)
                {
                    var skillSets = job.JobSkillSets.Select(s => s?.SkillSet?.Name).ToList();
                    string skillSetsName = skillSets.Count > 0 ? string.Join(", ", skillSets) : "N/A";

                    string jobItem = MatchingJobsEmailTemplate.MathchingJob
                        .Replace("${JobTitle}", job.JobTitle)
                        .Replace("${CompanyName}", job.Company.CompanyName)
                        .Replace("${JobSkillSets}", skillSetsName)
                        .Replace("${ExpiredDate}", job.ExpiryDate.ToShortDateString())
                        .Replace("${Address}", job.JobLocations.FirstOrDefault()?.StressAddressDetail)
                        .Replace("${ImageURL}", job.ImageURL);

                    jobsHtml += jobItem;
                }

                content = content
                    .Replace("${Name}", user?.FirstName + " " + user?.LastName)
                    .Replace("${Jobs}", jobsHtml);

                if (!string.IsNullOrEmpty(user?.Email) && jobs.Count > 0)
                {
                    await _emailService.SendMatchingJobEmail(user.Email, content);
                }
            }
        }
    }
}
