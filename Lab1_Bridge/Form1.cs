using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Bridge
{
    public partial class Form1 : Form
    {
        AbstractionClass abstractionClass;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbDDMMAA_CheckedChanged(object sender, EventArgs e)
        {
            abstractionClass = new AbstractionClass(new DDMMAA());
        }

        private void rbBE_CheckedChanged(object sender, EventArgs e)
        {
            abstractionClass = new AbstractionClass(new BigEndian());

        }

        private void rbMMDDAA_CheckedChanged(object sender, EventArgs e)
        {
            abstractionClass = new AbstractionClass(new MMDDAA());
        }

        private void btnAyer_Click(object sender, EventArgs e)
        {
            txtResult.Text = abstractionClass.Ayer();
        }

        private void btnManiana_Click(object sender, EventArgs e)
        {
            txtResult.Text = abstractionClass.Maniana();
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            txtResult.Text = abstractionClass.Hoy();
        }
    }
}
