using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;

namespace PizzaCheck
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Order_In_Cart()
        {
            PizzaShoppingCart cart = new PizzaShoppingCart();
            Assert.AreSame(2, cart.AddedPizzaToCart());

        }


        public void Content_In_Cart()
        {
            PizzaShoppingCart cart = new PizzaShoppingCart();
            cart.PizzaDetails();


        }
    }
}
