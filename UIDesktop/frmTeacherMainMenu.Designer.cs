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
            ((System.ComponentModel.ISupportInitialize)dgvRegistrationCourses).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistrationCourses
            // 
            dgvRegistrationCourses.AllowUserToOrderColumns = true;
            dgvRegistrationCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistrationCourses.GridColor = SystemColors.ButtonHighlight;
            dgvRegistrationCourses.Location = new Point(509, 135);
            dgvRegistrationCourses.Name = "dgvRegistrationCourses";
            dgvRegistrationCourses.RowHeadersWidth = 51;
            dgvRegistrationCourses.RowTemplate.Height = 29;
            dgvRegistrationCourses.Size = new Size(520, 211);
            dgvRegistrationCourses.TabIndex = 1;
            dgvRegistrationCourses.CellContentClick += dgvTeacheraCoursesList_CellContentClick;
            // 
            // lbTeacherCoursesList
            // 
            lbTeacherCoursesList.AutoSize = true;
            lbTeacherCoursesList.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTeacherCoursesList.Location = new Point(649, 62);
            lbTeacherCoursesList.Name = "lbTeacherCoursesList";
            lbTeacherCoursesList.Size = new Size(241, 28);
            lbTeacherCoursesList.TabIndex = 2;
            lbTeacherCoursesList.Text = "Listado de Cursos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 370);
            label1.Name = "label1";
            label1.Size = new Size(262, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresar IdCurso para ver sus alumnos ";
            // 
            // txtTeacherCoursesIdCourse
            // 
            txtTeacherCoursesIdCourse.Location = new Point(782, 367);
            txtTeacherCoursesIdCourse.Name = "txtTeacherCoursesIdCourse";
            txtTeacherCoursesIdCourse.Size = new Size(125, 27);
            txtTeacherCoursesIdCourse.TabIndex = 4;
            txtTeacherCoursesIdCourse.TextChanged += txtTeacherCoursesIdCourse_TextChanged;
            // 
            // btnTeacherCoursesAccept
            // 
            btnTeacherCoursesAccept.Location = new Point(912, 433);
            btnTeacherCoursesAccept.Name = "btnTeacherCoursesAccept";
            btnTeacherCoursesAccept.Size = new Size(120, 39);
            btnTeacherCoursesAccept.TabIndex = 5;
            btnTeacherCoursesAccept.Text = "Aceptar";
            btnTeacherCoursesAccept.UseVisualStyleBackColor = true;
            btnTeacherCoursesAccept.Click += btnTeacherCoursesAccept_Click;
            // 
            // btnTeacherCoursesCancel
            // 
            btnTeacherCoursesCancel.Location = new Point(782, 433);
            btnTeacherCoursesCancel.Name = "btnTeacherCoursesCancel";
            btnTeacherCoursesCancel.Size = new Size(107, 39);
            btnTeacherCoursesCancel.TabIndex = 6;
            btnTeacherCoursesCancel.Text = "Cancelar";
            btnTeacherCoursesCancel.UseVisualStyleBackColor = true;
            btnTeacherCoursesCancel.Click += btnTeacherCoursesCancel_Click;
            // 
            // frmTeacherMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1393, 701);
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
    }
}