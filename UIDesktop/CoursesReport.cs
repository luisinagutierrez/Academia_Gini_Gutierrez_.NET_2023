using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Reporting;

namespace UIDesktop
{
    public partial class CoursesReport : Form
    {
        public CoursesReport()
        {
            InitializeComponent();
        }

        private void CoursesReport_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Size = new Size(800, 600);
        }
    }
}
