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
        private IEmailService _emailService;
        public AuthService(IUnitOfWork unitOfWork, AppSettings appSettings, IClaimService claimService, IEmailService emailService)
        {
            _unitOfWork = unitOfWork;
            _appSettings = appSettings;
            _claimService = claimService;
            _emailService = emailService;
        }

        public async Task<ApiResponse> RegisterAsync(UserRegisterRequest userRequest)
        {
            ApiResponse response = new ApiResponse();

            var checkPassword = CheckUserPassword(userRequest);
            if (!checkPassword)
            {
                response.SetBadRequest(message: "Confirm password is wrong !");
                return response;
            }

            // Create password hash and save user details
            var pass = CreatePasswordHash(userRequest.Password);
            UserAccount user = new UserAccount()
            {
                UserName = userRequest.UserName,
                PasswordHash = pass.PasswordHash,
                PasswordSalt = pass.PasswordSalt,
                Email = userRequest.Email,
                FirstName = userRequest.FistName,
                LastName = userRequest.LastName,
                Role = userRequest.Role,
                IsEmailVerified = false // Initially, email is not verified
            };

            await _unitOfWork.UserAccounts.AddAsync(user);
            await _unitOfWork.SaveChangeAsync();

            // Generate verification code
            var verificationCode = GenerateVerificationCode(); // Method to generate the code
            var emailVerification = new EmailVerification
            {
                UserId = user.Id,
                VerificationCode = verificationCode,
                ExpiresAt = DateTime.Now.AddMinutes(30), // Code valid for 30 minutes
                IsUsed = false
            };

            // Save verification code to the database
            await _unitOfWork.EmailVerifications.AddAsync(emailVerification);
            await _unitOfWork.SaveChangeAsync();

            // Prepare email content
            string emailContent = $"Dear {user.FirstName},<br/>Please use the following verification code to validate your email: <strong>{verificationCode}</strong>.<br/>The code will expire in 30 minutes.";

            // Send validation email
            var emailResponse = await _emailService.SendValidationEmail(user.Email, emailContent);
            if (!emailResponse.IsSuccess)
            {
                response.SetBadRequest("Failed to send verification email.");
                return response;
            }

            response.SetOk("Register complete. Please check your email for the verification code.");
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

        private string GenerateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // Generate a 6-digit code
        }
    }
    public class PasswordDTO
    {
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt { get; set; } = new byte[32];
    }
}
