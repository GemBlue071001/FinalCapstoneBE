using Application.Interface;
using Application.Request.CV;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelFileHandlingController : ControllerBase
    {
        private readonly IExcelFileHandling _service;

        public ExcelFileHandlingController(IExcelFileHandling service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewCVAsync(IFormFile file)
        {
            var response = await _service.ImportExcel(file);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
