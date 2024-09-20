using Application.Interface;
using Application.Request.SeekerProfile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeekerProfileController : ControllerBase
    {
        public ISeekerProfileService _service;

        public SeekerProfileController(ISeekerProfileService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewSeekerProfileAsync(SeekerProfileRequest request)
        {
            var resposne = await _service.AddNewSeekerProfilesAsync(request);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSeekerProfileAsync()
        {
            var response = await _service.GetAllSeekerProfileAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletedSeekerProfileByIdAsync(int id)
        {
            var response = await _service.DeletedSeekerProfileByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
