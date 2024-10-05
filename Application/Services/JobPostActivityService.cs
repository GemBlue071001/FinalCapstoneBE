using Application.Interface;
using Application.Request.JobPostActivity;
using Application.Response;
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
            var jobPostActivityModel = await _unitOfWork.JobPostActivities.GetAsync( x => x.JobPostId == request.JobPostId && claim.Id == x.UserId );
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
            jobPostActivity.Status = JobPostActivityStatus.Applied;
            await _unitOfWork.JobPostActivities.AddAsync(jobPostActivity);
            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetOk("Apply Success!");
        }

        public async Task<ApiResponse> UpdateJobPostActivityAsync(JobPostActivityUpdateRequest request)
        {
            var jobPostActivity = await _unitOfWork.JobPostActivities.GetAsync(x => x.Id == request.JobPostActivityId);

            if (jobPostActivity == null)
            {
                return new ApiResponse().SetBadRequest($"Cant not find JobPostActivity {request.JobPostActivityId} !");
            }

            jobPostActivity.Status = (JobPostActivityStatus)request.Status!;
            await _unitOfWork.SaveChangeAsync();


            return new ApiResponse().SetOk("Update Job Post Activity Success !");
        }

    }
}
