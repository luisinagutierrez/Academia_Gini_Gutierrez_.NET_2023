﻿using System;
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
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnStudentDeleteInscription_Click(object sender, EventArgs e)
        {
            frmDeleteRegistration frmDeleteRegistration = new frmDeleteRegistration();
            frmDeleteRegistration.ShowDialog();

        }

        private void btnStudentNewInscription_Click(object sender, EventArgs e)
        {
            frmNewRegistration frmNewRegistration = new frmNewRegistration();
            frmNewRegistration.ShowDialog();
        }
    }
}
