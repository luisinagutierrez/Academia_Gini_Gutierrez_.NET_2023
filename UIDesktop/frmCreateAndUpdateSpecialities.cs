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
    public partial class frmCreateAndUpdateSpecialities : Form
    {
        public frmCreateAndUpdateSpecialities()
        {
            InitializeComponent();
        }

        private void frmCreateAndUpdateSpecialities_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateSpecialitie_Click(object sender, EventArgs e)
        {
            Negocio.Specialities ns = new Negocio.Specialities();
            ns.Add(txtSpecialityDescription.Text);
        }

        private void btnUpdateSpecialitie_Click(object sender, EventArgs e)
        {
            Negocio.Specialities ns = new Negocio.Specialities();
            ns.Update(txtSpecialityDescription.Text, Convert.ToInt32(txtIdSpeciality.Text));
        }
    }
}
