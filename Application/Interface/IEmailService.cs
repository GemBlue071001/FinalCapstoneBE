using Application.Response;

namespace Application.Interface
{
    public interface IEmailService
    {
        Task<ApiResponse> SendMail(string recievedUser, string emailContent, string userName, string company, string jobTitle, string skillSets);
        Task<ApiResponse> SendValidationEmail(string recievedUser, string emailContent);
        Task<ApiResponse> CustomSendEmail(string recievedUser, string emailContent, string companyName);
        Task<ApiResponse> SendMatchingJobEmail(string recievedUser, string emailContent);
    }
}
