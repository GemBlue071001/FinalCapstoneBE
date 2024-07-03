using Application.Interface;
using Application.Request.Job;
using Application.Response;
using Application.Response.Job;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ApiResponse> AddTrainingProgramToJobAsync(JobTrainingRequest request)
        {
            var response = new ApiResponse();
            var jobTrainingProgram = await _unitOfWork.JobTrainingPrograms.GetAsync(x => x.JobId == request.JobId &&
                                                                     x.TrainingProgramId == request.TrainingProgramId);
            if (jobTrainingProgram != null)
                return response.SetBadRequest("Training program already exist in this job !!");

            await _unitOfWork.JobTrainingPrograms.AddAsync(new JobTrainingProgram
            {
                TrainingProgramId = request.TrainingProgramId,
                JobId = request.JobId,
            });
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Add Training Program To Job Success !!");
        }

        public async Task<ApiResponse> RemoveTrainingProgramFromJobAsync(JobTrainingRequest request)
        {
            var response = new ApiResponse();
            var jobTrainingProgram = await _unitOfWork.JobTrainingPrograms.GetAsync(x => x.JobId == request.JobId &&
                                                                     x.TrainingProgramId == request.TrainingProgramId);
            if (jobTrainingProgram == null)
                return response.SetBadRequest("Training program not exist in this job !!");

            await _unitOfWork.JobTrainingPrograms.RemoveByIdAsync(jobTrainingProgram.Id);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Remove Training Program From Job Success !!");
        }

        public async Task<ApiResponse> GetAllJob()
        {
            var response = new ApiResponse();
            var jobs = await _unitOfWork.Jobs.GetAllAsync(null, x => x.Include(x => x.JobTrainingPrograms)
                                                                        .ThenInclude(x => x.TrainingProgram));
            var responseList = _mapper.Map<List<JobResponse>>(jobs);

            return response.SetOk(responseList);
        }

        public async Task<ApiResponse> DeleteJob(int id)
        {
            var response = new ApiResponse();
            var jobs = await _unitOfWork.Jobs.GetAsync(x => x.Id == id);
            if (jobs == null)
                return response.SetBadRequest("Job Not Found!");
            await _unitOfWork.Jobs.RemoveByIdAsync(id);
            await _unitOfWork.SaveChangeAsync();

            
            return response.SetOk(jobs);

        }

        public async Task<ApiResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            var response = new ApiResponse();
            var job = await _unitOfWork.Jobs.GetAsync(x => x.Id == request.Id);
            if(job == null)
            {
                return response.SetBadRequest("Job cannot found");
            }

            _mapper.Map(request, job);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(job);
        }
    }
}
