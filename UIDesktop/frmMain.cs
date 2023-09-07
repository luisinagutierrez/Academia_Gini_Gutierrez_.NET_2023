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
            switch (privilege)
            {
                case 1: //Teacher
                    btnTeacherMenu.Visible = true;
                    btnStudentRegistration.Visible = false; 
                    btnPerson.Visible = false;
                    btnSpeciality.Visible = false;
                    btnSubjects.Visible = false;
                    btnCommission.Visible = false;
                    btnCourse.Visible = false;
                    btnReports.Visible = false;
                    break;

                case 2: //Student
                    btnTeacherMenu.Visible = false;
                    btnStudentRegistration.Visible = true;
                    btnPerson.Visible = false;
                    btnSpeciality.Visible = false;
                    btnSubjects.Visible = false;
                    btnCommission.Visible = false;
                    btnCourse.Visible = false;
                    btnReports.Visible = false;
                    break;

                case 3: //Admin
                    btnTeacherMenu.Visible = false;
                    btnStudentRegistration.Visible = false;
                    btnPerson.Visible = true;
                    btnSpeciality.Visible = true;
                    btnSubjects.Visible = true;
                    btnCommission.Visible = true;
                    btnCourse.Visible = true;
                    btnReports.Visible = true;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnUsersReport_Click(object sender, EventArgs e)
        {
            pnSubmenuReports.Visible = false;
        }

        private void btnPeopleReports_Click(object sender, EventArgs e)
        {
            pnSubmenuReports.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
