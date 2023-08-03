namespace UIDesktop
{
    partial class frmStudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegistration));
            dgvStudentCourses = new DataGridView();
            btnStudentNewInscription = new Button();
            btnStudentDeleteInscription = new Button();
            lbStudetnCourses = new Label();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudentCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentCourses
            // 
            dgvStudentCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentCourses.Location = new Point(78, 99);
            dgvStudentCourses.Name = "dgvStudentCourses";
            dgvStudentCourses.RowHeadersWidth = 51;
            dgvStudentCourses.RowTemplate.Height = 29;
            dgvStudentCourses.Size = new Size(650, 200);
            dgvStudentCourses.TabIndex = 0;
            // 
            // btnStudentNewInscription
            // 
            btnStudentNewInscription.Location = new Point(526, 329);
            btnStudentNewInscription.Name = "btnStudentNewInscription";
            btnStudentNewInscription.Size = new Size(112, 64);
            btnStudentNewInscription.TabIndex = 1;
            btnStudentNewInscription.Text = "Nueva Inscripcion";
            btnStudentNewInscription.UseVisualStyleBackColor = true;
            btnStudentNewInscription.Click += btnStudentNewInscription_Click;
            // 
            // btnStudentDeleteInscription
            // 
            btnStudentDeleteInscription.Location = new Point(222, 329);
            btnStudentDeleteInscription.Name = "btnStudentDeleteInscription";
            btnStudentDeleteInscription.Size = new Size(112, 62);
            btnStudentDeleteInscription.TabIndex = 2;
            btnStudentDeleteInscription.Text = "Dar de baja inscripcion";
            btnStudentDeleteInscription.UseVisualStyleBackColor = true;
            btnStudentDeleteInscription.Click += btnStudentDeleteInscription_Click;
            // 
            // lbStudetnCourses
            // 
            lbStudetnCourses.AutoSize = true;
            lbStudetnCourses.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbStudetnCourses.Location = new Point(309, 43);
            lbStudetnCourses.Name = "lbStudetnCourses";
            lbStudetnCourses.Size = new Size(210, 25);
            lbStudetnCourses.TabIndex = 7;
            lbStudetnCourses.Text = "Cursos Inscriptos";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(28, 10);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 83);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 23;
            pictureLogo.TabStop = false;
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureLogo);
            Controls.Add(lbStudetnCourses);
            Controls.Add(btnStudentDeleteInscription);
            Controls.Add(btnStudentNewInscription);
            Controls.Add(dgvStudentCourses);
            Name = "frmStudentRegistration";
            Text = "Inscripcion Alumno";
            Load += frmStudentRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentCourses;
        private Button btnStudentNewInscription;
        private Button btnStudentDeleteInscription;
        private Label lbStudetnCourses;
        private PictureBox pictureLogo;
    }
}