using Application.Interface;
using Application.Repositories;
using Application.Request.SkillSet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillSetController : ControllerBase
    {
        public ISkillSetService _service;

        public SkillSetController(ISkillSetService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewSkillSet(SkillSetRequest request)
        {
            var response = await _service.AddNewSkillSet(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSkillSetAsync()
        {
            var response = await _service.GetAllSkillSetAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletedSkillSetByIdAsync(int id)
        {
            var response = await _service.DeletedSkillSetByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
