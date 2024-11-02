using Application;
using Application.Constants.SignalRHub;
using Microsoft.AspNetCore.SignalR;

public class SignalrHub : Hub
{
    private readonly IUnitOfWork _unitOfWork;

    public SignalrHub(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public override async Task OnConnectedAsync()
    {
        var userId = Context.UserIdentifier;
        Console.WriteLine($"User connected: {userId}");

        await AddUserToCompanyGroupChat(userId ?? string.Empty);
        await base.OnConnectedAsync();
    }

    public async Task SendMessageToUser(string userId, string message)
    {
        await Clients.User(userId).SendAsync(SignalRMethodNames.SendMessageToUser, userId, message);
        //await Clients.All.SendAsync("ReceiveMessage", userId, message);
    }

    public async Task SendMessageToAll(string message)
    {
        await Clients.All.SendAsync(SignalRMethodNames.SendMessageToAll, message);
    }

    public  async Task SendMessageToGroup(string groupId, string message, string sender)
    {
        await Clients.Group(groupId).SendAsync(SignalRMethodNames.SendMessageToGroup, message, sender);
    }

    public async Task JoinRoom(string groupId, string email)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupId);
        //await Clients.Group(groupId).SendAsync(SignalRMethodNames.SendMessageToGroup, username + " joined.");
    }

    public async Task LeaveRoom(string groupId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupId);
        await Clients.Group(groupId).SendAsync(SignalRMethodNames.SendMessageToGroup, Context.ConnectionId + " left.");
    }

    private async Task AddUserToCompanyGroupChat(string userId = "")
    {
        if (string.IsNullOrEmpty(userId))
        {
            return;
        }

        var isInt = int.TryParse(userId, out int id);
        if (isInt)
        {
            var user = await _unitOfWork.UserAccounts.GetAsync(a => a.Id == id);
            if (user != null)
            {
                if (user.CompanyId is not null)
                {
                    await JoinRoom($"{user.CompanyId}", $"{user.Id}");
                    Console.WriteLine($"User {userId} - Name: {user.Email} has joined group: {user.CompanyId}");
                }
            }
        } 
    }
}