using Application.Response;

namespace Application.Interface
{
    public interface IEmailService
    {
        Task<ApiResponse> SendMail(string recievedUser, string emailContent, string userName, string company, string jobTitle);
        Task<ApiResponse> SendValidationEmail(string recievedUser, string emailContent);
        Task<ApiResponse> CustomSendEmail(string recievedUser, string emailContent, string companyName);
    }
}
