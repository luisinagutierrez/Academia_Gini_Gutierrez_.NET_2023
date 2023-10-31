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
using Microsoft.Reporting.WinForms;

namespace UIDesktop
{
    public partial class frmCoursesReport : Form
    {
        public frmCoursesReport()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PC-LUCA;Initial Catalog=db_Academia_302_TT_2023;Integrated Security=True");
        private void btnCoursesReport_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Courses", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", table);
            reportViewer1.LocalReport.ReportPath = @"C:\\Users\\Usuario\\OneDrive\\Escritorio\\ISI UTN 3ero\\Tecnologías en Desarrollo de Software IDE (elec)\\TPI Academia\\TPI_3K2_TT_Academia\\PruebaAcademia\\UIDesktop\\bin\\Debug\\rptCourses.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
