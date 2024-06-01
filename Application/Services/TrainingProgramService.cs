using Application.Interface;
using Application.Request.TrainingProgram;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System.Resources;

namespace Application.Services
{
    public class TrainingProgramService : ITrainingProgramService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;
        public TrainingProgramService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<ApiResponse> AddTrainingProgram(TrainingProgramRequest request)
        {
            var response = new ApiResponse();
            await _unitOfWork.TrainingPrograms.AddAsync(_mapper.Map<TrainingProgram>(request));
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetAllTrainingProgram()
        {
            var response = new ApiResponse();
            var trainingPrograms = await _unitOfWork.TrainingPrograms.GetAllAsync(null);

            return response.SetOk(trainingPrograms);
        }
    }
}
