using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Singleton
{
    public partial class Form1 : Form
    {
        Singleton instance = Singleton.getInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            txtResult.Text = instance.addCounter();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtResult.Text = instance.subtractCounter();
        }
    }
}
