using Application.Interface;
using Application.Request.CV;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileHandlingController : ControllerBase
    {
        private readonly IFileHandlingService _service;

        public FileHandlingController(IFileHandlingService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewCVAsync(IFormFile file)
        {
            var response = await _service.ImportExcel(file);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpPost("Analyze")]
        public async Task<IActionResult> UploadCVToAnalyze(string filePath, int jobId)
        {
            var response = await _service.UploadCVToAnalyze(filePath, jobId);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpPost("Firebase")]
        public async Task<IActionResult> UploadCVToAnalyze(string file)
        {
            var response = await _service.UploadPdfFromFirebase(file);
            return  Ok(response);
        }
    }
}
