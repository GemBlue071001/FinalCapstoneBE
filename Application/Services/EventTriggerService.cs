using Application.Interface;
using Microsoft.AspNetCore.SignalR;

namespace Application.Services
{
    public class EventTriggerService : IEventTriggerService
    {
        private readonly IHubContext<SignalrHub> _hubContext;

        public EventTriggerService(IHubContext<SignalrHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task SendMessageToUser(string userId, string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", userId, message);
        }

        public async Task TriggerSendMessageToGroupEvent(string groupId, string message)
        {
            await _hubContext.Clients.Group(groupId).SendAsync("GroupReceiveMessage", message);
        }
    }
}
