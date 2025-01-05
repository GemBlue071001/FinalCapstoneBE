using Application.Request.Certificate;
using Application.Response;

namespace Application.Interface
{
    public interface ICertificateService
    {
        Task<ApiResponse> AddCertificateAsync(AddCertificateRequest request);
        Task<ApiResponse> UpdateCertificateAsync(UpdateCertificateRequest request);
        Task<ApiResponse> RemoveCertificateAsync(int id);
    }
}
