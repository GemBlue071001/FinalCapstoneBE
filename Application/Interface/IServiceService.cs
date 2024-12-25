using Application.Request.Service;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IServiceService
    {
        Task<ApiResponse> AddNewServiceAsync(ServiceRequest request);

        Task<ApiResponse> GetServiceListAsync();

        Task<ApiResponse> GetServiceByIdAsync(int Id);

        Task<ApiResponse> DeleteServiceAsync(int Id);

        Task<ApiResponse> UpdateServiceAsync(int Id, ServiceRequest? request);
    }
}
