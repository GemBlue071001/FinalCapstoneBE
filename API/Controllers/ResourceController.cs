using Application.Interface;
using Application.Request.Campaign;
using Application.Request.Resource;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private IResourceService _service;

        public ResourceController(IResourceService service)
        {
            _service = service;
        }
        

        [HttpPost]
        public async Task<IActionResult> AddCampaign(ResourceRequest request)
        {
            var result = await _service.AddResouceAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCampaign()
        {
            var result = await _service.GetAllResouceAsync();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
