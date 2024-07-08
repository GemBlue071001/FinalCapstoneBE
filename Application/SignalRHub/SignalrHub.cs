using Application.SignalRHub.Model;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

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
}