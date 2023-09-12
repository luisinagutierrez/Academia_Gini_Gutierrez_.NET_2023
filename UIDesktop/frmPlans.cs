using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UIDesktop
{
    public partial class frmPlans : Form
    {
        public frmPlans()
        {
            InitializeComponent();
        }

        private void brnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCreateAndUpdatePlans_Load(object sender, EventArgs e)
        {
            Negocio.Plans nPlans = new Negocio.Plans();
            List<Entidades.Plans> PlansList = nPlans.GetAll();
            dgvPlans.DataSource = PlansList;
        }

        private void btnCreatePlan_Click(object sender, EventArgs e)
        {
            if (txtPlanSpeciality.Text == "" || txtPlanDescription.Text == "")
            {
                MessageBox.Show("Para poder crear un nuevo plan debe ingresar su descripcion y el id de la especialidad");
                return;
            }
            int idS = Convert.ToInt32(txtPlanSpeciality.Text);
            string descrip = Convert.ToString(txtPlanDescription.Text);
            Negocio.Specialities s = new Negocio.Specialities();
            Entidades.Specialities sp = s.GetOne(idS);

            if (sp.IdSpeciality != 0)
            {
                Negocio.Plans p = new Negocio.Plans();
                p.Add(idS, descrip);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("El Id de la especialidad no fue encontrado");
            }

        }

        private void btnUpdatePlan_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(txtIdPlans.Text);
            int idS = Convert.ToInt32(txtPlanSpeciality.Text);
            string descrip = Convert.ToString(txtPlanDescription.Text);

            Negocio.Specialities s = new Negocio.Specialities();
            Entidades.Specialities sp = s.GetOne(idS);

            if (sp.IdSpeciality != 0)
            {
                Negocio.Plans p = new Negocio.Plans();
                int pl = p.Update(idP, descrip, idS);
                if (pl != 0)
                {
                    MessageBox.Show("Se actualizó el plan correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el plan.");
                }
            }
            else
            {
                MessageBox.Show("El Id de la especialidad no fue encontrado");
            }
        }

        private void btnDeletePlan_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(txtIdPlans.Text);
            Negocio.Plans plan = new Negocio.Plans();

            Negocio.Commissions c = new Negocio.Commissions();
            int com = c.GetCommissionsByIdPlan(idP);

            Negocio.People p = new Negocio.People();
            int pp = p.GetPeopleByIdPlan(idP);

            Negocio.Subjects s = new Negocio.Subjects();
            int sj = s.GetSubjectsByIdPlan(idP);

            if (sj == 0 && com == 0 && pp == 0)
            {
                int rtp = plan.Delete(idP);
                if (rtp != 0)
                {
                    MessageBox.Show("Operación exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Id plan ingresado no valido");
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar el plan dado que tiene materias, personas o comisiones en el que está asignado.");
            }
        }

        private void dgvPlans_SelectionChanged(object sender, EventArgs e)
        {
                if (dgvPlans.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPlans.SelectedRows[0];

                    txtIdPlans.Text = selectedRow.Cells["IdPlan"].Value.ToString();
                    txtPlanDescription.Text = selectedRow.Cells["PlanDescription"].Value.ToString();
                    txtPlanSpeciality.Text = selectedRow.Cells["IdSpeciality"].Value.ToString();
                }
                else
                {
                    txtIdPlans.Text = "";
                    txtPlanDescription.Text = "";
                    txtPlanSpeciality.Text = "";
                }

        }
    }
}
