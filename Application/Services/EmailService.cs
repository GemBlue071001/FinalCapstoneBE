using Application.Interface;
using Application.Response;
using MailKit.Net.Smtp;
using MimeKit;

namespace Application.Services
{
    public class EmailService : IEmailService
    {
        public EmailService()
        {

        }

        public async Task<ApiResponse> SendMail(string recievedUser, string emailContent, string userName, string company, string jobTitle)
        {
            try
            {
                // Replace placeholders with actual values
                emailContent = emailContent.Replace("${Name}", userName)
                                           .Replace("${CompanyName}", company)
                                           .Replace("${JobTitle}", jobTitle);

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("HighTech", "HighTech@gmail.com"));
                message.To.Add(new MailboxAddress("", recievedUser));
                message.Subject = $"Job Opportunity at {company}"; // Custom subject with company name
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = emailContent; // Use the modified emailContent with the placeholders replaced
                message.Body = bodyBuilder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 465, true);
                    await client.AuthenticateAsync("trinhtam2001@gmail.com", "hqpr gldl ccku rute");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
                return new ApiResponse().SetOk("Mail Sent!");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"Something went wrong: {ex.Message}");
            }
        }

    }
}
