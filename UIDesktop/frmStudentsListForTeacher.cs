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
    public partial class frmStudentsListForTeacher : Form
    {
        public int idCourse;

        public frmStudentsListForTeacher(int idPerson)
        {
            InitializeComponent();
            this.idCourse = idCourse;
        }

        private void frmStudentsListForTeacher_Load(object sender, EventArgs e)
        {
            Negocio.StudentsRegistrations reg = new Negocio.StudentsRegistrations();
            List<Entidades.StudentsRegistrations> RegistrationList = reg.GetStudentsListRegByIdCourse(9); //this.idCourse
            dgvStudentRegistration.DataSource = RegistrationList;
        }

        private void btnTeacherCoursesAccept_Click(object sender, EventArgs e)
        {
            int idR = Convert.ToInt32(txtIdRegistration.Text);
            int note = Convert.ToInt32(cBoxNote.Text);
            Negocio.StudentsRegistrations st = new Negocio.StudentsRegistrations();
            st.UpdateNote(idR,note);
            MessageBox.Show("Nota cargada");
        }
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
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
