using Application.Interface;
using Application.Request.TrainingProgram;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TrainingProgramService : ITrainingProgramService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public TrainingProgramService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddTrainingProgram(TrainingProgramRequest request)
        {
            var response = new ApiResponse();
            var program = _mapper.Map<TrainingProgram>(request);
            var jobs = await _unitOfWork.Jobs.GetAllAsync(u => request.JobIds.Contains(u.Id));

            if (request.JobIds.Count != jobs.Count)
                return response.SetBadRequest("JobId is invalid !");

            var lisOfJobTP = new List<JobTrainingProgram>();

            foreach (var job in jobs)
            {
                lisOfJobTP.Add(new JobTrainingProgram
                {
                    JobId = job.Id,
                    TrainingProgram = program
                });
            }
            program.JobTrainingPrograms = lisOfJobTP;

            await _unitOfWork.TrainingPrograms.AddAsync(program);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }
    }
}
