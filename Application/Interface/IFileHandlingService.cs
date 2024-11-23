using Application.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IFileHandlingService
    {
        Task<ApiResponse> ImportExcel(IFormFile file);
        Task<ApiResponse> UploadCVToAnalyze(string firebasePdfUrl, int jobId,int cvId, int userId);
    }
}
