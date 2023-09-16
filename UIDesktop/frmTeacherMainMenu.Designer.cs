namespace UIDesktop
{
    partial class frmTeacherMainMenu
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
            dgvRegistrationCourses = new DataGridView();
            lbTeacherCoursesList = new Label();
            label1 = new Label();
            txtTeacherCoursesIdCourse = new TextBox();
            btnTeacherCoursesAccept = new Button();
            btnTeacherCoursesCancel = new Button();
            cBoxMark = new ComboBox();
            lbNote = new Label();
            btnCancelStudentRegistration = new Button();
            btnStudentRegistrationAccept = new Button();
            txtIdRegistration = new TextBox();
            lbIdRegistration = new Label();
            lbCourseList = new Label();
            dgvStudentRegistration = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrationCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRegistration).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistrationCourses
            // 
            dgvRegistrationCourses.AllowUserToOrderColumns = true;
            dgvRegistrationCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistrationCourses.GridColor = SystemColors.ButtonHighlight;
            dgvRegistrationCourses.Location = new Point(55, 91);
            dgvRegistrationCourses.Name = "dgvRegistrationCourses";
            dgvRegistrationCourses.RowHeadersWidth = 51;
            dgvRegistrationCourses.RowTemplate.Height = 29;
            dgvRegistrationCourses.Size = new Size(520, 211);
            dgvRegistrationCourses.TabIndex = 1;
            dgvRegistrationCourses.CellContentClick += dgvTeacheraCoursesList_CellContentClick;
            dgvRegistrationCourses.SelectionChanged += dgvRegistrationCourses_SelectionChanged;
            // 
            // lbTeacherCoursesList
            // 
            lbTeacherCoursesList.AutoSize = true;
            lbTeacherCoursesList.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTeacherCoursesList.Location = new Point(195, 18);
            lbTeacherCoursesList.Name = "lbTeacherCoursesList";
            lbTeacherCoursesList.Size = new Size(241, 28);
            lbTeacherCoursesList.TabIndex = 2;
            lbTeacherCoursesList.Text = "Listado de Cursos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 326);
            label1.Name = "label1";
            label1.Size = new Size(262, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresar IdCurso para ver sus alumnos ";
            // 
            // txtTeacherCoursesIdCourse
            // 
            txtTeacherCoursesIdCourse.Location = new Point(328, 323);
            txtTeacherCoursesIdCourse.Name = "txtTeacherCoursesIdCourse";
            txtTeacherCoursesIdCourse.Size = new Size(125, 27);
            txtTeacherCoursesIdCourse.TabIndex = 4;
            txtTeacherCoursesIdCourse.TextChanged += txtTeacherCoursesIdCourse_TextChanged;
            // 
            // btnTeacherCoursesAccept
            // 
            btnTeacherCoursesAccept.Location = new Point(458, 389);
            btnTeacherCoursesAccept.Name = "btnTeacherCoursesAccept";
            btnTeacherCoursesAccept.Size = new Size(120, 39);
            btnTeacherCoursesAccept.TabIndex = 5;
            btnTeacherCoursesAccept.Text = "Aceptar";
            btnTeacherCoursesAccept.UseVisualStyleBackColor = true;
            btnTeacherCoursesAccept.Click += btnTeacherCoursesAccept_Click;
            // 
            // btnTeacherCoursesCancel
            // 
            btnTeacherCoursesCancel.Location = new Point(328, 389);
            btnTeacherCoursesCancel.Name = "btnTeacherCoursesCancel";
            btnTeacherCoursesCancel.Size = new Size(107, 39);
            btnTeacherCoursesCancel.TabIndex = 6;
            btnTeacherCoursesCancel.Text = "Cancelar";
            btnTeacherCoursesCancel.UseVisualStyleBackColor = true;
            btnTeacherCoursesCancel.Click += btnTeacherCoursesCancel_Click;
            // 
            // cBoxMark
            // 
            cBoxMark.FormattingEnabled = true;
            cBoxMark.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cBoxMark.Location = new Point(884, 365);
            cBoxMark.Name = "cBoxMark";
            cBoxMark.Size = new Size(91, 28);
            cBoxMark.TabIndex = 32;
            // 
            // lbNote
            // 
            lbNote.AutoSize = true;
            lbNote.Location = new Point(731, 373);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(42, 20);
            lbNote.TabIndex = 31;
            lbNote.Text = "Nota";
            // 
            // btnCancelStudentRegistration
            // 
            btnCancelStudentRegistration.Location = new Point(1086, 354);
            btnCancelStudentRegistration.Name = "btnCancelStudentRegistration";
            btnCancelStudentRegistration.Size = new Size(120, 39);
            btnCancelStudentRegistration.TabIndex = 30;
            btnCancelStudentRegistration.Text = "Cancelar";
            btnCancelStudentRegistration.UseVisualStyleBackColor = true;
            btnCancelStudentRegistration.Click += btnCancelStudentRegistration_Click_1;
            // 
            // btnStudentRegistrationAccept
            // 
            btnStudentRegistrationAccept.Location = new Point(1273, 354);
            btnStudentRegistrationAccept.Name = "btnStudentRegistrationAccept";
            btnStudentRegistrationAccept.Size = new Size(120, 39);
            btnStudentRegistrationAccept.TabIndex = 29;
            btnStudentRegistrationAccept.Text = "Aceptar";
            btnStudentRegistrationAccept.UseVisualStyleBackColor = true;
            btnStudentRegistrationAccept.Click += btnStudentRegistrationAccept_Click;
            // 
            // txtIdRegistration
            // 
            txtIdRegistration.Location = new Point(884, 316);
            txtIdRegistration.Name = "txtIdRegistration";
            txtIdRegistration.Size = new Size(125, 27);
            txtIdRegistration.TabIndex = 28;
            // 
            // lbIdRegistration
            // 
            lbIdRegistration.AutoSize = true;
            lbIdRegistration.Location = new Point(731, 323);
            lbIdRegistration.Name = "lbIdRegistration";
            lbIdRegistration.Size = new Size(131, 20);
            lbIdRegistration.TabIndex = 27;
            lbIdRegistration.Text = "Id registro alumno";
            // 
            // lbCourseList
            // 
            lbCourseList.AutoSize = true;
            lbCourseList.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourseList.Location = new Point(956, 18);
            lbCourseList.Name = "lbCourseList";
            lbCourseList.Size = new Size(185, 28);
            lbCourseList.TabIndex = 26;
            lbCourseList.Text = "Listado curso";
            // 
            // dgvStudentRegistration
            // 
            dgvStudentRegistration.AllowUserToOrderColumns = true;
            dgvStudentRegistration.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentRegistration.GridColor = SystemColors.ButtonHighlight;
            dgvStudentRegistration.Location = new Point(680, 91);
            dgvStudentRegistration.Name = "dgvStudentRegistration";
            dgvStudentRegistration.RowHeadersWidth = 51;
            dgvStudentRegistration.RowTemplate.Height = 29;
            dgvStudentRegistration.Size = new Size(713, 211);
            dgvStudentRegistration.TabIndex = 25;
            dgvStudentRegistration.SelectionChanged += dgvStudentRegistration_SelectionChanged;
            // 
            // frmTeacherMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1503, 701);
            Controls.Add(cBoxMark);
            Controls.Add(lbNote);
            Controls.Add(btnCancelStudentRegistration);
            Controls.Add(btnStudentRegistrationAccept);
            Controls.Add(txtIdRegistration);
            Controls.Add(lbIdRegistration);
            Controls.Add(lbCourseList);
            Controls.Add(dgvStudentRegistration);
            Controls.Add(btnTeacherCoursesCancel);
            Controls.Add(btnTeacherCoursesAccept);
            Controls.Add(txtTeacherCoursesIdCourse);
            Controls.Add(label1);
            Controls.Add(lbTeacherCoursesList);
            Controls.Add(dgvRegistrationCourses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTeacherMainMenu";
            Text = "Menú de Profesores";
            Load += frmTeacherMainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistrationCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRegistration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegistrationCourses;
        private Label lbTeacherCoursesList;
        private Label label1;
        private TextBox txtTeacherCoursesIdCourse;
        private Button btnTeacherCoursesAccept;
        private Button btnTeacherCoursesCancel;
        private ComboBox cBoxMark;
        private Label lbNote;
        private Button btnCancelStudentRegistration;
        private Button btnStudentRegistrationAccept;
        private TextBox txtIdRegistration;
        private Label lbIdRegistration;
        private Label lbCourseList;
        private DataGridView dgvStudentRegistration;
    }
}