using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Identity.Client;

namespace UIDesktop
{
    public partial class frmMain : Form
    {
        public int idPerson;
        public int privilege;
        public frmMain(int idPerson, int privilege)
        {
            InitializeComponent();
            btnTeacherMenu.Visible = false;
            btnStudentRegistration.Visible = false;
            btnPerson.Visible = false;
            btnSpeciality.Visible = false;
            btnSubjects.Visible = false;
            btnCommission.Visible = false;
            btnCourse.Visible = false;
            btnReports.Visible = false;
            btnPlan.Visible = false;
            btnUsers.Visible = false;
            btnEntitiesInfo.Visible = false;

            this.idPerson = idPerson;

            switch (privilege)
            {
                case 1: //Teacher
                    btnTeacherMenu.Visible = true;
                    btnEntitiesInfo.Visible = true;
                    break;

                case 2: //Student
                    btnStudentRegistration.Visible = true;
                    btnEntitiesInfo.Visible = true;
                    break;

                case 3: //Admin
                    btnPerson.Visible = true;
                    btnSpeciality.Visible = true;
                    btnSubjects.Visible = true;
                    btnCommission.Visible = true;
                    btnCourse.Visible = true;
                    btnReports.Visible = true;
                    btnPlan.Visible = true;
                    btnUsers.Visible = true;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnUpMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnSubmenuReports.Visible = true;
        }

        private void btnPeopleReports_Click(object sender, EventArgs e)
        {
            pnSubmenuReports.Visible = false;
            OpenDaughterForm(new frmCoursesReport());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmUserLogIn frmUserLogIn = new frmUserLogIn();
                frmUserLogIn.Show();
                this.Close();
            }
        }

        public void OpenDaughterForm(object formdaughter)
        {
            if (this.pnContainerMain.Controls.Count > 0)
            {
                this.pnContainerMain.Controls.RemoveAt(0);

            }

            Form fd = formdaughter as Form;
            fd.TopLevel = false;
            fd.Dock = DockStyle.Fill;
            this.pnContainerMain.Controls.Add(fd);
            this.pnContainerMain.Tag = fd;
            fd.Show();
        }

        public void btnStudentRegistration_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmRegistration(this.idPerson));
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmPeople());
        }

        private void btnSpeciality_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmSpecialities());
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmPlans());
        }

        private void btnCommission_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmCommissions());
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmSubjects());
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmCourses());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmContacts());
        }

        private void btnTeacherMenu_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmTeacherMainMenu(this.idPerson));
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmUsersAdmin());
        }

        private void btnEntitiesInfo_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmEntitiesInfoForPeople());
        }

        private void btnPlansReports_Click(object sender, EventArgs e)
        {
            OpenDaughterForm(new frmPlansReport());
        }
    }
}
