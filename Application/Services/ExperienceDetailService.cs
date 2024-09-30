using Application.Interface;
using Application.Request.ExperienceDetail;
using Application.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class ExperienceDetailService : IExperienceDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public ExperienceDetailService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddExperienceDetailAsync(ExperienceDetailRequest request)
        {
            try
            {
                var profile = await _unitOfWork.SeekerProfiles.GetAsync(x => x.Id == request.SeekerProfileId);

                if (profile == null)
                {
                    return new ApiResponse().SetNotFound($"Profile id {request.SeekerProfileId} not found !");
                }
                else
                {
                    var experienceDetail = _mapper.Map<ExperienceDetail>(request);
                    await _unitOfWork.ExperienceDetails.AddAsync(experienceDetail);
                    await _unitOfWork.SaveChangeAsync();

                    return new ApiResponse().SetOk("Success !");
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> GetExperienceDetailListAsync()
        {
            var experiences = await _unitOfWork.ExperienceDetails.GetAllAsync(null);
            var responseList = _mapper.Map<List<ExperienceDetailResponse>>(experiences);

            return new ApiResponse().SetOk(responseList);
        }

    }
}
