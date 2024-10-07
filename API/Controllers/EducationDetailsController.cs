using Application.Interface;
using Application.Request.EducationDetail;
using Application.Request.JobLocation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
