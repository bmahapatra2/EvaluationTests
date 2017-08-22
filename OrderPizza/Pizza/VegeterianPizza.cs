using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class VegeterianPizza : IPizzaVarietyContract
    {
        Pizza pizza = new Pizza();

        List<Pizza> vegPizza = new List<Pizza>();
        public List<Pizza> AvailablePizza()
        {
            pizza.PizzaName = "mozerella";
            pizza.Size.Prize = 150;
            pizza.Size.Shape = "Large";

            vegPizza.Add(pizza);

            return vegPizza;
        }
    }
}
