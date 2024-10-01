using Application.Request.BusinessStream;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IBusinessStreamService
    {
        Task<ApiResponse> AddNewBusinessStreamAsync(BusinessStreamRequest businessStreamRequest);
        Task<ApiResponse> GetAllBusinessStreamAsync();
    }
}
