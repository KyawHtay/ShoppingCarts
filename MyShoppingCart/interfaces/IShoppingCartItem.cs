using MyShoppingCart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart
{
    public interface IShoppingCartItem
    {
        decimal UpdatePrice(decimal discount, int quantity = 0);

        IProduct Product { get; }
        int Quantity { get; } // I used 'int' for simplicity here, in a real application it would probably be 'double'
        decimal Price { get; }
    }
}
