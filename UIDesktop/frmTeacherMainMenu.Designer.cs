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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherMainMenu));
            dgvTeacheraCoursesList = new DataGridView();
            lbTeacherCoursesList = new Label();
            label1 = new Label();
            txtTeacherCoursesIdCourse = new TextBox();
            btnTeacherCoursesAccept = new Button();
            btnTeacherCoursesCancel = new Button();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTeacheraCoursesList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvTeacheraCoursesList
            // 
            dgvTeacheraCoursesList.AllowUserToOrderColumns = true;
            dgvTeacheraCoursesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacheraCoursesList.GridColor = SystemColors.ButtonHighlight;
            dgvTeacheraCoursesList.Location = new Point(12, 108);
            dgvTeacheraCoursesList.Name = "dgvTeacheraCoursesList";
            dgvTeacheraCoursesList.RowHeadersWidth = 51;
            dgvTeacheraCoursesList.RowTemplate.Height = 29;
            dgvTeacheraCoursesList.Size = new Size(776, 188);
            dgvTeacheraCoursesList.TabIndex = 1;
            // 
            // lbTeacherCoursesList
            // 
            lbTeacherCoursesList.AutoSize = true;
            lbTeacherCoursesList.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTeacherCoursesList.Location = new Point(286, 48);
            lbTeacherCoursesList.Name = "lbTeacherCoursesList";
            lbTeacherCoursesList.Size = new Size(241, 28);
            lbTeacherCoursesList.TabIndex = 2;
            lbTeacherCoursesList.Text = "Listado de Cursos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 319);
            label1.Name = "label1";
            label1.Size = new Size(262, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresar IdCurso para ver sus alumnos ";
            // 
            // txtTeacherCoursesIdCourse
            // 
            txtTeacherCoursesIdCourse.Location = new Point(286, 316);
            txtTeacherCoursesIdCourse.Name = "txtTeacherCoursesIdCourse";
            txtTeacherCoursesIdCourse.Size = new Size(125, 27);
            txtTeacherCoursesIdCourse.TabIndex = 4;
            txtTeacherCoursesIdCourse.TextChanged += txtTeacherCoursesIdCourse_TextChanged;
            // 
            // btnTeacherCoursesAccept
            // 
            btnTeacherCoursesAccept.Location = new Point(648, 390);
            btnTeacherCoursesAccept.Name = "btnTeacherCoursesAccept";
            btnTeacherCoursesAccept.Size = new Size(120, 39);
            btnTeacherCoursesAccept.TabIndex = 5;
            btnTeacherCoursesAccept.Text = "Aceptar";
            btnTeacherCoursesAccept.UseVisualStyleBackColor = true;
            btnTeacherCoursesAccept.Click += btnTeacherCoursesAccept_Click;
            // 
            // btnTeacherCoursesCancel
            // 
            btnTeacherCoursesCancel.Location = new Point(420, 390);
            btnTeacherCoursesCancel.Name = "btnTeacherCoursesCancel";
            btnTeacherCoursesCancel.Size = new Size(107, 39);
            btnTeacherCoursesCancel.TabIndex = 6;
            btnTeacherCoursesCancel.Text = "Cancelar";
            btnTeacherCoursesCancel.UseVisualStyleBackColor = true;
            btnTeacherCoursesCancel.Click += btnTeacherCoursesCancel_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(96, 84);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 17;
            pictureLogo.TabStop = false;
            // 
            // frmTeacherMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureLogo);
            Controls.Add(btnTeacherCoursesCancel);
            Controls.Add(btnTeacherCoursesAccept);
            Controls.Add(txtTeacherCoursesIdCourse);
            Controls.Add(label1);
            Controls.Add(lbTeacherCoursesList);
            Controls.Add(dgvTeacheraCoursesList);
            Name = "frmTeacherMainMenu";
            Text = "Menú de Profesores";
            Load += frmTeacherMainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeacheraCoursesList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTeacheraCoursesList;
        private Label lbTeacherCoursesList;
        private Label label1;
        private TextBox txtTeacherCoursesIdCourse;
        private Button btnTeacherCoursesAccept;
        private Button btnTeacherCoursesCancel;
        private PictureBox pictureLogo;
    }
}