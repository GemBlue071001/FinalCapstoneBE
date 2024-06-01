using Application.Interface;
using Application.Request.Email;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private IEmailService _service;

        public MailController(IEmailService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SendMail (EmailRequest request)
        {
            var result = await _service.SendMail(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
