using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class PizzaShoppingCart

    {
        NonVegeterianPizza nonvegpizza = new NonVegeterianPizza();

        VegeterianPizza vegpizza = new VegeterianPizza();

        public List<Pizza> TotalOrderedPizza = new List<Pizza>();

        Pizza pizza = new Pizza();

        public int AddedPizzaToCart()
       {
            TotalOrderedPizza.AddRange(nonvegpizza.AvailablePizza());
            TotalOrderedPizza.AddRange(vegpizza.AvailablePizza());

            return TotalOrderedPizza.Count();
       }
       
        public List<Pizza> PizzaDetails()
        {
            AddedPizzaToCart();
            return TotalOrderedPizza;
        }

        

    }
}
