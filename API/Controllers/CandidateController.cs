using Application.Interface;
using Application.Request.Campaign;
using Application.Request.Candidate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private ICandidateService _service;
        public CandidateController(ICandidateService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Guest")]
        [HttpPost]
        public async Task<IActionResult> AddCadidate(CandidateRequest request)
        {
            var result = await _service.AddCadidate(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize(Roles ="Guest")]
        [HttpGet("UserAplication")]
        public async Task<IActionResult> GetUserAplicationAsync()
        {
            var result = await _service.GetUserAplication();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize(Roles = "Guest")]
        [HttpPut("Status")]
        public async Task<IActionResult> UpdateCadidateStatus(CandidataStatusUpdate request)
        {
            var result = await _service.UpdateCadidateStatus(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetProgramCandidate(int campaignId, int jobId)
        {
            var result = await _service.GetProgramCadidate(campaignId,jobId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateCandidate(CandidateUpdateRequest request)
        {
            var result = await _service.UpdateCandidateAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("soft")]
        public async Task<IActionResult> DeleteCandidateAsync(int id)
        {
            var result = await _service.DeleteCandidateAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
