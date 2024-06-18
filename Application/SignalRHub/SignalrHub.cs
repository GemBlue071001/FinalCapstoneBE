using Application.SignalRHub.Model;
using Microsoft.AspNetCore.SignalR;

public class SignalrHub : Hub
{
    private readonly string _botUser;
    private readonly IDictionary<string, UserConnection> _connections;

    public SignalrHub(IDictionary<string, UserConnection> connections)
    {
        _botUser = "MyChat Bot";
        _connections = connections;
    }



    public async Task JoinRoom(UserConnection userConnection)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room);

        _connections[Context.ConnectionId] = userConnection;

        await Clients.Group(userConnection.Room).SendAsync("ReceiveMessage", _botUser, $"{userConnection.User} has joined {userConnection.Room}");

    }


    public async Task SendMessage(string message)
    {
        if (_connections.TryGetValue(Context.ConnectionId, out UserConnection userConnection))
        {
            await Clients.Group(userConnection.Room).SendAsync("ReceiveMessage", userConnection.User, message);
        }
    }

    public async Task NewMessage(string user, string message)
    {
        await Clients.All.SendAsync("messageReceived", user, message);
    }
}