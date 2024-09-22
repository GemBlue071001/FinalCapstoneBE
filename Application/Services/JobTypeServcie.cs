using Application.Interface;
using Application.Request.JobPost;
using Application.Request.JobType;
using Application.Response;
using Application.Response.JobType;
using Application.Response.SeekerProfile;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class JobTypeServcie : IJobTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public JobTypeServcie(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddNewJobTypeAsync(JobTypeRequest jobTypeRequest)
        {
            try
            {
                var jobType = _mapper.Map<JobType>(jobTypeRequest);
                await _unitOfWork.JobTypes.AddAsync(jobType);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk();
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }

        }
        public async Task<ApiResponse> GetAllJobTypeAsync()
        {
            try
            {
                var jobTypes = await _unitOfWork.JobTypes.GetAllAsync(null);
                var jobTypeResponses = _mapper.Map<List<JobTypeResponse>>(jobTypes);
                return new ApiResponse().SetOk(jobTypeResponses);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message}");
            }
        }

        public async Task<ApiResponse> DeletedJobTypeByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var jobType = await _unitOfWork.JobTypes.GetAsync(x => x.Id == id);
                if (jobType == null)
                {
                    return response.SetNotFound("Can not found jobType id: " + id);
                }
                await _unitOfWork.JobTypes.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk(jobType);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }


    }
}
