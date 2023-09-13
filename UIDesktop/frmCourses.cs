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
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCreateAndUpdateCourses_Load(object sender, EventArgs e)
        {
            Negocio.Courses nCourses = new Negocio.Courses();
            List<Entidades.Courses> CoursesList = nCourses.GetAll();
            dgvCourses.DataSource = CoursesList;
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            //txtIdCourse
            if (txtIdCourse.Text != "")
            {
                MessageBox.Show("El campo IdCourse debe estar vacio para dar de alta un nuevo curso.");
                return;
            }
            if (txtCoursesIdSubject.Text == "")
            {
                MessageBox.Show("El campo Id Materia no puede estar vacio");
                return;
            }
            int idS = Convert.ToInt32(txtCoursesIdSubject.Text);
            if (txtCoursesIdCommission.Text == "")
            {
                MessageBox.Show("El campo Id Comision no puede estar vacio");
                return;
            }
            int idC = Convert.ToInt32(txtCoursesIdCommission.Text);
            if (txtCoursesCalendarYear.Text == "")
            {
                MessageBox.Show("El campo año no puede estar vacio");
                return;
            }
            int cy = Convert.ToInt32(txtCoursesCalendarYear.Text);
            if (txtCoursesQuota.Text == "")
            {
                MessageBox.Show("El campo cupo no puede estar vacio");
                return;
            }
            int q = Convert.ToInt32(txtCoursesQuota.Text);

            Negocio.Subjects s = new Negocio.Subjects();
            Entidades.Subjects sub = s.GetOne(idS);

            Negocio.Commissions c = new Negocio.Commissions();
            Entidades.Commissions com = c.GetOne(idC);

            if (com.IdCommission != 0 && sub.IdSubject != 0)
            {
                Negocio.Courses course = new Negocio.Courses();
                course.Add(idS, idC, cy, q);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("Id ingresados no validos");
            }
            


        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            int idC = Convert.ToInt32(txtIdCourse.Text);
            if (txtCoursesIdSubject.Text == "")
            {
                MessageBox.Show("El campo Id Materia no puede estar vacio");
                return;
            }
            int idS = Convert.ToInt32(txtCoursesIdSubject.Text);
            if (txtCoursesIdCommission.Text == "")
            {
                MessageBox.Show("El campo Id Comision no puede estar vacio");
                return;
            }
            int idCc = Convert.ToInt32(txtCoursesIdCommission.Text);
            if (txtCoursesCalendarYear.Text == "")
            {
                MessageBox.Show("El campo año no puede estar vacio");
                return;
            }
            int cy = Convert.ToInt32(txtCoursesCalendarYear.Text);
            if (txtCoursesQuota.Text == "")
            {
                MessageBox.Show("El campo cupo no puede estar vacio");
                return;
            }
            int q = Convert.ToInt32(txtCoursesQuota.Text);

            Negocio.Subjects s = new Negocio.Subjects();
            Entidades.Subjects sub = s.GetOne(idS);

            Negocio.Commissions c = new Negocio.Commissions();
            Entidades.Commissions com = c.GetOne(idCc);
            Negocio.Courses nCourse = new Negocio.Courses();
            Entidades.Courses course = new Entidades.Courses();
            course = nCourse.GetOne(idC);

            if (course.IdCourse == 0)
            {
                MessageBox.Show("El Id del curso no fue encontrado");
                return;
            }
            if (com.IdCommission != 0 && sub.IdSubject != 0)
            {
                Negocio.Courses nCour = new Negocio.Courses();
                nCour.Update(idC, idS, idCc, cy, q);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("Id ingresados no validos");
            }
            
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            int idC = Convert.ToInt32(txtIdCourse.Text);
            Negocio.Courses c = new Negocio.Courses();

            Entidades.Courses course = c.GetOne(idC);
            if (course.IdCourse != 0)
            {
                Negocio.StudentsRegistrations str = new Negocio.StudentsRegistrations();
                int s = str.GetStudentsRegByIdCourse(idC);

                Negocio.TeacherCourses tc = new Negocio.TeacherCourses();
                int t = tc.GetTeacherCoursesByIdCourse(idC);

                if (s == 0 && t == 0)
                {
                    c.Delete(idC);
                    MessageBox.Show("Operación exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el curso, ya que tiene uno o varios profesores o inscripciones activas.");
                }
            }
            else { MessageBox.Show("Curso ingresado no valido"); }
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCourses.SelectedRows[0];

                txtIdCourse.Text = selectedRow.Cells["IdCourse"].Value.ToString();
                txtCoursesIdSubject.Text = selectedRow.Cells["IdSubject"].Value.ToString();
                txtCoursesIdCommission.Text = selectedRow.Cells["IdCommission"].Value.ToString();
                txtCoursesCalendarYear.Text = selectedRow.Cells["CalendarYear"].Value.ToString();
                txtCoursesQuota.Text = selectedRow.Cells["Quota"].Value.ToString();
            }
            else
            {
                txtIdCourse.Text = "";
                txtCoursesIdSubject.Text = "";
                txtCoursesIdCommission.Text = "";
                txtCoursesCalendarYear.Text = "";
                txtCoursesQuota.Text = "";
            }
        }
    }
}
