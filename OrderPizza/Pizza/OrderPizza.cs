using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class OrderPizza
    {
        public IPizzaVarietyContract PizzaOrder(string type)
        {
            if (type.Equals("veg"))
            {
                VegeterianPizza veg = new VegeterianPizza();
                return veg;
            }

            else if (type.Equals("nonveg"))
            {
                NonVegeterianPizza nonveg = new NonVegeterianPizza();
                return nonveg;
            }
            return null;
        }
    }
}
