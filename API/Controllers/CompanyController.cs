using Application.Interface;
using Application.Request.Company;
using Application.Request.JobLocation;
using Domain.Entities;
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
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(new
                {
                    statusCode = 400,
                    isSuccess = false,
                    errorMessage = string.Join("; ", errors),
                    result = (object)null
                });
            }
            var response = await _service.AddNewCompanyAsync(companyRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateCompanyAsync(UpdateCompanyRequest companyRequest)
        {
           
            var response = await _service.UpdateCompanyAsync(companyRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanyAsync(CompanyStatus companyStatus=CompanyStatus.Approve)
        {
            var response = await _service.GetAllCompanyAsync(companyStatus);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        //[Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyDetailAsync(int id)
        {
            var response = await _service.GetCompanyDetailAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet("/CompanyName/{name}")]
        public async Task<IActionResult> GetCompanyDetaiByNamelAsync(string name)
        {
            var response = await _service.GetCompanyDetailByNameAsync(name);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCompanyByIdAsync(int id)
        {
            var response = await _service.DeleteCompanyByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet("company-name")]
        public async Task<IActionResult> GetCompanyByNameAsync([FromQuery] string companyName, [FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 5)
        {
            var response = await _service.GetCompanyByNameAsync(companyName, pageIndex, pageSize);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpGet("Pending")]
        public async Task<IActionResult> GetAllPendingCompanyAsync()
        {
            var response = await _service.GetAllPendingCompanyAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        //[Authorize]
        [HttpPut("company-status")]
        public async Task<IActionResult> UpdateStatusCompany(UpdateCompanyStatusRequest companyRequest)
        {
            var response = await _service.UpdateCompanyStatus(companyRequest);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

    }
}
