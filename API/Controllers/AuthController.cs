using Application.Interface;
using Application.Request;
using Application.Request.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public IAuthService _service;
        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest user)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(new
                {
                    statusCode = 400,
                    isSuccess = false,
                    errorMessage = string.Join("; ", errors),
                    result = (object)null
                });
            }

            var result = await _service.RegisterAsync(user);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("Verification")]
        public async Task<IActionResult> Verification(VerificationEmailRequest request)
        {

            var result = await _service.VerifyEmailAsync(request.UserId, request.VerificationCode);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut("Email")]
        public async Task<IActionResult> UpdateEmailVerification(UpdateEmailVerification request)
        {

            var result = await _service.UpdateEmailAsync(request.UserId, request.NewEmail);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPost("UpdatePassword")]
        public async Task<IActionResult> UpdatePassword(ChangePasswordRequest request)
        {
            var result = await _service.ChangePassword(request.CurrentPassword, request.NewPassword , request.ConfirmPassword);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("test")]
        public async Task<IActionResult> Test(UserRegisterRequest user)
        {
            return Ok("result");
            
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest user)
        {
            var result = await _service.LoginAsync(user);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
