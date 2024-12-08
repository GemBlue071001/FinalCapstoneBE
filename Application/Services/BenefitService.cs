using Application;
using Application.Request.SkillSet;
using Application.Response.SkillSet;
using Application.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Request.Benefit;
using Application.Response.Benefit;
using Application.Interface;

namespace Domain.Entities
{
    public class BenefitService : IBenefitService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public BenefitService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddBenefit(BenefitRequest benefitRequest)
        {
            try
            {
                //await ResetSkillSetIdSequenceAsync();
                var benefit = _mapper.Map<Benefit>(benefitRequest);
                await _unitOfWork.Benefits.AddAsync(benefit);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Add Success");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetAllBenefitAsync()
        {
            try
            {
                var benefits = await _unitOfWork.Benefits.GetAllAsync(null);
                var benefitResponse = _mapper.Map<List<BenefitResponse>>(benefits);
                return new ApiResponse().SetOk(benefitResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message}");
            }
        }

        public async Task<ApiResponse> DeletedBenefitByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var benefit = await _unitOfWork.Benefits.GetAsync(x => x.Id == id);
                if (benefit == null)
                {
                    return response.SetNotFound("Can not found benefit Set id: " + id);
                }
                await _unitOfWork.Benefits.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk(benefit);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }
    }
}
