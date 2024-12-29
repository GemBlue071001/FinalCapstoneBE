using Application.Interface;
using Application.Response;
using Application.Response.JobType;
using Application.Response.Location;
using AutoMapper;
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
    }
}
