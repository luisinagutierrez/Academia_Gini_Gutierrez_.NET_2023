using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UIDesktop
{
    public partial class frmPlansReport : Form
    {
        public frmPlansReport()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PC-LUCA;Initial Catalog=db_Academia_302_TT_2023;Integrated Security=True");
        private void btnCoursesReport_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Plans", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet2", table);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Usuario\OneDrive\Escritorio\ISI UTN 3ero\Tecnologías en Desarrollo de Software IDE (elec)\TPI Academia\TPI_3K2_TT_Academia\PruebaAcademia\UIDesktop\bin\Debug\rptPlans.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
