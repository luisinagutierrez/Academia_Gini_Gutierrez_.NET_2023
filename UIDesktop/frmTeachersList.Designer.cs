namespace UIDesktop
{
    partial class frmTeachersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeachersList));
            btnBack = new Button();
            lbTeachers = new Label();
            dgwTeachersList = new DataGridView();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgwTeachersList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(325, 347);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(164, 44);
            btnBack.TabIndex = 5;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbTeachers
            // 
            lbTeachers.AutoSize = true;
            lbTeachers.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTeachers.Location = new Point(207, 51);
            lbTeachers.Name = "lbTeachers";
            lbTeachers.Size = new Size(401, 25);
            lbTeachers.TabIndex = 4;
            lbTeachers.Text = "Lista de profesores de la academia";
            // 
            // dgwTeachersList
            // 
            dgwTeachersList.AllowUserToOrderColumns = true;
            dgwTeachersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTeachersList.Location = new Point(12, 127);
            dgwTeachersList.Name = "dgwTeachersList";
            dgwTeachersList.RowHeadersWidth = 51;
            dgwTeachersList.RowTemplate.Height = 29;
            dgwTeachersList.Size = new Size(776, 188);
            dgwTeachersList.TabIndex = 3;
            dgwTeachersList.CellContentClick += dgwTeachersList_CellContentClick;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 83);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 6;
            pictureLogo.TabStop = false;
            // 
            // frmTeachersList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureLogo);
            Controls.Add(btnBack);
            Controls.Add(lbTeachers);
            Controls.Add(dgwTeachersList);
            Name = "frmTeachersList";
            Text = "Listado de profesores";
            Load += frmTeachersList_Load;
            ((System.ComponentModel.ISupportInitialize)dgwTeachersList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbTeachers;
        private DataGridView dgwTeachersList;
        private PictureBox pictureLogo;
    }
}