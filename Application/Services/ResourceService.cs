using Application.Interface;
using Application.Request.Resource;
using Application.Response;
using Application.Response.Resource;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ResourceService : IResourceService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public ResourceService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> AddResouceAsync(ResourceRequest request)
        {
            var response = new ApiResponse();
            var resource = _mapper.Map<Resource>(request);
            var trainingPrograms = await _unitOfWork.TrainingPrograms.GetAllAsync(u => request.TrainingProgramIds.Contains(u.Id));

            if (request.TrainingProgramIds.Count != trainingPrograms.Count)
                return response.SetBadRequest("JobId is invalid !");

            var trainingResourceList = new List<TrainingProgramResource>();

            foreach (var program in trainingPrograms)
            {
                trainingResourceList.Add(new TrainingProgramResource
                {
                    TrainingProgramId = program.Id,
                    TrainingProgram = program
                });
            }
            resource.TrainingProgramResources = trainingResourceList;

            await _unitOfWork.Resources.AddAsync(resource);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetAllResouceAsync()
        {
            var response = new ApiResponse();
            var resouces = await _unitOfWork.Resources.GetAllAsync(null);
            var responseList = _mapper.Map<List<ResourceResponse>>(resouces);

            return response.SetOk(responseList);
        }

    }
}
