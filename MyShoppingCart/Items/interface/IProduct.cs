using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart.Products
{
    public interface IProduct
    {
        string ProductName { get; set; }
        decimal Price { get; set; }
    }
}
