using Application.Request.Job;
using Application.Request.KPI;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IKPIService
    {
        Task<ApiResponse> AddKPI(KPIRequest request);
        Task<ApiResponse> AddKPIToTranningProgram(ProgramKPIRequest request);
        Task<ApiResponse> GetAllKPI();
        Task<ApiResponse> DeleteKPI(int id);
        Task<ApiResponse> UpdateKPIAsync(UpdateKPIRequest request);
    }
}
