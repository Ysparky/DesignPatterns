using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Decorator2
{
    class Attack : Player
    {
        double _daño;
        public Attack(double daño)
        {
            _daño = daño;
        }
        public override double calcularFuerzaDeAtaque()
        {
            return _daño;
        }
    }
}
