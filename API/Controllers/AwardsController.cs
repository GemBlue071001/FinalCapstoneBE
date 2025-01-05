using Application.Interface;
using Application.Request.Award;
using Application.Request.EducationDetail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwardsController : ControllerBase
    {
        private IAwardService _service;

        public AwardsController(IAwardService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewAwardAsync(AddAwardRequest request)
        {
            var response = await _service.AddAwardAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }


        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateNewAwardAsync(UpdateAwardRequest request)
        {
            var response = await _service.UpdateAwardAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteAwardAsync(int id)
        {
            var response = await _service.RemoveAwardAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}

