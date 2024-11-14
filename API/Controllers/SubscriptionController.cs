using Application.Interface;
using Application.Request.Subscription;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {

        public ISubscriptionService _service;

        public SubscriptionController(ISubscriptionService service)
        {
            _service = service;
        }
        [HttpGet("{Userid}")]
        public async Task<IActionResult> GetAllSubscriptionAsync(int Userid)
        {
            var result = await _service.GetAllSubscriptionAsync(Userid);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
