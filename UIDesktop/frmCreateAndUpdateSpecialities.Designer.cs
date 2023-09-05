namespace UIDesktop
{
    partial class frmCreateAndUpdateSpecialities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAndUpdateSpecialities));
            lbIdSpecialities = new Label();
            txtIdSpeciality = new TextBox();
            brnBack = new Button();
            btnCreateSpecialitie = new Button();
            btnUpdateSpecialitie = new Button();
            txtSpecialityDescription = new TextBox();
            lbSpecialityDescription = new Label();
            dgvSpecialities = new DataGridView();
            pictureLogo = new PictureBox();
            lbCreateUpdateSpecialities = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // lbIdSpecialities
            // 
            lbIdSpecialities.AutoSize = true;
            lbIdSpecialities.Location = new Point(571, 152);
            lbIdSpecialities.Name = "lbIdSpecialities";
            lbIdSpecialities.Size = new Size(110, 20);
            lbIdSpecialities.TabIndex = 0;
            lbIdSpecialities.Text = "Id especialidad";
            // 
            // txtIdSpeciality
            // 
            txtIdSpeciality.Location = new Point(694, 152);
            txtIdSpeciality.Name = "txtIdSpeciality";
            txtIdSpeciality.Size = new Size(124, 27);
            txtIdSpeciality.TabIndex = 1;
            // 
            // brnBack
            // 
            brnBack.Location = new Point(321, 348);
            brnBack.Name = "brnBack";
            brnBack.Size = new Size(121, 48);
            brnBack.TabIndex = 2;
            brnBack.Text = "Atras";
            brnBack.UseVisualStyleBackColor = true;
            brnBack.Click += button1_Click;
            // 
            // btnCreateSpecialitie
            // 
            btnCreateSpecialitie.Location = new Point(503, 348);
            btnCreateSpecialitie.Name = "btnCreateSpecialitie";
            btnCreateSpecialitie.Size = new Size(121, 48);
            btnCreateSpecialitie.TabIndex = 3;
            btnCreateSpecialitie.Text = "Guardar nueva especialidad";
            btnCreateSpecialitie.UseVisualStyleBackColor = true;
            btnCreateSpecialitie.Click += btnCreateSpecialitie_Click;
            // 
            // btnUpdateSpecialitie
            // 
            btnUpdateSpecialitie.Location = new Point(689, 348);
            btnUpdateSpecialitie.Name = "btnUpdateSpecialitie";
            btnUpdateSpecialitie.Size = new Size(121, 48);
            btnUpdateSpecialitie.TabIndex = 4;
            btnUpdateSpecialitie.Text = "Actualizar especialidad";
            btnUpdateSpecialitie.UseVisualStyleBackColor = true;
            btnUpdateSpecialitie.Click += btnUpdateSpecialitie_Click;
            // 
            // txtSpecialityDescription
            // 
            txtSpecialityDescription.Location = new Point(688, 197);
            txtSpecialityDescription.Multiline = true;
            txtSpecialityDescription.Name = "txtSpecialityDescription";
            txtSpecialityDescription.Size = new Size(221, 71);
            txtSpecialityDescription.TabIndex = 6;
            // 
            // lbSpecialityDescription
            // 
            lbSpecialityDescription.AutoSize = true;
            lbSpecialityDescription.Location = new Point(571, 197);
            lbSpecialityDescription.Name = "lbSpecialityDescription";
            lbSpecialityDescription.Size = new Size(87, 20);
            lbSpecialityDescription.TabIndex = 5;
            lbSpecialityDescription.Text = "Descripcion";
            // 
            // dgvSpecialities
            // 
            dgvSpecialities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpecialities.Location = new Point(72, 108);
            dgvSpecialities.Name = "dgvSpecialities";
            dgvSpecialities.RowHeadersWidth = 51;
            dgvSpecialities.RowTemplate.Height = 29;
            dgvSpecialities.Size = new Size(448, 185);
            dgvSpecialities.TabIndex = 9;
            dgvSpecialities.CellContentClick += dgvSpecialities_CellContentClick;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 90);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 10;
            pictureLogo.TabStop = false;
            // 
            // lbCreateUpdateSpecialities
            // 
            lbCreateUpdateSpecialities.AutoSize = true;
            lbCreateUpdateSpecialities.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdateSpecialities.Location = new Point(447, 46);
            lbCreateUpdateSpecialities.Name = "lbCreateUpdateSpecialities";
            lbCreateUpdateSpecialities.Size = new Size(177, 25);
            lbCreateUpdateSpecialities.TabIndex = 14;
            lbCreateUpdateSpecialities.Text = "Especialidades";
            // 
            // frmCreateAndUpdateSpecialities
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1057, 461);
            Controls.Add(lbCreateUpdateSpecialities);
            Controls.Add(pictureLogo);
            Controls.Add(dgvSpecialities);
            Controls.Add(txtSpecialityDescription);
            Controls.Add(lbSpecialityDescription);
            Controls.Add(btnUpdateSpecialitie);
            Controls.Add(btnCreateSpecialitie);
            Controls.Add(brnBack);
            Controls.Add(txtIdSpeciality);
            Controls.Add(lbIdSpecialities);
            Name = "frmCreateAndUpdateSpecialities";
            Text = "Crear o Actualizar Especialidades";
            Load += frmCreateAndUpdateSpecialities_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIdSpecialities;
        private TextBox txtIdSpeciality;
        private Button brnBack;
        private Button btnCreateSpecialitie;
        private Button btnUpdateSpecialitie;
        private TextBox txtSpecialityDescription;
        private Label lbSpecialityDescription;
        private DataGridView dgvSpecialities;
        private PictureBox pictureLogo;
        private Label lbCreateUpdateSpecialities;
    }
}