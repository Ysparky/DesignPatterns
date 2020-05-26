using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Decorator2
{
    class Marfil : Decorator
    {
        public Marfil(Player player) : base(player) { }
        public override double calcularFuerzaDeAtaque()
        {
            return base.calcularFuerzaDeAtaque() - (base.calcularFuerzaDeAtaque()*0.15);
        }

    }
    class Oro : Decorator
    {
        public Oro(Player player) : base(player) { }
        public override double calcularFuerzaDeAtaque()
        {
            return base.calcularFuerzaDeAtaque() - (base.calcularFuerzaDeAtaque() * 0.40);
        }
    }
    class Rubi : Decorator
    {
        public Rubi(Player player) : base(player) { }
        public override double calcularFuerzaDeAtaque()
        {
            return base.calcularFuerzaDeAtaque() - (base.calcularFuerzaDeAtaque() * 1);
        }
    }
    class Esmeralda : Decorator
    {
        public Esmeralda(Player player) : base(player) { }
        public override double calcularFuerzaDeAtaque()
        {
            return base.calcularFuerzaDeAtaque() - (base.calcularFuerzaDeAtaque() * 0.15);
        }
    }
    class Diamante : Decorator
    {
        public Diamante(Player player) : base(player) { }
        public override double calcularFuerzaDeAtaque()
        {
            return base.calcularFuerzaDeAtaque() - (base.calcularFuerzaDeAtaque() * 0.5);
        }
    }
}
