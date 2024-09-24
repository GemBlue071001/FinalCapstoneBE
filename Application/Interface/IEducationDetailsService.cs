using Application.Request;
using Application.Response;

namespace Application.Interface
{
    public interface IEducationDetailsService
    {
        Task<ApiResponse> AddNewEducationDetailAsync(EducationDetailRequest request);
        Task<ApiResponse> GetEducationDetailListAsync();
    }
}
