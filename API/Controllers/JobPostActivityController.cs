using Application.Interface;
using Application.Request.JobPost;
using Application.Request.JobPostActivity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostActivityController : ControllerBase
    {
        public IJobPostActivityService _service;

        public JobPostActivityController(IJobPostActivityService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewJobPostActivityAsync(JobPostActivityRequest request)
        {
            var resposne = await _service.AddNewJobPostActivityAsync(request);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }
    }
}
