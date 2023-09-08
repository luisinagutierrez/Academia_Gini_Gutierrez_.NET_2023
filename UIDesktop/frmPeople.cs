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

        private void btnCreatePeople_Click(object sender, EventArgs e)
        {
            int idPlan = Convert.ToInt32(txtPeopleIdPlan.Text);
            int fileId = Convert.ToInt32(txtPeopleFileId.Text);
            string name = Convert.ToString(txtPeopleName.Text);
            string surname = Convert.ToString(txtPeopleSurname.Text);
            string address = Convert.ToString(txtPeopleAddress.Text);
            string email = Convert.ToString(txtPeopleEmail.Text);
            DateTime birthDate = Convert.ToDateTime(dtpPeopleBirthDate.Text);
            string telephone = Convert.ToString(txtPeopleTelephone.Text);
            int personType = Convert.ToInt32(txtPeoplePersonType.Text);
            Negocio.Plans nPlans = new Negocio.Plans();
            Entidades.Plans pl = nPlans.GetOne(idPlan);
            if (pl != null)
            {
                Negocio.People nP = new Negocio.People();
                Entidades.People p = new Entidades.People();
                p.FileId = fileId;
                p.Name = name;
                p.Surname = surname;
                p.Address = address;
                p.Email = email;
                p.BirthDate = birthDate;
                p.Telephone = telephone;
                p.PersonType = personType;
                p.IdPlan = idPlan;
                nP.Add(p);
                MessageBox.Show("Operación exitosa");
            }
            else
            {
                MessageBox.Show("El IdPlan ingresado no existe.");
            }
            this.Close();
        }
        private void btnUpdatePeople_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(txtIdPerson.Text);
            int idPlan = Convert.ToInt32(txtPeopleIdPlan.Text);
            int fileId = Convert.ToInt32(txtPeopleFileId.Text);
            string name = Convert.ToString(txtPeopleName.Text);
            string surname = Convert.ToString(txtPeopleSurname.Text);
            string address = Convert.ToString(txtPeopleAddress.Text);
            string email = Convert.ToString(txtPeopleEmail.Text);
            DateTime birthDate = Convert.ToDateTime(dtpPeopleBirthDate.Text);
            string telephone = Convert.ToString(txtPeopleTelephone.Text);

            Negocio.Plans nPlan = new Negocio.Plans();
            Entidades.Plans pl = nPlan.GetOne(idPlan);
            if (pl != null)
            {

                Negocio.People p = new Negocio.People();
                int pe = p.UpdatePeople(idP, fileId, name, surname, address, email, birthDate, telephone, idPlan);
                if (pe == 1)
                {
                    MessageBox.Show("Se actualizó la persona correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la persona.");
                }
            }
            else
            {
                MessageBox.Show("El Id del plan no fue encontrado");
            }
        }

        private void frmPeople_Load_1(object sender, EventArgs e)
        {
            Negocio.People nPeople = new Negocio.People();
            List<Entidades.People> PeopleList = nPeople.GetAll();
            dgvPeople.DataSource = PeopleList;
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(txtIdPerson.Text);
            Negocio.People nP = new Negocio.People();
            Negocio.Users nU = new Negocio.Users();
            int u = nU.GetUserByIdPerson(idP);
            if (u == 0)
            {
                nP.Delete(idP);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede eliminar la persona, ya que tiene un usuario asociado.");
                this.Close();
            }
        }
    }
}
