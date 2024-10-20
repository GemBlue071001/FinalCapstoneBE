namespace Application.Constants.SignalRHub
{
    public static class SignalRMethodNames
    {
        public static readonly string SendMessageToAll = "AllReceiveMessage";
        public static readonly string SendMessageToGroup = "GroupReceiveMessage";
        public static readonly string SendMessageToUser = "ReceiveMessage";
    }

    public static class SignalMessage
    {
        public static readonly string GET_NOTIFY_EMPLOYER = "GetNotifyEmployer";
        public static readonly string APPLICATION_STATUS_UPDATE = "ApplicationStatusUpdate";
    }
}
