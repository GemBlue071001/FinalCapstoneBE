using Application.Extensions;
using Application.Interface;
using Application.Request.Company;
using Application.Response;
using Application.Response.Company;
using AutoMapper;
using Domain.Entities;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using Application.Response.CompanyLocation;

namespace Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private IClaimService _claimService;

        public CompanyService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }


        public async Task ResetCompanyIdSequenceAsync()
        {
            var x = await _unitOfWork.Companys.CountAsync();
            if (x <= 0)
                return;
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
                company.CompanyStatus = CompanyStatus.Pending;

                await _unitOfWork.Companys.AddAsync(company);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk(company.Id);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException: {ex.InnerException?.Message}");
            }
        }


        public async Task<ApiResponse> UpdateCompanyAsync(UpdateCompanyRequest request)
        {
            try
            {
                ApiResponse response = new ApiResponse();
                var claim = _claimService.GetUserClaim();
                var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == claim.Id);
                if (user == null)
                    return response.SetNotFound("User not found");

                if (user.CompanyId != request.Id)
                    return response.SetNotFound("User do not own this company !!");

                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == user.CompanyId, x=> x.Include(x=> x.CompanyLocations)
                                                                                                       .ThenInclude(x=>x.Location));

                _mapper.Map(request, company);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk("Update Success");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }


        public async Task<ApiResponse> GetAllCompanyAsync(CompanyStatus companyStatus)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var companies = await _unitOfWork.Companys.GetAllAsync(x => x.CompanyStatus == companyStatus,
                                                                            x => x.Include(c => c.JobPosts!)
                                                                            .Include(x => x.BusinessStream)
                                                                            .Include(x => x!.CompanyLocations!)
                                                                            .ThenInclude(x => x.Location!));
                //var companies = await _unitOfWork.Companys.GetCompany();
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
                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == companyId, x => x.Include(c => c.JobPosts)
                                                                                                    .ThenInclude(x => x.JobSkillSets)
                                                                                                        .ThenInclude(x => x.SkillSet)
                                                                                                .Include(x => x!.CompanyLocations!)
                                                                                                    .ThenInclude(x => x.Location!));
                //var company = await _unitOfWork.Companys.GetCompanyByIdAsync(companyId);
                if (company is null)
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
                var company = await _unitOfWork.Companys.GetAsync(x => x.CompanyName.ToLower().Equals(companyName.ToLower()));
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


        public async Task<ApiResponse> GetCompanyByNameAsync(string companyName, int pageIndex, int pageSize, CompanyStatus companyStatus)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                /* var company = await _unitOfWork.Companys.GetAsync(c => c.CompanyName != null &&
                                                                    c.CompanyName.ToLower().Contains(companyName.ToLower())
                                                                 , x => x.Include(c => c.JobPosts).Include(x => x.BusinessStream));*/
                var company = await _unitOfWork.Companys.GetCompanyByNameAsync(companyName, pageIndex, pageSize, companyStatus);
                var totalCount = await _unitOfWork.Companys.CountTotalPaging(companyName, companyStatus);
                /* if (company == null)
                 {
                     return apiResponse.SetBadRequest("Can not found companyName: " + companyName);
                 }*/
                var companyResponse = _mapper.Map<List<CompanyResponse>>(company);
                var result = companyResponse.ToPaginationResponse(pageIndex, pageSize, false);
                result.TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
                result.TotalCount = totalCount;
                result.PageIndex = pageIndex;

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
        public async Task<ApiResponse> GetAllPendingCompanyAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var companies = await _unitOfWork.Companys.GetAllAsync(x => x.CompanyStatus == CompanyStatus.Pending,
                                                                            x => x.Include(c => c.JobPosts!)
                                                                            .Include(x => x.BusinessStream)
                                                                            .Include(x => x!.CompanyLocations!)
                                                                            .ThenInclude(x => x.Location!));
                //var companies = await _unitOfWork.Companys.GetAllCompanyPending();
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
        public async Task<ApiResponse> UpdateCompanyStatus(UpdateCompanyStatusRequest request)
        {
            try
            {
                ApiResponse response = new ApiResponse();
                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == request.CompanyId);
                if (company is null)
                {
                    return new ApiResponse().SetBadRequest("Can not found company Id " + request.CompanyId);
                }
                company.CompanyStatus = request.CompanyStatus;


                await _unitOfWork.SaveChangeAsync();

                return response.SetOk("Update Success");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }
        public async Task<ApiResponse> UpdateCompanyRejectAsync(UpdateCompanyRejectRequest request)
        {
            try
            {
                ApiResponse response = new ApiResponse();
                var claim = _claimService.GetUserClaim();
                var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == claim.Id);
                if (user == null)
                    return response.SetNotFound("User not found");

                if (user.CompanyId != request.Id)
                    return response.SetNotFound("User do not own this company !!");

                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == user.CompanyId, x => x.Include(x => x.CompanyLocations)
                                                                                                       .ThenInclude(x => x.Location));
                company.CompanyStatus = CompanyStatus.Pending;
                _mapper.Map(request, company);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk("Update Success");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> GetCompanyLocationByCompanyIdAsync(int companyId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == companyId, x => x.Include(x => x.CompanyLocations)
                                                                                              .ThenInclude(x => x.Location));
                if (company is null)
                {
                    return new ApiResponse().SetBadRequest("Can not found company Id " + companyId);
                }
                var companyLocations = await _unitOfWork.CompanyLocations.GetAllAsync(x => x.CompanyId == company.Id);

                var companyLocationResponse = _mapper.Map<List<CompanyLocationResponse>>(companyLocations);

                return new ApiResponse().SetOk(companyLocationResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }
    }
}
