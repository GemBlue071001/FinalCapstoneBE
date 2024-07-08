using Microsoft.AspNetCore.SignalR;

namespace Application.Services
{
    public class CustomUserIdProvider : IUserIdProvider
    {
        public string GetUserId(HubConnectionContext connection)
        {
            // Use "UserId" claim or another claim that contains your user ID
            return connection.User?.FindFirst("UserId")?.Value;
        }
    }
}
