using Application.Interface;
using Application.Request.UserJobAlertCriteria;
using Application.Response;
using Application.Response.UserJobAlertCriteria;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserJobAlertCriteriaService : IUserJobAlertCriteriaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserJobAlertCriteriaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddNewAlertCriteriaAsync(UserJobAlertCriteriaRequest criteriaRequest)
        {
            try
            {
                var criteria = _mapper.Map<UserJobAlertCriteria>(criteriaRequest);
                await _unitOfWork.UserJobAlertCriterias.AddAsync(criteria);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk();
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> DeleteAlertCriteriaByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var criteria = await _unitOfWork.UserJobAlertCriterias.GetAsync(c => c.Id == id);
                if (criteria == null)
                {
                    return response.SetNotFound("Cannot find UserJobAlertCriteria with ID: " + id);
                }

                await _unitOfWork.UserJobAlertCriterias.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk(criteria);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetAllAlertCriteriaAsync(int userId)
        {
            try
            {
                var criteriaList = await _unitOfWork.UserJobAlertCriterias.GetAllAsync(c => c.UserId == userId, 
                                                                                       x => x.Include(x => x.SkillSet!)
                                                                                              .Include(x=>x.JobType!)
                                                                                              .Include(x => x.Location!));
                var response = _mapper.Map<List<UserJobAlertCriteriaResponse>>(criteriaList);

                return new ApiResponse().SetOk(response);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
    }
}
