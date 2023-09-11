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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UIDesktop
{
    public partial class frmUserLogIn : Form
    {
        public int cont;
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
            if (this.cont != 0)
            {
                string nom = Convert.ToString(txtUserName.Text);
                string pass = Convert.ToString(txtUserPassword.Text);

                Negocio.Users u = new Negocio.Users();
                int privilege = u.ValidateUser(nom, pass);

                if (privilege != 0)
                {
                    int idPerson = u.GetIdPerson(nom, pass);
                    frmMain frmMain = new frmMain(idPerson, privilege);
                    frmMain.ShowDialog();
                    this.Close();
                    return;
                }
                else 
                {
                    txtUserName.Text = "";
                    txtUserPassword.Text = "";
                    MessageBox.Show("Usuario o contraseña incorrectos, intente nuevamente, le quedan " + this.cont.ToString() + " intentos");
                    this.cont--;
                }

            }
            else 
            {
                this.Close();
            }
        }

        private void frmUserLogIn_Load(object sender, EventArgs e)
        {
            this.cont = 2;

        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserSignUp frmUserSignUp = new frmUserSignUp();
            frmUserSignUp.ShowDialog();
        }
    }
}
