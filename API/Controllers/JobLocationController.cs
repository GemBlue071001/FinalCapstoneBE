using Application.Interface;
using Application.Request.JobLocation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobLocationController : ControllerBase
    {
        public IJobLocationService _service { get; set; }
        public JobLocationController(IJobLocationService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewJobLocationAsync(JobLocationRequest jobLocationRequest)
        {
            var response = await _service.AddNewJobLocationAsync(jobLocationRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSeekerProfileAsync()
        {
            var response = await _service.GetAllJobLocationAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletedSeekerProfileByIdAsync(int id)
        {
            var response = await _service.DeleteJobLocationByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    
    }
}
