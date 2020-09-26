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
        public int ScrollY { get; set; }
        public int ScrollX { get; set; }
        public int PageYOffset { get; set; }
        public int PageXOffset { get; set; }
    }
}
