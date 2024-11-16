using Application.Interface;
using Application.Request.Company;
using Application.Request.JobLocation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public ICompanyService _service { get; set; }
        public CompanyController(ICompanyService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewCompanyAsync(CompanyRequest companyRequest)
        {
            var response = await _service.AddNewCompanyAsync(companyRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCompanyAsync()
        {
            var response = await _service.GetAllCompanyAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        //[Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyDetailAsync(int id)
        {
            var response = await _service.GetCompanyDetailAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCompanyByIdAsync(int id)
        {
            var response = await _service.DeleteCompanyByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet("company-name")]
        public async Task<IActionResult> GetCompanyByNameAsync(string companyName)
        {
            var response = await _service.GetCompanyByNameAsync(companyName);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
