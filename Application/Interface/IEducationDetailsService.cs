using Application.Request.EducationDetail;
using Application.Response;

namespace Application.Interface
{
    public interface IEducationDetailsService
    {
        Task<ApiResponse> AddNewEducationDetailAsync(EducationDetailRequest request);
        Task<ApiResponse> GetEducationDetailListAsync();
        Task<ApiResponse> UpdateEducationDetailAsync(int userId, UpdateEducationDetailRequest request);
        Task<ApiResponse> DeletedEducationDetailByIdAsync(int id);
    }
}
