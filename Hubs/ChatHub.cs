using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, object message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}