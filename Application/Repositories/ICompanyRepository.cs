using Application.Repository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface ICompanyRepository: IGenericRepository<Company>
    {
        Task<List<Company>> GetCompany();
        Task<Company> GetCompanyByIdAsync(int companyId);
        Task<List<Company>> GetCompanyByNameAsync(string companyName, int pageIndex, int pageSize);
    }
}
