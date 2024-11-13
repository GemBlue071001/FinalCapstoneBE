using Application.Constants.SignalRHub;
using Application.Interface;
using Application.Request.JobPostActivity;
using Application.Response.JobPostActivity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostActivityController : ControllerBase
    {
        private IJobPostActivityService _service;
        private readonly IEventTriggerService _eventTriggerService;
        private readonly IUserService _userService;

        public JobPostActivityController(IJobPostActivityService service, IEventTriggerService eventTriggerService, IUserService userService)
        {
            _service = service;
            _eventTriggerService = eventTriggerService;
            _userService = userService;
        }

        [Authorize(Roles = "JobSeeker, Employer")]
        [HttpPost]
        public async Task<IActionResult> AddNewJobPostActivityAsync(JobPostActivityRequest request)
        {
            var response = await _service.AddNewJobPostActivityAsync(request);
            if (response.IsSuccess && response.Result is not null)
            {
                var template = response.Result as JobPostActivityMessageTemplate;
                if (template != null)
                {
                    await _eventTriggerService.TriggerSendMessageToGroupEvent($"{template.CompanyId}", SignalMessage.GET_NOTIFY_EMPLOYER);
                }
            }
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize(Roles = "JobSeeker, Employer")]
        [HttpGet("notifications")]
        public async Task<IActionResult> GetNotifications()
        {
            var userClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (userClaim is null)
            {
                return Unauthorized();
            }

            bool isUserIdValid = int.TryParse(userClaim.Value, out int userId);

            if (!isUserIdValid)
            {
                return BadRequest("Invalid User Id. Must be integer.");
            }

            var response = await _service.GetNotifications(userId, false);
            return Ok(response);
        } 

        [Authorize(Roles = "Employer")]
        [HttpPut]
        public async Task<IActionResult> UpdateJobPostActivityAsync(JobPostActivityUpdateRequest request)
        {
            var response = await _service.UpdateJobPostActivityAsync(request);
            if (response.IsSuccess && response.Result is not null ) 
            {
                await _eventTriggerService.SendMessageToUser($"{response.Result}", SignalMessage.APPLICATION_STATUS_UPDATE);
            }
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize(Roles = "JobSeeker, Employer")]
        [HttpPut("notification/read")]
        public async Task<IActionResult> ReadNotification([FromQuery] int notificationId)
        {
            var isReadSuccess = await _service.ReadNotification(notificationId);
            return  isReadSuccess ? Ok() : NotFound();
        }

        [Authorize(Roles = "JobSeeker, Employer")]
        [HttpPut("notification/read-all")]
        public async Task<IActionResult> ReadAllNotification()
        {
            var userClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (userClaim is null)
            {
                return Unauthorized();
            }

            bool isUserIdValid = int.TryParse(userClaim.Value, out int userId);

            if (!isUserIdValid)
            {
                return BadRequest("Invalid User Id. Must be integer.");
            }

            await _service.ReadAllNotification(userId);
            return Ok();
        }

        [HttpGet("top100")]
        public async Task<IActionResult> GetTop100()
        {
            var top100 = await _service.GetTop100();
            return Ok(top100.Result);
        }
    }
}
