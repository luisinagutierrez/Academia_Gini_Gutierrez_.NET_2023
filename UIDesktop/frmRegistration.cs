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
            List<Entidades.Courses> CoursesList = nCourses.GetAvailableCourses();
            dgvNewCourses.DataSource = CoursesList;
        }
    }
}
