using Application.Interface;
using Application.Request.Assessment;
using Application.Request.Campaign;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentController : ControllerBase
    {
        private IAssessmentService _service;
        public AssessmentController(IAssessmentService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddAssessment(AssessmentRequest request)
        {
            var result = await _service.AddAssessment(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
