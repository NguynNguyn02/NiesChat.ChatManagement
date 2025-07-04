

using Microsoft.AspNetCore.SignalR;
using NiesChat.Domain.ChatManagement.Models;

namespace NiesChat.Infra.ChatManagement.Hubs;

public class ChatHub : Hub
{
    public async Task JoinChat(UserConnection connection)
    {
        await Clients.All.SendAsync("ReceiveMessage", "admin", $"{connection.UserName} has joined");
    }
    public async Task JoinSpecificChatRoom(UserConnection connection)
    { 
        await Groups.AddToGroupAsync(Context.ConnectionId, connection.ChatRoom);
        await Clients.Group(connection.ChatRoom).SendAsync("ReceiveMessage", "admin", $"{connection.UserName} has joined {connection.ChatRoom}");
    }
}
