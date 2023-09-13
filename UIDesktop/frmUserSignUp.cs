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
            int idP = Convert.ToInt32(txtIdPerson.Text);
            Negocio.Users user = new Negocio.Users();      //NO LO TIENE QUE ENCONTRAR PARA ENTRAR AL IF Y AGREGAR UNO NUEVO
            int u = user.GetUserByIdPerson(idP);
            if (u == 0)
            {
                string name = Convert.ToString(txtUserName.Text);
                string pass = Convert.ToString(txtUserPassword.Text);
                Negocio.People p = new Negocio.People();
                int privilege = p.GetPersonType(idP);  // BUSCO EL PRIVILEGIO 
                user.Add(idP, privilege, name, pass);
                MessageBox.Show("Operacion exitosa");
                this.Close();

            }
            else
            {
                MessageBox.Show("Ya tiene un usuario asociado");      //FUNCIONA
                this.Close();
            }
            ///VALIDAR QUE EXISTA EL ID DE PERSONA NECESITO EL PRIVILEGIO PARA DARSELO AL USER
            ///VALIDA QUE NO TIENE YA UN USUARIO ASOCIADO 
            ///ADD USER 
        }
    }
}
