using Application.Interface;
using Application.Request.CV;
using Application.Services;
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

        [HttpPost("Analyz")]
        public async Task<IActionResult> UploadCVToAnalyze(IFormFile file)
        {
            var response = await _service.UploadCVToAnalyze(file);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
