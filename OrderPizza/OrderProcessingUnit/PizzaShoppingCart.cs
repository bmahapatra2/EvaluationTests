using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaEntity;
using PizzaOrderContract;

namespace OrderProcessingUnit
{
    public class PizzaShoppingCart

    {
        NonVegeterianPizza nonvegpizza = new NonVegeterianPizza();

        VegeterianPizza vegpizza = new VegeterianPizza();

        public List<Pizzaa> TotalOrderedPizza = new List<Pizzaa>();

    

        public int AddedPizzaToCart()
       {
            TotalOrderedPizza.AddRange(nonvegpizza.AvailablePizza());
            TotalOrderedPizza.AddRange(vegpizza.AvailablePizza());

            return TotalOrderedPizza.Count();
       }
       
        public List<Pizzaa> PizzaDetails()
        {
            AddedPizzaToCart();
            return TotalOrderedPizza;
        }

        public bool ValidationOnOrder()

        { 
            
            if ( AddedPizzaToCart()>=2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
}
