using Application.Interface;
using Application.Request.Assessment;
using Application.Request.Campaign;
using Application.Request.Candidate;
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
            var result = await _service.AddAssessmentAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssessment(int programId = 0)
        {
            var result = await _service.GetAllAssessmentAsync(programId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAssessmentAsync(AssessmentUpdateRequest request)
        {
            var result = await _service.UpdateAssessmentAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAssessmentAsync(int id)
        {
            var result = await _service.DeleteAssessmentAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut("Program")]
        public async Task<IActionResult> AddAssessmentToProgramAsync(ProgramAssessmentRequest request)
        {
            var result = await _service.AsignAssessmentToProgramAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPut("Status")]
        public async Task<IActionResult> UpdateAssessmentStatusAsync(AssessmentUpdateStatusRequest request)
        {
            var result = await _service.UpdateAssessmentStatusAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut("Grade")]
        public async Task<IActionResult> GradeAssessmentAsync(GradeAssessmentRequest request)
        {
            var result = await _service.GradeAssessmentAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
