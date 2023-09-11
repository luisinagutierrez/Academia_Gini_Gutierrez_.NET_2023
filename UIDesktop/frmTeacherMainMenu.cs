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
        public frmTeacherMainMenu(int idPerson)
        {
            InitializeComponent();
            this.idPerson = idPerson;
        }

        private void frmTeacherMainMenu_Load(object sender, EventArgs e)
        {
            //MOSTRAR TODOS LOS CURSOS DE UN PROFESOR 
            Negocio.TeacherCourses nTc = new Negocio.TeacherCourses();
            List<Entidades.TeacherCourses> CoursesList = nTc.GetTeacherCoursesByIdPerson(1); // aca debería de ir el idPerson que no se como vamos a hacer para pasar 
            dgvTeacheraCoursesList.DataSource = CoursesList;

            //MOSTRAR LOS STUDENT REGISTRATION DE UN CURSO EN PARICULAR, no se como se como se podría hacer capaz q pidiendole el curso y depues apretando aceptar, pero donde se valida que l curso que ingresó estaba bien 

            //Negocio.TeacherCourses nSt = new Negocio.TeacherCourses();
            //List<Entidades.StudentsRegistrations> CoursesList = nSt.GetCoursesByIdPerson(this.idPerson);
            //dgvRegistrationCourses.DataSource = CoursesList;

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
            //aca habria que validar que exista el curso
            //de no existir, mostrar un mensaje de error y dejarlo volver a ingresar
            //si existe, pasa a los alumnos que esten inscriptos en ese curso
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
