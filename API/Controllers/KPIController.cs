using Application.Interface;
using Application.Request.Job;
using Application.Request.KPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KPIController : ControllerBase
    {
        public IKPIService _service;
        public KPIController(IKPIService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddJob(KPIRequest request)
        {
            var result = await _service.AddKPI(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllKPI()
        {
            var result = await _service.GetAllKPI();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteKPI(int id)
        {
            var result = await _service.DeleteKPI(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateKPI(UpdateKPIRequest request)
        {
            var result = await _service.UpdateKPIAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
