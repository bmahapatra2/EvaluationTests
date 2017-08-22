using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Pizza
    {
        public string PizzaName { get; set; }

        public Size Size { get; set; }

        public Pizza()
        {
            new Size();
        }
    }
}
