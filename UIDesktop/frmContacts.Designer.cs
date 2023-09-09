namespace UIDesktop
{
    partial class frmContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacts));
            btnBack = new Button();
            lbTitleContacts = new Label();
            lbSpecialities = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(290, 304);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 52);
            btnBack.TabIndex = 0;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbTitleContacts
            // 
            lbTitleContacts.AutoSize = true;
            lbTitleContacts.Location = new Point(290, 90);
            lbTitleContacts.Name = "lbTitleContacts";
            lbTitleContacts.Size = new Size(193, 200);
            lbTitleContacts.TabIndex = 2;
            lbTitleContacts.Text = "Institucion\r\ntel: +341 1857071\r\nmail academia@gmail.com\r\n\r\nHoarios atencion presencial\r\nPrimer piso- secretaria.\r\nLunes y miercoles\r\n8hs a 12 hs y 14hs a 17hs\r\n\r\n\r\n";
            // 
            // lbSpecialities
            // 
            lbSpecialities.AutoSize = true;
            lbSpecialities.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSpecialities.Location = new Point(334, 49);
            lbSpecialities.Name = "lbSpecialities";
            lbSpecialities.Size = new Size(111, 25);
            lbSpecialities.TabIndex = 3;
            lbSpecialities.Text = "Contacto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(594, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmContacts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(826, 400);
            Controls.Add(pictureBox1);
            Controls.Add(lbSpecialities);
            Controls.Add(lbTitleContacts);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmContacts";
            Text = "frmContacts";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbTitleContacts;
        private Label lbSpecialities;
        private PictureBox pictureBox1;
    }
}