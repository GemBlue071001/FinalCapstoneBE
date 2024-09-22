using Application.Request.JobLocation;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IJobLocationService
    {
        Task<ApiResponse> AddNewJobLocationAsync(JobLocationRequest jobLocationRequest);
        Task<ApiResponse> GetAllJobLocationAsync();
        Task<ApiResponse> DeleteJobLocationByIdAsync(int id);
    }
}
