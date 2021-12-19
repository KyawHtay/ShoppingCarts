using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart
{
    public interface IShoppingCart
    {
        void AddShoppingItem(IShoppingCartItem item);
        void RemoveShoppingItem(IShoppingCartItem item);
        decimal GetTotalPrice();

        IList<IShoppingCartItem> ItemsInBasket { get; }
    }
}
