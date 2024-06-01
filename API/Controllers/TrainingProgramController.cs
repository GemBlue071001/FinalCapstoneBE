using Application.Interface;
using Application.Request.TrainingProgram;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProgramController : ControllerBase
    {
        public ITrainingProgramService _service;
        public TrainingProgramController(ITrainingProgramService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddTrainingProgram(TrainingProgramRequest request)
        {
            var result = await _service.AddTrainingProgram(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTrainingProgram()
        {
            var result = await _service.GetAllTrainingProgram();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
