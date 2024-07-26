using Application.Interface;
using Application.Request.Conversation;
using Application.Request.Message;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IMessageService _service;
        public MessageController(IMessageService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddConversation(MessageRequest request)
        {
            var result = await _service.AddMessages(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
