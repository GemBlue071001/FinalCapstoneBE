using Application.Interface;
using Application.Request.AssessmentSubmition;
using Application.Request.Job;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentSubmitionController : ControllerBase
    {
        public IAssessmentSubmitionService _service;

        public AssessmentSubmitionController(IAssessmentSubmitionService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddSubmitionAsync(SubmitionRequest request)
        {
            var result = await _service.AddSubmitionAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSubmitionByAsseessmentAsync(int assessmentId)
        {
            var result = await _service.GetAllSubmitionByAsseessmentAsync(assessmentId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveSubmitionAsync(int id)
        {
            var result = await _service.RemoveSubmitionAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

    }
}
