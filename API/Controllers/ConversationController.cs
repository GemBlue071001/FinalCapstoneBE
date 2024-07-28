using Application.Interface;
using Application.Request.Assessment;
using Application.Request.Conversation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversationController : ControllerBase
    {
        private IConversationService _service;
        public ConversationController(IConversationService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddConversation(ConversationRequest request)
        {
            var result = await _service.AddConversation(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssessment()
        {
            var result = await _service.GetAllConversation();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPost("User")]
        public async Task<IActionResult> AddUserToConversationAsync(ConversationUserRequest request)
        {
            var result = await _service.AddUserToConversationAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateConversationAsync(ConversationUpdateRequest request)
        {
            var result = await _service.UpdateConversationAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("remove-user")]
        public async Task<IActionResult> DeleteUserFromConversation(int conversationId, int userId)
        {
            var result = await _service.RemoveUserFromConversation(conversationId, userId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

    }
}
