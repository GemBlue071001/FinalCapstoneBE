using Application.Interface;
using Application.Request.JobType;
using Application.Request.Location;
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
        [HttpPost]
        public async Task<IActionResult> AddNewLocationAsync(LocationRequest request)
        {
            var response = await _service.AddNewLocationAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllJobTypeAsync()
        {
            var response = await _service.GetAllLocationAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet("Id/{id}")]
        public async Task<IActionResult> GetLocationByIdAsync(int id)
        {
            var response = await _service.GetLocationByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletedLocationByIdAsync(int id)
        {
            var response = await _service.DeletedLocationByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLocationByIdAsync(LocationUpdateRequest locationUpdateRequest)
        {
            var response = await _service.UpdateLocationByIdAsync(locationUpdateRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
