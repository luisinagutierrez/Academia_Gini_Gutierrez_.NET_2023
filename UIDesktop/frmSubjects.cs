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

            Negocio.Plans nPlan = new Negocio.Plans();
            List<Entidades.Plans> Pl = nPlan.GetAll();
            cBoxIdPlan.DataSource = Pl;
            cBoxIdPlan.DisplayMember = "IdPlan";
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
            }
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            if (txtIdSubject.Text != "")
            {
                MessageBox.Show("El campo IdSubject debe estar vacio para dar de alta una nueva materia.");
                return;
            }
            if (cBoxIdPlan.Text == "")
            {
                MessageBox.Show("El campo IdPlan no puede estar vacio");
                return;
            }
            int idP = Convert.ToInt32(cBoxIdPlan.Text);
            if (txtSubjectDescription.Text == "")
            {
                MessageBox.Show("El campo Descripcion no puede estar vacio");
                return;
            }
            string descrip = Convert.ToString(txtSubjectDescription.Text);
            if (txtSubjectsTotalHours.Text == "")
            {
                MessageBox.Show("El campo Horas totales no puede estar vacio");
                return;
            }
            int ths = Convert.ToInt32(txtSubjectsTotalHours.Text);
            if (txtSubjectsWeeklyHours.Text == "")
            {
                MessageBox.Show("El campo Horas semanales no puede estar vacio");
                return;
            }
            int whs = Convert.ToInt32(txtSubjectsWeeklyHours.Text);

            Negocio.Plans p = new Negocio.Plans();
            Entidades.Plans pl = p.GetOne(idP);

            if (pl.IdPlan != 0)
            {
                Negocio.Subjects sub = new Negocio.Subjects();
                sub.Add(idP, descrip, ths, whs);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("El Id del plan no fue encontrado");
            }
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            if (txtIdSubject.Text == "")
            {
                MessageBox.Show("El campo IdSubject no puede estar vacio");
                return;
            }
            int idS = Convert.ToInt32(txtIdSubject.Text);
            if (cBoxIdPlan.Text == "")
            {
                MessageBox.Show("El campo IdPlan no puede estar vacio");
                return;
            }
            int idP = Convert.ToInt32(cBoxIdPlan.Text);
            if (txtSubjectDescription.Text == "")
            {
                MessageBox.Show("El campo Descripcion no puede estar vacio");
                return;
            }
            string descrip = Convert.ToString(txtSubjectDescription.Text);
            if (txtSubjectsTotalHours.Text == "")
            {
                MessageBox.Show("El campo Horas totales no puede estar vacio");
                return;
            }
            int ths = Convert.ToInt32(txtSubjectsTotalHours.Text);
            if (txtSubjectsWeeklyHours.Text == "")
            {
                MessageBox.Show("El campo Horas semanales no puede estar vacio");
                return;
            }
            int whs = Convert.ToInt32(txtSubjectsWeeklyHours.Text);

            Negocio.Plans p = new Negocio.Plans();
            Entidades.Plans pl = p.GetOne(idP);
            Negocio.Subjects nS = new Negocio.Subjects();
            Entidades.Subjects subject = nS.GetOne(idS);

            if (subject.IdSubject == 0)
            {
                MessageBox.Show("El Id de la materia no fue encontrado");
                return;
            }
            if (pl.IdPlan != 0)
            {
                Negocio.Subjects sub = new Negocio.Subjects();
                int rt = sub.Update(idS, descrip, ths, whs, idP);

                if (rt != 0)
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
            this.Close();
        }

        private void dgvSubjects_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada
            if (dgvSubjects.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dgvSubjects.SelectedRows[0];

                // Accede a las celdas de la fila y asigna sus valores a los TextBox
                txtIdSubject.Text = selectedRow.Cells["IdSubject"].Value.ToString();
                txtSubjectDescription.Text = selectedRow.Cells["SubjectDescription"].Value.ToString();
                txtSubjectsWeeklyHours.Text = selectedRow.Cells["WeeklyHours"].Value.ToString();
                txtSubjectsTotalHours.Text = selectedRow.Cells["TotalHours"].Value.ToString();
                cBoxIdPlan.Text = selectedRow.Cells["IdPlan"].Value.ToString();
                // ... y así sucesivamente para cada TextBox y columna que desees mostrar
            }
            else
            {
                // Si no hay filas seleccionadas, borra los TextBox
                txtIdSubject.Text = "";
                txtSubjectDescription.Text = "";
                txtSubjectsWeeklyHours.Text = "";
                txtSubjectsTotalHours.Text = "";
                cBoxIdPlan.Text = "";
                // ... y así sucesivamente para cada TextBox que desees borrar
            }
        }
    }
}
