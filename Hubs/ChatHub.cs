using Microsoft.AspNetCore.SignalR;

namespace ChatSISDIS.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(/*string room,*/ string user, string message)
        {
            Clients.All.SendAsync("ReceiveMessage", user, message);
            
            //await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
        }

        /*public async Task AddToGroup(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("ShowWho", $"Alguien se conecto {Context.ConnectionId}");
        }*/
    }
}
