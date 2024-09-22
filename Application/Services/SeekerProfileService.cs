using Application.Interface;
using Application.Request.SeekerProfile;
using Application.Response;
using Application.Response.SeekerProfile;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SeekerProfileService : ISeekerProfileService
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
                return new ApiResponse().SetOk(seekerProfile);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetAllSeekerProfileAsync()
        {
            try
            {
                var seekerProfile = await _unitOfWork.SeekerProfiles.GetAllAsync(null);
                var seekerProfileResponse = _mapper.Map<List<SeekerProfileResponse>>(seekerProfile);
                return new ApiResponse().SetOk(seekerProfileResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message}");
            }
        }

        public async Task<ApiResponse> DeletedSeekerProfileByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var seekerProfile = await _unitOfWork.SeekerProfiles.GetAsync(x => x.Id == id);
                if (seekerProfile == null)
                {
                    return response.SetNotFound("Can not found seeker profile id: " + id);
                }
                await _unitOfWork.SeekerProfiles.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk(seekerProfile);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

    }
}
