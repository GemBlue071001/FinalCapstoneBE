using Application.Interface;
using Application.Request.SeekerProfile;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SeekerProfileService: ISeekerProfileService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public SeekerProfileService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddNewSeekerProfilesAsync(SeekerProfileRequest seekerProfileRequest)
        {
            try
            {
                var seekerProfile = _mapper.Map<SeekerProfile>(seekerProfileRequest);
                await _unitOfWork.SeekerProfiles.AddAsync(seekerProfile);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk();
            }catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
    }
}
