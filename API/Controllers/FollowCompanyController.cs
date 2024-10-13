using Application.Interface;
using Application.Request.CV;
using Application.Request.FollowCompany;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowCompanyController : ControllerBase
    {
        private readonly IFollowCompanyService _service;

        public FollowCompanyController(IFollowCompanyService service)
        {
            _service = service;
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddFollowCompanyAsync(FollowCompanyRequest request)
        {
            var response = await _service.AddFollowCompanyAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetFollowCompanyAsync()
        {
            var response = await _service.GetFollowCompanyAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteFollowCompanyById(int id)
        {
            var response = await _service.DeleteFollowCompanyById(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
