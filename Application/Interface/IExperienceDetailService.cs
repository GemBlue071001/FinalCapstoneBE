using Application.Request.ExperienceDetail;
using Application.Response;

namespace Application.Interface
{
    public interface IExperienceDetailService
    {
        Task<ApiResponse> AddExperienceDetailAsync(ExperienceDetailRequest request);
        Task<ApiResponse> GetExperienceDetailListAsync();
        Task<ApiResponse> UpdateExperienceDetailAsync(int userId, UpdateExperienceDetailRequest request);
        Task<ApiResponse> DeletedExperienceDetailByIdAsync(int id);

    }
}
