using Application.Interface;
using Application.Request.Feedback;
using Application.Request.Review;
using Application.Response;
using Application.Response.Feedback;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private IClaimService _claimService;

        public ReviewService(IClaimService claimService, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _claimService = claimService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        /*public async Task ResetFeedbackIdSequenceAsync()
        {
            var x = await _unitOfWork.FeedBacks.CountAsync();
            if (x <= 0)
                return;
            // Get the sequence name for the Feedbacks.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"Feedbacks\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the Feedbacks table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"Feedbacks\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }*/

        private async Task<int> CalculateRating(ReviewRequest request)
        {
            double calculateRating = (request.TrainingRating + request.CareRating + request.CultureRating + request.OfficeRating + request.SalaryRating) / 5;
            int rating;
            if (calculateRating >= 4.5)
            {
                rating = (int)Math.Ceiling(calculateRating);
            }
            else
            {
                rating = (int)Math.Floor(calculateRating);
            }
                
            return rating;
        }

        public async Task<ApiResponse> AddNewReviewAsync(ReviewRequest request)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                //await ResetFeedbackIdSequenceAsync();

                var claim = _claimService.GetUserClaim();
                var review = _mapper.Map<Review>(request);
                

                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == request.CompanyId);
                if (company == null)
                {
                    return response.SetNotFound("Cannot find Company Id " + request.CompanyId);
                }

                if (company.CompanyStatus != CompanyStatus.Approve)
                {
                    return response.SetBadRequest("Company status must be approved ");
                }

                review.CompanyId = company.Id;
                review.ReviewStatus = ReviewStatus.Pending;
                review.Rating = await CalculateRating(request);

                review.UserId = claim.Id;
                await _unitOfWork.Reviews.AddAsync(review);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk("Feedback has been created successfully!");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetApprovedReviewListAsync(int Id)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var reviewList = await _unitOfWork.Reviews.GetAllAsync(x => x.ReviewStatus == ReviewStatus.Approve && x.CompanyId == Id);
                var responseList = _mapper.Map<List<ReviewReponse>>(reviewList);

                return response.SetOk(responseList);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetPendingReviewListAsync()
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var reviewList = await _unitOfWork.Reviews.GetAllAsync(x => x.ReviewStatus == ReviewStatus.Pending, include: query => query.Include(r => r.Company));
                var responseList = _mapper.Map<List<ReviewReponse>>(reviewList);
                
                return response.SetOk(responseList);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> RejectReviewAsync(UpdateReviewRequest request)
        {
            ApiResponse response = new ApiResponse();
            var review = await _unitOfWork.Reviews.GetAsync(r => r.Id == request.Id);
            if (review == null)
            {
                return response.SetNotFound($"Review Id: {request.Id} not found");
            }

            review.ReviewStatus = ReviewStatus.Reject;
            review.ReasonToReject = request.ReasonToReject;

            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(review);
        }

        public async Task<ApiResponse> ApproveReviewAsync(int Id)
        {
            ApiResponse response = new ApiResponse();
            var review = await _unitOfWork.Reviews.GetAsync(r => r.Id == Id);
            if (review == null)
            {
                return response.SetNotFound($"Review Id: {Id} not found");
            }

            review.ReviewStatus = ReviewStatus.Approve;

            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(review);
        }
    }
}
