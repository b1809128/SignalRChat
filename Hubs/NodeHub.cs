using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class NodeHub : Hub
    {
        public async Task SendMessage(string id, object message)
        {
            await Clients.All.SendAsync("ReceiveMessage", id, message);
        }
    }
}