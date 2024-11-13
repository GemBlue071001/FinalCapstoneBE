using Application.Interface;
using Application.Request.SkillSet;
using Application.Response;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        public IVnPayService _service { get; set; }
        public PaymentController(IVnPayService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreatePaymentUrl(PaymentInformation model)
        {
            var response = await _service.CreatePaymentUrl(model, HttpContext);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }


        [HttpGet("callback")]
        public async Task<IActionResult> PaymentCallback()
        {
            var response = await _service.PaymentExecute(Request.Query);

            // Redirect the user directly to the front-end with status
            if (response.IsSuccess)
            {
                // Extract the redirect URL from the response and pass it as a query parameter to the FE
                var redirectUrl = "http://localhost:5173/it-jobs?status=success";
                return Redirect(redirectUrl);
            }
            else
            {
                var redirectUrl = "http://localhost:5173/it-jobs?status=failure";
                return Redirect(redirectUrl);
            }
        }

        //[HttpGet("Save")]
        //public async Task<IActionResult> Save()
        //{
        //    var response = await _service.Save();

          
        //   return Ok(response.StatusCode);
        //}
    }
}
