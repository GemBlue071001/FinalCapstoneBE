using Application.Interface;
using Application.Request.EducationDetail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationDetailsController : ControllerBase
    {
        private IEducationDetailsService _service;

        public EducationDetailsController(IEducationDetailsService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetEducationDetailListAsync()
        {
            var resposne = await _service.GetEducationDetailListAsync();
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewEducationDetailAsync(EducationDetailRequest request)
        {
            var response = await _service.AddNewEducationDetailAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateEducationDetail(UpdateEducationDetailRequest request)
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

            var response = await _service.UpdateEducationDetailAsync(userId, request);

            if (response is null)
            {
                return BadRequest("Unhandle exception occured");
            }

            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    {
                        return Ok(response);
                    }
                case System.Net.HttpStatusCode.NoContent:
                    {
                        return NoContent();
                    }
                case System.Net.HttpStatusCode.Conflict:
                    {
                        return Conflict(response.ErrorMessage);
                    }
                case System.Net.HttpStatusCode.NotFound:
                    {
                        return NotFound(response.ErrorMessage);
                    }
                default:
                    {
                        return BadRequest("Unhandle exception occured");
                    }
            }
        }
    }
}
