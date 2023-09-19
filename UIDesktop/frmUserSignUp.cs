using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class frmUserSignUp : Form
    {
        public frmUserSignUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUserSignUpCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserSignUpAccept_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtUserPassword.Text == "" || txtPersonEmail.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            string email = Convert.ToString(txtPersonEmail.Text);
            Negocio.People p = new Negocio.People();
            int idP = p.GetIdPersonByEmail(email);
            if (idP != 0)
            {
                Negocio.Users user = new Negocio.Users();
                int u = user.GetUserByIdPerson(idP);
                if (u == 0)
                {
                    string name = Convert.ToString(txtUserName.Text);
                    string pass = Convert.ToString(txtUserPassword.Text);
                    int privilege = p.GetPersonType(idP);
                    user.Add(idP, privilege, name, pass);
                    MessageBox.Show("Operacion exitosa");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Ya tiene un usuario asociado");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No existe una persona con ese email");
            }
        }
    }
}
