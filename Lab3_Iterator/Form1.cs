using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Iterator
{
    public partial class Form1 : Form
    {
        Iterator iterator;
        public Form1()
        {
            InitializeComponent();
            iterator = new Iterator(MiListBox);
        }

        private void txtTop_Click(object sender, EventArgs e)
        {
            txtResult.Text = iterator.getTop();
        }

        private void txtBottom_Click(object sender, EventArgs e)
        {
            txtResult.Text = iterator.getBottom();
        }

        private void txtNext_Click(object sender, EventArgs e)
        {
            txtResult.Text = iterator.getNext();
        }

        private void txtPrevious_Click(object sender, EventArgs e)
        {
            txtResult.Text = iterator.getPrevious();
        }

        private void txtCentral_Click(object sender, EventArgs e)
        {
            txtResult.Text = iterator.getCentral();
        }
    }
}
