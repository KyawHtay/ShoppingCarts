using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShoppingCart.Discount;
using MyShoppingCart.Items;
using System.Collections.Generic;

namespace MyShoppingCart.Tests
{
    [TestClass]
    public class MyShoppingCartTests
    {
        [TestMethod]
        public void GetTotalPrice_OneBreadOneButterOneMilk_Pass()
        {
            // Arrange
            List<IDiscount> discounts = new List<IDiscount>();
            discounts.Add(new ButterDiscount());
            discounts.Add(new MilkDiscount());

            IShoppingCart basket = new ShoppingCart(discounts);
            basket.AddShoppingItem(new ShoppingCartItem(new Bread(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Butter(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 1));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(2.95m, total);
        }
        [TestMethod]
        public void GetTotalPrice_OneBreadOneButterOneMilkNoDiscount_Pass()
        {
            // Arrange
            IShoppingCart basket = new ShoppingCart();
            basket.AddShoppingItem(new ShoppingCartItem(new Bread(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Butter(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 1));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(2.95m, total);
        }

      
        [TestMethod]
        public void GetTotalPrice_TwoButtersTwoBreads_Pass()
        {
            // Arrange
            List<IDiscount> offers = new List<IDiscount>();
            offers.Add(new ButterDiscount());
            offers.Add(new MilkDiscount());

            IShoppingCart basket = new ShoppingCart(offers);
            basket.AddShoppingItem(new ShoppingCartItem(new Bread(), 2));
            basket.AddShoppingItem(new ShoppingCartItem(new Butter(), 2));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(3.10m, total);
        }
        [TestMethod]
        public void GetTotalPrice_OneButterOneButterTwoBreads_Pass()
        {
            // Arrange
            List<IDiscount> offers = new List<IDiscount>();
            offers.Add(new ButterDiscount());
            offers.Add(new MilkDiscount());

            IShoppingCart basket = new ShoppingCart(offers);
            basket.AddShoppingItem(new ShoppingCartItem(new Bread(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Bread(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Butter(), 2));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(3.10m, total);
        }

        [TestMethod]
        public void GetTotalPrice_FourMilks_Pass()
        {
            // Arrange
            List<IDiscount> discounts = new List<IDiscount>();
            discounts.Add(new ButterDiscount());
            discounts.Add(new MilkDiscount()); 

            IShoppingCart basket = new ShoppingCart(discounts);
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 4));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(3.45m, total);
        }
        [TestMethod]
        public void GetTotalPrice_OneMilkthreeMilks_Pass()
        {
            // Arrange
            List<IDiscount> discounts = new List<IDiscount>();
            discounts.Add(new ButterDiscount());
            discounts.Add(new MilkDiscount());

            IShoppingCart basket = new ShoppingCart(discounts);
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 3));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(3.45m, total);
        }
        [TestMethod]
        public void GetTotalPrice_TwoButtersOneBreadEightMilks_Pass()
        {
            // Arrange
            List<IDiscount> discounts = new List<IDiscount>();
            discounts.Add(new ButterDiscount());
            discounts.Add(new MilkDiscount());

            IShoppingCart basket = new ShoppingCart(discounts);
            basket.AddShoppingItem(new ShoppingCartItem(new Butter(), 2));
            basket.AddShoppingItem(new ShoppingCartItem(new Bread(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 8));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(9, total);
        }

        [TestMethod]
        public void GetTotalPrice_OneButterOneButterOneBreadEightMilks_Pass()
        {
            // Arrange
            List<IDiscount> discounts = new List<IDiscount>();
            discounts.Add(new ButterDiscount());
            discounts.Add(new MilkDiscount());

            IShoppingCart basket = new ShoppingCart(discounts);
            basket.AddShoppingItem(new ShoppingCartItem(new Butter(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Butter(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Bread(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 8));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(9, total);
        }

        [TestMethod]
        public void GetTotalPrice_TwoButtersOneBreadSevenMilkOneMilk_Pass()
        {
            // Arrange
            List<IDiscount> discounts = new List<IDiscount>();
            discounts.Add(new ButterDiscount());
            discounts.Add(new MilkDiscount());

            IShoppingCart basket = new ShoppingCart(discounts);
            basket.AddShoppingItem(new ShoppingCartItem(new Butter(), 2));
            basket.AddShoppingItem(new ShoppingCartItem(new Bread(), 1));
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 7));
            basket.AddShoppingItem(new ShoppingCartItem(new Milk(), 1));

            // Act
            decimal total = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(9, total);
        }

    }
}
