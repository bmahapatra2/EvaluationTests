using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderContract;
using PizzaEntity;

namespace OrderProcessingUnit
{
    public class VegeterianPizza : IPizzaVarietyContract
    {
        Pizzaa pizza1 = new Pizzaa();
        Size size = new Size();
        List<Pizzaa> vegPizza = new List<Pizzaa>();
        public List<Pizzaa> AvailablePizza()
        {
            pizza1.PizzaName = "mozerella";
            pizza1.Size = new Size() { Shape = "Large", Price = 250 };
           

            vegPizza.Add(pizza1);

            return vegPizza;
        }
    }
}
