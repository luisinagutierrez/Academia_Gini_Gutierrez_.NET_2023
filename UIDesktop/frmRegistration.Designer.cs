namespace UIDesktop
{
    partial class frmRegistration
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
            btnStudentNewRegistrationAccept = new Button();
            btnStudentNewRegistrationCancel = new Button();
            lbCoursesAvailable = new Label();
            dgvAvailableCourses = new DataGridView();
            txtIdCouse = new TextBox();
            lbtxtNewCouseRegistrationIdCourse = new Label();
            btnDeleteRegistration = new Button();
            dgvRegistrationCourses = new DataGridView();
            lbCoursesInscription = new Label();
            txtIdRegistration = new TextBox();
            lbIdRegistration = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrationCourses).BeginInit();
            SuspendLayout();
            // 
            // btnStudentNewRegistrationAccept
            // 
            btnStudentNewRegistrationAccept.Location = new Point(652, 449);
            btnStudentNewRegistrationAccept.Name = "btnStudentNewRegistrationAccept";
            btnStudentNewRegistrationAccept.Size = new Size(95, 51);
            btnStudentNewRegistrationAccept.TabIndex = 21;
            btnStudentNewRegistrationAccept.Text = "Inscribirse";
            btnStudentNewRegistrationAccept.UseVisualStyleBackColor = true;
            btnStudentNewRegistrationAccept.Click += btnStudentNewRegistrationAccept_Click;
            // 
            // btnStudentNewRegistrationCancel
            // 
            btnStudentNewRegistrationCancel.Location = new Point(472, 449);
            btnStudentNewRegistrationCancel.Name = "btnStudentNewRegistrationCancel";
            btnStudentNewRegistrationCancel.Size = new Size(105, 51);
            btnStudentNewRegistrationCancel.TabIndex = 20;
            btnStudentNewRegistrationCancel.Text = "Cancelar";
            btnStudentNewRegistrationCancel.UseVisualStyleBackColor = true;
            btnStudentNewRegistrationCancel.Click += btnStudentNewRegistrationCancel_Click;
            // 
            // lbCoursesAvailable
            // 
            lbCoursesAvailable.AutoSize = true;
            lbCoursesAvailable.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCoursesAvailable.Location = new Point(270, 43);
            lbCoursesAvailable.Name = "lbCoursesAvailable";
            lbCoursesAvailable.Size = new Size(226, 25);
            lbCoursesAvailable.TabIndex = 19;
            lbCoursesAvailable.Text = "Cursos Disponibles\r\n";
            // 
            // dgvAvailableCourses
            // 
            dgvAvailableCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableCourses.Location = new Point(59, 101);
            dgvAvailableCourses.Name = "dgvAvailableCourses";
            dgvAvailableCourses.RowHeadersWidth = 51;
            dgvAvailableCourses.RowTemplate.Height = 29;
            dgvAvailableCourses.Size = new Size(638, 216);
            dgvAvailableCourses.TabIndex = 18;
            dgvAvailableCourses.CellContentClick += dgvNewCourses_CellContentClick;
            dgvAvailableCourses.SelectionChanged += dgvAvailableCourses_SelectionChanged;
            // 
            // txtIdCouse
            // 
            txtIdCouse.Location = new Point(179, 353);
            txtIdCouse.Name = "txtIdCouse";
            txtIdCouse.Size = new Size(125, 27);
            txtIdCouse.TabIndex = 17;
            // 
            // lbtxtNewCouseRegistrationIdCourse
            // 
            lbtxtNewCouseRegistrationIdCourse.AutoSize = true;
            lbtxtNewCouseRegistrationIdCourse.Location = new Point(59, 360);
            lbtxtNewCouseRegistrationIdCourse.Name = "lbtxtNewCouseRegistrationIdCourse";
            lbtxtNewCouseRegistrationIdCourse.Size = new Size(67, 20);
            lbtxtNewCouseRegistrationIdCourse.TabIndex = 16;
            lbtxtNewCouseRegistrationIdCourse.Text = "Id curso*";
            // 
            // btnDeleteRegistration
            // 
            btnDeleteRegistration.Location = new Point(811, 449);
            btnDeleteRegistration.Name = "btnDeleteRegistration";
            btnDeleteRegistration.Size = new Size(95, 51);
            btnDeleteRegistration.TabIndex = 23;
            btnDeleteRegistration.Text = "Eliminar inscripcion";
            btnDeleteRegistration.UseVisualStyleBackColor = true;
            btnDeleteRegistration.Click += btnDeleteRegistration_Click;
            // 
            // dgvRegistrationCourses
            // 
            dgvRegistrationCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistrationCourses.Location = new Point(738, 101);
            dgvRegistrationCourses.Name = "dgvRegistrationCourses";
            dgvRegistrationCourses.RowHeadersWidth = 51;
            dgvRegistrationCourses.RowTemplate.Height = 29;
            dgvRegistrationCourses.Size = new Size(587, 216);
            dgvRegistrationCourses.TabIndex = 24;
            dgvRegistrationCourses.SelectionChanged += dgvRegistrationCourses_SelectionChanged;
            // 
            // lbCoursesInscription
            // 
            lbCoursesInscription.AutoSize = true;
            lbCoursesInscription.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCoursesInscription.Location = new Point(962, 43);
            lbCoursesInscription.Name = "lbCoursesInscription";
            lbCoursesInscription.Size = new Size(198, 25);
            lbCoursesInscription.TabIndex = 25;
            lbCoursesInscription.Text = "Cursos Inscripto";
            // 
            // txtIdRegistration
            // 
            txtIdRegistration.Location = new Point(863, 353);
            txtIdRegistration.Name = "txtIdRegistration";
            txtIdRegistration.Size = new Size(125, 27);
            txtIdRegistration.TabIndex = 27;
            // 
            // lbIdRegistration
            // 
            lbIdRegistration.AutoSize = true;
            lbIdRegistration.Location = new Point(743, 360);
            lbIdRegistration.Name = "lbIdRegistration";
            lbIdRegistration.Size = new Size(103, 20);
            lbIdRegistration.TabIndex = 26;
            lbIdRegistration.Text = "Id Inscripcion*";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1409, 529);
            Controls.Add(txtIdRegistration);
            Controls.Add(lbIdRegistration);
            Controls.Add(lbCoursesInscription);
            Controls.Add(dgvRegistrationCourses);
            Controls.Add(btnDeleteRegistration);
            Controls.Add(btnStudentNewRegistrationAccept);
            Controls.Add(btnStudentNewRegistrationCancel);
            Controls.Add(lbCoursesAvailable);
            Controls.Add(dgvAvailableCourses);
            Controls.Add(txtIdCouse);
            Controls.Add(lbtxtNewCouseRegistrationIdCourse);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistration";
            Text = "Inscripcion curso";
            Load += frmNewRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrationCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentNewRegistrationAccept;
        private Button btnStudentNewRegistrationCancel;
        private Label lbCoursesAvailable;
        private DataGridView dgvAvailableCourses;
        private TextBox txtIdCouse;
        private Label lbtxtNewCouseRegistrationIdCourse;
        private Button btnDeleteRegistration;
        private DataGridView dgvRegistrationCourses;
        private Label lbCoursesInscription;
        private TextBox txtIdRegistration;
        private Label lbIdRegistration;
    }
}