using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            if (nom == "hola" & pass == "hola")
            {
                frmAdminMainMenu frmAdminMainMenu = new frmAdminMainMenu();
                frmAdminMainMenu.ShowDialog();
            }
            //    // si se verifica q coincide nombre y contra y la ingreso menos de 3 veces 
            //    int cont = 0;
            //    while (cont < 3)
            //    {
            //        Negocio.Users u = Negocio.Users.ValidateUser(nom), pass);
            //        cont++;
            //        if (u != null)
            //        {
            //            //hay que buscar desde el idperson el typeperson que es
            //            int typeP = new Negocio.People.GetPersonType(u.idPerson);
            //            switch (typeP)
            //            {
            //                case 1:
            //                    {
            //                        frmTeacherMainMenu frmTeacherMainMenu = new frmTeacherMainMenu();
            //                        frmTeacherMainMenu.ShowDialog();
            //                        break;
            //                    }
            //                case 2:
            //                    {
            //frmStudentRegistration frmStudentRegistration = new frmStudentRegistration();
            //frmStudentRegistration.ShowDialog();
            //                        break;
            //                    }
            //            }
            //        }
            //    }
        }

        private void frmUserLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
