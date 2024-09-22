using Application.Interface;
using Application.Request.JobLocation;
using Application.Response;
using Application.Response.JobLocation;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class JobLocationService: IJobLocationService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public JobLocationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddNewJobLocationAsync(JobLocationRequest jobLocationRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var joblocation = _mapper.Map<JobLocation>(jobLocationRequest);
                await _unitOfWork.JobLocations.AddAsync(joblocation);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk(joblocation);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetAllJobLocationAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var jobLocations = await _unitOfWork.JobLocations.GetAllAsync(null);
                var jobLocationResponse = _mapper.Map<List<JobLocationResponse>>(jobLocations);
                return new ApiResponse().SetOk(jobLocationResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> DeleteJobLocationByIdAsync(int id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var jobLocation = await _unitOfWork.JobLocations.GetAsync(x => x.Id == id);
                if (jobLocation == null)
                {
                    return apiResponse.SetNotFound("Can not found job location id: " + id);
                }
                await _unitOfWork.JobLocations.RemoveByIdAsync(jobLocation.Id);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk(jobLocation);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
    }
}
