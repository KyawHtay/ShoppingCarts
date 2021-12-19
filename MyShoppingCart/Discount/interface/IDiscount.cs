using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart.Discount
{
    public interface IDiscount
    {
        void ProcessForDiscounts(IShoppingCart shoppingBasket);
    }
}
