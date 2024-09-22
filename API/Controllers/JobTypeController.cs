using Application.Interface;
using Application.Request.JobType;
using Application.Request.SeekerProfile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTypeController : ControllerBase
    {
        public IJobTypeService _service;

        public JobTypeController(IJobTypeService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewJobTypeAsync(JobTypeRequest request)
        {
            var response = await _service.AddNewJobTypeAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllJobTypeAsync()
        {
            var response = await _service.GetAllJobTypeAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletedJobTypeByIdAsync(int id)
        {
            var response = await _service.DeletedJobTypeByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
