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
        public frmTeacherMainMenu()
        {
            InitializeComponent();
        }

        private void frmTeacherMainMenu_Load(object sender, EventArgs e)
        {

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
    }
}
