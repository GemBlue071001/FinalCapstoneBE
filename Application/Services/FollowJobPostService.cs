using Application.Interface;
using Application.Request.FollowJob;
using Application.Response;
using Application.Response.JobPost;
using AutoMapper;
using Domain.Entities;


namespace Application.Services
{
    public class FollowJobPostService : IFollowJobPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private IClaimService _claimService;
        public FollowJobPostService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }
        public async Task ResetFollowJobIdSequenceAsync()
        {
            // Get the sequence name for the FollowJob.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"FollowJobs\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the FollowJobs table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"FollowJobs\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }
        public async Task<ApiResponse> AddFollowJobPostAsync(FollowJobRequest followJobRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                await ResetFollowJobIdSequenceAsync();
                var claim = _claimService.GetUserClaim();
                var jobPost = await _unitOfWork.JobPosts.GetAsync(x => x.Id == followJobRequest.JobPostId);
                if (jobPost == null)
                {
                    return apiResponse.SetBadRequest("Not found Company " + followJobRequest.JobPostId);
                }
                var followJobPost = _mapper.Map<FollowJob>(followJobRequest);
                followJobPost.UserId = claim.Id;
                await _unitOfWork.FollowJobs.AddAsync(followJobPost);
                await _unitOfWork.SaveChangeAsync();
                return apiResponse.SetOk("Add Success");

            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetFollowJobPostAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var claim = _claimService.GetUserClaim();
                var followJobs = await _unitOfWork.FollowJobs.GetAllAsync(x => x.UserId == claim.Id);
                var listJobsId = followJobs.Select(x => x.JobPostId).ToList();
                var jobposts = await _unitOfWork.JobPosts.GetAllAsync(x => listJobsId.Contains(x.Id));
                var responseList = _mapper.Map<List<JobPostResponse>>(jobposts);
                return apiResponse.SetOk(responseList);
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> DeleteFollowJobPostById(int id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var claim = _claimService.GetUserClaim();
                var followJobPost = await _unitOfWork.FollowJobs.GetAsync(x => x.UserId == claim.Id && x.JobPostId == id);
                if (followJobPost == null)
                {
                    return apiResponse.SetBadRequest("Not found follow Job " + id);
                }
                await _unitOfWork.FollowJobs.RemoveByIdAsync(followJobPost.Id);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("follow Job deleted successfully!");
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
    }
}
