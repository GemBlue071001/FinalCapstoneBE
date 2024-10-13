using Application.Interface;
using Application.Request;
using Application.Response;
using DocumentFormat.OpenXml.Spreadsheet;
using Domain;
using Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Application.Services
{
    public class AuthService : IAuthService
    {
        private IUnitOfWork _unitOfWork;
        private AppSettings _appSettings;
        private IClaimService _claimService;
        public AuthService(IUnitOfWork unitOfWork, AppSettings appSettings, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _appSettings = appSettings;
            _claimService = claimService;
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
                Role = user.Role,
            };
            await _unitOfWork.UserAccounts.AddAsync(_user);
            await _unitOfWork.SaveChangeAsync();

            response.SetOk("Resgister Complete");
            return response;
        }

        public async Task<ApiResponse> LoginAsync(LoginRequest account)
        {
            ApiResponse response = new ApiResponse();
            var _account = await _unitOfWork.UserAccounts.GetAsync(u => u.UserName == account.UserName);
            if (_account == null || !VerifyPasswordHash(account.Password, _account.PasswordHash, _account.PasswordSalt))
            {
                response.SetBadRequest(message: "Username or password is wrong");
                return response;
            }

            response.SetOk(CreateToken(_account));
            return response;
        }

        private string CreateToken(UserAccount user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim("Role", user.Role.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim( "name" , user.UserName),
                new Claim("UserId", user.Id.ToString()),
            };

            if (user.CompanyId != null)
            {
                claims.Add(new Claim("CompanyId", user.CompanyId?.ToString() ?? string.Empty));
            }
            else
            {
                claims.Add(new Claim("CompanyId", "null"));
            }

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                 _appSettings!.SecretToken.Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }

        public async Task<ApiResponse> ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            var userClaim = _claimService.GetUserClaim();
            var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == userClaim.Id);

            if (user == null)
            {
                return new ApiResponse().SetBadRequest("Can't find User !");
            }

            if (!VerifyPasswordHash(currentPassword, user.PasswordHash, user.PasswordSalt))
            {
                return new ApiResponse().SetBadRequest("Current password is incorrect !");
            }

            if (newPassword != confirmPassword)
            {
                return new ApiResponse().SetBadRequest("New password and confirmation do not match !"); // New password and confirmation do not match
            }
            
            var passwordData = CreatePasswordHash(newPassword);
            user.PasswordHash = passwordData.PasswordHash;
            user.PasswordSalt = passwordData.PasswordSalt;
            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetOk(" Password change was successful !"); // Password change was successful
        }



        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
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
