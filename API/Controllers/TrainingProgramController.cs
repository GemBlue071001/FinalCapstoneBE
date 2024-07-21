using Application.Interface;
using Application.Request.Candidate;
using Application.Request.KPI;
using Application.Request.TrainingProgram;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> AddTrainingProgramAsync(TrainingProgramRequest request)
        {
            var result = await _service.AddTrainingProgram(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTrainingProgramAsync(TrainingUpdateRequest request)
        {
            var result = await _service.UpdateTrainingProgramAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTrainingProgramAsync()
        {
            var result = await _service.GetAllTrainingProgram();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("UserTrainingProgram")]
        public async Task<IActionResult> GetUserTrainingProgramAsync(int userId = 0)
        {
            var result = await _service.GetUserTrainingProgram(userId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("Resource")]
        public async Task<IActionResult> RemoveResourceFromProgramAsync(TrainingResourceRequest request)
        {
            var result = await _service.RemoveResourceFromTrainingProgramAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("Resource")]
        public async Task<IActionResult> AddResourceToProgramAsync(TrainingResourceRequest request)
        {
            var result = await _service.AddResourceToTrainingProgramAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveProgramAsync(int id)
        {
            var result = await _service.DeleteTrainingProgramAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPost("KPI")]
        public async Task<IActionResult> AddKPIToTrainingProgramAsync(ProgramKPIRequest request)
        {
            var result = await _service.AddKPIToTranningProgram(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("KPI")]
        public async Task<IActionResult> RemoveKPIFromProgramAsync(ProgramKPIRequest request)
        {
            var result = await _service.RemoveKPIFromTrainingProgramAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
