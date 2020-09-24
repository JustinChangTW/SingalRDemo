using Microsoft.AspNetCore.SignalR;
using SingalRDemo.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingalRDemo.Hubs
{
    public class ShopingHub:Hub
    {
        public async Task Buy(string productId ,string quantity)
        {
            var remaining = ProductStorage.Update(productId, Int32.Parse(quantity));
            await Clients.All.SendAsync("bought", productId, remaining);
        }
        public async Task GetCount(string producId)
        {
            var quantity = ProductStorage.Products.FirstOrDefault(x => x.ProductId == producId).Quanitiy;
            await Clients.All.SendAsync("setCount",producId,quantity);
        }
    }
}
