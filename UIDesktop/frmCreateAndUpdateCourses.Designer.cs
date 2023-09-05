namespace UIDesktop
{
    partial class frmCreateAndUpdateCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAndUpdateCourses));
            lbCreateUpdateCourse = new Label();
            pictureLogo = new PictureBox();
            dgvCourses = new DataGridView();
            btnUpdateCourse = new Button();
            btnCreateCourse = new Button();
            btnBack = new Button();
            txtIdCourse = new TextBox();
            lbIdCommission = new Label();
            txtCoursesIdSubject = new TextBox();
            lbCoursesIdSubject = new Label();
            txtCoursesIdCommission = new TextBox();
            lbCoursesIdCommission = new Label();
            txtCourseNumStudents = new TextBox();
            lbCourseNumStudents = new Label();
            txtCoursesQuota = new TextBox();
            lbCoursesQuota = new Label();
            txtCoursesCalendarYear = new TextBox();
            lbCoursesCalendarYear = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // lbCreateUpdateCourse
            // 
            lbCreateUpdateCourse.AutoSize = true;
            lbCreateUpdateCourse.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdateCourse.Location = new Point(427, 52);
            lbCreateUpdateCourse.Name = "lbCreateUpdateCourse";
            lbCreateUpdateCourse.Size = new Size(88, 25);
            lbCreateUpdateCourse.TabIndex = 50;
            lbCreateUpdateCourse.Text = "Cursos";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 90);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 49;
            pictureLogo.TabStop = false;
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(22, 128);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.RowTemplate.Height = 29;
            dgvCourses.Size = new Size(532, 212);
            dgvCourses.TabIndex = 48;
            dgvCourses.CellContentClick += dgvCourses_CellContentClick;
            // 
            // btnUpdateCourse
            // 
            btnUpdateCourse.Location = new Point(646, 381);
            btnUpdateCourse.Name = "btnUpdateCourse";
            btnUpdateCourse.Size = new Size(121, 48);
            btnUpdateCourse.TabIndex = 45;
            btnUpdateCourse.Text = "Actualizar curso";
            btnUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.Location = new Point(460, 381);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(121, 48);
            btnCreateCourse.TabIndex = 44;
            btnCreateCourse.Text = "Guardar nuevo curso";
            btnCreateCourse.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(278, 381);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 43;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtIdCourse
            // 
            txtIdCourse.Location = new Point(720, 117);
            txtIdCourse.Name = "txtIdCourse";
            txtIdCourse.Size = new Size(124, 27);
            txtIdCourse.TabIndex = 42;
            // 
            // lbIdCommission
            // 
            lbIdCommission.AutoSize = true;
            lbIdCommission.Location = new Point(597, 120);
            lbIdCommission.Name = "lbIdCommission";
            lbIdCommission.Size = new Size(61, 20);
            lbIdCommission.TabIndex = 41;
            lbIdCommission.Text = "Id curso";
            // 
            // txtCoursesIdSubject
            // 
            txtCoursesIdSubject.Location = new Point(720, 159);
            txtCoursesIdSubject.Name = "txtCoursesIdSubject";
            txtCoursesIdSubject.Size = new Size(124, 27);
            txtCoursesIdSubject.TabIndex = 56;
            txtCoursesIdSubject.TextChanged += textBox1_TextChanged;
            // 
            // lbCoursesIdSubject
            // 
            lbCoursesIdSubject.AutoSize = true;
            lbCoursesIdSubject.Location = new Point(597, 162);
            lbCoursesIdSubject.Name = "lbCoursesIdSubject";
            lbCoursesIdSubject.Size = new Size(77, 20);
            lbCoursesIdSubject.TabIndex = 55;
            lbCoursesIdSubject.Text = "Id Materia";
            lbCoursesIdSubject.Click += label1_Click;
            // 
            // txtCoursesIdCommission
            // 
            txtCoursesIdCommission.Location = new Point(720, 202);
            txtCoursesIdCommission.Name = "txtCoursesIdCommission";
            txtCoursesIdCommission.Size = new Size(124, 27);
            txtCoursesIdCommission.TabIndex = 58;
            // 
            // lbCoursesIdCommission
            // 
            lbCoursesIdCommission.AutoSize = true;
            lbCoursesIdCommission.Location = new Point(597, 205);
            lbCoursesIdCommission.Name = "lbCoursesIdCommission";
            lbCoursesIdCommission.Size = new Size(86, 20);
            lbCoursesIdCommission.TabIndex = 57;
            lbCoursesIdCommission.Text = "Id comision";
            // 
            // txtCourseNumStudents
            // 
            txtCourseNumStudents.Location = new Point(720, 332);
            txtCourseNumStudents.Name = "txtCourseNumStudents";
            txtCourseNumStudents.Size = new Size(124, 27);
            txtCourseNumStudents.TabIndex = 64;
            // 
            // lbCourseNumStudents
            // 
            lbCourseNumStudents.AutoSize = true;
            lbCourseNumStudents.Location = new Point(596, 332);
            lbCourseNumStudents.Name = "lbCourseNumStudents";
            lbCourseNumStudents.Size = new Size(72, 20);
            lbCourseNumStudents.TabIndex = 63;
            lbCourseNumStudents.Text = "Inscriptos";
            lbCourseNumStudents.Click += label3_Click;
            // 
            // txtCoursesQuota
            // 
            txtCoursesQuota.Location = new Point(720, 286);
            txtCoursesQuota.Name = "txtCoursesQuota";
            txtCoursesQuota.Size = new Size(124, 27);
            txtCoursesQuota.TabIndex = 62;
            // 
            // lbCoursesQuota
            // 
            lbCoursesQuota.AutoSize = true;
            lbCoursesQuota.Location = new Point(597, 289);
            lbCoursesQuota.Name = "lbCoursesQuota";
            lbCoursesQuota.Size = new Size(44, 20);
            lbCoursesQuota.TabIndex = 61;
            lbCoursesQuota.Text = "Cupo";
            // 
            // txtCoursesCalendarYear
            // 
            txtCoursesCalendarYear.Location = new Point(720, 244);
            txtCoursesCalendarYear.Name = "txtCoursesCalendarYear";
            txtCoursesCalendarYear.Size = new Size(124, 27);
            txtCoursesCalendarYear.TabIndex = 60;
            // 
            // lbCoursesCalendarYear
            // 
            lbCoursesCalendarYear.AutoSize = true;
            lbCoursesCalendarYear.Location = new Point(597, 247);
            lbCoursesCalendarYear.Name = "lbCoursesCalendarYear";
            lbCoursesCalendarYear.Size = new Size(110, 20);
            lbCoursesCalendarYear.TabIndex = 59;
            lbCoursesCalendarYear.Text = "Año calendario";
            // 
            // frmCreateAndUpdateCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(950, 478);
            Controls.Add(txtCourseNumStudents);
            Controls.Add(lbCourseNumStudents);
            Controls.Add(txtCoursesQuota);
            Controls.Add(lbCoursesQuota);
            Controls.Add(txtCoursesCalendarYear);
            Controls.Add(lbCoursesCalendarYear);
            Controls.Add(txtCoursesIdCommission);
            Controls.Add(lbCoursesIdCommission);
            Controls.Add(txtCoursesIdSubject);
            Controls.Add(lbCoursesIdSubject);
            Controls.Add(lbCreateUpdateCourse);
            Controls.Add(pictureLogo);
            Controls.Add(dgvCourses);
            Controls.Add(btnUpdateCourse);
            Controls.Add(btnCreateCourse);
            Controls.Add(btnBack);
            Controls.Add(txtIdCourse);
            Controls.Add(lbIdCommission);
            Name = "frmCreateAndUpdateCourses";
            Text = "Crear o nombrar curso";
            Load += frmCreateAndUpdateCourses_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCreateUpdateCourse;
        private PictureBox pictureLogo;
        private DataGridView dgvCourses;
        private Button btnUpdateCourse;
        private Button btnCreateCourse;
        private Button btnBack;
        private TextBox txtIdCourse;
        private Label lbIdCommission;
        private TextBox txtCoursesIdSubject;
        private Label lbCoursesIdSubject;
        private TextBox txtCoursesIdCommission;
        private Label lbCoursesIdCommission;
        private TextBox txtCourseNumStudents;
        private Label lbCourseNumStudents;
        private TextBox txtCoursesQuota;
        private Label lbCoursesQuota;
        private TextBox txtCoursesCalendarYear;
        private Label lbCoursesCalendarYear;
    }
}