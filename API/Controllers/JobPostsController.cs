using Application.Interface;
using Application.Request.JobPost;
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

        [HttpPost("SkillSet")]
        public async Task<IActionResult> AddSkillSetToJobPost(JobPostSkillSetRequest request)
        {
            var resposne = await _service.AddSkillSetToJobPost(request);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [HttpGet("Id/{id}/Seekers")]
        public async Task<IActionResult> GetJobSeekersAsync(int id)
        {
            var resposne = await _service.GetJobSeekerByJobPost(id);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }
        [HttpGet("Id/{id}")]
        public async Task<IActionResult> GetJobPostById(int id)
        {
            var resposne = await _service.GetJobPostById(id);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchJobPost([FromBody] SearchJobPostRequest request)
        {
            var response = await _service.SearchJobs(request);
            return Ok(response);
        }
    }
}
