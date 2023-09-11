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
            int idS = Convert.ToInt32(txtCoursesIdSubject.Text);
            int idC = Convert.ToInt32(txtCoursesIdCommission.Text);
            int cy = Convert.ToInt32(txtCoursesCalendarYear.Text);
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
            }
            else
            {
                MessageBox.Show("Id ingresados no validos");
            }
            this.Close();


        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            int idC = Convert.ToInt32(txtIdCourse.Text);
            int idS = Convert.ToInt32(txtCoursesIdSubject.Text);
            int idCc = Convert.ToInt32(txtCoursesIdCommission.Text);
            int cy = Convert.ToInt32(txtCoursesCalendarYear.Text);
            int q = Convert.ToInt32(txtCoursesQuota.Text);

            Negocio.Subjects s = new Negocio.Subjects();
            Entidades.Subjects sub = s.GetOne(idS);

            Negocio.Commissions c = new Negocio.Commissions();
            Entidades.Commissions com = c.GetOne(idCc);

            if (com.IdCommission != 0 && sub.IdSubject != 0)
            {
                Negocio.Courses course = new Negocio.Courses();
                course.UpdateCourse(idC, idS, idCc, cy, q);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("Id ingresados no validos");
            }
            this.Close();

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            int idC = Convert.ToInt32(txtIdCourse.Text);
            Negocio.Courses c = new Negocio.Courses();

            Negocio.StudentsRegistrations str = new Negocio.StudentsRegistrations();
            int s = str.GetStudentsRegByIdCourse(idC);

            Negocio.TeacherCourses tc = new Negocio.TeacherCourses();
            int t = tc.GetTeacherCoursesByIdCourse(idC);

            if (s == 0 && t == 0)
            {
                Negocio.Courses course = new Negocio.Courses();
                course.Delete(idC);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede eliminar el curso, ya que tiene uno o varios profesores o inscripciones activas.");
                this.Close();
            }
        }
    }
}
