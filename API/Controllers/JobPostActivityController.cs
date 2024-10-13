using Application.Interface;
using Application.Request.EducationDetail;
using Application.Request.JobPostActivity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostActivityController : ControllerBase
    {
        private IJobPostActivityService _service;
        private readonly IEventTriggerService _eventTriggerService;

        public JobPostActivityController(IJobPostActivityService service, IEventTriggerService eventTriggerService)
        {
            _service = service;
            _eventTriggerService = eventTriggerService;
        }

        [Authorize(Roles = "JobSeeker")]
        [HttpPost]
        public async Task<IActionResult> AddNewJobPostActivityAsync(JobPostActivityRequest request)
        {
            var response = await _service.AddNewJobPostActivityAsync(request);
            if (response.IsSuccess && response.Result is not null)
            {
                await _eventTriggerService.SendMessageToUser(response.Result.ToString() ?? "0", "Application Applied");
            }
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize(Roles = "Employer")]
        [HttpPut]
        public async Task<IActionResult> UpdateJobPostActivityAsync(JobPostActivityUpdateRequest request)
        {
            var response = await _service.UpdateJobPostActivityAsync(request);
            if (response.IsSuccess && response.Result is not null ) 
            {
                await _eventTriggerService.SendMessageToUser(response.Result.ToString() ?? "0", "Application Status Updated");
            }
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
