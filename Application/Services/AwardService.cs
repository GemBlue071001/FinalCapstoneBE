using Application.Interface;
using Application.Request.Award;
using Application.Request.EducationDetail;
using Application.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class AwardService : IAwardService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IClaimService _claimService;

        public AwardService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }


        public async Task<ApiResponse> AddAwardAsync(AddAwardRequest request)
        {
            try
            {
                
                var claim = _claimService.GetUserClaim();
                var award = _mapper.Map<Award>(request);
                award.UserId = claim.Id;

                await _unitOfWork.Awards.AddAsync(award);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

    }
}
