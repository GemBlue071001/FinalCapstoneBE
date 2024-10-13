namespace Application.Interface
{
    public interface IEventTriggerService
    {
        Task TriggerSendMessageToGroupEvent(string groupId, string message);
    }
}
