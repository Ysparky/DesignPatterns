using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Decorator2
{
    public partial class Form1 : Form
    {
        Player player;
        public Form1()
        {
            InitializeComponent();
            lblPoder.Text = "Daño";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblPoder.Text = player.calcularFuerzaDeAtaque().ToString();
        }

        private void btnOtorgar_Click(object sender, EventArgs e)
        {
            player = new Attack(double.Parse(txtDaño.Text));
        }

        private void cbOro_CheckedChanged(object sender, EventArgs e)
        {
            player = new Oro(player);
        }

        private void cbRubi_CheckedChanged(object sender, EventArgs e)
        {
            player = new Rubi(player);
        }

        private void cbEsmeralda_CheckedChanged(object sender, EventArgs e)
        {
            player = new Esmeralda(player);
        }

        private void cbDiamante_CheckedChanged(object sender, EventArgs e)
        {
            player = new Diamante(player);
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            cbDiamante.Checked = false;
            cbEsmeralda.Checked = false;
            cbMarfil.Checked = false;
            cbOro.Checked = false;
            cbRubi.Checked = false;
            txtDaño.Clear();
        }
    }
}
