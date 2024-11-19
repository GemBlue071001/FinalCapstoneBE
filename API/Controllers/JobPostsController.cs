using Application.Interface;
using Application.Request.JobPost;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "Employer, Manager, Admin")]
        [HttpPut("approve")]
        public async Task<IActionResult> ApproveJobPost([FromQuery] int id)
        {
            var resposne = await _service.UpdateStatusJobPost(id, JobPostReviewStatus.Accepted);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [Authorize(Roles = "Employer, Manager, Admin")]
        [HttpPut("reject")]
        public async Task<IActionResult> RejectJobPost(int id)
        {
            var resposne = await _service.UpdateStatusJobPost(id, JobPostReviewStatus.Rejected);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [Authorize(Roles = "Employer")]
        [HttpPut("update")]
        public async Task<IActionResult> UpdateJobPost([FromQuery] int id, [FromBody] JobPostRequest request)
        {
            var resposne = await _service.UpdateJobPost(id, request);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }

        [HttpGet("accept")]
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

        [HttpPost("search")]
        public async Task<IActionResult> SearchJobPost([FromBody] SearchJobPostRequest request)
        {
            var response = await _service.SearchJobs(request);
            return Ok(response);
        }
        [HttpGet("pending")]
        public async Task<IActionResult> GetAllJobPostPending()
        {
            var resposne = await _service.GetAllJobPostPending();
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }
        [HttpPost("seeds")]
        public async Task<IActionResult> SeedsData()
        {
            var response = await _service.SeedsData();
            return Ok(response);
        }
        [HttpPost("SearchJobsQuery")]
        public async Task<IActionResult> SearchJobIdsAsync(string query)
        {
            var response = await _service.SearchJobIdsAsync(query);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
