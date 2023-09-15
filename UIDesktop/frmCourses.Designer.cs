namespace UIDesktop
{
    partial class frmCourses
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
            lbCreateUpdateCourse = new Label();
            dgvCourses = new DataGridView();
            btnUpdateCourse = new Button();
            btnCreateCourse = new Button();
            btnBack = new Button();
            txtIdCourse = new TextBox();
            lbIdCommission = new Label();
            lbCoursesIdSubject = new Label();
            lbCoursesIdCommission = new Label();
            txtCoursesQuota = new TextBox();
            lbCoursesQuota = new Label();
            txtCoursesCalendarYear = new TextBox();
            lbCoursesCalendarYear = new Label();
            btnDeleteCourse = new Button();
            cBoxIdSubject = new ComboBox();
            cBoxIdCommission = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // lbCreateUpdateCourse
            // 
            lbCreateUpdateCourse.AutoSize = true;
            lbCreateUpdateCourse.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdateCourse.Location = new Point(762, 53);
            lbCreateUpdateCourse.Name = "lbCreateUpdateCourse";
            lbCreateUpdateCourse.Size = new Size(88, 25);
            lbCreateUpdateCourse.TabIndex = 50;
            lbCreateUpdateCourse.Text = "Cursos";
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(246, 154);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.RowTemplate.Height = 29;
            dgvCourses.Size = new Size(741, 225);
            dgvCourses.TabIndex = 48;
            dgvCourses.CellContentClick += dgvCourses_CellContentClick;
            dgvCourses.SelectionChanged += dgvCourses_SelectionChanged;
            // 
            // btnUpdateCourse
            // 
            btnUpdateCourse.Location = new Point(854, 451);
            btnUpdateCourse.Name = "btnUpdateCourse";
            btnUpdateCourse.Size = new Size(121, 48);
            btnUpdateCourse.TabIndex = 45;
            btnUpdateCourse.Text = "Actualizar curso";
            btnUpdateCourse.UseVisualStyleBackColor = true;
            btnUpdateCourse.Click += btnUpdateCourse_Click;
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.Location = new Point(675, 451);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(121, 48);
            btnCreateCourse.TabIndex = 44;
            btnCreateCourse.Text = "Guardar nuevo curso";
            btnCreateCourse.UseVisualStyleBackColor = true;
            btnCreateCourse.Click += btnCreateCourse_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(493, 451);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 43;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtIdCourse
            // 
            txtIdCourse.Location = new Point(1143, 168);
            txtIdCourse.Name = "txtIdCourse";
            txtIdCourse.Size = new Size(124, 27);
            txtIdCourse.TabIndex = 42;
            // 
            // lbIdCommission
            // 
            lbIdCommission.AutoSize = true;
            lbIdCommission.Location = new Point(1020, 171);
            lbIdCommission.Name = "lbIdCommission";
            lbIdCommission.Size = new Size(61, 20);
            lbIdCommission.TabIndex = 41;
            lbIdCommission.Text = "Id curso";
            // 
            // lbCoursesIdSubject
            // 
            lbCoursesIdSubject.AutoSize = true;
            lbCoursesIdSubject.Location = new Point(1020, 213);
            lbCoursesIdSubject.Name = "lbCoursesIdSubject";
            lbCoursesIdSubject.Size = new Size(77, 20);
            lbCoursesIdSubject.TabIndex = 55;
            lbCoursesIdSubject.Text = "Id Materia";
            lbCoursesIdSubject.Click += label1_Click;
            // 
            // lbCoursesIdCommission
            // 
            lbCoursesIdCommission.AutoSize = true;
            lbCoursesIdCommission.Location = new Point(1020, 256);
            lbCoursesIdCommission.Name = "lbCoursesIdCommission";
            lbCoursesIdCommission.Size = new Size(86, 20);
            lbCoursesIdCommission.TabIndex = 57;
            lbCoursesIdCommission.Text = "Id comision";
            // 
            // txtCoursesQuota
            // 
            txtCoursesQuota.Location = new Point(1143, 337);
            txtCoursesQuota.Name = "txtCoursesQuota";
            txtCoursesQuota.Size = new Size(124, 27);
            txtCoursesQuota.TabIndex = 62;
            // 
            // lbCoursesQuota
            // 
            lbCoursesQuota.AutoSize = true;
            lbCoursesQuota.Location = new Point(1020, 340);
            lbCoursesQuota.Name = "lbCoursesQuota";
            lbCoursesQuota.Size = new Size(44, 20);
            lbCoursesQuota.TabIndex = 61;
            lbCoursesQuota.Text = "Cupo";
            // 
            // txtCoursesCalendarYear
            // 
            txtCoursesCalendarYear.Location = new Point(1143, 295);
            txtCoursesCalendarYear.Name = "txtCoursesCalendarYear";
            txtCoursesCalendarYear.Size = new Size(124, 27);
            txtCoursesCalendarYear.TabIndex = 60;
            // 
            // lbCoursesCalendarYear
            // 
            lbCoursesCalendarYear.AutoSize = true;
            lbCoursesCalendarYear.Location = new Point(1020, 298);
            lbCoursesCalendarYear.Name = "lbCoursesCalendarYear";
            lbCoursesCalendarYear.Size = new Size(110, 20);
            lbCoursesCalendarYear.TabIndex = 59;
            lbCoursesCalendarYear.Text = "Año calendario";
            // 
            // btnDeleteCourse
            // 
            btnDeleteCourse.Location = new Point(1032, 451);
            btnDeleteCourse.Name = "btnDeleteCourse";
            btnDeleteCourse.Size = new Size(121, 48);
            btnDeleteCourse.TabIndex = 65;
            btnDeleteCourse.Text = "Eliminar curso";
            btnDeleteCourse.UseVisualStyleBackColor = true;
            btnDeleteCourse.Click += btnDeleteCourse_Click;
            // 
            // cBoxIdSubject
            // 
            cBoxIdSubject.FormattingEnabled = true;
            cBoxIdSubject.Location = new Point(1143, 205);
            cBoxIdSubject.Name = "cBoxIdSubject";
            cBoxIdSubject.Size = new Size(124, 28);
            cBoxIdSubject.TabIndex = 66;
            // 
            // cBoxIdCommission
            // 
            cBoxIdCommission.FormattingEnabled = true;
            cBoxIdCommission.Location = new Point(1143, 248);
            cBoxIdCommission.Name = "cBoxIdCommission";
            cBoxIdCommission.Size = new Size(124, 28);
            cBoxIdCommission.TabIndex = 67;
            // 
            // frmCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1585, 613);
            Controls.Add(cBoxIdCommission);
            Controls.Add(cBoxIdSubject);
            Controls.Add(btnDeleteCourse);
            Controls.Add(txtCoursesQuota);
            Controls.Add(lbCoursesQuota);
            Controls.Add(txtCoursesCalendarYear);
            Controls.Add(lbCoursesCalendarYear);
            Controls.Add(lbCoursesIdCommission);
            Controls.Add(lbCoursesIdSubject);
            Controls.Add(lbCreateUpdateCourse);
            Controls.Add(dgvCourses);
            Controls.Add(btnUpdateCourse);
            Controls.Add(btnCreateCourse);
            Controls.Add(btnBack);
            Controls.Add(txtIdCourse);
            Controls.Add(lbIdCommission);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCourses";
            Text = "Crear o nombrar curso";
            Load += frmCreateAndUpdateCourses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCreateUpdateCourse;
        private DataGridView dgvCourses;
        private Button btnUpdateCourse;
        private Button btnCreateCourse;
        private Button btnBack;
        private TextBox txtIdCourse;
        private Label lbIdCommission;
        private Label lbCoursesIdSubject;
        private Label lbCoursesIdCommission;
        private TextBox txtCoursesQuota;
        private Label lbCoursesQuota;
        private TextBox txtCoursesCalendarYear;
        private Label lbCoursesCalendarYear;
        private Button btnDeleteCourse;
        private ComboBox cBoxIdSubject;
        private ComboBox cBoxIdCommission;
    }
}