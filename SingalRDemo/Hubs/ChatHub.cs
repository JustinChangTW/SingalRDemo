using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingalRDemo.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user,string groupName,string message)
        {
            await Clients.Group(groupName).SendAsync("ReceiveMessage", user, message);
        }

        public async Task AddGroup(string user,string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("Send", $@"歡迎光臨{user}, 加入 {groupName}會議 {DateTime.Now.ToString()}");
        }

        public async Task LeaveGroup(string user, string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("Send", $@"{user} 已經離開 {groupName}會議 {DateTime.Now.ToString()}");
        }
    }
}
