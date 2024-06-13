using Application.SignalRHub.Model;
using Microsoft.AspNetCore.SignalR;
public class SignalrHub : Hub
{
    public async Task NewMessage(string user, string message)
    {
        await Clients.All.SendAsync("messageReceived", user, message);
    }


    public async Task JoinRoom(UserConnection userConnection)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room);
        await Clients.All.SendAsync("ReceiveMessage", "_botUser",
        $"{userConnection.User} has joined {userConnection.Room}");


    }

}