using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Memento
{
    class Memento
    {
        Color color;
        String texto;

        public Memento(Color color, String texto) {
            this.color = color;
            this.texto = texto;
        }

        public String getTexto() { return texto; }

        public void setTexto(String texto) { this.texto = texto; }

        public Color getColor() { return color; }

        public void setColor(Color color) { this.color = color; }
    }
}
