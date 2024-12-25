using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Request.Service;
namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _service;

        public ServiceController(IServiceService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewServiceAsync(ServiceRequest request)
        {
            var response = await _service.AddNewServiceAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetServiceListAsync()
        {
            var response = await _service.GetServiceListAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetServiceByIdAsync(int Id)
        {
            var response = await _service.GetServiceByIdAsync(Id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteServiceAsync(int Id)
        {
            var response = await _service.DeleteServiceAsync(Id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateServiceAsync(int Id, ServiceRequest request)
        {
            var response = await _service.UpdateServiceAsync(Id, request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
