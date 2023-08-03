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
            // si se verifica q coincide nombre y contra y la ingreso menos de 3 veces 
            frmStudentRegistration frmStudentRegistration = new frmStudentRegistration();
            frmStudentRegistration.ShowDialog();
        }

        private void frmUserLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
