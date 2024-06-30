using Application.Interface;
using Application.Request.Resource;
using Application.Response;
using Application.Response.Resource;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Org.BouncyCastle.Asn1.Ocsp;
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

        public async Task<ApiResponse> UpdateResourceAsync(ResourceUpdateRequest request)
        {
            var response = new ApiResponse();
            var resouce = await _unitOfWork.Resources.GetAsync(x => x.Id == request.Id);

            if (resouce == null)
            {
                return response.SetBadRequest($"resouce id {request.Id} is not found !");
            }

            _mapper.Map(request, resouce);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(resouce);
        }

        public async Task<ApiResponse> DeleteResourceAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                await _unitOfWork.Resources.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
            }
            catch (DbUpdateException ex)
            {
                return response.SetBadRequest($"Resource id {id} is still in a training program!");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest($"Resource id {id} is not found or another error occurred!");
            }

            return response.SetOk($"Resource id {id} is deleted!");
        }

    }
}
