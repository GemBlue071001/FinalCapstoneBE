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

        public async Task<ApiResponse> AddNewJobPostActivityAsync(JobPostActivityRequest request)
        {
            var claim = _claimService.GetUserClaim();
            var jobPost = await _unitOfWork.JobPosts.GetAsync(x => x.Id == request.JobPostId);
            if (jobPost == null)
            {
                return new ApiResponse().SetBadRequest("Job Post not found.");
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

            if(jobPostActivity.UserId is not null)
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

        public async Task<List<Notification>> GetNotificationsByEmployerId(int userId, bool isRead = false)
        {
            var account = await _unitOfWork.UserAccounts.GetAsync(a => a.Id == userId);

            if(account is null || account.CompanyId is null)
            {
                return [];
            }

            List<Notification> result = await GetNotificationsByCompanyId(account.CompanyId ?? 0, isRead);

            return result ?? [];
        }

        public async Task<List<Notification>> GetNotificationsByCompanyId(int companyId, bool isRead = false)
        {
            var notifications = await _unitOfWork.Notifcations.GetAllAsync(x => x.ReceiverId == companyId);

            if(notifications is null || (notifications != null && notifications.Count <= 0))
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
                JobPostActivityId = companyId,
                ReceiverId = n.ReceiverId,
            }).ToList();

            if (isRead == false)
            {
                result = result.Where(res => res.IsRead == false).ToList();
            }

            result = result.OrderByDescending(item => item.CreatedDate).ToList();

            return result ?? [];
        }
    }
}
