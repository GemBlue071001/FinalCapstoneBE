using Application.Interface;
using Application.Request.ExperienceDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public async Task<IActionResult> GetExperienceListAsync()
        {
            var resposne = await _service.GetExperienceDetailListAsync();
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [HttpPost]
        public async Task<IActionResult> AddExperienceDetailAsync(ExperienceDetailRequest request)
        {
            var response = await _service.AddExperienceDetailAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
