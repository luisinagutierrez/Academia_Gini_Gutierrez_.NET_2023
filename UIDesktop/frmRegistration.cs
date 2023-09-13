using Microsoft.Identity.Client;
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
        public int idPerson;
        public frmRegistration(int idPerson)
        {

            InitializeComponent();
            this.idPerson = idPerson;
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
            int cant = 0;
            foreach (Entidades.Courses course in AvailableCoursesList)
            {
                cant++;
            }
            if (cant == 0)
            {
                MessageBox.Show("No hay cursos disponibles");
                this.Close();
            }
            else
            {
                dgvAvailableCourses.DataSource = AvailableCoursesList;
            }

            Negocio.StudentsRegistrations nSt = new Negocio.StudentsRegistrations();
            List<Entidades.StudentsRegistrations> CoursesList = nSt.GetCoursesByIdPerson(this.idPerson);
            dgvRegistrationCourses.DataSource = CoursesList;
        }


        private void btnStudentNewRegistrationAccept_Click(object sender, EventArgs e)
        {
            //ME FALTÓ VALIDAR QUE EL ALUMNO NO ESTÉ YA INSCRIPTO EN ESE CURSO, NO SE SI ESO ES NECESARIO
            int IdCourse = Convert.ToInt32(txtIdCouse.Text);
            Negocio.Courses nCourses = new Negocio.Courses();
            int course = nCourses.ValidateCourseAvailability(IdCourse);
            if (course != 0)
            {
                Negocio.StudentsRegistrations nst = new Negocio.StudentsRegistrations();
                nst.Add(IdCourse, this.idPerson);//  sería el id de persona que no se como pasarle al form !!!!         
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
            int IdRegistration = Convert.ToInt32(txtIdRegistration.Text);
            Negocio.StudentsRegistrations nStuReg = new Negocio.StudentsRegistrations();
            int idCourse = nStuReg.ValidateStudentsRegistrations(IdRegistration, this.idPerson);
            if (idCourse != 0) 
            {
                Negocio.Courses nCourses = new Negocio.Courses();
                nCourses.UpdateCourseAvailability(idCourse, -1);
                MessageBox.Show("Operacion exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("Registro de inscripcion no encontrado");
            }
        }

        private void dgvAvailableCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAvailableCourses.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dgvAvailableCourses.SelectedRows[0];

                // Accede a las celdas de la fila y asigna sus valores a los TextBox
                txtIdCouse.Text = selectedRow.Cells["IdCourse"].Value.ToString();
                // ... y así sucesivamente para cada TextBox y columna que desees mostrar
            }
            else
            {
                // Si no hay filas seleccionadas, borra los TextBox
                txtIdCouse.Text = "";
                // ... y así sucesivamente para cada TextBox que desees borrar
            }
        }

        private void dgvRegistrationCourses_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada
            if (dgvRegistrationCourses.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dgvRegistrationCourses.SelectedRows[0];

                // Accede a las celdas de la fila y asigna sus valores a los TextBox
                txtIdRegistration.Text = selectedRow.Cells["IdRegistration"].Value.ToString();
                // ... y así sucesivamente para cada TextBox y columna que desees mostrar
            }
            else
            {
                // Si no hay filas seleccionadas, borra los TextBox
                txtIdRegistration.Text = "";
                // ... y así sucesivamente para cada TextBox que desees borrar
            }
        }
    }
}
