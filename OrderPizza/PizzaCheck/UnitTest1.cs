using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaEntity;
using PizzaOrderContract;
using OrderProcessingUnit;

namespace PizzaCheck
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Order_In_Cart()
        {
            PizzaShoppingCart cart = new PizzaShoppingCart();
            Assert.AreEqual(2, cart.AddedPizzaToCart());

        }

        [TestMethod]
        public void Content_In_Cart()
        {
            PizzaShoppingCart cart = new PizzaShoppingCart();
            int totalPrice = 0;
            cart.AddedPizzaToCart();
             foreach (var pizza in cart.TotalOrderedPizza)
            {
                totalPrice +=pizza.Size.Price;
            }

            //int am = cart.PizzaDetails()[0].Size.Price;
            Assert.AreEqual(600, totalPrice);

        }

        [TestMethod]
        public void Validation_Of_Order_Number()
        {
            PizzaShoppingCart cart = new PizzaShoppingCart();
            Assert.AreEqual(true, cart.ValidationOnOrder());
        }
    }
}
