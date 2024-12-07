using Application.Request.Benefit;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IBenefitService
    {
        Task<ApiResponse> AddBenefit(BenefitRequest benefitRequest);
        Task<ApiResponse> GetAllBenefitAsync();
        Task<ApiResponse> DeletedBenefitByIdAsync(int id);
    }
}
