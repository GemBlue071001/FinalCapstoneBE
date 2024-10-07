using Application.Interface;
using Application.Request.ExperienceDetail;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System.Security.Claims;

namespace Application.Services
{
    public class ExperienceDetailService : IExperienceDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private IClaimService _claimService;
        public ExperienceDetailService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }

        public async Task<ApiResponse> AddExperienceDetailAsync(ExperienceDetailRequest request)
        {
            try
            {
                var claim = _claimService.GetUserClaim();
                var experienceDetail = _mapper.Map<ExperienceDetail>(request);
                experienceDetail.UserId = claim.Id;

                await _unitOfWork.ExperienceDetails.AddAsync(experienceDetail);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk("Success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> GetExperienceDetailListAsync()
        {
            var claim = _claimService.GetUserClaim();
            var experiences = await _unitOfWork.ExperienceDetails.GetAllAsync(x => x.UserId == claim.Id);
            var responseList = _mapper.Map<List<ExperienceDetailResponse>>(experiences);

            return new ApiResponse().SetOk(responseList);
        }

    }
}
