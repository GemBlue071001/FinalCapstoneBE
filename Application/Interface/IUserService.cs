using Application.Request.User;
using Application.Response;

namespace Application.Interface
{
    public interface IUserService
    {
        
       
        Task<ApiResponse> UpdateUserAsync(UpdateUserRequest request);
       
    }
}
