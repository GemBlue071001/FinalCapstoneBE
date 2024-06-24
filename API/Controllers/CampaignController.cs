using Application.Interface;
using Application.Request.Campaign;
using Application.Request.Job;
using Application.Request.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private ICampaignService _service;
        public CampaignController(ICampaignService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddCampaign(CampaignRequest request)
        {
            var result = await _service.AddCampaign(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCampaign()
        {
            var result = await _service.GetAllCampaign();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCampaign(int id)
        {
            var result = await _service.DeleteCampaign(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCampain(UpdateCampainRequest request)
        {
            var result = await _service.UpdateCampainAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
