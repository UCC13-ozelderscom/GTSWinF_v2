using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTSWinF_v2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThesis frmThesis = new frmThesis();
            frmThesis.ShowDialog();
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTQuery frmTQuery = new frmTQuery();
            frmTQuery.ShowDialog();
        }

        private void universityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUniv frmUniv = new frmUniv();

            frmUniv.ShowDialog();
        }
    }
}
