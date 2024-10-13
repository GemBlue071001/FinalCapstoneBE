using Application.Request.FollowCompany;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IFollowCompanyService
    {
        Task<ApiResponse> AddFollowCompanyAsync(FollowCompanyRequest followCompanyRequest);
        Task<ApiResponse> GetFollowCompanyAsync();
        Task<ApiResponse> DeleteFollowCompanyById(int id);
    }
}
