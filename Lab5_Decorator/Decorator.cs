using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Decorator
{
    public abstract class Decorator : Pizza
    {
        private Pizza miPizza;
        public Decorator(Pizza miPizza)
        {
            this.miPizza = miPizza;
        }
        public override double Precio()
        {
            if (miPizza != null)
            {
                return miPizza.Precio();
            }
            else
            {
                return 0.00;
            }
        }
    }
}
