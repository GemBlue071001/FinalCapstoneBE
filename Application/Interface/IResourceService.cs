using Application.Request.Resource;
using Application.Response;

namespace Application.Interface
{
    public interface IResourceService
    {
        Task<ApiResponse> AddResouceAsync(ResourceRequest request);
        Task<ApiResponse> GetAllResouceAsync();
    }
}
