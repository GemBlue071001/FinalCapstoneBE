using Application.Request.Award;
using Application.Response;

namespace Application.Interface
{
    public interface IAwardService
    {
        Task<ApiResponse> AddAwardAsync(AddAwardRequest request);
        Task<ApiResponse> UpdateAwardAsync(UpdateAwardRequest request);
        Task<ApiResponse> RemoveAwardAsync(int id);
    }
}
