using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class NonVegeterianPizza:IPizzaVarietyContract
    {
        Pizza pizza = new Pizza();

        List<Pizza> nonvegPizza = new List<Pizza>();
        public List<Pizza> AvailablePizza()
        {
            pizza.PizzaName = "chickencrustcheese";
            pizza.Size.Prize = 450;
            pizza.Size.Shape = "Medium";
            nonvegPizza.Add(pizza);

            return nonvegPizza;

        }
    }
}
