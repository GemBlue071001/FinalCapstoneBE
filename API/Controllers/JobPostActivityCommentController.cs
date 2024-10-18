using Application.Interface;
using Application.Request.JobLocation;
using Application.Request.JobPostActivityComment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostActivityCommentController : ControllerBase
    {
        public IJobPostActivityCommentService _service { get; set; }
        public JobPostActivityCommentController(IJobPostActivityCommentService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewJobLocationAsync(JobPostActivityCommentRequest jobPostActivityCommentRequest)
        {
            var response = await _service.AddNewJobPostActivityCommentAsync(jobPostActivityCommentRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSeekerProfileAsync()
        {
            var response = await _service.GetAllJobPostActivityCommentAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteJobPostActivityCommentByIdAsync(int id)
        {
            var response = await _service.DeleteJobPostActivityCommentByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet("Id/{id}/JobPostActivity")]
        public async Task<IActionResult> GetAllJobPostActivityCommentByJobPostActivityIdAsync(int id)
        {
            var response = await _service.GetAllJobPostActivityCommentByJobPostActivityIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

    }
}
