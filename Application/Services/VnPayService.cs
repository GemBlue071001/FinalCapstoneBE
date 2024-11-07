using Application.Interface;
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
        public async Task<ApiResponse> CreatePaymentUrl(PaymentInformation model, HttpContext context)
        {
            ApiResponse response = new ApiResponse();
            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(_configuration["TimeZoneId"]);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var tick = DateTime.Now.Ticks.ToString();
            var pay = new VnPayLibrary();
            var urlCallBack = _configuration["PaymentCallBack:ReturnUrl"];

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

            var paymentUrl =
                pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);
            var claim = _claimService.GetUserClaim();
            var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == claim.Id);
            if (user.IsPremium == true)
            {
                user.PremiumExpireDate = user.PremiumExpireDate.HasValue
                    ? user.PremiumExpireDate.Value.AddYears(1)
                    : DateTime.Now.AddYears(1);
            }
            else
            {
                user.IsPremium = true;
                user.PremiumExpireDate = DateTime.Now.AddYears(1);
            }
            return response.SetOk(paymentUrl);
        }
        public async Task<ApiResponse> PaymentExecute(IQueryCollection collections)
        {
            ApiResponse apiResponse = new ApiResponse();
            var pay = new VnPayLibrary();
            var response = pay.GetFullResponseData(collections, _configuration["Vnpay:HashSecret"]);

            return apiResponse.SetOk(response);
        }
    }
}
