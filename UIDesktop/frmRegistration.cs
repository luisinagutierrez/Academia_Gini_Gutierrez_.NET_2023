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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnStudentNewRegistrationCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmNewRegistration_Load(object sender, EventArgs e)
        {
            Negocio.Courses nCourses = new Negocio.Courses();
            List<Entidades.Courses> AvailableCoursesList = nCourses.GetAvailableCourses();
            dgvAvailableCourses.DataSource = AvailableCoursesList;

            int idPerson = 31; /// debería de pasarselo el main pero no se como hacerlo!!!!1
            Negocio.StudentsRegistrations nSt = new Negocio.StudentsRegistrations();
            List<Entidades.StudentsRegistrations> CoursesList = nSt.GetCoursesByIdPerson(idPerson);
            dgvRegistrationCourses.DataSource = CoursesList;

        }


        private void btnStudentNewRegistrationAccept_Click(object sender, EventArgs e)
        {
            //ME FALTÓ VALIDAR QUE EL ALUMNO NO ESTÉ YA INSCRIPTO EN ESE CURSO, NO SE SI ESO ES NECESARIO
            int IdCourse = Convert.ToInt32(txtIdCouse.Text);
            Negocio.Courses nCourses = new Negocio.Courses();
            bool course = nCourses.ValidateCourseAvailability(IdCourse);
            if (course)
            {
                Negocio.StudentsRegistrations nst = new Negocio.StudentsRegistrations();
                nst.Add(IdCourse, 31);//  sería el id de persona que no se como pasarle al form !!!!         
                MessageBox.Show("Operacion exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("El curso ingresado no fue encontrado o no tiene cupo");
            }

        }


        private void btnDeleteRegistration_Click(object sender, EventArgs e)
        {

            // VALIDO QUE ESTÉ INGRESANDO UNA REGISTATION VALIDA PARA ESE ALUMNO PASAR COMO PARÁMETRO SU IDE Y EL DE LA REGISTRACION
            //CURSOS RESTARLE UN INCRIPTO Y ELIMINAR LA REGISTRACION DEL REGISTRATION 

            int IdRegistration = Convert.ToInt32(txtIdRegistration.Text);
            Negocio.StudentsRegistrations nStuReg = new Negocio.StudentsRegistrations();
            int idCourse = nStuReg.ValidateStudentsRegistrations(IdRegistration, 31); //      sería el id de persona que no se como pasarle al form !!!!        
            if (idCourse != 0) ///ACA NO SE QUE ME DEVOLVERÍA SI INGRESA UNA REGISTRATION NO VALIDA
            {
                Negocio.Courses nCourses = new Negocio.Courses();
                nCourses.UpdateCourseAvailability(idCourse, -1);
                MessageBox.Show("Operacion exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("El curso ingresado no fue encontrado o no tiene cupo");
            }
        }
    }
}
