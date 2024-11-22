using Application.Request.CV;
using Application.Response;

namespace Application.Interface
{
    public interface ICVService
    {
        Task<ApiResponse> AddNewCVAsync(CVRequest request);
        Task<ApiResponse> GetCVListAsync();
        Task<ApiResponse> DeletedCvByIdAsync(int id);
        Task<string?> AnalyzeCVAsync(string fileUrl, int cvId);
    }
}
