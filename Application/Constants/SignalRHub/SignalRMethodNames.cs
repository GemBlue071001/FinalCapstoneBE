namespace Application.Constants.SignalRHub
{
    public static class SignalRMethodNames
    {
        public static readonly string SendMessageToAll = "AllReceiveMessage";
        public static readonly string SendMessageToGroup = "GroupReceiveMessage";
        public static readonly string SendMessageToUser = "ReceiveMessage";
    }
}
