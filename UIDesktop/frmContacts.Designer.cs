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
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(134, 320);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(99, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbTitleContacts
            // 
            lbTitleContacts.AutoSize = true;
            lbTitleContacts.Location = new Point(95, 107);
            lbTitleContacts.Name = "lbTitleContacts";
            lbTitleContacts.Size = new Size(193, 200);
            lbTitleContacts.TabIndex = 2;
            lbTitleContacts.Text = "Institucion\r\ntel: +341 1857071\r\nmail academia@gmail.com\r\n\r\nHoarios atencion presencial\r\nPrimer piso- secretaria.\r\nLunes y miercoles\r\n8hs a 12 hs y 14hs a 17hs\r\n\r\n\r\n";
            // 
            // lbSpecialities
            // 
            lbSpecialities.AutoSize = true;
            lbSpecialities.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSpecialities.Location = new Point(125, 44);
            lbSpecialities.Name = "lbSpecialities";
            lbSpecialities.Size = new Size(111, 25);
            lbSpecialities.TabIndex = 3;
            lbSpecialities.Text = "Contacto";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(18, 21);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 83);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 7;
            pictureLogo.TabStop = false;
            // 
            // frmContacts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(373, 425);
            Controls.Add(pictureLogo);
            Controls.Add(lbSpecialities);
            Controls.Add(lbTitleContacts);
            Controls.Add(btnBack);
            Name = "frmContacts";
            Text = "frmContacts";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbTitleContacts;
        private Label lbSpecialities;
        private PictureBox pictureLogo;
    }
}