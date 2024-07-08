using Application.Interface;
using Application.Request.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersByUserName(string userName = null)
        {
            var result = await _service.GetUsersByUserName(userName);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(UpdateUserRequest request)
        {
            var result = await _service.UpdateUserAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getProfile")]
        public async Task<IActionResult> GetUserProfileAsync(int id)
        {
            var result = await _service.GetUserProfileAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("CampaginJob")]
        public async Task<IActionResult> GetInternInCampaginJobAsync(int campaignId, int jobId)
        {
            var result = await _service.GetInternInCampaginJobAsync(campaignId, jobId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("CampaginJob")]
        public async Task<IActionResult> AddUserToCampaginJobAsync(UserCampaignJobRequest request)
        {
            var result = await _service.AddUserToCampaginJobAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
