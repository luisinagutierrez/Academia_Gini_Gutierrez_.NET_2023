namespace UIDesktop
{
    partial class frmCreateAndUpdateSubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAndUpdateSubjects));
            txtSubjectsPlan = new TextBox();
            lbSubjectIdPlan = new Label();
            txtSubjectsWeeklyHours = new TextBox();
            lbSubjectsWeeklyHours = new Label();
            lbCreateUpdateSubjects = new Label();
            pictureLogo = new PictureBox();
            dgvSubjects = new DataGridView();
            txtSubjectDescription = new TextBox();
            lbSubjectDescription = new Label();
            btnUpdateSubject = new Button();
            btnCreateSubject = new Button();
            btnBack = new Button();
            txtIdSubject = new TextBox();
            lbIdSubject = new Label();
            txtSubjectsSpecialityYear = new TextBox();
            lbSubjectsSpecialityYear = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // txtSubjectsPlan
            // 
            txtSubjectsPlan.Location = new Point(822, 367);
            txtSubjectsPlan.Name = "txtSubjectsPlan";
            txtSubjectsPlan.Size = new Size(124, 27);
            txtSubjectsPlan.TabIndex = 54;
            // 
            // lbSubjectIdPlan
            // 
            lbSubjectIdPlan.AutoSize = true;
            lbSubjectIdPlan.Location = new Point(699, 367);
            lbSubjectIdPlan.Name = "lbSubjectIdPlan";
            lbSubjectIdPlan.Size = new Size(55, 20);
            lbSubjectIdPlan.TabIndex = 53;
            lbSubjectIdPlan.Text = "Id plan";
            // 
            // txtSubjectsWeeklyHours
            // 
            txtSubjectsWeeklyHours.Location = new Point(822, 259);
            txtSubjectsWeeklyHours.Name = "txtSubjectsWeeklyHours";
            txtSubjectsWeeklyHours.Size = new Size(124, 27);
            txtSubjectsWeeklyHours.TabIndex = 52;
            // 
            // lbSubjectsWeeklyHours
            // 
            lbSubjectsWeeklyHours.AutoSize = true;
            lbSubjectsWeeklyHours.Location = new Point(699, 259);
            lbSubjectsWeeklyHours.Name = "lbSubjectsWeeklyHours";
            lbSubjectsWeeklyHours.Size = new Size(92, 20);
            lbSubjectsWeeklyHours.TabIndex = 51;
            lbSubjectsWeeklyHours.Text = "Año cursado";
            // 
            // lbCreateUpdateSubjects
            // 
            lbCreateUpdateSubjects.AutoSize = true;
            lbCreateUpdateSubjects.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdateSubjects.Location = new Point(572, 51);
            lbCreateUpdateSubjects.Name = "lbCreateUpdateSubjects";
            lbCreateUpdateSubjects.Size = new Size(108, 25);
            lbCreateUpdateSubjects.TabIndex = 50;
            lbCreateUpdateSubjects.Text = "Materias";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(29, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 90);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 49;
            pictureLogo.TabStop = false;
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(39, 128);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidth = 51;
            dgvSubjects.RowTemplate.Height = 29;
            dgvSubjects.Size = new Size(632, 276);
            dgvSubjects.TabIndex = 48;
            // 
            // txtSubjectDescription
            // 
            txtSubjectDescription.Location = new Point(822, 170);
            txtSubjectDescription.Multiline = true;
            txtSubjectDescription.Name = "txtSubjectDescription";
            txtSubjectDescription.Size = new Size(221, 71);
            txtSubjectDescription.TabIndex = 47;
            // 
            // lbSubjectDescription
            // 
            lbSubjectDescription.AutoSize = true;
            lbSubjectDescription.Location = new Point(699, 173);
            lbSubjectDescription.Name = "lbSubjectDescription";
            lbSubjectDescription.Size = new Size(87, 20);
            lbSubjectDescription.TabIndex = 46;
            lbSubjectDescription.Text = "Descripcion";
            // 
            // btnUpdateSubject
            // 
            btnUpdateSubject.Location = new Point(776, 447);
            btnUpdateSubject.Name = "btnUpdateSubject";
            btnUpdateSubject.Size = new Size(121, 48);
            btnUpdateSubject.TabIndex = 45;
            btnUpdateSubject.Text = "Actualizar comision";
            btnUpdateSubject.UseVisualStyleBackColor = true;
            // 
            // btnCreateSubject
            // 
            btnCreateSubject.Location = new Point(572, 447);
            btnCreateSubject.Name = "btnCreateSubject";
            btnCreateSubject.Size = new Size(121, 48);
            btnCreateSubject.TabIndex = 44;
            btnCreateSubject.Text = "Guardar nueva comision";
            btnCreateSubject.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(357, 447);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 43;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtIdSubject
            // 
            txtIdSubject.Location = new Point(822, 125);
            txtIdSubject.Name = "txtIdSubject";
            txtIdSubject.Size = new Size(124, 27);
            txtIdSubject.TabIndex = 42;
            // 
            // lbIdSubject
            // 
            lbIdSubject.AutoSize = true;
            lbIdSubject.Location = new Point(699, 128);
            lbIdSubject.Name = "lbIdSubject";
            lbIdSubject.Size = new Size(77, 20);
            lbIdSubject.TabIndex = 41;
            lbIdSubject.Text = "Id materia";
            // 
            // txtSubjectsSpecialityYear
            // 
            txtSubjectsSpecialityYear.Location = new Point(822, 317);
            txtSubjectsSpecialityYear.Name = "txtSubjectsSpecialityYear";
            txtSubjectsSpecialityYear.Size = new Size(124, 27);
            txtSubjectsSpecialityYear.TabIndex = 56;
            // 
            // lbSubjectsSpecialityYear
            // 
            lbSubjectsSpecialityYear.AutoSize = true;
            lbSubjectsSpecialityYear.Location = new Point(699, 317);
            lbSubjectsSpecialityYear.Name = "lbSubjectsSpecialityYear";
            lbSubjectsSpecialityYear.Size = new Size(92, 20);
            lbSubjectsSpecialityYear.TabIndex = 55;
            lbSubjectsSpecialityYear.Text = "Año cursado";
            // 
            // frmCreateAndUpdateSubjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1195, 554);
            Controls.Add(txtSubjectsSpecialityYear);
            Controls.Add(lbSubjectsSpecialityYear);
            Controls.Add(txtSubjectsPlan);
            Controls.Add(lbSubjectIdPlan);
            Controls.Add(txtSubjectsWeeklyHours);
            Controls.Add(lbSubjectsWeeklyHours);
            Controls.Add(lbCreateUpdateSubjects);
            Controls.Add(pictureLogo);
            Controls.Add(dgvSubjects);
            Controls.Add(txtSubjectDescription);
            Controls.Add(lbSubjectDescription);
            Controls.Add(btnUpdateSubject);
            Controls.Add(btnCreateSubject);
            Controls.Add(btnBack);
            Controls.Add(txtIdSubject);
            Controls.Add(lbIdSubject);
            Name = "frmCreateAndUpdateSubjects";
            Text = "Crear o actualizar materias";
            Load += frmCreateAndUpdateSubjects_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubjectsPlan;
        private Label lbSubjectIdPlan;
        private TextBox txtSubjectsWeeklyHours;
        private Label lbSubjectsWeeklyHours;
        private Label lbCreateUpdateSubjects;
        private PictureBox pictureLogo;
        private DataGridView dgvSubjects;
        private TextBox txtSubjectDescription;
        private Label lbSubjectDescription;
        private Button btnUpdateSubject;
        private Button btnCreateSubject;
        private Button btnBack;
        private TextBox txtIdSubject;
        private Label lbIdSubject;
        private TextBox txtSubjectsSpecialityYear;
        private Label lbSubjectsSpecialityYear;
    }
}