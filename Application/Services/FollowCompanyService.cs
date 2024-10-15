using Application.Interface;
using Application.Request.FollowCompany;
using Application.Response;
using Application.Response.Company;
using Application.Response.FollowCompany;
using AutoMapper;
using Domain.Entities;


namespace Application.Services
{
    public class FollowCompanyService : IFollowCompanyService
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
                if (company == null)
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
        public async Task<ApiResponse> GetFollowCompanyAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var claim = _claimService.GetUserClaim();
                var followCompanies = await _unitOfWork.FollowCompanies.GetAllAsync(x => x.UserId == claim.Id);
                var listCompaniesId = followCompanies.Select(x => x.CompanyId).ToList();
                var companies = await _unitOfWork.Companys.GetAllAsync(x => listCompaniesId.Contains(x.Id));
                var responseList = _mapper.Map<List<CompanyResponse>>(companies);
                return apiResponse.SetOk(responseList);
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> DeleteFollowCompanyById(int id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var claim = _claimService.GetUserClaim();
                var followCompany = await _unitOfWork.FollowCompanies.GetAsync(x => x.UserId == claim.Id && x.CompanyId == id);
                if (followCompany == null)
                {
                    return apiResponse.SetBadRequest("Not found follow company " + id);
                }
                await _unitOfWork.FollowCompanies.RemoveByIdAsync(followCompany.Id);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("follow company deleted successfully!");
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
    }
}
