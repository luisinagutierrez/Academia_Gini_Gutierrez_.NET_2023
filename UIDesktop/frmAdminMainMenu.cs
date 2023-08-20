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
    public partial class frmAdminMainMenu : Form
    {
        public frmAdminMainMenu()
        {
            InitializeComponent();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeletePeople frmDeletePeople = new frmDeletePeople();
            frmDeletePeople.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSpecialitiesList frmSpecialitiesList = new frmSpecialitiesList();
            frmSpecialitiesList.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSpecialitiesList frmSpecialitiesList = new frmSpecialitiesList();
            frmSpecialitiesList.ShowDialog();
        }

        private void frmAdminMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdateSpecialities frmCreateAndUpdateSpecialities = new frmCreateAndUpdateSpecialities();
            frmCreateAndUpdateSpecialities.ShowDialog();
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdateSpecialities frmCreateAndUpdateSpecialities = new frmCreateAndUpdateSpecialities();
            frmCreateAndUpdateSpecialities.ShowDialog();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeleteSpecialities frmDeleteSpecialities = new frmDeleteSpecialities();
            frmDeleteSpecialities.ShowDialog();

        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdatePlans frmCreateAndUpdatePlans = new frmCreateAndUpdatePlans();
            frmCreateAndUpdatePlans.ShowDialog();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdatePlans frmCreateAndUpdatePlans = new frmCreateAndUpdatePlans();
            frmCreateAndUpdatePlans.ShowDialog();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDeletePlans frmDeletePlans = new frmDeletePlans();
            frmDeletePlans.ShowDialog();

        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdateCommissions frmCreateAndUpdateCommissions = new frmCreateAndUpdateCommissions();
            frmCreateAndUpdateCommissions.ShowDialog();
        }

        private void modificacionToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdateCommissions frmCreateAndUpdateCommissions = new frmCreateAndUpdateCommissions();
            frmCreateAndUpdateCommissions.ShowDialog();
        }

        private void bajaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmDeleteCommissions frmDeleteCommissions = new frmDeleteCommissions();
            frmDeleteCommissions.ShowDialog();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdateSubjects frmCreateAndUpdateSubjects = new frmCreateAndUpdateSubjects();
            frmCreateAndUpdateSubjects.ShowDialog();

        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdateSubjects frmCreateAndUpdateSubjects = new frmCreateAndUpdateSubjects();
            frmCreateAndUpdateSubjects.ShowDialog();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmDeleteSubjects frmDeleteSubjects = new frmDeleteSubjects();
            frmDeleteSubjects.ShowDialog();
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdateCourses frmCreateAndUpdateCourses = new frmCreateAndUpdateCourses();
            frmCreateAndUpdateCourses.ShowDialog();
        }

        private void modificacionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdateCourses frmCreateAndUpdateCourses = new frmCreateAndUpdateCourses();
            frmCreateAndUpdateCourses.ShowDialog();
        }

        private void bajaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmDeleteCourses frmDeleteCourses = new frmDeleteCourses();
            frmDeleteCourses.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdatePeople frmCreateAndUpdatePeople = new frmCreateAndUpdatePeople();
            frmCreateAndUpdatePeople.ShowDialog();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateAndUpdatePeople frmCreateAndUpdatePeople = new frmCreateAndUpdatePeople();
            frmCreateAndUpdatePeople.ShowDialog();
        }
    }
}
