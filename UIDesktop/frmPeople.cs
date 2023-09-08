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
    public partial class frmPeople : Form
    {
        public frmPeople()
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

        private void frmPeople_Load(object sender, EventArgs e)
        {
            Negocio.People nPeople = new Negocio.People();
            List<Entidades.People> PeopleList = nPeople.GetAll();
            dgvPeople.DataSource = PeopleList;
        }

        private void btnCreatePeople_Click(object sender, EventArgs e)
        {
            int fileId = Convert.ToInt32(txtPeopleFileId.Text);
            string name = Convert.ToString(txtPeopleName.Text);
            string surname = Convert.ToString(txtPeopleSurname.Text);
            int idPlan = Convert.ToInt32(txtPeopleIdPlan.Text);
            Negocio.Plans nPlans = new Negocio.Plans();
            while (idPlan != -1)
            {
                Entidades.Plans p = nPlans.GetOne(idPlan);
                if (p.IdPlan == idPlan)
                {
                    break;
                }
                else
                {
                    MessageBox.Show("El IdPlan ingresado no existe.");
                    break;
                }
            }
            if (fileId > 0 && name != " " && surname != " ")
            {
                Negocio.People nP = new Negocio.People();
                Entidades.People p = new Entidades.People();
                p.FileId = Convert.ToInt32(txtPeopleFileId.Text);
                p.Name = Convert.ToString(txtPeopleName.Text);
                p.Surname = Convert.ToString(txtPeopleSurname.Text);
                p.Address = Convert.ToString(txtPeopleAddress.Text);
                p.Email = Convert.ToString(txtPeopleEmail.Text);
                p.BirthDate = Convert.ToDateTime(dtpPeopleBirthDate.Text);
                p.Telephone = Convert.ToString(txtPeopleTelephone.Text);
                p.PersonType = Convert.ToInt32(txtPeoplePersonType.Text);
                nP.Add(p);
                MessageBox.Show("Operación exitosa");
            }
            else
            {
                MessageBox.Show("Para poder crear una nueva persona debe ingresar su legajo, nombre, apellido.");
            }
            this.Close();
        }

        private void btnUpdatePeople_Click(object sender, EventArgs e)
        {
            //string descrip = Convert.ToString(txtSpecialityDescription.Text);
            //int id = Convert.ToInt32(txtIdSpeciality.Text);
            //Negocio.Specialities s = new Negocio.Specialities();
            //int sp = s.UpdateSpeciality(id, descrip);
            //if (sp == 1)
            //{
            //    MessageBox.Show("Se actualizó la especialidad correctamente.");
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo actualizar la especialidad.");
            //}
        }
    }
}
