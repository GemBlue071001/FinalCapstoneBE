using Application.Response;

namespace Application.Interface
{
    public interface IEmailService
    {
        Task<ApiResponse> SendMail(string recievedUser, string content);
    }
}
