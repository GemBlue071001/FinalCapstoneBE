using Application.Interface;
using Application.Request.FollowCompany;
using Application.Response;
using Application.Response.FollowCompany;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FollowCompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private IClaimService _claimService;
        public FollowCompanyService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }
        public async Task<ApiResponse> AddFollowCompanyAsync(FollowCompanyRequest followCompanyRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var claim = _claimService.GetUserClaim();
                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == followCompanyRequest.CompanyId);
                if (company != null)
                {
                    return apiResponse.SetBadRequest("Not found Company " + followCompanyRequest.CompanyId);
                }
                var followCompany = _mapper.Map<FollowCompany>(followCompanyRequest);
                followCompany.UserId = claim.Id;
                await _unitOfWork.FollowCompanies.AddAsync(followCompany);
                await _unitOfWork.SaveChangeAsync();
                return apiResponse.SetOk("Add Success");

            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> getFollowCompanyAsync() 
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var claim = _claimService.GetUserClaim();
                var followCompanies = await _unitOfWork.FollowCompanies.GetAllAsync(x => x.UserId == claim.Id);
                var responseList = _mapper.Map<List<FollowCompanyResponse>>(followCompanies)l
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
    }
}
