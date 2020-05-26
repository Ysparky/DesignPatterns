using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Decorator2
{
    public abstract class Decorator : Player
    {
        Player _player;
        public Decorator(Player player)
        {
            _player = player;
        }
        public override double calcularFuerzaDeAtaque()
        {
            return _player.calcularFuerzaDeAtaque();
        }
    }
}
