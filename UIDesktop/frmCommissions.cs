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
    public partial class frmCommissions : Form
    {
        public frmCommissions()
        {
            InitializeComponent();
        }

        private void frmCreateAndUpdateCommissions_Load(object sender, EventArgs e)
        {
            Negocio.Commissions nCommissions = new Negocio.Commissions();
            List<Entidades.Commissions> CommissionsList = nCommissions.GetAll();
            dgvCommissions.DataSource = CommissionsList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCommissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCreateCommission_Click(object sender, EventArgs e)
        {
            if (txtIdCommission.Text != "")
            {
                MessageBox.Show("El campo IdCommission debe estar vacio para dar de alta una nueva comision.");
                return;
            }
            int idP = Convert.ToInt32(txtCommissionPlan.Text);
            string descrip = Convert.ToString(txtCommissionDescription.Text);
            int y = Convert.ToInt32(txtCommissionSpecialityYear.Text);

            Negocio.Plans p = new Negocio.Plans();
            Entidades.Plans pl = p.GetOne(idP);

            if (pl.IdPlan != 0)
            {
                Negocio.Commissions sub = new Negocio.Commissions();
                sub.Add(idP, descrip, y);
                MessageBox.Show("Operación exitosa");
            }
            else
            {
                MessageBox.Show("El Id del plan no fue encontrado");
            }
            this.Close();
        }

        private void btnUpdateCommission_Click(object sender, EventArgs e)
        {
            if(txtIdCommission.Text == "")
            {
                MessageBox.Show("El campo IdCommission no puede estar vacio");
                return;
            }
            int idC = Convert.ToInt32(txtIdCommission.Text);
            if (txtCommissionPlan.Text == "")
            {
                MessageBox.Show("El campo Plan no puede estar vacio");
                return;
            }
            int idP = Convert.ToInt32(txtCommissionPlan.Text);
            if(txtCommissionDescription.Text == "" || txtCommissionSpecialityYear.Text == "")
            {
                MessageBox.Show("El campo Descripcion o Año de especialidad no pueden estar vacios.");
                return;
            }
            string descrip = Convert.ToString(txtCommissionDescription.Text);
            int y = Convert.ToInt32(txtCommissionSpecialityYear.Text);

            Negocio.Plans p = new Negocio.Plans();
            Entidades.Plans pl = p.GetOne(idP);
            Negocio.Commissions nC = new Negocio.Commissions();
            Entidades.Commissions comi = nC.GetOne(idC);
            if(comi.IdCommission == 0)
            {
                MessageBox.Show("El Id de la comision no fue encontrado.");
                return;
            }
            if (pl.IdPlan != 0)
            {
                Negocio.Commissions com = new Negocio.Commissions();
                int co = com.Update(idC, descrip, y, idP);
                if (co != 0)
                {
                    MessageBox.Show("Se actualizó la comision correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la comision.");
                }
            }
            else
            {
                MessageBox.Show("El Id del plan no fue encontrado");
            }
            this.Close();
        }

        private void btnDeleteCommission_Click(object sender, EventArgs e)
        {
            int idC = Convert.ToInt32(txtIdCommission.Text);
            Negocio.Commissions nC = new Negocio.Commissions();
            Entidades.Commissions com = nC.GetOne(idC);
            Negocio.Courses nCourses = new Negocio.Courses();
            int c = nCourses.GetCoursesByIdCommission(idC);
            if (com.IdCommission == 0)
            {
                MessageBox.Show("El Id de la comision no fue encontrado");
                return;
            }
            else
            {
                if (c == 1)
                {
                    nC.Delete(idC);
                    MessageBox.Show("Operación exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar la comision, ya que tiene uno o varios curso/s asociado/s.");
                    this.Close();
                }
            }

        }

        private void dgvCommissions_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada
            if (dgvCommissions.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dgvCommissions.SelectedRows[0];

                // Accede a las celdas de la fila y asigna sus valores a los TextBox
                txtIdCommission.Text = selectedRow.Cells["IdCommission"].Value.ToString();
                txtCommissionDescription.Text = selectedRow.Cells["CommissionDescription"].Value.ToString();
                txtCommissionSpecialityYear.Text = selectedRow.Cells["SpecialityYear"].Value.ToString();
                txtCommissionPlan.Text = selectedRow.Cells["IdPlan"].Value.ToString();
                // ... y así sucesivamente para cada TextBox y columna que desees mostrar
            }
            else
            {
                // Si no hay filas seleccionadas, borra los TextBox
                txtIdCommission.Text = "";
                txtCommissionDescription.Text = "";
                txtCommissionSpecialityYear.Text = "";
                txtCommissionPlan.Text = "";
                // ... y así sucesivamente para cada TextBox que desees borrar
            }
        }
    }
}
