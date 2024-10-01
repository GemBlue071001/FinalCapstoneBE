using Application.Interface;
using Application.Request.EducationDetail;
using Application.Request.JobLocation;
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

        [HttpGet]
        public async Task<IActionResult> GetJobPostAsync()
        {
            var resposne = await _service.GetEducationDetailListAsync();
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewJobLocationAsync(EducationDetailRequest request)
        {
            var response = await _service.AddNewEducationDetailAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
