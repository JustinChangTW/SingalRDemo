using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingalRDemo.Storage
{
    public static class ProductStorage
    {
        public static  List<Product> Products = new List<Product>();

        static  ProductStorage()
        {
            Products.Add(new Product { ProductId = "1", ProductName = "木瓜", Quanitiy = 3, UnitPrice = 100 });
        }

        public static int Update(string productId,int quanitiy)
        {
           var p = Products.FirstOrDefault(x => x.ProductId == productId);
            p.Quanitiy = p.Quanitiy - quanitiy;
            return p.Quanitiy;
        }
    }

    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quanitiy { get; set; }
        public int UnitPrice { get; set; }
    }
}
