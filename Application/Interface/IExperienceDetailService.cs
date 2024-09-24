using Application.Request;
using Application.Response;

namespace Application.Interface
{
    public interface IExperienceDetailService
    {
        Task<ApiResponse> AddExperienceDetailAsync(ExperienceDetailRequest request);
        Task<ApiResponse> GetExperienceDetailListAsync();
    }
}
