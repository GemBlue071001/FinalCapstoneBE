using Application.Request.Company;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICompanyService
    {
        Task<ApiResponse> AddNewCompanyAsync(CompanyRequest companyRequest);
        Task<ApiResponse> DeleteCompanyByIdAsync(int id);
        Task<ApiResponse> GetAllCompanyAsync();
        Task<ApiResponse> GetCompanyDetailAsync(int companyId);
        Task<ApiResponse> GetCompanyByNameAsync(string companyName);
    }
}
