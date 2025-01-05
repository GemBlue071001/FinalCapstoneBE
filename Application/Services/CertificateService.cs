using Application.Interface;
using Application.Request.Award;
using Application.Request.Certificate;
using Application.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class CertificateService : ICertificateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IClaimService _claimService;

        public CertificateService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }


        public async Task<ApiResponse> AddCertificateAsync(AddCertificateRequest request)
        {
            try
            {

                var claim = _claimService.GetUserClaim();
                var certificate = _mapper.Map<Certificate>(request);
                certificate.UserId = claim.Id;

                await _unitOfWork.Certificates.AddAsync(certificate);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> UpdateCertificateAsync(UpdateCertificateRequest request)
        {
            try
            {
                var claim = _claimService.GetUserClaim();

                var certificate = await _unitOfWork.Certificates.GetAsync(x => x.Id == request.Id && claim.Id == x.UserId);

                if (certificate == null)
                {
                    return new ApiResponse().SetBadRequest("Can not find user award !");
                }

                _mapper.Map(request, certificate);

                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }


        public async Task<ApiResponse> RemoveCertificateAsync(int id)
        {
            try
            {
                var claim = _claimService.GetUserClaim();

                var award = await _unitOfWork.Certificates.GetAsync(x => x.Id == id && claim.Id == x.UserId);

                if (award == null)
                {
                    return new ApiResponse().SetBadRequest("Can not find user award !");
                }

                await _unitOfWork.Certificates.RemoveByIdAsync(award.Id);

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
