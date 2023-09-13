namespace UIDesktop
{
    partial class frmStudentsListForTeacher
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
            cBoxNote = new ComboBox();
            lbNote = new Label();
            btnTeacherCoursesCancel = new Button();
            btnTeacherCoursesAccept = new Button();
            txtIdRegistration = new TextBox();
            lbIdStudent = new Label();
            lbCourseList = new Label();
            dgvStudentRegistration = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRegistration).BeginInit();
            SuspendLayout();
            // 
            // cBoxNote
            // 
            cBoxNote.FormattingEnabled = true;
            cBoxNote.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cBoxNote.Location = new Point(998, 255);
            cBoxNote.Name = "cBoxNote";
            cBoxNote.Size = new Size(91, 28);
            cBoxNote.TabIndex = 24;
            // 
            // lbNote
            // 
            lbNote.AutoSize = true;
            lbNote.Location = new Point(861, 263);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(42, 20);
            lbNote.TabIndex = 23;
            lbNote.Text = "Nota";
            // 
            // btnTeacherCoursesCancel
            // 
            btnTeacherCoursesCancel.Location = new Point(834, 372);
            btnTeacherCoursesCancel.Name = "btnTeacherCoursesCancel";
            btnTeacherCoursesCancel.Size = new Size(107, 39);
            btnTeacherCoursesCancel.TabIndex = 22;
            btnTeacherCoursesCancel.Text = "Cancelar";
            btnTeacherCoursesCancel.UseVisualStyleBackColor = true;
            // 
            // btnTeacherCoursesAccept
            // 
            btnTeacherCoursesAccept.Location = new Point(1007, 372);
            btnTeacherCoursesAccept.Name = "btnTeacherCoursesAccept";
            btnTeacherCoursesAccept.Size = new Size(120, 39);
            btnTeacherCoursesAccept.TabIndex = 21;
            btnTeacherCoursesAccept.Text = "Aceptar";
            btnTeacherCoursesAccept.UseVisualStyleBackColor = true;
            btnTeacherCoursesAccept.Click += btnTeacherCoursesAccept_Click;
            // 
            // txtIdRegistration
            // 
            txtIdRegistration.Location = new Point(998, 213);
            txtIdRegistration.Name = "txtIdRegistration";
            txtIdRegistration.Size = new Size(125, 27);
            txtIdRegistration.TabIndex = 20;
            // 
            // lbIdStudent
            // 
            lbIdStudent.AutoSize = true;
            lbIdStudent.Location = new Point(861, 213);
            lbIdStudent.Name = "lbIdStudent";
            lbIdStudent.Size = new Size(131, 20);
            lbIdStudent.TabIndex = 19;
            lbIdStudent.Text = "id registro alumno";
            // 
            // lbCourseList
            // 
            lbCourseList.AutoSize = true;
            lbCourseList.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourseList.Location = new Point(520, 52);
            lbCourseList.Name = "lbCourseList";
            lbCourseList.Size = new Size(185, 28);
            lbCourseList.TabIndex = 18;
            lbCourseList.Text = "Listado curso";
            // 
            // dgvStudentRegistration
            // 
            dgvStudentRegistration.AllowUserToOrderColumns = true;
            dgvStudentRegistration.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentRegistration.GridColor = SystemColors.ButtonHighlight;
            dgvStudentRegistration.Location = new Point(78, 134);
            dgvStudentRegistration.Name = "dgvStudentRegistration";
            dgvStudentRegistration.RowHeadersWidth = 51;
            dgvStudentRegistration.RowTemplate.Height = 29;
            dgvStudentRegistration.Size = new Size(713, 237);
            dgvStudentRegistration.TabIndex = 17;
            // 
            // frmStudentsListForTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1210, 554);
            Controls.Add(cBoxNote);
            Controls.Add(lbNote);
            Controls.Add(btnTeacherCoursesCancel);
            Controls.Add(btnTeacherCoursesAccept);
            Controls.Add(txtIdRegistration);
            Controls.Add(lbIdStudent);
            Controls.Add(lbCourseList);
            Controls.Add(dgvStudentRegistration);
            Name = "frmStudentsListForTeacher";
            Text = "frmStudentsListForTeacher";
            Load += frmStudentsListForTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentRegistration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBoxNote;
        private Label lbNote;
        private Button btnTeacherCoursesCancel;
        private Button btnTeacherCoursesAccept;
        private TextBox txtIdRegistration;
        private Label lbIdStudent;
        private Label lbCourseList;
        private DataGridView dgvStudentRegistration;
    }
}