using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace UIDesktop
{
    public partial class frmDeleteRegistration : Form
    {
        public frmDeleteRegistration()
        {
            InitializeComponent();
        }

        private void lbCouses_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentDeleteRegistrationCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStudentDeleteRegistrationAccept_Click(object sender, EventArgs e)
        {
            Negocio.StudentsRegistrations.Delete(int id);
        }

        private void dgvCoursesRegistration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Entidades.StudentsRegistrations> RegistrationsList = StudentsRegistrations.GetAll();
        }
    }
}
