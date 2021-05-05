using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Items
{
    public class ChatHub : Hub
    {
        public async Task Send(string user, string message)
        {
            await Clients.All.SendAsync("Send", user, message);
        }
    }
}
