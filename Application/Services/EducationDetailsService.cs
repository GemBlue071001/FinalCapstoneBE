using Application.CustomExceptions;
using Application.Interface;
using Application.Request.EducationDetail;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System.Net;

namespace Application.Services
{
    public class EducationDetailsService : IEducationDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IClaimService _claimService;

        public EducationDetailsService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }

        public async Task<ApiResponse> AddNewEducationDetailAsync(EducationDetailRequest request)
        {
            try
            {
                var claim = _claimService.GetUserClaim();
                var educationDetail = _mapper.Map<EducationDetail>(request);
                educationDetail.UserId = claim.Id;

                await _unitOfWork.EducationDetails.AddAsync(educationDetail);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetEducationDetailListAsync()
        {
            var claim = _claimService.GetUserClaim();
            var educations = await _unitOfWork.EducationDetails.GetAllAsync(x => x.UserId == claim.Id);
            var responseList = _mapper.Map<List<EducationDetailResponse>>(educations);

            return new ApiResponse().SetOk(responseList);
        }

        public async Task<ApiResponse> UpdateEducationDetailAsync(int userId, UpdateEducationDetailRequest request)
        {
            var educationDetail = await _unitOfWork.EducationDetails.GetAsync(education => education.Id == request.Id);
            if (educationDetail == null)
            {
                throw new NotFoundException($"Education Detail ID: {request.Id} not found.");
            }

            if(educationDetail.UserId != userId)
            {
                throw new NotMatchException($"UserId from request: {educationDetail.UserId} not match with ${userId}");
            }

            educationDetail.Name = request.Name;
            educationDetail.InstitutionName = request.InstitutionName;
            educationDetail.Degree = request.Degree;
            educationDetail.FieldOfStudy = request.FieldOfStudy;
            educationDetail.StartDate = request.StartDate;
            educationDetail.EndDate = request.EndDate;
            educationDetail.GPA = request.GPA;

            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetApiResponse(HttpStatusCode.NoContent, true, string.Empty, educationDetail.Id.ToString());
        }
    }
}
