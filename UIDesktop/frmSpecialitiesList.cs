﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace UIDesktop
{
    public partial class frmSpecialitiesList : Form
    {
        public frmSpecialitiesList()
        {
            InitializeComponent();
        }

        private void frmSpecialitiesList_Load(object sender, EventArgs e)
        {
            dgwSpecialitiesList.DataSource = NegocioEspecialidades.GetAll();
            Connection.Connect();
            dgwSpecialitiesList.DataSource = Index();
            Connection.Disconnect();
        }

        public DataTable Index()
        {
            //Connection.Connect();
            DataTable dt = new DataTable();
            string sql = "Select * from Specialities";
            SqlCommand command = new SqlCommand(sql, Connection.Connect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        private void dgwSpecialitiesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
