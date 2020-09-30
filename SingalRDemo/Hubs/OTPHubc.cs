using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingalRDemo.Hubs
{
    public class OTPHub:Hub
    {
        public async Task AddGroup(string GroupId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, GroupId);
        }

        public async Task ClientCheck(string groupId, string otp)
        {
            await Clients.Group(groupId).SendAsync("check-otp", otp);
        }
        
        public async Task ServerResult(string groupId,string result)
        {
            await Clients.Group(groupId).SendAsync("result-otp", result);
        }

        public async Task ClientResult(string groupId,string result)
        {
            await Clients.Group(groupId).SendAsync("client-result", result);
        }
    }
}
