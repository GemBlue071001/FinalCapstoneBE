using Application.Interface;
using Application.Request.Service;
using Application.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Application.Response.Service;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace Application.Services
{
    public class ServiceSerivce : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private IClaimService _claimService;

        public ServiceSerivce(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }

        public async Task<ApiResponse> AddNewServiceAsync(ServiceRequest request)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var service = _mapper.Map<Service>(request);
                await _unitOfWork.Services.AddAsync(service);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk("Create Service Successfully");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetServiceListAsync()
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var serviceList = await _unitOfWork.Services.GetAllAsync(null);
                var responseList = _mapper.Map<List<ServiceResponse>>(serviceList);

                return response.SetOk(responseList);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetServiceByIdAsync(int Id)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var serviceId = await _unitOfWork.Services.GetAsync(x => x.Id == Id);
                if (serviceId == null)
                {
                    return response.SetNotFound("Cannot found service Id: " + Id);
                }
                var service = _mapper.Map<ServiceResponse>(serviceId);
                return response.SetOk(service);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> DeleteServiceAsync(int Id)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var service = await _unitOfWork.Services.GetAsync(x => x.Id == Id);
                if (service == null)
                {
                    return response.SetNotFound("Cannot found service Id: " + Id);
                }
                await _unitOfWork.Services.RemoveByIdAsync(Id);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk("Deleted successfully");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> UpdateServiceAsync(int Id, ServiceRequest request)
        {
            ApiResponse response = new ApiResponse();
            var service = await _unitOfWork.Services.GetAsync(s => s.Id == Id);
            if (service == null)
            {
                return response.SetNotFound($"Service Id: {Id} not found");
            }
            _mapper.Map(request, service);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Updated successfully");
        }
    }
}
