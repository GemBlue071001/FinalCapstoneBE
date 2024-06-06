using Application.Interface;
using Application.Request.Job;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        public IJobService _service;
        public JobController(IJobService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddJob(JobRequest request)
        {
            var result = await _service.AddJob(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJob()
        {
            var result = await _service.GetAllJob();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
