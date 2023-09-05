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
    public partial class frmDeletePeople : Form
    {
        public frmDeletePeople()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Entidades.People> People = new List<Entidades.People>();
            People = new Negocio.People().GetAll();
            dgvPeople.DataSource = People;
        }

        private void lbPlans_Click(object sender, EventArgs e)
        {

        }

        private void frmDeletePeople_Load(object sender, EventArgs e)
        {
            Negocio.People nPeople = new Negocio.People();
            List<Entidades.People> PeopleList = nPeople.GetAll();
            dgvPeople.DataSource = PeopleList;
        }
    }
}
