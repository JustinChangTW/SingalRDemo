using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingalRDemo.Hubs
{
    public class SyncSrollHub : Hub
    {
        public async Task Scroll(ScrollModel scroll)
        {
            await Clients.Others.SendAsync("scrolled", scroll);
        }
    }

    public class ScrollModel{
        public decimal ScrollY { get; set; }
        public decimal ScrollX { get; set; }
        public decimal PageYOffset { get; set; }
        public decimal PageXOffset { get; set; }
    }
}
