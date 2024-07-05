using Application.Interface;
using Application.Request.Meeting;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        private readonly IMeetingService _meetingsService;

        public MeetingsController(IMeetingService meetingsService)
        {
            _meetingsService = meetingsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMeetings() 
        {
            var meetings = await _meetingsService.GetAllMeeting();
            return Ok(meetings);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetMeeting([FromQuery] int id)
        {
            var response = await _meetingsService.GetMeeting(id);
            return response != null ? Ok(response) : NotFound(response);
        }

        [HttpPost()]
        public async Task<IActionResult> AddMeeting([FromBody] MeetingRequest meeting)
        {
            var response = await _meetingsService.AddMeeting(meeting);
            return response != null ? Ok(response) : NotFound(response);
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateMeeting([FromBody] MeetingUpdateRequest meeting)
        {
            var response = await _meetingsService.UpdateMeeting(meeting);
            return response.IsSuccess? Ok(response) : BadRequest(response);
        }

        [HttpDelete()]
        public async Task<IActionResult> RemoveMeeting([FromQuery] int meetingId)
        {
            var response = await _meetingsService.RemoveMeeting(meetingId);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpPost("add-user")]
        public async Task<IActionResult> AddUserToMeeting([FromQuery] int meetingId, [FromQuery] int userId)
        {
            var response = await _meetingsService.AddUserToMeeting(meetingId, userId);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpDelete("remove-user")]
        public async Task<IActionResult> RemoveUserFromMeeting([FromQuery] int meetingId, [FromQuery] int userId)
        {
            var result = await _meetingsService.RemoveUserFromMeeting(meetingId, userId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

    }
}
