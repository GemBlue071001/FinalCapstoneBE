using Application.Interface;
using Application.Request.CV;
using Application.Request.EducationDetail;
using Application.Response;
using Application.Response.CV;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CVService : ICVService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;
        public CVService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }
        public async Task<ApiResponse> AddNewCVAsync(CVRequest request)
        {   
            try
            {
                var claim = _claimService.GetUserClaim();
                var cv = _mapper.Map<CV>(request);
                cv.UserId = claim.Id;
                await _unitOfWork.CVs.AddAsync(cv);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetCVListAsync()
        {
            var claim = _claimService.GetUserClaim();
            var cvs = await _unitOfWork.CVs.GetAllAsync(x => x.UserId == claim.Id);
            var responseList = _mapper.Map<List<CVResponse>>(cvs);

            return new ApiResponse().SetOk(responseList);
        }
    }
}
