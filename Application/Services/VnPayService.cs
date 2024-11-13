using Application.Interface;
using Application.Response;
using Application.Response.Payment;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class VnPayService : IVnPayService
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClaimService _claimService;
        private readonly ILogger<VnPayService> _logger;
        public VnPayService(IConfiguration configuration, IUnitOfWork unitOfWork, IClaimService claimService)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _claimService = claimService;
        }
        public async Task<ApiResponse> CreatePaymentUrl(PaymentInformation model, HttpContext context)
        {
            ApiResponse response = new ApiResponse();
            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(_configuration["TimeZoneId"]);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var tick = DateTime.Now.Ticks.ToString();
            var pay = new VnPayLibrary();

            // Get user claim to include user ID in the callback URL
            var claim = _claimService.GetUserClaim();

            // Include the user ID as a query parameter in the callback URL
            var urlCallBack = $"{_configuration["PaymentCallBack:ReturnUrl"]}?userId={claim.Id}&vnp_Amount={model.Amount}";

            pay.AddRequestData("vnp_Version", _configuration["Vnpay:Version"]);
            pay.AddRequestData("vnp_Command", _configuration["Vnpay:Command"]);
            pay.AddRequestData("vnp_TmnCode", _configuration["Vnpay:TmnCode"]);
            pay.AddRequestData("vnp_Amount", ((int)model.Amount * 100).ToString());
            pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", _configuration["Vnpay:CurrCode"]);
            pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
            pay.AddRequestData("vnp_Locale", _configuration["Vnpay:Locale"]);
            pay.AddRequestData("vnp_OrderInfo", $"{model.Name} {model.OrderDescription} {model.Amount}");
            pay.AddRequestData("vnp_OrderType", model.OrderType);
            pay.AddRequestData("vnp_ReturnUrl", urlCallBack);
            pay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl = pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);
            return response.SetOk(paymentUrl);
        }

        public async Task<ApiResponse> PaymentExecute(IQueryCollection collections)
        {
            ApiResponse apiResponse = new ApiResponse();
            var pay = new VnPayLibrary();
            var response = pay.GetFullResponseData(collections, _configuration["Vnpay:HashSecret"]);
            try
            {
                // Extract userId from query parameters
                if (collections.TryGetValue("userId", out var userIdValue) && int.TryParse(userIdValue, out int userId))
                {
                    // Check the response code to ensure the payment was successful
                    if (response.Success)
                    {
                        Subscription subscription = new Subscription();
                        // Payment was successful
                        var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == userId);

                        if (user != null)
                        {
                            if (user.IsPremium)
                            {
                                user.PremiumExpireDate = user.PremiumExpireDate.HasValue
                                    ? user.PremiumExpireDate.Value.AddYears(1)
                                    : DateTime.Now.AddYears(1);
                                subscription.ExpiredDate = DateTime.Now.AddYears(1);
                            }
                            else
                            {
                                user.IsPremium = true;
                                user.PremiumExpireDate = DateTime.Now.AddYears(1);
                                subscription.ExpiredDate = DateTime.Now.AddYears(1);
                            }
                             collections.TryGetValue("vnp_Amount", out var amountValue1);
                             int.TryParse(amountValue1, out int amount1);
                             await Save(900000, userId);
                            subscription.UserId = userId;
                            subscription.SubscriptionDate = DateTime.Now;
                            if (collections.TryGetValue("vnp_Amount", out var amountValue) && int.TryParse(amountValue, out int amount))
                            {
                                subscription.PaymentAmount = amount / 100;
                                _logger.LogInformation($"amount: {amount}");
                            }
                            else
                            {
                                _logger.LogError($"can not get amount");
                                return apiResponse.SetBadRequest("Payment amount is missing or invalid");
                            }
                            await _unitOfWork.Subscriptions.AddAsync(subscription);

                            await _unitOfWork.SaveChangeAsync();
                            var redirectUrl = "http://localhost:5173/it-jobs?status=success";
                            return apiResponse.SetOk(redirectUrl);
                        }
                        else
                        {
                            return apiResponse.SetBadRequest("User not found");
                        }
                    }
                    else
                    {
                        // Payment failed
                        var redirectUrl = "http://localhost:5173/it-jobs?status=failure";
                        return apiResponse.SetOk(redirectUrl);
                    }
                }
                else
                {
                    return apiResponse.SetBadRequest("Invalid or missing userId");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ex: {ex.Message}{ex.InnerException?.Message}");
                throw;
            } 
            
        }
        public async Task<ApiResponse> Save(float amount,int userId)
        {   
            ApiResponse apiResponse = new ApiResponse();
            Subscription subscription = new Subscription();
            subscription.UserId = userId;
            subscription.SubscriptionDate = DateTime.Now;
            //if (collections.TryGetValue("vnp_Amount", out var amountValue) && int.TryParse(amountValue, out int amount))
            //{
            //    subscription.PaymentAmount = amount / 100;
            //    _logger.LogInformation($"amount: {amount}");
            //}
            subscription.PaymentAmount = amount;
            //else
            //{
            //    _logger.LogError($"can not get amount");
            //    return apiResponse.SetBadRequest("Payment amount is missing or invalid");
            //}
            _logger.LogInformation($"callSave {amount}");
            await _unitOfWork.Subscriptions.AddAsync(subscription);

            await _unitOfWork.SaveChangeAsync();
            return apiResponse.SetOk();
        }


    }
}
