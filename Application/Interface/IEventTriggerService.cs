namespace Application.Interface
{
    public interface IEventTriggerService
    {
        Task TriggerSendMessageToGroupEvent(string groupId, string message);
        Task SendMessageToUser(string userId, string message);
    }
}
