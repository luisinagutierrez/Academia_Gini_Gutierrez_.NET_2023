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
    public partial class frmDeleteCommissions : Form
    {
        public frmDeleteCommissions()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCommissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmDeleteCommissions_Load(object sender, EventArgs e)
        {
            Negocio.Commissions nCommissions = new Negocio.Commissions();
            List<Entidades.Commissions> CommissionsList = nCommissions.GetAll();
            dgvCommissions.DataSource = CommissionsList;
        }
    }
}
