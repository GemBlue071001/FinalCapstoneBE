using Application.Interface;
using Application.Request.User;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "JobSeeker")]
        [Route("JobPostActivity")]
        [HttpGet]
        public async Task<IActionResult> GetJobActivities()
        {
            var result = await _service.GetUserJobPostActivity();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("Profile/{id}")]
        public async Task<IActionResult> GetUserProfileDetail(int id)
        {
            var result = await _service.GetUserProfileAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(UpdateUserRequest request)
        {
            var result = await _service.UpdateUserAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize(Roles = "Employer")]
        [Route("Company")]
        [HttpPost]
        public async Task<IActionResult> AddEmployerToCompany(AddEmployerToCompanyRequest request)
        {
            var result = await _service.AddEmployerToCompany(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [Route("SkilSet")]
        [HttpPost]
        public async Task<IActionResult> AddSkillSetToUser(SeekerSkillSetRequest request)
        {
            var result = await _service.AddSkillSetToUser(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Route("SkilSet")]
        [HttpDelete]
        public async Task<IActionResult> RemoveSkillSetToUser(SeekerSkillSetRequest request)
        {
            var result = await _service.RemoveSkillSetToUser(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("JobSeekerRole")]
        public async Task<IActionResult> GetAllJobSeekerRoleAsync([FromQuery] int jobPostId, [FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 5)
        {
            var result = await _service.GetAllJobSeekerRoleAsync(pageIndex, pageSize,jobPostId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

    }
}
