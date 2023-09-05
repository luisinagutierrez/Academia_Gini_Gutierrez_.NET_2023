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
    public partial class frmDeletePlans : Form
    {
        public frmDeletePlans()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmDeletePlans_Load(object sender, EventArgs e)
        {
            Negocio.Plans nPlans = new Negocio.Plans();
            List<Entidades.Plans> PlansList = nPlans.GetAll();
            dgvPlans.DataSource = PlansList;
        }
    }
}
