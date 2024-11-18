using Application.Interface;
using Application.Request;
using Application.Request.Company;
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
        public async Task ResetUserIdSequenceAsync()
        {
            // Lấy tên của sequence liên kết với cột Id trong bảng Users
            string sequenceSql = "SELECT pg_get_serial_sequence('\"Users\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Lấy giá trị Id lớn nhất hiện có trong bảng Users
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"Users\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Cập nhật sequence để bắt đầu từ giá trị lớn nhất hiện tại
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }


        public async Task<ApiResponse> RegisterAsync(UserRegisterRequest userRequest)
        {
            ApiResponse response = new ApiResponse();

            await ResetUserIdSequenceAsync();
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
                //UserName = userRequest.UserName,
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

            response.SetOk(user.Id);
            return response;
        }

        public async Task<ApiResponse> VerifyEmailAsync(int userId, string verificationCode)
        {
            ApiResponse response = new ApiResponse();

            // Retrieve the verification record
            var verificationRecord = await _unitOfWork.EmailVerifications
                .GetAsync(x => x.UserId == userId && x.VerificationCode == verificationCode && x.IsUsed == false);

            // Verification record not found or code already used
            if (verificationRecord == null)
            {
                response.SetBadRequest("Invalid or expired verification code.");
                return response;
            }

            // Check if the code has expired
            if (verificationRecord.ExpiresAt < DateTime.Now)
            {
                response.SetBadRequest("The verification code has expired.");
                return response;
            }

            // Mark the verification code as used
            verificationRecord.IsUsed = true;
            await _unitOfWork.SaveChangeAsync();

            // Mark the user's email as verified
            var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == userId);
            if (user == null)
            {
                response.SetBadRequest("User not found.");
                return response;
            }

            user.IsEmailVerified = true;
            await _unitOfWork.SaveChangeAsync();

            response.SetOk("Email verified successfully.");
            return response;
        }
        public async Task<ApiResponse> GenerateCodeToAddCompanyAsync(CompanyRegisterRequest request)
        {
            ApiResponse response = new ApiResponse();
            var claim = _claimService.GetUserClaim();

            // Generate verification code
            var verificationCode = GenerateVerificationCode(); // Method to generate the code
            var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Email!.Equals(request.Email));
            var emailVerification = new EmailVerification
            {
                UserId = user.Id,
                VerificationCode = verificationCode,
                ExpiresAt = DateTime.Now.AddMinutes(30), // Code valid for 30 minutes
                IsUsed = false,
                CompanyId = user.CompanyId,
            };


            // Save verification code to the database
            await _unitOfWork.EmailVerifications.AddAsync(emailVerification);
            await _unitOfWork.SaveChangeAsync();

            // Prepare email content
            string emailContent = $"Dear {request.Email},<br/>Please use the following verification code to validate your company: <strong>{verificationCode}</strong>.<br/>The code will expire in 30 minutes.";

            // Send validation email
            var emailResponse = await _emailService.SendValidationEmail(request.Email, emailContent);
            if (!emailResponse.IsSuccess)
            {
                response.SetBadRequest("Failed to send verification email.");
                return response;
            }

            response.SetOk(user.Id);
            return response;
        }
        public async Task<ApiResponse> VerifyEmailForCompanyAsync(int companyId, int employeeId, string verificationCode)
        {
            ApiResponse response = new ApiResponse();
            var claim = _claimService.GetUserClaim();
            // Retrieve the verification record
            var verificationRecord = await _unitOfWork.EmailVerifications
                .GetAsync(x => x.UserId == claim.Id && x.VerificationCode == verificationCode && x.IsUsed == false);

            // Verification record not found or code already used
            if (verificationRecord == null)
            {
                response.SetBadRequest("Invalid or expired verification code.");
                return response;
            }


            if (claim.Role != Role.Employer)
            {
                response.SetBadRequest("User be employer");
            }
            var company = await _unitOfWork.Companys.GetAsync(x => x.Id == companyId);
            if (company == null)
            {
                return response.SetBadRequest("Company not exist or user not in company");
            }
            var employee = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == employeeId);
            if (employee == null)
            {
                return response.SetBadRequest($"EmployeeId {employeeId} not exist");
            }
            if (employee.CompanyId != null)
            {
                return response.SetBadRequest("Employee already assign in company");
            }
            employee.CompanyId = companyId;
            await _unitOfWork.SaveChangeAsync();

            // Check if the code has expired
            if (verificationRecord.ExpiresAt < DateTime.Now)
            {
                response.SetBadRequest("The verification code has expired.");
                return response;
            }

            // Mark the verification code as used
            verificationRecord.IsUsed = true;
            await _unitOfWork.SaveChangeAsync();
            response.SetOk("Add success !");
            return response;
        }

        public async Task<ApiResponse> UpdateEmailAsync(int userId, string newEmail)
        {
            ApiResponse response = new ApiResponse();

            // Find the user
            var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == userId);
            if (user == null)
            {
                response.SetBadRequest("User not found.");
                return response;
            }

            // Check if the email is already verified
            if ((bool)user.IsEmailVerified!)
            {
                response.SetBadRequest("You have Verified already , Please Login to change your email !");
                return response;
            }

            // Update the user's email and reset verification status
            user.Email = newEmail;
            user.IsEmailVerified = false;  // Reset the verification flag

            // Generate a new verification code
            var verificationCode = GenerateVerificationCode();
            var emailVerification = new EmailVerification
            {
                UserId = user.Id,
                VerificationCode = verificationCode,
                ExpiresAt = DateTime.Now.AddMinutes(30), // New code valid for 30 minutes
                IsUsed = false
            };

            // Save the updated user and the new verification code
            await _unitOfWork.EmailVerifications.AddAsync(emailVerification);
            await _unitOfWork.SaveChangeAsync();

            // Send the new verification email
            string emailContent = $"Dear user {user.Email},<br/>Please use the following verification code to validate your email: <strong>{verificationCode}</strong>.<br/>The code will expire in 30 minutes.";
            var emailResponse = await _emailService.SendValidationEmail(user.Email, emailContent);

            if (!emailResponse.IsSuccess)
            {
                response.SetBadRequest("Failed to send verification email.");
                return response;
            }

            response.SetOk("Email updated successfully. Please check your new email for the verification code.");
            return response;
        }

        public async Task<ApiResponse> LoginAsync(LoginRequest request)
        {
            ApiResponse response = new ApiResponse();
            var account = await _unitOfWork.UserAccounts.GetAsync(u => u.Email == request.UserEmail);
            if (account == null || !VerifyPasswordHash(request.Password, account.PasswordHash, account.PasswordSalt))
            {
                response.SetBadRequest(message: "Email or password is wrong");
                return response;
            }

            if (account.IsEmailVerified == false)
            {
                response.SetBadRequest(message: "Please Verify your email");
                return response;
            }

            response.SetOk(CreateToken(account));
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
                new Claim( "Email" , user.Email!),
                new Claim("UserId", user.Id.ToString()),
                new Claim("IsPremium", user.IsPremium.ToString()),
                new Claim("PremiumExpireDate", user.PremiumExpireDate.ToString()),
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
