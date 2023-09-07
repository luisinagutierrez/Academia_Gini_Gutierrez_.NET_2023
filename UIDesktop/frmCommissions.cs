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
    public partial class frmCommissions : Form
    {
        public frmCommissions()
        {
            InitializeComponent();
        }

        private void frmCreateAndUpdateCommissions_Load(object sender, EventArgs e)
        {
            Negocio.Commissions nCommissions = new Negocio.Commissions();
            List<Entidades.Commissions> CommissionsList = nCommissions.GetAll();
            dgvCommissions.DataSource = CommissionsList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCommissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
