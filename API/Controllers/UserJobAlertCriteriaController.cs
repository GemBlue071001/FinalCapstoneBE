using Application.Interface;
using Application.Request.UserJobAlertCriteria;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserJobAlertCriteriaController : ControllerBase
    {
        private readonly IUserJobAlertCriteriaService _service;

        public UserJobAlertCriteriaController(IUserJobAlertCriteriaService service)
        {
            _service = service;
        }

        // Add a new job alert criteria
        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewAlertCriteriaAsync(UserJobAlertCriteriaRequest request)
        {
            var response = await _service.AddNewAlertCriteriaAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet]
        [Route("matching-criterial")]
        public async Task<IActionResult> Match()
        {
            var response = await _service.ProcessMatchingJob();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        // Get all job alert criteria for a specific user
        //[Authorize]
        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetAllAlertCriteriaAsync(int userId)
        {
            var response = await _service.GetAllAlertCriteriaAsync(userId);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        // Delete a job alert criteria by ID
        //[Authorize]
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAlertCriteriaByIdAsync(int id)
        {
            var response = await _service.DeleteAlertCriteriaByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
