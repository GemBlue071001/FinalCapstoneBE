using Application.Interface;
using Application.Request.SkillSet;
using Application.Request.Subscription;
using Application.Response;
using Application.Response.SkillSet;
using Application.Response.Subscription;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SubscriptionService: ISubscriptionService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public SubscriptionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> GetAllSubscriptionAsync(int UserId)
        {
            try
            {   
                var subscriptions = await _unitOfWork.Subscriptions.GetAllAsync(x => x.UserId == UserId);
                var sortedSubscriptions = subscriptions.OrderByDescending(x => x.SubscriptionDate).ToList();
                var subscriptionSetResponse = _mapper.Map<List<SubscriptionResponse>>(sortedSubscriptions);
                return new ApiResponse().SetOk(subscriptionSetResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message}");
            }
        }
    }
}
