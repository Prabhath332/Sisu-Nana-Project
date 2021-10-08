using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using web_project.Models;

namespace web_project.Hubs
{
    public class ChatHub : Hub 
    {
        public async Task SendMessage(Message message) =>
        await Clients.All.SendAsync("receiveMessage", message);
    }
}
