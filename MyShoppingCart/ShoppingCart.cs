using MyShoppingCart.Discount;
using System.Collections.Generic;
using System.Linq;

namespace MyShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        public IList<IShoppingCartItem> _itemsInCart = new List<IShoppingCartItem>();
        private IList<IDiscount> _discounts;
        public ShoppingCart(IList<IDiscount> offers = null)
        {
            _discounts = offers;
        }

        public IList<IShoppingCartItem> ItemsInBasket { get { return _itemsInCart; } }

        //private IList<IOffer> _offers;
        public void AddShoppingItem(IShoppingCartItem item)
        {
            _itemsInCart.Add(item);
        }

        public decimal GetTotalPrice()
        {
            if (_discounts != null)
            {
                foreach (IDiscount offer in _discounts)
                {
                    offer.ProcessForDiscounts(this);
                }
            }
            else
            {
                foreach (IShoppingCartItem item in _itemsInCart)
                {
                    item.UpdatePrice(1);
                }
            }

            return _itemsInCart.Select(i => i.Price).Sum();
        }

        public void RemoveShoppingItem(IShoppingCartItem item)
        {
            _itemsInCart.Remove(item);
        }
    }
}
