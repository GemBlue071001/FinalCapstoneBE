using Application.Interface;
using Application.Request.EducationDetail;
using Application.Request.Email;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private IEmailService _service;

        public EmailController(IEmailService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CustomSendEmail(CustomSendEmailRequest request)
        {
            var response = await _service.CustomSendEmail(request.ReciveUser,request.Content , request.CompanyName);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpPost("SendEmailRejectCompany")]
        public async Task<IActionResult> SendEmailRejectCompany(SendEmailRejectCompanyRequest request)
        {
            var response = await _service.SendEmailRejectCompany(request.CompanyEmail, request.EmailContent, request.CompanyName);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
