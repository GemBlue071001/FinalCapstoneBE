using Application.Request.JobType;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IJobTypeService
    {
        Task<ApiResponse> AddNewJobTypeAsync(JobTypeRequest jobTypeRequest);
        Task<ApiResponse> GetAllJobTypeAsync();
        Task<ApiResponse> DeletedJobTypeByIdAsync(int id);
    }
}
