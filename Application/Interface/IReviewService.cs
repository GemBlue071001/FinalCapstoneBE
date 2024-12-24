using Application.Request.Feedback;
using Application.Request.Review;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IReviewService
    {
        Task<ApiResponse> AddNewReviewAsync(ReviewRequest request);

        Task<ApiResponse> GetApprovedReviewListAsync(int Id);

        Task<ApiResponse> GetPendingReviewListAsync();

        Task<ApiResponse> RejectReviewAsync(UpdateReviewRequest request);

        Task<ApiResponse> ApproveReviewAsync(int Id);
    }
}
