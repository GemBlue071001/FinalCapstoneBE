using Application.Request.User;
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
        Task<ApiResponse> UpdateUserAsync(UpdateUserRequest request);
        Task<ApiResponse> GetInternInCampaginJobAsync(int campaginId, int jobId);
        Task<ApiResponse> AddUserToCampaginJobAsync(UserCampaignJobRequest request);
    }
}
