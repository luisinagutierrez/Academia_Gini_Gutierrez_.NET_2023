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
    public partial class frmCreateAndUpdateSubjects : Form
    {
        public frmCreateAndUpdateSubjects()
        {
            InitializeComponent();
        }

        private void frmCreateAndUpdateSubjects_Load(object sender, EventArgs e)
        {
            Negocio.Subjects nSubjects = new Negocio.Subjects();
            List<Entidades.Subjects> SubjectsList = nSubjects.GetAll();
            dgvSubjects.DataSource = SubjectsList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
