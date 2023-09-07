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
    public partial class frmUserPasswordChange : Form
    {
        public frmUserPasswordChange()
        {
            InitializeComponent();
        }

        private void btnUserNewPasswordCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserNewPasswordAcept_Click(object sender, EventArgs e)
        {
            string nom = Convert.ToString(txtUserName.Text);
            string pass = Convert.ToString(txtUserNewPassword.Text);

            Negocio.Users u = new Negocio.Users();
            u.ChangePassword(nom, pass);
            MessageBox.Show("Se guardó la contraseña correctamente.");
            this.Close();
        }
    }
}
