namespace UIDesktop
{
    partial class frmPlansReport
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
            btnPlansReport = new Button();
            label1 = new Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // btnPlansReport
            // 
            btnPlansReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlansReport.Location = new Point(423, 59);
            btnPlansReport.Name = "btnPlansReport";
            btnPlansReport.Size = new Size(172, 43);
            btnPlansReport.TabIndex = 3;
            btnPlansReport.Text = "Cargar Reporte";
            btnPlansReport.UseVisualStyleBackColor = true;
            btnPlansReport.Click += btnCoursesReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(372, 15);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 2;
            label1.Text = "Reporte de Cursos";
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(12, 108);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(983, 385);
            reportViewer1.TabIndex = 4;
            // 
            // frmPlansReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1007, 542);
            Controls.Add(reportViewer1);
            Controls.Add(btnPlansReport);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPlansReport";
            Text = "frmPlansReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlansReport;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}