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
    public partial class frmTeacherMainMenu : Form
    {
        public int idPerson;
        public int idCourse;
        public frmTeacherMainMenu(int idPerson)
        {
            InitializeComponent();
            this.idPerson = idPerson;
        }

        private void frmTeacherMainMenu_Load(object sender, EventArgs e)
        {
            Negocio.TeacherCourses nTc = new Negocio.TeacherCourses();
            List<Entidades.TeacherCourses> CoursesList = nTc.GetTeacherCoursesByIdPerson(this.idPerson); // aca debería de ir el idPerson que no se como vamos a hacer para pasar 
            dgvRegistrationCourses.DataSource = CoursesList;
        }

        private void txtTeacherCoursesIdCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTeacherCoursesCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTeacherCoursesAccept_Click(object sender, EventArgs e)
        {

            int idC = Convert.ToInt32(txtTeacherCoursesIdCourse.Text);

            Negocio.Courses nC = new Negocio.Courses();
            Entidades.Courses cour = nC.GetOne(idC);   //quizá hbaría que validar q se de ese profesor en particular 

            if (cour.IdCourse != 0)
            {
                frmStudentsListForTeacher frmStudentsListForTeacher = new frmStudentsListForTeacher(idC);
                frmStudentsListForTeacher.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cusro ingresado no valido");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvTeacheraCoursesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvSubjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRegistrationCourses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRegistrationCourses.SelectedRows[0];
                txtTeacherCoursesIdCourse.Text = selectedRow.Cells["IdCourse"].Value.ToString();
            }
            else
            {
                txtTeacherCoursesIdCourse.Text = "";
            }
        }
    }
}
