using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Memento
{
    public partial class Form1 : Form
    {
        Guardian guard = new Guardian();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            guardarEstado(gbColores.BackColor, lblColor.Text);
            setColors(Color.Red, "Rojo");                       
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Memento memento = guard.doPop();
            setColors(memento.getColor(), memento.getTexto());
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            guardarEstado(gbColores.BackColor, lblColor.Text);
            setColors(Color.Blue, "Azul");
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            guardarEstado(gbColores.BackColor, lblColor.Text);
            setColors(Color.Green, "Verde");
        }

        public void guardarEstado(Color color, string text)
        {
            Memento m = new Memento(color, text);
            guard.doPush(m);
        }

        public void setColors(Color color, string text)
        {
            lblColor.Text = text;
            gbColores.BackColor = color;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Z))
            {
                Memento memento = guard.doPop();
                setColors(memento.getColor(), memento.getTexto());
            }
        }
    }
}
