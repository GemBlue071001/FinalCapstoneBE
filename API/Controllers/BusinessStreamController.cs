using Application.Interface;
using Application.Request.BusinessStream;
using Application.Request.Company;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessStreamController : ControllerBase
    {
        public IBusinessStreamService _service { get; set; }
        public BusinessStreamController(IBusinessStreamService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewBusinessStreamAsync(BusinessStreamRequest businessStreamRequest)
        {
            var response = await _service.AddNewBusinessStreamAsync(businessStreamRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBusinessStreamAsync()
        {
            var response = await _service.GetAllBusinessStreamAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
