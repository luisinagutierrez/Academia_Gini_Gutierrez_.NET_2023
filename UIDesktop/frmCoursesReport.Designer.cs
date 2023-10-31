namespace UIDesktop
{
    partial class frmCoursesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCoursesReport = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 0;
            label1.Text = "Reporte de Cursos";
            // 
            // btnCoursesReport
            // 
            btnCoursesReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoursesReport.Location = new Point(436, 63);
            btnCoursesReport.Name = "btnCoursesReport";
            btnCoursesReport.Size = new Size(172, 43);
            btnCoursesReport.TabIndex = 1;
            btnCoursesReport.Text = "Cargar Reporte";
            btnCoursesReport.UseVisualStyleBackColor = true;
            btnCoursesReport.Click += btnCoursesReport_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(12, 112);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(983, 385);
            reportViewer1.TabIndex = 2;
            // 
            // frmCoursesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1007, 542);
            Controls.Add(reportViewer1);
            Controls.Add(btnCoursesReport);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCoursesReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCoursesReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCoursesReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}