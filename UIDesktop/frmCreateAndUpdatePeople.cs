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
    public partial class frmCreateAndUpdatePeople : Form
    {
        public frmCreateAndUpdatePeople()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmCreateAndUpdatePeople_Load(object sender, EventArgs e)
        {
            Negocio.People nPeople = new Negocio.People();
            List<Entidades.People> PeopleList = nPeople.GetAll();
            dgvPeople.DataSource = PeopleList;
        }
    }
}
