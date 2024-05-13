using Application.Request;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IAuthService
    {
        //Task<ApiResponse> LoginAsync(LoginRequest account);
        Task<ApiResponse> RegisterAsync(UserRegisterRequest user);
    }
}
