using Application.Interface;
using Application.Request.Campaign;
using Application.Request.Candidate;
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

        [HttpPost]
        public async Task<IActionResult> AddCampaign(CandidateRequest request)
        {
            var result = await _service.AddCadidate(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetProgramCandidate(int campaignId, int jobId)
        {
            var result = await _service.GetProgramCadidate(campaignId,jobId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
