namespace UIDesktop
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnUpMain = new Panel();
            btnMinimize = new PictureBox();
            btnRestore = new PictureBox();
            btnMaximize = new PictureBox();
            btnClose = new PictureBox();
            pnLeftMain = new Panel();
            btnEntitiesInfo = new Button();
            btnUsers = new Button();
            btnContact = new Button();
            pnSubmenuReports = new Panel();
            btnPlansReports = new Button();
            btnCoursesReports = new Button();
            btnExit = new PictureBox();
            btnReports = new Button();
            btnTeacherMenu = new Button();
            btnStudentRegistration = new Button();
            btnCourse = new Button();
            btnSubjects = new Button();
            btnCommission = new Button();
            btnPlan = new Button();
            btnSpeciality = new Button();
            btnPerson = new Button();
            pictureBox1 = new PictureBox();
            pnContainerMain = new Panel();
            pnUpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            pnLeftMain.SuspendLayout();
            pnSubmenuReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnUpMain
            // 
            pnUpMain.BackColor = Color.FromArgb(0, 80, 200);
            pnUpMain.Controls.Add(btnMinimize);
            pnUpMain.Controls.Add(btnRestore);
            pnUpMain.Controls.Add(btnMaximize);
            pnUpMain.Controls.Add(btnClose);
            pnUpMain.Dock = DockStyle.Top;
            pnUpMain.Location = new Point(0, 0);
            pnUpMain.Name = "pnUpMain";
            pnUpMain.Size = new Size(1370, 38);
            pnUpMain.TabIndex = 0;
            pnUpMain.MouseDown += pnUpMain_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(1252, 7);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.Image = (Image)resources.GetObject("btnRestore.Image");
            btnRestore.Location = new Point(1293, 7);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(25, 25);
            btnRestore.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestore.TabIndex = 2;
            btnRestore.TabStop = false;
            btnRestore.Visible = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(1293, 7);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(25, 25);
            btnMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximize.TabIndex = 1;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1333, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnLeftMain
            // 
            pnLeftMain.BackColor = Color.FromArgb(26, 32, 40);
            pnLeftMain.Controls.Add(btnEntitiesInfo);
            pnLeftMain.Controls.Add(btnUsers);
            pnLeftMain.Controls.Add(btnContact);
            pnLeftMain.Controls.Add(pnSubmenuReports);
            pnLeftMain.Controls.Add(btnExit);
            pnLeftMain.Controls.Add(btnReports);
            pnLeftMain.Controls.Add(btnTeacherMenu);
            pnLeftMain.Controls.Add(btnStudentRegistration);
            pnLeftMain.Controls.Add(btnCourse);
            pnLeftMain.Controls.Add(btnSubjects);
            pnLeftMain.Controls.Add(btnCommission);
            pnLeftMain.Controls.Add(btnPlan);
            pnLeftMain.Controls.Add(btnSpeciality);
            pnLeftMain.Controls.Add(btnPerson);
            pnLeftMain.Controls.Add(pictureBox1);
            pnLeftMain.Dock = DockStyle.Left;
            pnLeftMain.Location = new Point(0, 38);
            pnLeftMain.Name = "pnLeftMain";
            pnLeftMain.Size = new Size(220, 809);
            pnLeftMain.TabIndex = 1;
            // 
            // btnEntitiesInfo
            // 
            btnEntitiesInfo.Cursor = Cursors.Hand;
            btnEntitiesInfo.FlatAppearance.BorderSize = 0;
            btnEntitiesInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnEntitiesInfo.FlatStyle = FlatStyle.Flat;
            btnEntitiesInfo.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntitiesInfo.ForeColor = SystemColors.ButtonHighlight;
            btnEntitiesInfo.Location = new Point(0, 227);
            btnEntitiesInfo.Name = "btnEntitiesInfo";
            btnEntitiesInfo.Size = new Size(220, 32);
            btnEntitiesInfo.TabIndex = 3;
            btnEntitiesInfo.Text = "Listados clases";
            btnEntitiesInfo.UseVisualStyleBackColor = true;
            btnEntitiesInfo.Click += btnEntitiesInfo_Click;
            // 
            // btnUsers
            // 
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.ForeColor = SystemColors.ButtonHighlight;
            btnUsers.Location = new Point(0, 530);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(220, 32);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnContact
            // 
            btnContact.Cursor = Cursors.Hand;
            btnContact.FlatAppearance.BorderSize = 0;
            btnContact.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnContact.FlatStyle = FlatStyle.Flat;
            btnContact.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnContact.ForeColor = SystemColors.ButtonHighlight;
            btnContact.Location = new Point(0, 688);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(220, 32);
            btnContact.TabIndex = 6;
            btnContact.Text = "Contacto";
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += btnContact_Click;
            // 
            // pnSubmenuReports
            // 
            pnSubmenuReports.Controls.Add(btnPlansReports);
            pnSubmenuReports.Controls.Add(btnCoursesReports);
            pnSubmenuReports.Location = new Point(71, 606);
            pnSubmenuReports.Name = "pnSubmenuReports";
            pnSubmenuReports.Size = new Size(149, 76);
            pnSubmenuReports.TabIndex = 4;
            pnSubmenuReports.Visible = false;
            // 
            // btnPlansReports
            // 
            btnPlansReports.Cursor = Cursors.Hand;
            btnPlansReports.FlatAppearance.BorderSize = 0;
            btnPlansReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPlansReports.FlatStyle = FlatStyle.Flat;
            btnPlansReports.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlansReports.ForeColor = SystemColors.ButtonHighlight;
            btnPlansReports.Location = new Point(0, 44);
            btnPlansReports.Name = "btnPlansReports";
            btnPlansReports.Size = new Size(149, 32);
            btnPlansReports.TabIndex = 3;
            btnPlansReports.Text = "Planes";
            btnPlansReports.UseVisualStyleBackColor = true;
            btnPlansReports.Click += btnPlansReports_Click;
            // 
            // btnCoursesReports
            // 
            btnCoursesReports.Cursor = Cursors.Hand;
            btnCoursesReports.FlatAppearance.BorderSize = 0;
            btnCoursesReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCoursesReports.FlatStyle = FlatStyle.Flat;
            btnCoursesReports.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoursesReports.ForeColor = SystemColors.ButtonHighlight;
            btnCoursesReports.Location = new Point(0, 0);
            btnCoursesReports.Name = "btnCoursesReports";
            btnCoursesReports.Size = new Size(149, 32);
            btnCoursesReports.TabIndex = 4;
            btnCoursesReports.Text = "Cursos";
            btnCoursesReports.UseVisualStyleBackColor = true;
            btnCoursesReports.Click += btnPeopleReports_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(0, 750);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 59);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 5;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReports.ForeColor = SystemColors.ButtonHighlight;
            btnReports.Location = new Point(0, 568);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 32);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reportes";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnTeacherMenu
            // 
            btnTeacherMenu.Cursor = Cursors.Hand;
            btnTeacherMenu.FlatAppearance.BorderSize = 0;
            btnTeacherMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnTeacherMenu.FlatStyle = FlatStyle.Flat;
            btnTeacherMenu.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeacherMenu.ForeColor = SystemColors.ButtonHighlight;
            btnTeacherMenu.Location = new Point(0, 261);
            btnTeacherMenu.Name = "btnTeacherMenu";
            btnTeacherMenu.Size = new Size(220, 32);
            btnTeacherMenu.TabIndex = 2;
            btnTeacherMenu.Text = "Notas y condiciones";
            btnTeacherMenu.UseVisualStyleBackColor = true;
            btnTeacherMenu.Click += btnTeacherMenu_Click;
            // 
            // btnStudentRegistration
            // 
            btnStudentRegistration.Cursor = Cursors.Hand;
            btnStudentRegistration.FlatAppearance.BorderSize = 0;
            btnStudentRegistration.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnStudentRegistration.FlatStyle = FlatStyle.Flat;
            btnStudentRegistration.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStudentRegistration.ForeColor = SystemColors.ButtonHighlight;
            btnStudentRegistration.Location = new Point(0, 189);
            btnStudentRegistration.Name = "btnStudentRegistration";
            btnStudentRegistration.Size = new Size(220, 32);
            btnStudentRegistration.TabIndex = 2;
            btnStudentRegistration.Text = "Inscripciones";
            btnStudentRegistration.UseVisualStyleBackColor = true;
            btnStudentRegistration.Click += btnStudentRegistration_Click;
            // 
            // btnCourse
            // 
            btnCourse.Cursor = Cursors.Hand;
            btnCourse.FlatAppearance.BorderSize = 0;
            btnCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCourse.ForeColor = SystemColors.ButtonHighlight;
            btnCourse.Location = new Point(0, 492);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(220, 32);
            btnCourse.TabIndex = 2;
            btnCourse.Text = "Cursos";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.Cursor = Cursors.Hand;
            btnSubjects.FlatAppearance.BorderSize = 0;
            btnSubjects.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnSubjects.FlatStyle = FlatStyle.Flat;
            btnSubjects.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubjects.ForeColor = SystemColors.ButtonHighlight;
            btnSubjects.Location = new Point(0, 454);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(220, 32);
            btnSubjects.TabIndex = 2;
            btnSubjects.Text = "Materias";
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnCommission
            // 
            btnCommission.Cursor = Cursors.Hand;
            btnCommission.FlatAppearance.BorderSize = 0;
            btnCommission.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCommission.FlatStyle = FlatStyle.Flat;
            btnCommission.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommission.ForeColor = SystemColors.ButtonHighlight;
            btnCommission.Location = new Point(0, 416);
            btnCommission.Name = "btnCommission";
            btnCommission.Size = new Size(220, 32);
            btnCommission.TabIndex = 2;
            btnCommission.Text = "Comisiones";
            btnCommission.UseVisualStyleBackColor = true;
            btnCommission.Click += btnCommission_Click;
            // 
            // btnPlan
            // 
            btnPlan.Cursor = Cursors.Hand;
            btnPlan.FlatAppearance.BorderSize = 0;
            btnPlan.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPlan.FlatStyle = FlatStyle.Flat;
            btnPlan.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlan.ForeColor = SystemColors.ButtonHighlight;
            btnPlan.Location = new Point(0, 378);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(220, 32);
            btnPlan.TabIndex = 3;
            btnPlan.Text = "Planes";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // btnSpeciality
            // 
            btnSpeciality.Cursor = Cursors.Hand;
            btnSpeciality.FlatAppearance.BorderSize = 0;
            btnSpeciality.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnSpeciality.FlatStyle = FlatStyle.Flat;
            btnSpeciality.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpeciality.ForeColor = SystemColors.ButtonHighlight;
            btnSpeciality.Location = new Point(0, 340);
            btnSpeciality.Name = "btnSpeciality";
            btnSpeciality.Size = new Size(220, 32);
            btnSpeciality.TabIndex = 2;
            btnSpeciality.Text = "Especialidades";
            btnSpeciality.UseVisualStyleBackColor = true;
            btnSpeciality.Click += btnSpeciality_Click;
            // 
            // btnPerson
            // 
            btnPerson.Cursor = Cursors.Hand;
            btnPerson.FlatAppearance.BorderSize = 0;
            btnPerson.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPerson.FlatStyle = FlatStyle.Flat;
            btnPerson.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPerson.ForeColor = SystemColors.ButtonHighlight;
            btnPerson.Location = new Point(0, 302);
            btnPerson.Name = "btnPerson";
            btnPerson.Size = new Size(220, 32);
            btnPerson.TabIndex = 1;
            btnPerson.Text = "Personas";
            btnPerson.UseVisualStyleBackColor = true;
            btnPerson.Click += btnPerson_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnContainerMain
            // 
            pnContainerMain.BackColor = Color.FromArgb(49, 66, 82);
            pnContainerMain.Dock = DockStyle.Fill;
            pnContainerMain.Location = new Point(220, 38);
            pnContainerMain.Name = "pnContainerMain";
            pnContainerMain.Size = new Size(1150, 809);
            pnContainerMain.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 847);
            Controls.Add(pnContainerMain);
            Controls.Add(pnLeftMain);
            Controls.Add(pnUpMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            pnUpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            pnLeftMain.ResumeLayout(false);
            pnSubmenuReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnUpMain;
        private Panel pnLeftMain;
        private PictureBox btnClose;
        private Panel pnContainerMain;
        private PictureBox btnMinimize;
        private PictureBox btnMaximize;
        private PictureBox btnRestore;
        private PictureBox pictureBox1;
        private Button btnPerson;
        private Button btnCourse;
        private Button btnSubjects;
        private Button btnCommission;
        private Button btnPlan;
        private Button btnSpeciality;
        private Button btnReports;
        private Button btnTeacherMenu;
        private Button btnStudentRegistration;
        private Panel pnSubmenuReports;
        private Button btnCoursesReports;
        private Button btnPlansReports;
        private PictureBox btnExit;
        private Button btnContact;
        private Button btnUsers;
        private Button btnEntitiesInfo;
    }
}