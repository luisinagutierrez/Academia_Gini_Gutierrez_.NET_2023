namespace UIDesktop
{
    partial class frmDeleteRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteRegistration));
            btnStudentDeleteRegistrationAccept = new Button();
            btnStudentDeleteRegistrationCancel = new Button();
            lbCourses = new Label();
            dgvCoursesRegistration = new DataGridView();
            txtDeleteCouseRegistrationIdCourse = new TextBox();
            lbtxtDeleteCouseRegistrationIdCourse = new Label();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCoursesRegistration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // btnStudentDeleteRegistrationAccept
            // 
            btnStudentDeleteRegistrationAccept.Location = new Point(642, 435);
            btnStudentDeleteRegistrationAccept.Name = "btnStudentDeleteRegistrationAccept";
            btnStudentDeleteRegistrationAccept.Size = new Size(95, 39);
            btnStudentDeleteRegistrationAccept.TabIndex = 15;
            btnStudentDeleteRegistrationAccept.Text = "Aceptar";
            btnStudentDeleteRegistrationAccept.UseVisualStyleBackColor = true;
            // 
            // btnStudentDeleteRegistrationCancel
            // 
            btnStudentDeleteRegistrationCancel.Location = new Point(412, 435);
            btnStudentDeleteRegistrationCancel.Name = "btnStudentDeleteRegistrationCancel";
            btnStudentDeleteRegistrationCancel.Size = new Size(105, 39);
            btnStudentDeleteRegistrationCancel.TabIndex = 14;
            btnStudentDeleteRegistrationCancel.Text = "Cancelar";
            btnStudentDeleteRegistrationCancel.UseVisualStyleBackColor = true;
            btnStudentDeleteRegistrationCancel.Click += btnStudentDeleteRegistrationCancel_Click;
            // 
            // lbCourses
            // 
            lbCourses.AutoSize = true;
            lbCourses.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourses.Location = new Point(319, 47);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(198, 25);
            lbCourses.TabIndex = 13;
            lbCourses.Text = "Cursos Inscripto\r\n";
            lbCourses.Click += lbCouses_Click;
            // 
            // dgvCoursesRegistration
            // 
            dgvCoursesRegistration.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoursesRegistration.Location = new Point(64, 134);
            dgvCoursesRegistration.Name = "dgvCoursesRegistration";
            dgvCoursesRegistration.RowHeadersWidth = 51;
            dgvCoursesRegistration.RowTemplate.Height = 29;
            dgvCoursesRegistration.Size = new Size(673, 216);
            dgvCoursesRegistration.TabIndex = 12;
            // 
            // txtDeleteCouseRegistrationIdCourse
            // 
            txtDeleteCouseRegistrationIdCourse.Location = new Point(183, 367);
            txtDeleteCouseRegistrationIdCourse.Name = "txtDeleteCouseRegistrationIdCourse";
            txtDeleteCouseRegistrationIdCourse.Size = new Size(125, 27);
            txtDeleteCouseRegistrationIdCourse.TabIndex = 11;
            // 
            // lbtxtDeleteCouseRegistrationIdCourse
            // 
            lbtxtDeleteCouseRegistrationIdCourse.AutoSize = true;
            lbtxtDeleteCouseRegistrationIdCourse.Location = new Point(63, 374);
            lbtxtDeleteCouseRegistrationIdCourse.Name = "lbtxtDeleteCouseRegistrationIdCourse";
            lbtxtDeleteCouseRegistrationIdCourse.Size = new Size(67, 20);
            lbtxtDeleteCouseRegistrationIdCourse.TabIndex = 10;
            lbtxtDeleteCouseRegistrationIdCourse.Text = "Id curso*";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(25, 22);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(96, 84);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 16;
            pictureLogo.TabStop = false;
            // 
            // frmDeleteRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(812, 558);
            Controls.Add(pictureLogo);
            Controls.Add(btnStudentDeleteRegistrationAccept);
            Controls.Add(btnStudentDeleteRegistrationCancel);
            Controls.Add(lbCourses);
            Controls.Add(dgvCoursesRegistration);
            Controls.Add(txtDeleteCouseRegistrationIdCourse);
            Controls.Add(lbtxtDeleteCouseRegistrationIdCourse);
            Name = "frmDeleteRegistration";
            Text = "Eliminar Inscripcion";
            ((System.ComponentModel.ISupportInitialize)dgvCoursesRegistration).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentDeleteRegistrationAccept;
        private Button btnStudentDeleteRegistrationCancel;
        private Label lbCourses;
        private DataGridView dgvCoursesRegistration;
        private TextBox txtDeleteCouseRegistrationIdCourse;
        private Label lbtxtDeleteCouseRegistrationIdCourse;
        private PictureBox pictureLogo;
    }
}