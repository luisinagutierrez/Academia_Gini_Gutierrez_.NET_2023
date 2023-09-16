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
    public partial class frmEntitiesInfoForPeople : Form
    {
        public frmEntitiesInfoForPeople()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntitiesInfoForPeople_Load(object sender, EventArgs e)
        {
            Negocio.Specialities nS = new Negocio.Specialities();
            List<Entidades.Specialities> SpecialitiesList = nS.GetAll();
            dgvSpecialities.DataSource = SpecialitiesList;

            Negocio.Plans nP = new Negocio.Plans();
            List<Entidades.Plans> PlansList = nP.GetAll();
            dgvPlans.DataSource = PlansList;

            Negocio.Commissions nCom = new Negocio.Commissions();
            List<Entidades.Commissions> CommissionsList = nCom.GetAll();
            dgvCommissions.DataSource = CommissionsList;

            Negocio.Subjects nSub = new Negocio.Subjects();
            List<Entidades.Subjects> SubjectsList = nSub.GetAll();
            dgvSubjects.DataSource = SubjectsList;

            Negocio.Courses nC = new Negocio.Courses();
            List<Entidades.Courses> CoursesList = nC.GetAll();
            dgvCourses.DataSource = CoursesList;

        }
    }
}
