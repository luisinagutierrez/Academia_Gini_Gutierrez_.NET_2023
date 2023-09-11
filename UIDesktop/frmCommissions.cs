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
            int idC = Convert.ToInt32(txtIdCommission.Text);
            int idP = Convert.ToInt32(txtCommissionPlan.Text);
            string descrip = Convert.ToString(txtCommissionDescription.Text);
            int y = Convert.ToInt32(txtCommissionSpecialityYear.Text);

            Negocio.Plans p = new Negocio.Plans();
            Entidades.Plans pl = p.GetOne(idP);

            if (pl.IdPlan != 0)
            {
                Negocio.Commissions com = new Negocio.Commissions();
                int co = com.UpdateCommission(idC, descrip, y, idP);
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
            Negocio.Courses nCourses = new Negocio.Courses();
            int c = nCourses.GetCoursesByIdCommission(idC);
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
}
