using Application.Interface;
using Application.Request.JobPostActivity;
using Application.Response;
using Application.Response.JobPostActivity;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class JobPostActivityService : IJobPostActivityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;

        public JobPostActivityService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }
        public async Task ResetJobPostActivityIdSequenceAsync()
        {
            // Get the sequence name for the JobPostActivitie.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"JobPostActivities\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the JobPostActivities table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"JobPostActivities\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }
        public async Task<ApiResponse> AddNewJobPostActivityAsync(JobPostActivityRequest request)
        {
            await ResetJobPostActivityIdSequenceAsync();
            var claim = _claimService.GetUserClaim();
            var jobPost = await _unitOfWork.JobPosts.GetJobPostsByIdAsync(request.JobPostId);
            if (jobPost == null)
            {
                return new ApiResponse().SetBadRequest("Job Post not found.");
            }
            if(DateTime.UtcNow > jobPost.ExpiryDate)
            {
                return new ApiResponse().SetBadRequest("Job Post Exprire");
            }
            var jobPostActivityModel = await _unitOfWork.JobPostActivities.GetAsync(x => x.JobPostId == request.JobPostId && claim.Id == x.UserId);
            if (jobPostActivityModel != null)
            {
                return new ApiResponse().SetBadRequest("User have already apply.");
            }
            var userCvs = await _unitOfWork.CVs.GetAllAsync(cv => cv.UserId == claim.Id);
            if (userCvs == null || !userCvs.Any())
            {
                return new ApiResponse().SetBadRequest("User must have at least one CV to apply.");
            }
            var userCv = userCvs.FirstOrDefault(cv => cv.Id == request.CvId);
            if (userCv == null)
            {
                return new ApiResponse().SetBadRequest("Invalid CV provided.");
            }
            var jobPostActivity = _mapper.Map<JobPostActivity>(request);
            jobPostActivity.UserId = claim.Id;
            jobPostActivity.ApplicationDate = DateTime.UtcNow;
            jobPostActivity.Status = JobPostActivityStatus.Pending;
            await _unitOfWork.JobPostActivities.AddAsync(jobPostActivity);
            await _unitOfWork.SaveChangeAsync();

            var notification = new Notification
            {
                JobPostActivityId = jobPostActivity.Id,
                Title = "New Application Created",
                Description = "Status: " + jobPostActivity.Status.ToString(),
                CreatedDate = DateTime.UtcNow,
                ReceiverId = jobPost.CompanyId ?? 0,
            };

            await _unitOfWork.Notifcations.AddAsync(notification);

            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetOk(new JobPostActivityMessageTemplate { CompanyId = jobPost.CompanyId ?? 0, JobPostActivityId = jobPostActivity.Id });
        }

        public async Task<ApiResponse> UpdateJobPostActivityAsync(JobPostActivityUpdateRequest request)
        {
            var jobPostActivity = await _unitOfWork.JobPostActivities.GetAsync(x => x.Id == request.JobPostActivityId);

            if (jobPostActivity == null)
            {
                return new ApiResponse().SetBadRequest($"Cant not find JobPostActivity {request.JobPostActivityId} !");
            }

            jobPostActivity.Status = (JobPostActivityStatus)request.Status!;

            var notification = new Notification
            {
                JobPostActivityId = request.JobPostActivityId,
                Title = "Application Status Updated",
                Description = "Status: " + jobPostActivity.Status.ToString(),
                CreatedDate = DateTime.UtcNow,
            };

            if (jobPostActivity.UserId is not null)
            {
                var userAccount = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == jobPostActivity.UserId);

                if (userAccount is not null)
                {
                    notification.ReceiverId = userAccount.Id;
                }
            }

            await _unitOfWork.Notifcations.AddAsync(notification);

            await _unitOfWork.SaveChangeAsync();


            return new ApiResponse().SetOk(notification.ReceiverId);
        }

        public async Task<List<Notification>> GetNotifications(int userId, bool isUnreadOnly = false)
        {
            var account = await _unitOfWork.UserAccounts.GetAsync(a => a.Id == userId);

            if (account is null)
            {
                return [];
            }

            var receiverId = userId;

            if(account.Role == Role.Employer)
            {
                receiverId = account.CompanyId ?? 0;
            }

            var notifications = await _unitOfWork.Notifcations.GetAllAsync(x => x.ReceiverId == receiverId);

            if (notifications is null || (notifications != null && notifications.Count <= 0))
            {
                return [];
            }

            List<Notification> result = notifications!.Select(n => new Notification
            {
                Id = n.Id,
                Title = n.Title,
                Description = n.Description,
                IsRead = n.IsRead,
                CreatedDate = DateTime.UtcNow,
                JobPostActivityId = n.JobPostActivityId,
                ReceiverId = n.ReceiverId,
            }).ToList();

            if (isUnreadOnly == true)
            {
                result = result.Where(item => item.IsRead == false).ToList();
            }

            result = result.OrderByDescending(item => item.CreatedDate).ToList();

            return result ?? [];
        }

        public async Task<bool> ReadNotification(int id)
        {
            var notification = await _unitOfWork.Notifcations.GetAsync(x => x.Id == id);
            if (notification != null)
            {
                notification.IsRead = true;
                await _unitOfWork.SaveChangeAsync();
                return true;
            }
            return false;
        }

        public async Task ReadAllNotification(int userId)
        {
            var notifications = await GetNotifications(userId, false);

            if (notifications != null && notifications.Count > 0)
            {
                foreach (var notify in notifications.ToList())
                {
                    notify.IsRead = true;
                }
                await _unitOfWork.SaveChangeAsync();
            }
        }

        public async Task<ApiResponse> GetTop100()
        {
            var top100 = await _unitOfWork.JobPostActivities.SelectTop100MatchApplications();
            var result = top100.Select(x => x.Id).ToList();
            return new ApiResponse().SetOk(result);
        }
        public async Task<ApiResponse> AddNewJobPostActivityAndUserAsync(JobPostActivityUserRequest request)
        {
            //var claim = _claimService.GetUserClaim();
            var jobPost = await _unitOfWork.JobPosts.GetJobPostsByIdAsync(request.JobPostId);
            if (jobPost == null)
            {
                return new ApiResponse().SetBadRequest("Job Post not found.");
            }
            if (DateTime.UtcNow > jobPost.ExpiryDate)
            {
                return new ApiResponse().SetBadRequest("Job Post Exprire");
            }
            var jobPostActivityModel = await _unitOfWork.JobPostActivities.GetAsync(x => x.JobPostId == request.JobPostId && request.UserId == x.UserId);
            if (jobPostActivityModel != null)
            {
                return new ApiResponse().SetBadRequest("User have already apply.");
            }
            var userCvs = await _unitOfWork.CVs.GetAllAsync(cv => cv.UserId == request.UserId);
            if (userCvs == null || !userCvs.Any())
            {
                return new ApiResponse().SetBadRequest("User must have at least one CV to apply.");
            }
            var userCv = userCvs.FirstOrDefault(cv => cv.Id == request.CvId);
            if (userCv == null)
            {
                return new ApiResponse().SetBadRequest("Invalid CV provided.");
            }
            var jobPostActivity = _mapper.Map<JobPostActivity>(request);
            jobPostActivity.UserId = request.UserId;
            jobPostActivity.ApplicationDate = DateTime.UtcNow;
            jobPostActivity.Status = JobPostActivityStatus.InterviewStage;
            await _unitOfWork.JobPostActivities.AddAsync(jobPostActivity);
            await _unitOfWork.SaveChangeAsync();

            var notification = new Notification
            {
                JobPostActivityId = jobPostActivity.Id,
                Title = "New Application Created",
                Description = "Status: " + jobPostActivity.Status.ToString(),
                CreatedDate = DateTime.UtcNow,
                ReceiverId = jobPost.CompanyId ?? 0,
            };

            await _unitOfWork.Notifcations.AddAsync(notification);

            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetOk(new JobPostActivityMessageTemplate { CompanyId = jobPost.CompanyId ?? 0, JobPostActivityId = jobPostActivity.Id });
        }
    }
}
