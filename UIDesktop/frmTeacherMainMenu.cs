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
            List<Entidades.TeacherCourses> CoursesList = nTc.GetTeacherCoursesByIdPerson(this.idPerson);
            dgvRegistrationCourses.DataSource = CoursesList;

            //Negocio.StudentsRegistrations reg = new Negocio.StudentsRegistrations();
            //List<Entidades.StudentsRegistrations> RegistrationList = reg.GetStudentsListRegByIdCourse(1);
            //dgvStudentRegistration.DataSource = RegistrationList;
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
            if (txtTeacherCoursesIdCourse.Text == "")
            {
                MessageBox.Show("Debe seleccionar un curso.");
            }
            else
            {
                int idC = Convert.ToInt32(txtTeacherCoursesIdCourse.Text);
                Negocio.Courses nC = new Negocio.Courses();
                Entidades.Courses cour = nC.GetOne(idC);   //quizá habría que validar q se de ese profesor en particular 

                if (cour.IdCourse != 0)
                {
                    this.idCourse = idC;
                    UploadDataToStudentRegistration(this.idCourse);
                }
                else
                {
                    MessageBox.Show("Curso ingresado no valido");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvRegistrationCourses_SelectionChanged(object sender, EventArgs e)
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
        private void UploadDataToStudentRegistration(int idCourse)
        {
            Negocio.StudentsRegistrations reg = new Negocio.StudentsRegistrations();
            List<Entidades.StudentsRegistrations> RegistrationList = reg.GetStudentsListRegByIdCourse(idCourse); //this.idCourse
            dgvStudentRegistration.DataSource = RegistrationList;
        }

        private void btnCancelStudentRegistration_Click_1(object sender, EventArgs e)
        {
            txtIdRegistration.Text = "";
            cBoxMark.Text = "";
        }

        private void btnStudentRegistrationAccept_Click(object sender, EventArgs e)
        {
            if (txtIdRegistration.Text == "" || cBoxMark.Text == "")
            {
                MessageBox.Show("Debe seleccionar un alumno y asignarle una nota.");
            }
            else
            {
                int idR = Convert.ToInt32(txtIdRegistration.Text);
                int mark = Convert.ToInt32(cBoxMark.Text);
                
                Negocio.StudentsRegistrations st = new Negocio.StudentsRegistrations();
                st.UpdateMark(idR, mark);

                MessageBox.Show("Nota cargada y condicion del alumno actualizada.");
                // Ejemplo de cómo usar Invoke() para llamar a Refresh() desde otro hilo.
                dgvStudentRegistration.Refresh();
            }
        }

        private void dgvStudentRegistration_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudentRegistration.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudentRegistration.SelectedRows[0];
                txtIdRegistration.Text = selectedRow.Cells["IdRegistration"].Value.ToString();
            }
            else
            {
                txtIdRegistration.Text = "";
            }
        }
    }
}
