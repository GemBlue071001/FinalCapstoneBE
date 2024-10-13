using Application.Interface;
using Application.Request.ExperienceDetail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceDetailController : ControllerBase
    {
        private readonly IExperienceDetailService _service;

        public ExperienceDetailController(IExperienceDetailService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetExperienceListAsync()
        {
            var resposne = await _service.GetExperienceDetailListAsync();
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddExperienceDetailAsync(ExperienceDetailRequest request)
        {
            var response = await _service.AddExperienceDetailAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateExperienceDetailAsync(UpdateExperienceDetailRequest request)
        {
            var userClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (userClaim is null)
            {
                return Unauthorized();
            }

            bool isUserIdValid = int.TryParse(userClaim.Value, out int userId);

            if (!isUserIdValid)
            {
                return BadRequest("Invalid User Id. Must be integer.");
            }

            var response = await _service.UpdateExperienceDetailAsync(userId, request);

            if (response is null || !response.IsSuccess)
            {
                return BadRequest("Unhandle exception occured");
            }

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletedExperienceDetailByIdAsync(int id)
        {
            var response = await _service.DeletedExperienceDetailByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
