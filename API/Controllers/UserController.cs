using Application.Interface;
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
        public async Task<IActionResult> GetUsersByUserName(string userName = null)
        {
            var result = await _service.GetUsersByUserName(userName);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        

    }
}
