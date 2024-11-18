using Application.Interface;
using Application.Request.FollowCompany;
using Application.Request.FollowJob;
using Application.Request.JobLocation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowJobPostController : ControllerBase
    {
        private readonly IFollowJobPostService _service;
        public FollowJobPostController(IFollowJobPostService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddFollowJobPostAsync(FollowJobRequest followJobRequest)
        {
            var response = await _service.AddFollowJobPostAsync(followJobRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetFollowJobPostAsync()
        {
            var response = await _service.GetFollowJobPostAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeletedSeekerProfileByIdAsync(int id)
        {
            var response = await _service.DeleteFollowJobPostById(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
