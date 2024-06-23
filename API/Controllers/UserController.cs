using Application.Interface;
using Application.Request.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersByUserName(string userName=null)
        {
            var result = await _service.GetUsersByUserName(userName);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(UpdateUserRequest request)
        {
            var result = await _service.UpdateUserAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
