using Application.Interface;
using Application.Request.JobType;
using Application.Request.Location;
using Application.Response;
using Application.Response.CV;
using Application.Response.JobType;
using Application.Response.Location;
using AutoMapper;


using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public LocationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddNewLocationAsync(LocationRequest locationRequest)
        {
            try
            {
                var location = _mapper.Map<Location>(locationRequest);
                await _unitOfWork.Locations.AddAsync(location);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk("Add Success");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }

        }
        public async Task<ApiResponse> GetAllLocationAsync()
        {
            try
            {
                var locations = await _unitOfWork.Locations.GetAllAsync(null);
                var locationsResponses = _mapper.Map<List<LocationResponse>>(locations);
                return new ApiResponse().SetOk(locationsResponses);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message}");
            }
        }
        public async Task<ApiResponse> GetLocationByIdAsync(int locationId)
        {
            try
            {   
                var location = await _unitOfWork.Locations.GetAsync(x=> x.Id == locationId);
                if (location == null)
                {
                    return new ApiResponse().SetNotFound("Can not found location id: " + locationId);
                }
                var locationsResponses = _mapper.Map<LocationResponse>(location);
                return new ApiResponse().SetOk(locationsResponses);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message}");
            }
        }
        public async Task<ApiResponse> DeletedLocationByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var location = await _unitOfWork.Locations.GetAsync(x => x.Id == id);
                if (location == null)
                {
                    return new ApiResponse().SetNotFound("Can not found location id: " + id);
                }
                await _unitOfWork.Locations.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk("Deleted");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> UpdateLocationByIdAsync(LocationUpdateRequest locationUpdateRequest)
        {
            var response = new ApiResponse();
            try
            {
                var location = await _unitOfWork.Locations.GetAsync(x => x.Id == locationUpdateRequest.Id);
                if (location == null)
                {
                    return new ApiResponse().SetNotFound("Can not found location id: " + locationUpdateRequest.Id);
                }
                location.City = locationUpdateRequest.City;
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk("Update Success");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }
    }
}
