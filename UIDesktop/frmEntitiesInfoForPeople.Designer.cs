namespace UIDesktop
{
    partial class frmEntitiesInfoForPeople
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
            dgvSpecialities = new DataGridView();
            dgvPlans = new DataGridView();
            dgvCommissions = new DataGridView();
            dgvSubjects = new DataGridView();
            dgvCourses = new DataGridView();
            lbSpecialities = new Label();
            lbPlans = new Label();
            lbCommissions = new Label();
            lbSubjects = new Label();
            lbCourses = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // dgvSpecialities
            // 
            dgvSpecialities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpecialities.Location = new Point(12, 49);
            dgvSpecialities.Name = "dgvSpecialities";
            dgvSpecialities.RowHeadersWidth = 51;
            dgvSpecialities.RowTemplate.Height = 29;
            dgvSpecialities.Size = new Size(419, 188);
            dgvSpecialities.TabIndex = 0;
            // 
            // dgvPlans
            // 
            dgvPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlans.Location = new Point(470, 49);
            dgvPlans.Name = "dgvPlans";
            dgvPlans.RowHeadersWidth = 51;
            dgvPlans.RowTemplate.Height = 29;
            dgvPlans.Size = new Size(426, 188);
            dgvPlans.TabIndex = 1;
            // 
            // dgvCommissions
            // 
            dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommissions.Location = new Point(935, 49);
            dgvCommissions.Name = "dgvCommissions";
            dgvCommissions.RowHeadersWidth = 51;
            dgvCommissions.RowTemplate.Height = 29;
            dgvCommissions.Size = new Size(426, 188);
            dgvCommissions.TabIndex = 2;
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(12, 309);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidth = 51;
            dgvSubjects.RowTemplate.Height = 29;
            dgvSubjects.Size = new Size(649, 188);
            dgvSubjects.TabIndex = 3;
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(712, 309);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.RowTemplate.Height = 29;
            dgvCourses.Size = new Size(649, 188);
            dgvCourses.TabIndex = 4;
            // 
            // lbSpecialities
            // 
            lbSpecialities.AutoSize = true;
            lbSpecialities.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbSpecialities.Location = new Point(135, 9);
            lbSpecialities.Name = "lbSpecialities";
            lbSpecialities.Size = new Size(160, 22);
            lbSpecialities.TabIndex = 5;
            lbSpecialities.Text = "Especialidades";
            // 
            // lbPlans
            // 
            lbPlans.AutoSize = true;
            lbPlans.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbPlans.Location = new Point(642, 9);
            lbPlans.Name = "lbPlans";
            lbPlans.Size = new Size(77, 22);
            lbPlans.TabIndex = 6;
            lbPlans.Text = "Planes";
            // 
            // lbCommissions
            // 
            lbCommissions.AutoSize = true;
            lbCommissions.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCommissions.Location = new Point(1089, 9);
            lbCommissions.Name = "lbCommissions";
            lbCommissions.Size = new Size(125, 22);
            lbCommissions.TabIndex = 7;
            lbCommissions.Text = "Comisiones";
            // 
            // lbSubjects
            // 
            lbSubjects.AutoSize = true;
            lbSubjects.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbSubjects.Location = new Point(265, 271);
            lbSubjects.Name = "lbSubjects";
            lbSubjects.Size = new Size(97, 22);
            lbSubjects.TabIndex = 8;
            lbSubjects.Text = "Materias";
            // 
            // lbCourses
            // 
            lbCourses.AutoSize = true;
            lbCourses.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourses.Location = new Point(1004, 271);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(79, 22);
            lbCourses.TabIndex = 9;
            lbCourses.Text = "Cursos";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(628, 540);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 37);
            btnBack.TabIndex = 10;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmEntitiesInfoForPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1373, 589);
            Controls.Add(btnBack);
            Controls.Add(lbCourses);
            Controls.Add(lbSubjects);
            Controls.Add(lbCommissions);
            Controls.Add(lbPlans);
            Controls.Add(lbSpecialities);
            Controls.Add(dgvCourses);
            Controls.Add(dgvSubjects);
            Controls.Add(dgvCommissions);
            Controls.Add(dgvPlans);
            Controls.Add(dgvSpecialities);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEntitiesInfoForPeople";
            Text = "EntitiesInfoForPeople";
            Load += EntitiesInfoForPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSpecialities;
        private DataGridView dgvPlans;
        private DataGridView dgvCommissions;
        private DataGridView dgvSubjects;
        private DataGridView dgvCourses;
        private Label lbSpecialities;
        private Label lbPlans;
        private Label lbCommissions;
        private Label lbSubjects;
        private Label lbCourses;
        private Button btnBack;
    }
}