using Application.Request;
using Application.Request.Company;
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
        Task<ApiResponse> LoginAsync(LoginRequest account);
        Task<ApiResponse> RegisterAsync(UserRegisterRequest user);
        Task<ApiResponse> ChangePassword(string currentPassword, string newPassword, string confirmPassword);
        Task<ApiResponse> VerifyEmailAsync(int userId, string verificationCode);
        Task<ApiResponse> UpdateEmailAsync(int userId, string newEmail);
        Task<ApiResponse> GenerateCodeToAddCompanyAsync(CompanyRegisterRequest request);
        Task<ApiResponse> VerifyEmailForCompanyAsync(int companyId, int employeeId, string verificationCode);
    }
}
