using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Decorator
{
    public partial class Form1 : Form
    {
        Pizza miPizza;
        public Form1()
        {
            InitializeComponent();
            lblPrecio.Text = "Precio";
        }

        private void cbAnchoas_CheckedChanged(object sender, EventArgs e)
        {
            miPizza = new Anchoas(miPizza);
        }

        private void cbQueso_CheckedChanged(object sender, EventArgs e)
        {
            miPizza = new Queso(miPizza);
        }

        private void cbPiña_CheckedChanged(object sender, EventArgs e)
        {
            miPizza = new Piña(miPizza);
        }

        private void cbJalapeño_CheckedChanged(object sender, EventArgs e)
        {
            miPizza = new Jalapeño(miPizza);
        }

        private void cbChorizo_CheckedChanged(object sender, EventArgs e)
        {
            miPizza = new Chorizo(miPizza);
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            lblPrecio.Text = "S/ " + miPizza.Precio().ToString();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            miPizza = new BaseJamon();
            cbChorizo.Checked = false;
            cbAnchoas.Checked = false;
            cbJalapeño.Checked = false;
            cbPiña.Checked = false;
            cbQueso.Checked = false;
        }
    }
}
