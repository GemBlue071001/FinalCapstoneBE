using Application.Request.JobPostActivity;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IJobPostActivityService
    {
        Task<ApiResponse> AddNewJobPostActivityAsync(JobPostActivityRequest jobPostActivityRequest);
    }
}
