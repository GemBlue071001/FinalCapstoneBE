using Application.Request.Location;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ILocationService
    {
        Task<ApiResponse> AddNewLocationAsync(LocationRequest locationRequest);
        Task<ApiResponse> GetAllLocationAsync();
        Task<ApiResponse> GetLocationByIdAsync(int locationId);
        Task<ApiResponse> DeletedLocationByIdAsync(int id);
        Task<ApiResponse> UpdateLocationByIdAsync(LocationUpdateRequest locationUpdateRequest);
    }
}
