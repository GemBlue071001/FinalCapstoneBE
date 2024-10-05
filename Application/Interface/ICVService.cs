using Application.Request.CV;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICVService
    {
        Task<ApiResponse> AddNewCVAsync(CVRequest request);
        Task<ApiResponse> GetCVListAsync();
    }
}
