using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class frmSpecialities : Form
    {
        public frmSpecialities()
        {
            InitializeComponent();
        }

        private void frmSpecialities_Load(object sender, EventArgs e)
        {
            Negocio.Specialities nSpecialities = new Negocio.Specialities();
            List<Entidades.Specialities> SpecialitiesList = nSpecialities.GetAll();
            dgvSpecialities.DataSource = SpecialitiesList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateSpecialitie_Click(object sender, EventArgs e)
        {
            string descrip = Convert.ToString(txtSpecialityDescription.Text);
            if (descrip != " ")
            {
                Negocio.Specialities s = new Negocio.Specialities();
                s.Add(descrip);
                MessageBox.Show("Operación exitosa");
            }
            else
            {
                MessageBox.Show("Para poder crear una nueva especialidad debe ingresar su descripcion");
            }
            this.Close();
        }

        private void btnUpdateSpecialitie_Click(object sender, EventArgs e)
        {
            string descrip = Convert.ToString(txtSpecialityDescription.Text);
            int id = Convert.ToInt32(txtIdSpeciality.Text);

            Negocio.Specialities s = new Negocio.Specialities();
            int sp = s.Update(id, descrip);
            if (sp == 1)
            {
                MessageBox.Show("Se actualizó la especialidad correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("El Id de la especialidad no fue encontrado");
            }
        }

        private void dgvSpecialities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDeleteSpeciality_Click(object sender, EventArgs e)
        {
            int idS = Convert.ToInt32(txtIdSpeciality.Text);

            Negocio.Plans p = new Negocio.Plans();
            int pl = p.GetPlansByIdSpeciality(idS);
            MessageBox.Show(pl.ToString());              // muestra 0 aunque encuentre 
            if (pl == 0)
            {
                Negocio.Specialities s = new Negocio.Specialities();
                int rts = s.Delete(idS);
                MessageBox.Show(rts.ToString());
                if (rts == 1)                  
                {
                    MessageBox.Show("Operación exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Id especialidad ingresado no valido");
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar la especialidad dado que tiene planas asignados a la misma.");
                this.Close();
            }
        }

        private void frmSpecialities_Load_1(object sender, EventArgs e)
        {
            Negocio.Specialities nSpecialities = new Negocio.Specialities();
            List<Entidades.Specialities> PeopleList = nSpecialities.GetAll();
            dgvSpecialities.DataSource = PeopleList;
        }
    }
}
