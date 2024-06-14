using Application.Interface;
using Application.Request.Candidate;
using Application.Request.TrainingProgram;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProgramController : ControllerBase
    {
        private ITrainingProgramService _service;
        public TrainingProgramController(ITrainingProgramService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddCampaign(TrainingProgramRequest request)
        {
            var result = await _service.AddTrainingProgram(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
