using Application.Interface;
using Application.Request.Benefit;
using Application.Request.SkillSet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitController : ControllerBase
    {
        public IBenefitService _service { get; set; }
        public BenefitController(IBenefitService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddBenefit(BenefitRequest request)
        {
            var response = await _service.AddBenefit(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBenefitAsync()
        {
            var response = await _service.GetAllBenefitAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletedBenefitByIdAsync(int id)
        {
            var response = await _service.DeletedBenefitByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
