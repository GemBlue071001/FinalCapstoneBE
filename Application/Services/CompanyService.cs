using Application.Interface;
using Application.Request.Company;
using Application.Request.JobLocation;
using Application.Response;
using Application.Response.Company;
using Application.Response.JobLocation;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CompanyService: ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public CompanyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddNewCompanyAsync(CompanyRequest companyRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var company = _mapper.Map<Company>(companyRequest);
                await _unitOfWork.Companys.AddAsync(company);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk(company);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetAllCompanyAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var companys = await _unitOfWork.Companys.GetAllAsync(null);
                var companyResponse = _mapper.Map<List<CompanyResponse>>(companys);
                return new ApiResponse().SetOk(companyResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> DeleteCompanyByIdAsync(int id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == id);
                if (company == null)
                {
                    return apiResponse.SetNotFound("Can not found company id: " + id);
                }
                await _unitOfWork.Companys.RemoveByIdAsync(company.Id);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk(company);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

    }
}
