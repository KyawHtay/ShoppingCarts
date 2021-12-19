using MyShoppingCart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingCart
{
    public class ShoppingCartItem : IShoppingCartItem
    {
        private IProduct _product;
        private int _quantity;
        private decimal _itemPrice;
        public ShoppingCartItem(IProduct product, int quantity)
        {
            _product = product;
            _quantity = quantity;

            _itemPrice = _product.Price * Quantity;
        }

        public IProduct Product { get { return _product; } }

        public int Quantity { get { return _quantity; } }

        public decimal Price { get { return _itemPrice; } }

        public decimal UpdatePrice(decimal discount, int quantity = 0)
        {
            int discountedQuantity = quantity < Quantity ? quantity : Quantity;

            _itemPrice = (Product.Price * discountedQuantity * discount) + (Product.Price * (Quantity - discountedQuantity));

            return _itemPrice;
        }
    }
}
