using Application.Interface;
using Application.Request.TrainingProgram;
using Application.Response;
using Application.Response.Campaign;
using Application.Response.Job;
using Application.Response.Resource;
using Application.Response.TrainingProgram;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
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
        public async Task<ApiResponse> GetAllTrainingProgram()
        {
            var response = new ApiResponse();
            var trainingPrograms = await _unitOfWork.TrainingPrograms.GetAllTrainingProgram();

            var resposeList = _mapper.Map<List<TrainingProgramResponse>>(trainingPrograms);



            return response.SetOk(resposeList);

        }

        public async Task<ApiResponse> RemoveResourceFromTrainingProgramAsync(TrainingResourceRequest request)
        {
            var response = new ApiResponse();
            var trainingResource = await _unitOfWork.TrainingProgramResources.GetAsync(x => x.ResourceId == request.ResourceId &&
                                                                                        x.TrainingProgramId == request.TrainingProgramId);

            if (trainingResource == null)
            {
                return response.SetBadRequest($"training resource is not found !");
            }

            await _unitOfWork.TrainingProgramResources.RemoveByIdAsync(trainingResource.Id);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk($"remove success!");
        }

        public async Task<ApiResponse> UpdateTrainingProgramAsync(TrainingUpdateRequest request)
        {
            var response = new ApiResponse();
            var trainingProgram = await _unitOfWork.TrainingPrograms.GetAsync(x => x.Id == request.Id);

            if (trainingProgram == null)
            {
                return response.SetBadRequest($"training program is not found !");
            }

            _mapper.Map(request, trainingProgram);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(trainingProgram);
        }

        public async Task<ApiResponse> DeleteTrainingProgramAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                await _unitOfWork.TrainingPrograms.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
            }
            catch (DbUpdateException ex)
            {
                return response.SetBadRequest($"training Program id {id} is still in a campaign!");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest($"Resource id {id} is not found or another error occurred!");
            }

            return response.SetOk($"Resource id {id} is deleted!");
        }

    }
}
