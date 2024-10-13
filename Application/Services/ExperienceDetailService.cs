using Application.CustomExceptions;
using Application.Interface;
using Application.Request.ExperienceDetail;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System.Net;
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

        public async Task<ApiResponse> UpdateExperienceDetailAsync(int userId, UpdateExperienceDetailRequest request)
        {
            var experienceDetail = await _unitOfWork.ExperienceDetails.GetAsync(experience => experience.Id == request.Id);
            if (experienceDetail == null)
            {
                throw new NotFoundException($"ExperienceDetail ID: {request.Id} not found.");
            }

            if (experienceDetail.UserId != userId)
            {
                throw new NotMatchException($"UserId from request: {experienceDetail.UserId} not match with {userId}");
            }

            experienceDetail.CompanyName = request.CompanyName;
            experienceDetail.Position = request.Position;
            experienceDetail.StartDate = request.StartDate;
            experienceDetail.EndDate = request.EndDate;
            experienceDetail.Responsibilities = request.Responsibilities;
            experienceDetail.Achievements = request.Achievements;

            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetApiResponse(HttpStatusCode.NoContent, true, experienceDetail.Id.ToString());
        }
        public async Task<ApiResponse> DeletedExperienceDetailByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var experienceDetail = await _unitOfWork.ExperienceDetails.GetAsync(x => x.Id == id);
                if (experienceDetail == null)
                {
                    return response.SetNotFound("Can not found experienceDetail id: " + id);
                }
                await _unitOfWork.ExperienceDetails.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk("deleted !");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }
    }
}
