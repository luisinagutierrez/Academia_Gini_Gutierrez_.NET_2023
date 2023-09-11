using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace UIDesktop
{
    public partial class frmUserLogIn : Form
    {
        public frmUserLogIn()
        {
            InitializeComponent();
        }

        private void btnUserLogInCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbUserPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserPasswordChange frmUserPasswordChange = new frmUserPasswordChange();
            frmUserPasswordChange.ShowDialog();
        }

        private void btnUserLogInAccept_Click(object sender, EventArgs e)
        {
            string nom = Convert.ToString(txtUserName.Text);
            string pass = Convert.ToString(txtUserPassword.Text);

            int cont = 3;
            while (cont != 0)
            {
                Negocio.Users u = new Negocio.Users();
                int privilege = u.ValidateUser(nom, pass);
                
                if (privilege != 0)
                {
                    int idPerson = u.GetIdPerson(nom, pass);
                    frmMain frmMain = new frmMain(idPerson, privilege);
                    frmMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incrrectos,intente nuevamente, le quedan " + cont.ToString() +" intentos");
                    cont--;/// no sale del while ver
                }
            }
        }

        private void frmUserLogIn_Load(object sender, EventArgs e)
        {

        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserSignUp frmUserSignUp = new frmUserSignUp();
            frmUserSignUp.ShowDialog();
        }
    }
}
