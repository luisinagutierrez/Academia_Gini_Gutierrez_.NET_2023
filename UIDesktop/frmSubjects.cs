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
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }

        private void frmCreateAndUpdateSubjects_Load(object sender, EventArgs e)
        {
            Negocio.Subjects nSubjects = new Negocio.Subjects();
            List<Entidades.Subjects> SubjectsList = nSubjects.GetAll();
            dgvSubjects.DataSource = SubjectsList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbSubjectsWeeklyHours_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            int idS = Convert.ToInt32(txtIdSubject.Text);

            Negocio.Courses nC = new Negocio.Courses();
            int c = nC.GetCoursesByIdSubject(idS);
            if (c == 0)
            {
                Negocio.Subjects nS = new Negocio.Subjects();
                nS.Delete(idS);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede eliminar la materia, ya que tiene uno o varios curso/s asociado/s.");
                this.Close();
            }
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {

            int idP = Convert.ToInt32(txtSubjectsPlan.Text);
            string descrip = Convert.ToString(txtSubjectDescription.Text);
            int ths = Convert.ToInt32(txtSubjectsTotalHours.Text);
            int whs = Convert.ToInt32(txtSubjectsWeeklyHours.Text);

            Negocio.Plans p = new Negocio.Plans();
            Entidades.Plans pl = p.GetOne(idP);
            MessageBox.Show("id plan " + pl.ToString());

            if (pl.IdPlan != 0)
            {
                Negocio.Subjects sub = new Negocio.Subjects();
                sub.Add(idP, descrip, ths, whs);
                MessageBox.Show("Operación exitosa");
            }
            else
            {
                MessageBox.Show("El Id del plan no fue encontrado");
            }
            this.Close();
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            int idS = Convert.ToInt32(txtIdSubject.Text);
            int idP = Convert.ToInt32(txtSubjectsPlan.Text);
            string descrip = Convert.ToString(txtSubjectDescription.Text);
            int ths = Convert.ToInt32(txtSubjectsTotalHours.Text);
            int whs = Convert.ToInt32(txtSubjectsWeeklyHours.Text);

            Negocio.Plans p = new Negocio.Plans();
            Entidades.Plans pl = p.GetOne(idP);
            MessageBox.Show("id plan que encuentra " + pl.IdPlan.ToString());

            if (pl.IdPlan != 0)
            {
                Negocio.Subjects sub = new Negocio.Subjects();
                int sb = sub.Update(idS, descrip, ths, whs, idP);
                MessageBox.Show("ide manteria que euncuentea " + sb.ToString());
                if (sb > 0)
                {
                    MessageBox.Show("Se actualizó la materia correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la materia.");
                }
            }
            else
            {
                MessageBox.Show("El Id del plan no fue encontrado");
            }
        }
    }
}
