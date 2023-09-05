using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace UIDesktop
{
    public partial class frmDeleteSpecialities : Form
    {
        public frmDeleteSpecialities()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteSpecialitie_Click(object sender, EventArgs e)
        {
            Negocio.Specialities specialitie = new Negocio.Specialities();
            specialitie.Delete(Convert.ToInt32(txtIdSpecialities.Text));
        }

        private void dgvSpecialities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void frmDeleteSpecialities_Load(object sender, EventArgs e)
        {
            Negocio.Specialities nSpecialities = new Negocio.Specialities();
            List<Entidades.Specialities> SpecialitiesList = nSpecialities.GetAll();
            dgvSpecialities.DataSource = SpecialitiesList;
        }
    }
}
