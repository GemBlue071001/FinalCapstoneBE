using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IUserService
    {
        Task<ApiResponse> GetUsersByUserName(string userName);
        Task<ApiResponse> GetUserProfileAsync(int id);
        /*Task<ApiResponse> UpdateUserByID(int id);*/
                
    }
}
