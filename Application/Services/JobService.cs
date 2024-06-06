using Application.Interface;
using Application.Request.Job;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System.Resources;

namespace Application.Services
{
    public class JobService : IJobService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;
        public JobService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<ApiResponse> AddJob(JobRequest request)
        {
            var response = new ApiResponse();
            await _unitOfWork.Jobs.AddAsync(_mapper.Map<Job>(request));
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetAllJob()
        {
            var response = new ApiResponse();
            var trainingPrograms = await _unitOfWork.Jobs.GetAllAsync(null);

            return response.SetOk(trainingPrograms);
        }
    }
}
