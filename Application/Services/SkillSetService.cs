﻿using Application.Interface;
using Application.Request.SeekerProfile;
using Application.Request.SkillSet;
using Application.Response;
using Application.Response.SeekerProfile;
using Application.Response.SkillSet;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SkillSetService: ISkillSetService
    {

        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public SkillSetService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddNewSkillSet(SkillSetRequest skillSetRequest)
        {
            try
            {
                var skillSet = _mapper.Map<SkillSet>(skillSetRequest);
                await _unitOfWork.SkillSets.AddAsync(skillSet);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk(skillSet);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetAllSkillSetAsync()
        {
            try
            {
                var skillSets = await _unitOfWork.SkillSets.GetAllAsync(null);
                var skillSetResponse = _mapper.Map<List<SkillSetResponse>>(skillSets);
                return new ApiResponse().SetOk(skillSetResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message}");
            }
        }

        public async Task<ApiResponse> DeletedSkillSetByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var skillSet = await _unitOfWork.SkillSets.GetAsync(x => x.Id == id);
                if (skillSet == null)
                {
                    return response.SetNotFound("Can not found skill Set id: " + id);
                }
                await _unitOfWork.SkillSets.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk(skillSet);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }
    }
}