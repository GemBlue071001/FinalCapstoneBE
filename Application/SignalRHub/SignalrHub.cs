using Microsoft.AspNetCore.SignalR;

public class SignalrHub : Hub
{

    public override async Task OnConnectedAsync()
    {
        var userId = Context.UserIdentifier;
        Console.WriteLine($"User connected: {userId}");
        await base.OnConnectedAsync();
    }

    public async Task SendMessageToUser(string userId, string message)
    {
        await Clients.User(userId).SendAsync("ReceiveMessage", userId, message);
        //await Clients.All.SendAsync("ReceiveMessage", userId, message);
    }

    public async Task SendMessageToAll(string message)
    {
        await Clients.All.SendAsync("all", message);
    }

    public  async Task SendMessageToGroup(string groupId, string message, string sender)
    {
        await Clients.Group(groupId).SendAsync("GroupReceiveMessage", message, sender);
    }

    public async Task JoinRoom(string groupId, string username)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupId);
        await Clients.Group(groupId).SendAsync("GroupReceiveMessage", username + " joined.");
    }

    public async Task LeaveRoom(string groupId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupId);
        await Clients.Group(groupId).SendAsync("GroupReceiveMessage", Context.ConnectionId + " left.");
    }
}