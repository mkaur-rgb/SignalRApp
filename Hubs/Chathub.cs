using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        // Broadcast the message to all connected clients
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
