using Application.Interface;
using Application.Request.Conversation;
using Application.Request.Job;
using Application.Request.Message;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
        public async Task<IActionResult> AddMessage(MessageRequest request)
        {
            var result = await _service.AddMessages(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMessageAsync()
        {
            var result = await _service.GetAllMessage();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveMessage(int id)
        {
            var response = await _service.RemoveMessageById(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        

    }
}
