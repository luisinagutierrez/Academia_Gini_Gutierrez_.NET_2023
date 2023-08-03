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
    public partial class frmAdminLogIn : Form
    {
        public frmAdminLogIn()
        {
            InitializeComponent();
        }

        private void btnLogInAdminCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogInAdminAccept_Click(object sender, EventArgs e)
        {
            frmAdminMainMenu frmAdminMainMenu = new frmAdminMainMenu();
            frmAdminMainMenu.ShowDialog();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
