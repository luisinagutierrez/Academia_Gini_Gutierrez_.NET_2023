namespace UIDesktop
{
    partial class frmNewRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewRegistration));
            btnStudentNewRegistrationAccept = new Button();
            btnStudentNewRegistrationCancel = new Button();
            lbCoursesAve = new Label();
            dgvNewCourses = new DataGridView();
            txtNewCouseRegistrationIdCourse = new TextBox();
            lbtxtNewCouseRegistrationIdCourse = new Label();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvNewCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // btnStudentNewRegistrationAccept
            // 
            btnStudentNewRegistrationAccept.Location = new Point(642, 422);
            btnStudentNewRegistrationAccept.Name = "btnStudentNewRegistrationAccept";
            btnStudentNewRegistrationAccept.Size = new Size(95, 39);
            btnStudentNewRegistrationAccept.TabIndex = 21;
            btnStudentNewRegistrationAccept.Text = "Aceptar";
            btnStudentNewRegistrationAccept.UseVisualStyleBackColor = true;
            // 
            // btnStudentNewRegistrationCancel
            // 
            btnStudentNewRegistrationCancel.Location = new Point(410, 422);
            btnStudentNewRegistrationCancel.Name = "btnStudentNewRegistrationCancel";
            btnStudentNewRegistrationCancel.Size = new Size(105, 39);
            btnStudentNewRegistrationCancel.TabIndex = 20;
            btnStudentNewRegistrationCancel.Text = "Cancelar";
            btnStudentNewRegistrationCancel.UseVisualStyleBackColor = true;
            btnStudentNewRegistrationCancel.Click += btnStudentNewRegistrationCancel_Click;
            // 
            // lbCoursesAve
            // 
            lbCoursesAve.AutoSize = true;
            lbCoursesAve.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCoursesAve.Location = new Point(302, 37);
            lbCoursesAve.Name = "lbCoursesAve";
            lbCoursesAve.Size = new Size(226, 25);
            lbCoursesAve.TabIndex = 19;
            lbCoursesAve.Text = "Cursos Disponibles\r\n";
            // 
            // dgvNewCourses
            // 
            dgvNewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNewCourses.Location = new Point(59, 101);
            dgvNewCourses.Name = "dgvNewCourses";
            dgvNewCourses.RowHeadersWidth = 51;
            dgvNewCourses.RowTemplate.Height = 29;
            dgvNewCourses.Size = new Size(673, 216);
            dgvNewCourses.TabIndex = 18;
            // 
            // txtNewCouseRegistrationIdCourse
            // 
            txtNewCouseRegistrationIdCourse.Location = new Point(179, 353);
            txtNewCouseRegistrationIdCourse.Name = "txtNewCouseRegistrationIdCourse";
            txtNewCouseRegistrationIdCourse.Size = new Size(125, 27);
            txtNewCouseRegistrationIdCourse.TabIndex = 17;
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
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(29, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 83);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 22;
            pictureLogo.TabStop = false;
            // 
            // frmNewRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(798, 514);
            Controls.Add(pictureLogo);
            Controls.Add(btnStudentNewRegistrationAccept);
            Controls.Add(btnStudentNewRegistrationCancel);
            Controls.Add(lbCoursesAve);
            Controls.Add(dgvNewCourses);
            Controls.Add(txtNewCouseRegistrationIdCourse);
            Controls.Add(lbtxtNewCouseRegistrationIdCourse);
            Name = "frmNewRegistration";
            Text = "Inscripcion curso";
            ((System.ComponentModel.ISupportInitialize)dgvNewCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentNewRegistrationAccept;
        private Button btnStudentNewRegistrationCancel;
        private Label lbCoursesAve;
        private DataGridView dgvNewCourses;
        private TextBox txtNewCouseRegistrationIdCourse;
        private Label lbtxtNewCouseRegistrationIdCourse;
        private PictureBox pictureLogo;
    }
}