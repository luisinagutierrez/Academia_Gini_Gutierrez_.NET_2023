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
            if (cBoxIdPlan.Text == "" || txtPeopleFileId.Text == "" || txtPeopleName.Text == "" ||
                txtPeopleSurname.Text == "" || txtPeopleAddress.Text == "" || txtPeopleEmail.Text == "" ||
                txtPeopleEmail.Text == "" || dtpPeopleBirthDate.Text == "" || txtPeopleTelephone.Text == "" ||
                cboxTypePerson.Text == "")
            {
                MessageBox.Show("Ningun campo puede estar vacio para actualizar una persona.");
                return;
            }
            int idPlan = Convert.ToInt32(cBoxIdPlan.Text);
            int fileId = Convert.ToInt32(txtPeopleFileId.Text);
            string name = Convert.ToString(txtPeopleName.Text);
            string surname = Convert.ToString(txtPeopleSurname.Text);
            string address = Convert.ToString(txtPeopleAddress.Text);
            string email = Convert.ToString(txtPeopleEmail.Text);
            DateTime birthDate = Convert.ToDateTime(dtpPeopleBirthDate.Text);
            string telephone = Convert.ToString(txtPeopleTelephone.Text);
            int personType = Convert.ToInt32(cboxTypePerson.Text);

            Negocio.Plans nPlans = new Negocio.Plans();
            Entidades.Plans pl = nPlans.GetOne(idPlan);
            if (txtIdPerson.Text != "")
            {
                MessageBox.Show("El campo IdPerson debe estar vacio para dar de alta una nueva persona.");
                return;
            }
            if (pl.IdPlan != 0)
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
                this.Close();
            }
            else
            {
                MessageBox.Show("El IdPlan ingresado no existe.");
            }

        }
        private void btnUpdatePeople_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(txtIdPerson.Text);
            if (cBoxIdPlan.Text == "")
            {
                MessageBox.Show("El campo Plan no puede estar vacio");
                return;
            }
            int idPlan = Convert.ToInt32(cBoxIdPlan.Text);
            if (txtPeopleFileId.Text == "")
            {
                MessageBox.Show("El campo legajo no puede estar vacio");
                return;
            }
            int fileId = Convert.ToInt32(txtPeopleFileId.Text);
            if (txtPeopleName.Text == "")
            {
                MessageBox.Show("El campo nombre no puede estar vacio");
                return;
            }
            string name = Convert.ToString(txtPeopleName.Text);
            if (txtPeopleSurname.Text == "")
            {
                MessageBox.Show("El campo apellido no puede estar vacio");
                return;
            }
            string surname = Convert.ToString(txtPeopleSurname.Text);
            if (txtPeopleAddress.Text == "")
            {
                MessageBox.Show("El campo direccion no puede estar vacio");
                return;
            }
            string address = Convert.ToString(txtPeopleAddress.Text);
            if (txtPeopleEmail.Text == "")
            {
                MessageBox.Show("El campo email no puede estar vacio");
                return;
            }
            string email = Convert.ToString(txtPeopleEmail.Text);
            if (dtpPeopleBirthDate.Text == "")
            {
                MessageBox.Show("El campo fecha de nacimiento no puede estar vacio");
                return;
            }
            DateTime birthDate = Convert.ToDateTime(dtpPeopleBirthDate.Text);
            if (txtPeopleTelephone.Text == "")
            {
                MessageBox.Show("El campo telefono no puede estar vacio");
                return;
            }
            string telephone = Convert.ToString(txtPeopleTelephone.Text);

            Negocio.Plans nPlan = new Negocio.Plans();
            Entidades.Plans pl = nPlan.GetOne(idPlan);
            if (pl.IdPlan != 0)
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

            Negocio.Plans nPlan = new Negocio.Plans();
            List<Entidades.Plans> Pl = nPlan.GetAll();
            cBoxIdPlan.DataSource = Pl;
            cBoxIdPlan.DisplayMember = "IdPlan";
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (txtIdPerson.Text == "")
            {
                MessageBox.Show("Debe seleccionar una persona para eliminarla.");
                return;
            }
            int idP = Convert.ToInt32(txtIdPerson.Text);
            Negocio.People nP = new Negocio.People();
            Negocio.Users nU = new Negocio.Users();
            Negocio.StudentsRegistrations nSR = new Negocio.StudentsRegistrations();
            int u = nU.GetUserByIdPerson(idP);
            if (nSR.GetStudentRegByIdPerson(idP) != 0)
            {
                MessageBox.Show("No se puede eliminar la persona, ya que tiene una/s inscripción/es asociada/s.");
                return;
            }
            if (u == 0)
            {
                nP.Delete(idP);
                MessageBox.Show("Operación exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede eliminar la persona, ya que tiene un usuario asociado.");
            }
        }

        private void dgvPeople_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPeople.SelectedRows[0];
                txtIdPerson.Text = selectedRow.Cells["IdPerson"].Value.ToString();
                txtPeopleName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPeopleSurname.Text = selectedRow.Cells["Surname"].Value.ToString();
                txtPeopleAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtPeopleEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtPeopleTelephone.Text = selectedRow.Cells["Telephone"].Value.ToString();
                cBoxIdPlan.Text = selectedRow.Cells["IdPlan"].Value.ToString();
                txtPeopleFileId.Text = selectedRow.Cells["FileId"].Value.ToString();
                dtpPeopleBirthDate.Text = selectedRow.Cells["BirthDate"].Value.ToString();
                cboxTypePerson.Text = selectedRow.Cells["PersonType"].Value.ToString();
            }
            else
            {
                txtIdPerson.Text = "";
                txtPeopleName.Text = "";
                txtPeopleSurname.Text = "";
                txtPeopleAddress.Text = "";
                txtPeopleEmail.Text = "";
                txtPeopleTelephone.Text = "";
                cBoxIdPlan.Text = "";
                txtPeopleFileId.Text = "";
                dtpPeopleBirthDate.Text = "";
                cboxTypePerson.Text = "";
            }
        }
    }
}
