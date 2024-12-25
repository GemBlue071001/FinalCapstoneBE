using Application.Interface;
using Application.Request.Payment;
using Application.Response;
using Application.Response.Payment;
using DocumentFormat.OpenXml.Office2010.Excel;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
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
        public VnPayService(IConfiguration configuration, IUnitOfWork unitOfWork, IClaimService claimService)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _claimService = claimService;
        }
        public async Task<ApiResponse> CreatePaymentUrl(PaymentRequest request, HttpContext context)
        {
            ApiResponse response = new ApiResponse();
            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(_configuration["TimeZoneId"]);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var tick = DateTime.Now.Ticks.ToString();
            var pay = new VnPayLibrary();

            // Get user claim to include user ID in the callback URL
            var claim = _claimService.GetUserClaim();
            var userId = claim.Id;
            /*var existingSubscription = await _unitOfWork.Subscriptions.GetSubscriptionByUserIdAsync(userId);
            if (existingSubscription != null && existingSubscription.ExpiredDate > timeNow)
            {
                return response.SetBadRequest("You already have an active subscription.");
            }*/

            var service = await _unitOfWork.Services.GetAsync(s => s.Id == request.OrderType);
            if (service == null)
            {
                return response.SetBadRequest("Invalid Service Id!");
            }

            var model = new PaymentInformation();

            model.Name = service.Name;
            model.Amount = (double)service.Price;
            model.OrderDescription = service.Description;
            model.OrderType = "Basic";



            // Include the user ID as a query parameter in the callback URL
            var urlCallBack = $"{_configuration["PaymentCallBack:ReturnUrl"]}?userId={claim.Id}&amount={model.Amount}";

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
            try
            {
                ApiResponse apiResponse = new ApiResponse();
                var pay = new VnPayLibrary();
                var response = pay.GetFullResponseData(collections, _configuration["Vnpay:HashSecret"]);

                if (!response.VnPayResponseCode.Equals("00"))
                {
                    return apiResponse.SetBadRequest("Payment Cancel!");
                }

                // Extract userId from query parameters
                if (collections.TryGetValue("userId", out var userIdValue) && int.TryParse(userIdValue, out int userId))
                {
                    // Check the response code to ensure the payment was successful
                    if (response.Success)
                    {
                        // Payment was successful
                        var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == userId);

                        if (user != null)
                        {
                            /*if (user.IsPremium)
                            {
                                user.PremiumExpireDate = user.PremiumExpireDate.HasValue
                                    ? user.PremiumExpireDate.Value.AddYears(1)
                                    : DateTime.Now.AddYears(1);
                            }
                            else
                            {
                                user.IsPremium = true;
                                user.PremiumExpireDate = DateTime.Now.AddYears(1);
                            }*/
                            if (collections.TryGetValue("amount", out var amountValue) && int.TryParse(amountValue, out int amount))
                            {
                                var service = await _unitOfWork.Services.GetAsync(s => s.Price == amount);
                                if (service == null)
                                {
                                    return apiResponse.SetBadRequest("Invalid payment amount.");
                                }
                                var existingUserService = await _unitOfWork.UserAccountServices.GetAsync(uas => uas.UserId == userId && uas.ServiceId == service.Id);
                                if (existingUserService != null)
                                {
                                    
                                    existingUserService.NumberOfPostLeft += service.NumberOfPost;
                                    await _unitOfWork.SaveChangeAsync();
                                }
                                else
                                {
                                    var userAccountService = new UserAccountService
                                    {
                                        UserId = userId,
                                        ServiceId = service.Id,
                                        NumberOfPostLeft = service.NumberOfPost
                                    };

                                    await _unitOfWork.UserAccountServices.AddAsync(userAccountService);
                                }
                                /*var sub = new Subscription
                                {
                                    UserId = userId,
                                    PaymentAmount = amount,
                                    SubscriptionDate = DateTime.Now,
                                    //ExpiredDate = amount == 0 ? null : user.PremiumExpireDate,
                                };*/

                                //await _unitOfWork.Subscriptions.AddAsync(sub);
                            }
                            else
                            {
                                return apiResponse.SetBadRequest("parse error");
                            }

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
                        return apiResponse.SetOk("VN Pay api respone fail");
                    }
                }
                else
                {
                    return apiResponse.SetBadRequest("Invalid or missing userId From call back url");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
