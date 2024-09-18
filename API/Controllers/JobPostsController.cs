using Application.Interface;
using Application.Request.JobPost;
using Application.Request.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostsController : ControllerBase
    {
        public IJobPostService _service;

        public JobPostsController(IJobPostService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewJobPostAsync(JobPostRequest request)
        {
            var resposne = await _service.AddNewJobPostAsync(request);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [HttpGet]
        public async Task<IActionResult> GetJobPostAsync()
        {
            var resposne = await _service.GetJobPostAsync();
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }
    }
}
