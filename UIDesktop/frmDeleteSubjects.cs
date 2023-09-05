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
    public partial class frmDeleteSubjects : Form
    {
        public frmDeleteSubjects()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }

        private void frmDeleteSubjects_Load(object sender, EventArgs e)
        {
            Negocio.Subjects nSubjects = new Negocio.Subjects();
            List<Entidades.Subjects> SubjectsList = nSubjects.GetAll();
            dgvSubjects.DataSource = SubjectsList;
        }
    }
}
