namespace Application.Services
{
    public class EmailService
    {
        public EmailService()
        {

        }

        //public async Task<ApiResponse> SendMail(EmailRequest request)
        //{
        //    try
        //    {
        //        var message = new MimeMessage();
        //        message.From.Add(new MailboxAddress("HighTech", "HighTech@gmail.com"));
        //        message.To.Add(new MailboxAddress("", request.RecievedUser));
        //        message.Subject = "Intern Application";
        //        var bodyBuilder = new BodyBuilder();
        //        bodyBuilder.HtmlBody = request.Content;
        //        message.Body = bodyBuilder.ToMessageBody();
        //        using (var client = new SmtpClient())
        //        {
        //            await client.ConnectAsync("smtp.gmail.com", 465, true);
        //            await client.AuthenticateAsync("trinhtam2001@gmail.com", "srtb iprw hiwv htpj");
        //            await client.SendAsync(message);
        //            await client.DisconnectAsync(true);
        //        }
        //        return new ApiResponse().SetOk("Mail Sent !");
        //    }
        //    catch (Exception)
        //    {
        //        return new ApiResponse().SetBadRequest("Somthing Wrong");
        //    }

        //}
    }
}
