namespace UIDesktop
{
    partial class frmSpecialitiesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecialitiesList));
            dgwSpecialitiesList = new DataGridView();
            lbSpecialities = new Label();
            btnBack = new Button();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgwSpecialitiesList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // dgwSpecialitiesList
            // 
            dgwSpecialitiesList.AllowUserToOrderColumns = true;
            dgwSpecialitiesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSpecialitiesList.Location = new Point(12, 111);
            dgwSpecialitiesList.Name = "dgwSpecialitiesList";
            dgwSpecialitiesList.RowHeadersWidth = 51;
            dgwSpecialitiesList.RowTemplate.Height = 29;
            dgwSpecialitiesList.Size = new Size(776, 188);
            dgwSpecialitiesList.TabIndex = 0;
            dgwSpecialitiesList.CellContentClick += dgwSpecialitiesList_CellContentClick;
            // 
            // lbSpecialities
            // 
            lbSpecialities.AutoSize = true;
            lbSpecialities.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSpecialities.Location = new Point(181, 53);
            lbSpecialities.Name = "lbSpecialities";
            lbSpecialities.Size = new Size(445, 25);
            lbSpecialities.TabIndex = 1;
            lbSpecialities.Text = "Lista de especialidades de la academia";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(321, 360);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(164, 44);
            btnBack.TabIndex = 2;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button1_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(103, 93);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 3;
            pictureLogo.TabStop = false;
            // 
            // frmSpecialitiesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureLogo);
            Controls.Add(btnBack);
            Controls.Add(lbSpecialities);
            Controls.Add(dgwSpecialitiesList);
            Name = "frmSpecialitiesList";
            Text = "Listado de especialidades";
            Load += frmSpecialitiesList_Load;
            ((System.ComponentModel.ISupportInitialize)dgwSpecialitiesList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwSpecialitiesList;
        private Label lbSpecialities;
        private Button btnBack;
        private PictureBox pictureLogo;
    }
}