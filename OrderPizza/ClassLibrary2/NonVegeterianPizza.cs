using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderContract;

namespace PizzaEntity
{
    public class NonVegeterianPizza:IPizzaVarietyContract
    {
        Pizzaa pizza2 = new Pizzaa();
   
        List<Pizzaa> nonvegPizza = new List<Pizzaa>();
        public List<Pizzaa> AvailablePizza()
        {
            pizza2.PizzaName = "chickencrustcheese";
            pizza2.Size = new Size() { Shape = "Medium", Price = 350 };
                ;
            nonvegPizza.Add(pizza2);

            return nonvegPizza;

        }
    }
}
