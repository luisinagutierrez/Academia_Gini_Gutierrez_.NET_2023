using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class frmAdminMainMenu : Form
    {
        public frmAdminMainMenu()
        {
            InitializeComponent();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSpecialitiesList frmSpecialitiesList = new frmSpecialitiesList();
            frmSpecialitiesList.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSpecialitiesList frmSpecialitiesList = new frmSpecialitiesList();
            frmSpecialitiesList.ShowDialog();
        }
    }
}
