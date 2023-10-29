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
    public partial class frmUsersAdmin : Form
    {
        public frmUsersAdmin()
        {
            InitializeComponent();
        }

        private void brnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsersAdmin_Load(object sender, EventArgs e)
        {
            Negocio.Users nUsers = new Negocio.Users();
            List<Entidades.Users> UsersList = nUsers.GetAll();
            dgvUsers.DataSource = UsersList;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];

                // Accede a las celdas de la fila y asigna sus valores a los TextBox
                txtIdUser.Text = selectedRow.Cells["IdUser"].Value.ToString();
                txtUserName.Text = selectedRow.Cells["UserName"].Value.ToString();
                txtPassword.Text = selectedRow.Cells["Password"].Value.ToString();
                cBoxStatus.Text = selectedRow.Cells["Status"].Value.ToString();
                cBoxChangedPassword.Text = selectedRow.Cells["ChangePassword"].Value.ToString();
                txtIdPerson.Text = selectedRow.Cells["IdPerson"].Value.ToString();
                cBoxPrivilege.Text = selectedRow.Cells["Privilege"].Value.ToString();
                // ... y así sucesivamente para cada TextBox y columna que desees mostrar
            }
            else
            {
                // Si no hay filas seleccionadas, borra los TextBox
                txtIdUser.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
                cBoxStatus.Text = "";
                cBoxChangedPassword.Text = "";
                txtIdPerson.Text = "";
                cBoxPrivilege.Text = "";
                // ... y así sucesivamente para cada TextBox que desees borrar
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int idUser = Convert.ToInt32(txtIdUser.Text);
            string userName = Convert.ToString(txtUserName.Text);
            string password = Convert.ToString(txtPassword.Text);
            bool status = Convert.ToBoolean(cBoxStatus.Text);
            bool changePassword = Convert.ToBoolean(cBoxChangedPassword.Text);
            int idPerson = Convert.ToInt32(txtIdPerson.Text);
            int privilege = Convert.ToInt32(cBoxPrivilege.Text);

            Negocio.Users u = new Negocio.Users();
            int us = u.UpdateUser(idUser, userName, password, status, changePassword, idPerson, privilege);
            if (us == 1)
            {
                MessageBox.Show("Se actualizó el usuario correctamente.");
                dgvUsers.DataSource = u.GetAll();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int idU = Convert.ToInt32(txtIdUser.Text);
            Negocio.Users u = new Negocio.Users();
            if (idU != 22)
            {
                if (idU != 0)
                {
                    u.Delete(idU);
                    MessageBox.Show("Operación exitosa");
                    dgvUsers.DataSource = u.GetAll();
                }
                else
                {
                    MessageBox.Show("No fue posible eliminar el usuario");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar el usuario administrador");
                this.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
