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
    }
}
