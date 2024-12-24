using Application.Interface;
using Application.Request.Feedback;
using Application.Request.Review;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _service;

        public ReviewController(IReviewService service)
        {
            _service = service;
        }

        [HttpPost]
        [Authorize(Roles = "JobSeeker")]
        public async Task<IActionResult> AddNewReviewAsync(ReviewRequest request)
        {
            var response = await _service.AddNewReviewAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet("GetApprovedReviewList")]
        public async Task<IActionResult> GetApprovedReviewList(int Id)
        {
            var response = await _service.GetApprovedReviewListAsync(Id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet("GetPendingReviewList")]
        public async Task<IActionResult> GetPendingReviewList()
        {
            var response = await _service.GetPendingReviewListAsync();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpPut("RejectReview")]
        public async Task<IActionResult> RejectReviewWithReason(UpdateReviewRequest request)
        {
            var response = await _service.RejectReviewAsync(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpPut("ApproveReview")]
        public async Task<IActionResult> ApproveReviewWithReason(int Id)
        {
            var response = await _service.ApproveReviewAsync(Id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
