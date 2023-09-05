namespace UIDesktop
{
    partial class frmDeleteSpecialities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteSpecialities));
            lbDeleteSpecialities = new Label();
            pictureLogo = new PictureBox();
            dgvSpecialities = new DataGridView();
            btnDeleteSpecialitie = new Button();
            button1 = new Button();
            txtIdSpecialities = new TextBox();
            lbIdSpecialities = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).BeginInit();
            SuspendLayout();
            // 
            // lbDeleteSpecialities
            // 
            lbDeleteSpecialities.AutoSize = true;
            lbDeleteSpecialities.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDeleteSpecialities.Location = new Point(191, 46);
            lbDeleteSpecialities.Name = "lbDeleteSpecialities";
            lbDeleteSpecialities.Size = new Size(252, 25);
            lbDeleteSpecialities.TabIndex = 24;
            lbDeleteSpecialities.Text = "Eliminar Especialidad";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 90);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 23;
            pictureLogo.TabStop = false;
            // 
            // dgvSpecialities
            // 
            dgvSpecialities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpecialities.Location = new Point(62, 129);
            dgvSpecialities.Name = "dgvSpecialities";
            dgvSpecialities.RowHeadersWidth = 51;
            dgvSpecialities.RowTemplate.Height = 29;
            dgvSpecialities.Size = new Size(456, 189);
            dgvSpecialities.TabIndex = 22;
            dgvSpecialities.CellContentClick += dgvSpecialities_CellContentClick;
            // 
            // btnDeleteSpecialitie
            // 
            btnDeleteSpecialitie.Location = new Point(411, 439);
            btnDeleteSpecialitie.Name = "btnDeleteSpecialitie";
            btnDeleteSpecialitie.Size = new Size(107, 37);
            btnDeleteSpecialitie.TabIndex = 18;
            btnDeleteSpecialitie.Text = "Aceptar";
            btnDeleteSpecialitie.UseVisualStyleBackColor = true;
            btnDeleteSpecialitie.Click += btnDeleteSpecialitie_Click;
            // 
            // button1
            // 
            button1.Location = new Point(269, 439);
            button1.Name = "button1";
            button1.Size = new Size(111, 37);
            button1.TabIndex = 17;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdSpecialities
            // 
            txtIdSpecialities.Location = new Point(160, 361);
            txtIdSpecialities.Name = "txtIdSpecialities";
            txtIdSpecialities.Size = new Size(124, 27);
            txtIdSpecialities.TabIndex = 16;
            // 
            // lbIdSpecialities
            // 
            lbIdSpecialities.AutoSize = true;
            lbIdSpecialities.Location = new Point(37, 361);
            lbIdSpecialities.Name = "lbIdSpecialities";
            lbIdSpecialities.Size = new Size(116, 20);
            lbIdSpecialities.TabIndex = 15;
            lbIdSpecialities.Text = "Id especialidad*";
            // 
            // frmDeleteSpecialities
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(594, 506);
            Controls.Add(lbDeleteSpecialities);
            Controls.Add(pictureLogo);
            Controls.Add(dgvSpecialities);
            Controls.Add(btnDeleteSpecialitie);
            Controls.Add(button1);
            Controls.Add(txtIdSpecialities);
            Controls.Add(lbIdSpecialities);
            Name = "frmDeleteSpecialities";
            Text = "Eliminar Especialidad";
            Load += frmDeleteSpecialities_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDeleteSpecialities;
        private PictureBox pictureLogo;
        private DataGridView dgvSpecialities;
        private Button btnDeleteSpecialitie;
        private Button button1;
        private TextBox txtIdSpecialities;
        private Label lbIdSpecialities;
    }
}