using Application.Request.Job;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IJobService
    {
        Task<ApiResponse> AddJob(JobRequest request);
        Task<ApiResponse> GetAllJob();
        Task<ApiResponse> DeleteJob(int id);
        Task<ApiResponse> AddTrainingProgramToJobAsync(JobTrainingRequest request);
    }
}
