using MyShoppingCart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart.Items
{
    public class Products : IProduct
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Products(string name, decimal price)
        {
            ProductName = name;
            Price = price;
        }

    }
}
