using Application.Interface;
using Application.Request.Certificate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        private ICertificateService _service;

        public CertificatesController(ICertificateService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewCertificateAsync(AddCertificateRequest request)
        {
            var response = await _service.AddCertificateAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }


        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateNewCertificateAsync(UpdateCertificateRequest request)
        {
            var response = await _service.UpdateCertificateAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteCertificateAsync(int id)
        {
            var response = await _service.RemoveCertificateAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
