using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public ILocationService _service { get; set; }
        public LocationController(ILocationService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllJobTypeAsync()
        {
            var response = await _service.GetAllLocationAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
