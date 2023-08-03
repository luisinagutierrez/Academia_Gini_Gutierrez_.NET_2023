namespace UIDesktop
{
    partial class frmAdminLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogIn));
            btnLogInAdminAccept = new Button();
            lbLogInAdminName = new Label();
            txtLogInAdminName = new TextBox();
            txtLogInAdminPassword = new TextBox();
            lbLogInAdminPassword = new Label();
            btnLogInAdminCancel = new Button();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // btnLogInAdminAccept
            // 
            btnLogInAdminAccept.Location = new Point(353, 243);
            btnLogInAdminAccept.Name = "btnLogInAdminAccept";
            btnLogInAdminAccept.Size = new Size(94, 29);
            btnLogInAdminAccept.TabIndex = 0;
            btnLogInAdminAccept.Text = "Aceptar";
            btnLogInAdminAccept.UseVisualStyleBackColor = true;
            btnLogInAdminAccept.Click += btnLogInAdminAccept_Click;
            // 
            // lbLogInAdminName
            // 
            lbLogInAdminName.AutoSize = true;
            lbLogInAdminName.Location = new Point(106, 114);
            lbLogInAdminName.Name = "lbLogInAdminName";
            lbLogInAdminName.Size = new Size(118, 20);
            lbLogInAdminName.TabIndex = 1;
            lbLogInAdminName.Text = "Nombre Admin*";
            // 
            // txtLogInAdminName
            // 
            txtLogInAdminName.Location = new Point(242, 107);
            txtLogInAdminName.Name = "txtLogInAdminName";
            txtLogInAdminName.Size = new Size(205, 27);
            txtLogInAdminName.TabIndex = 2;
            // 
            // txtLogInAdminPassword
            // 
            txtLogInAdminPassword.Location = new Point(242, 173);
            txtLogInAdminPassword.Name = "txtLogInAdminPassword";
            txtLogInAdminPassword.Size = new Size(205, 27);
            txtLogInAdminPassword.TabIndex = 4;
            // 
            // lbLogInAdminPassword
            // 
            lbLogInAdminPassword.AutoSize = true;
            lbLogInAdminPassword.Location = new Point(106, 173);
            lbLogInAdminPassword.Name = "lbLogInAdminPassword";
            lbLogInAdminPassword.Size = new Size(89, 20);
            lbLogInAdminPassword.TabIndex = 3;
            lbLogInAdminPassword.Text = "Contraseña*";
            // 
            // btnLogInAdminCancel
            // 
            btnLogInAdminCancel.Location = new Point(168, 243);
            btnLogInAdminCancel.Name = "btnLogInAdminCancel";
            btnLogInAdminCancel.Size = new Size(94, 29);
            btnLogInAdminCancel.TabIndex = 5;
            btnLogInAdminCancel.Text = "Cancelar";
            btnLogInAdminCancel.UseVisualStyleBackColor = true;
            btnLogInAdminCancel.Click += btnLogInAdminCancel_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = SystemColors.GradientInactiveCaption;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(21, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(99, 78);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 17;
            pictureLogo.TabStop = false;
            pictureLogo.Click += pictureLogo_Click;
            // 
            // frmAdminLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(559, 349);
            Controls.Add(btnLogInAdminCancel);
            Controls.Add(txtLogInAdminPassword);
            Controls.Add(lbLogInAdminPassword);
            Controls.Add(txtLogInAdminName);
            Controls.Add(lbLogInAdminName);
            Controls.Add(btnLogInAdminAccept);
            Controls.Add(pictureLogo);
            Name = "frmAdminLogIn";
            Text = "Inicio Sesión Administrador";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogInAdminAccept;
        private Label lbLogInAdminName;
        private TextBox txtLogInAdminName;
        private TextBox txtLogInAdminPassword;
        private Label lbLogInAdminPassword;
        private Button btnLogInAdminCancel;
        private PictureBox pictureLogo;
    }
}