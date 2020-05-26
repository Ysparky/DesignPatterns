using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Decorator
{
    class Anchoas : Decorator
    {
        public Anchoas(Pizza miPizza) : base(miPizza) { }
        public override double Precio()
        {
            return base.Precio() + 6.00;
        }
    }
    class Chorizo : Decorator
    {
        public Chorizo(Pizza miPizza) : base(miPizza) { }
        public override double Precio()
        {
            return base.Precio() + 3.50;
        }
    }
    class Queso : Decorator
    {
        public Queso(Pizza miPizza) : base(miPizza) { }
        public override double Precio()
        {
            return base.Precio() + 5.00;
        }
    }
    class Piña : Decorator
    {
        public Piña(Pizza miPizza) : base(miPizza) { }
        public override double Precio()
        {
            return base.Precio() + 2.00;
        }
    }
    class Jalapeño : Decorator
    {
        public Jalapeño(Pizza miPizza) : base(miPizza) { }
        public override double Precio()
        {
            return base.Precio() + 4;
        }
    }
}
