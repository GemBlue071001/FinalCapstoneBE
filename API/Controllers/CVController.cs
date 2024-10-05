using Application.Interface;
using Application.Request.CV;
using Application.Request.EducationDetail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVController : ControllerBase
    {
        public ICVService _service { get; set; }
        public CVController(ICVService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewCVAsync(CVRequest request)
        {
            var response = await _service.AddNewCVAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetCVListAsync()
        {
            var resposne = await _service.GetCVListAsync();
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }
    }
}
