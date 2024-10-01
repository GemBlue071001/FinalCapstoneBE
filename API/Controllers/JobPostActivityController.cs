using Application.Interface;
using Application.Request.EducationDetail;
using Application.Request.JobPostActivity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostActivityController : ControllerBase
    {
        private IJobPostActivityService _service;

        public JobPostActivityController(IJobPostActivityService service)
        {
            _service = service;
        }

        [Authorize(Roles = "JobSeeker")]
        [HttpPost]
        public async Task<IActionResult> AddNewJobPostActivityAsync(JobPostActivityRequest request)
        {
            var response = await _service.AddNewJobPostActivityAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize(Roles = "Employer")]
        [HttpPut]
        public async Task<IActionResult> UpdateJobPostActivityAsync(JobPostActivityUpdateRequest request)
        {
            var response = await _service.UpdateJobPostActivityAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
