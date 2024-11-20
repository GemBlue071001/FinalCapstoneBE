﻿using Application.Extensions;
using Application.Interface;
using Application.Request.Company;
using Application.Request.JobLocation;
using Application.Request.JobPost;
using Application.Response;
using Application.Response.Company;
using Application.Response.JobLocation;
using AutoMapper;
using DocumentFormat.OpenXml.Vml;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public CompanyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task ResetCompanyIdSequenceAsync()
        {
            // Get the sequence name for the Companys.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"Companys\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the Companys table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"Companys\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }


        public async Task<ApiResponse> AddNewCompanyAsync(CompanyRequest companyRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                // Reset the sequence to avoid conflicts
                await ResetCompanyIdSequenceAsync();

                var company = _mapper.Map<Company>(companyRequest);

                var businessStream = await _unitOfWork.BusinessStreams.GetAsync(x => x.Id == companyRequest.BusinessStreamId);
                if (businessStream == null)
                {
                    return new ApiResponse().SetBadRequest("Cannot find Business Stream Id " + companyRequest.BusinessStreamId);
                }

                company.BusinessStreamId = businessStream.Id;

                await _unitOfWork.Companys.AddAsync(company);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk(company.Id);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException: {ex.InnerException?.Message}");
            }
        }


        public async Task<ApiResponse> GetAllCompanyAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                //var companies = await _unitOfWork.Companys.GetAllAsync(null, x => x.Include(c => c.JobPosts).Include(x => x.BusinessStream));
                var companies = await _unitOfWork.Companys.GetCompany();
                var companyResponse = _mapper.Map<List<CompanyResponse>>(companies);

                return new ApiResponse().SetOk(companyResponse);
            }
            catch (JsonException jsonEx)
            {
                // Log chi tiết lỗi JSON để kiểm tra
                return new ApiResponse().SetBadRequest($"JSON Error: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ khác
                return new ApiResponse().SetBadRequest($"Error: {ex.Message} - InnerException: {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> GetCompanyDetailAsync(int companyId)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                //var company = await _unitOfWork.Companys.GetAsync(x => x.Id == companyId, x => x.Include(c => c.JobPosts).ThenInclude(x => x.JobSkillSets).ThenInclude(x => x.SkillSet));
                var company = await _unitOfWork.Companys.GetCompanyByIdAsync(companyId);
                if(company is null)
                {
                    return new ApiResponse().SetBadRequest("Can not found company Id " + companyId);
                }
                var companyResponse = _mapper.Map<CompanyResponse>(company);

                return new ApiResponse().SetOk(companyResponse);
            }
            catch (JsonException jsonEx)
            {
                return new ApiResponse().SetBadRequest($"JSON Error: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"Error: {ex.Message} - InnerException: {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> GetCompanyDetailByNameAsync(string companyName)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                //var company = await _unitOfWork.Companys.GetAsync(x => x.Id == companyId, x => x.Include(c => c.JobPosts).ThenInclude(x => x.JobSkillSets).ThenInclude(x => x.SkillSet));
                var company = await _unitOfWork.Companys.GetAsync(x=>x.CompanyName.ToLower().Equals(companyName.ToLower()));
                if (company is null)
                {
                    return new ApiResponse().SetBadRequest("Can not found company Id " + companyName);
                }
                var companyResponse = _mapper.Map<CompanyResponse>(company);

                return new ApiResponse().SetOk(companyResponse);
            }
            catch (JsonException jsonEx)
            {
                return new ApiResponse().SetBadRequest($"JSON Error: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"Error: {ex.Message} - InnerException: {ex.InnerException?.Message}");
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
        public async Task<ApiResponse> GetCompanyByNameAsync(string companyName, int pageIndex, int pageSize)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                /* var company = await _unitOfWork.Companys.GetAsync(c => c.CompanyName != null &&
                                                                    c.CompanyName.ToLower().Contains(companyName.ToLower())
                                                                 , x => x.Include(c => c.JobPosts).Include(x => x.BusinessStream));*/
                var company = await _unitOfWork.Companys.GetCompanyByNameAsync(companyName, pageIndex, pageSize);
                var totalCount = await _unitOfWork.Companys.CountTotalPaging(companyName);
               /* if (company == null)
                {
                    return apiResponse.SetBadRequest("Can not found companyName: " + companyName);
                }*/
                var companyResponse = _mapper.Map<List<CompanyResponse>>(company);
                var result = companyResponse.ToPaginationResponse(pageIndex, pageSize, false);
                result.TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
                result.TotalCount = totalCount;

                return new ApiResponse().SetOk(result);
            }
            catch (JsonException jsonEx)
            {
                // Log chi tiết lỗi JSON để kiểm tra
                return new ApiResponse().SetBadRequest($"JSON Error: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ khác
                return new ApiResponse().SetBadRequest($"Error: {ex.Message} - InnerException: {ex.InnerException?.Message}");
            }
        }


    }
}
