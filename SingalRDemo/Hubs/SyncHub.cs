using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SingalRDemo
{
    public class SyncHub:Hub
    {
        public async Task Sync(string id)
        {
            await Clients.All.SendAsync("synced", id);
        }

        public async Task SyncToData(string id,string data)
        {
            await Clients.Others.SendAsync("dataFromSync", id, data);
        }
    }
}