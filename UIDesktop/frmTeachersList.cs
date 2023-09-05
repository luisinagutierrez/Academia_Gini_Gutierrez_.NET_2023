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
    public partial class frmTeachersList : Form
    {
        public frmTeachersList()
        {
            InitializeComponent();
        }

        private void frmTeachersList_Load(object sender, EventArgs e)
        {
            Negocio.People nPeople = new Negocio.People();
            List<Entidades.People> PeopleList = nPeople.GetAll();
            dgwTeachersList.DataSource = PeopleList;
        }

        private void dgwTeachersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
