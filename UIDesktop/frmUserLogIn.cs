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

            int cont = 0;
            while (cont < 3)
            {
                Negocio.Users u = new Negocio.Users();
                int privilege = u.ValidateUser(nom, pass); 
                if (privilege != -1)
                {
                    switch (privilege)
                    {
                        case 1:
                            {
                                frmTeacherMainMenu frmTeacherMainMenu = new frmTeacherMainMenu();
                                frmTeacherMainMenu.ShowDialog();
                                break;
                            }
                        case 2:
                            {
                                frmStudentRegistration frmStudentRegistration = new frmStudentRegistration();
                                frmStudentRegistration.ShowDialog();
                                break;
                            }
                        case 3:
                            {
                                frmAdminMainMenu frmAdminMainMenu = new frmAdminMainMenu();
                                frmAdminMainMenu.ShowDialog();
                                break;
                            }

                    }

                }
                else 
                { // nom usuario o contra no validos
                    cont++;
                }
             }
        }

        private void frmUserLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
