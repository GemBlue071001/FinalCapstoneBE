using Application.Request.Resource;
using Application.Response;

namespace Application.Interface
{
    public interface IResourceService
    {
        Task<ApiResponse> AddResouceAsync(ResourceRequest request);
        Task<ApiResponse> GetAllResouceAsync();
        Task<ApiResponse> UpdateResourceAsync(ResourceUpdateRequest request);
        Task<ApiResponse> DeleteResourceAsync(int id);
    }
}
