using Application.Interface;
using Application.Request;
using Application.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AuthService: IAuthService
    {
        private IUnitOfWork _unitOfWork;
        public AuthService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> RegisterAsync(UserRegisterRequest user)
        {
            ApiResponse response = new ApiResponse();

            var checkPassword = CheckUserPassword(user);
            if (!checkPassword)
            {
                response.SetBadRequest(message: "Confirm password is wrong !");
                return response;
            }
            var pass = CreatePasswordHash(user.Password);
            UserAccount _user = new UserAccount()
            {
                UserName = user.UserName,
                PasswordHash = pass.PasswordHash,
                PasswordSalt = pass.PasswordSalt,
                Email = user.Email,
                FirstName = user.FistName,
                LastName = user.LastName,
            };
            await _unitOfWork.UserAccounts.AddAsync(_user);
            await _unitOfWork.SaveChangeAsync();

            response.SetOk("Resgister Complete");
            return response;
        }

        public bool CheckUserPassword(UserRegisterRequest user)
        {
            if (user.Password is null) return (false);
            return (user.Password.Equals(user.ConfirmPassword));
        }

        private PasswordDTO CreatePasswordHash(string password)
        {
            PasswordDTO pass = new PasswordDTO();
            using (var hmac = new HMACSHA512())
            {
                pass.PasswordSalt = hmac.Key;
                pass.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
            return pass;
        }
    }
    public class PasswordDTO
    {
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt { get; set; } = new byte[32];
    }
}
