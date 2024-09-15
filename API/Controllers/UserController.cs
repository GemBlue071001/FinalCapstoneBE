using Application.Interface;
using Application.Request.User;
using Microsoft.AspNetCore.Authorization;
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

       

        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(UpdateUserRequest request)
        {
            var result = await _service.UpdateUserAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        
    }
}
