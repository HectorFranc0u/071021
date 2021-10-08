using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtest frmtest = new frmtest();
            frmtest.MdiParent = this;
            frmtest.Show();

        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreceta frmreceta = new frmreceta();
            frmreceta.MdiParent = this;
            frmreceta.Show();
        }
    }
}
