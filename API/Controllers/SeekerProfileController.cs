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
        public async Task<IActionResult> AddNewSeekerProfileController(SeekerProfileRequest request)
        {
            var resposne = await _service.AddNewSeekerProfilesAsync(request);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }
    }
}
