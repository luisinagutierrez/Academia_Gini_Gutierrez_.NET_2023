namespace UIDesktop
{
    partial class frmUserPasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserPasswordChange));
            txtUserEmail = new TextBox();
            textBox1 = new TextBox();
            lbUserPasswordChangeEmail = new Label();
            lbUserPasswordChangeName = new Label();
            btnUserNewPasswordCancel = new Button();
            btnUserNewPasswordAcept = new Button();
            txtUserNewPassword = new TextBox();
            label1 = new Label();
            lbUserNewPassword = new Label();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(269, 171);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(192, 27);
            txtUserEmail.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 6;
            // 
            // lbUserPasswordChangeEmail
            // 
            lbUserPasswordChangeEmail.AutoSize = true;
            lbUserPasswordChangeEmail.Location = new Point(96, 174);
            lbUserPasswordChangeEmail.Name = "lbUserPasswordChangeEmail";
            lbUserPasswordChangeEmail.Size = new Size(52, 20);
            lbUserPasswordChangeEmail.TabIndex = 5;
            lbUserPasswordChangeEmail.Text = "Email*";
            // 
            // lbUserPasswordChangeName
            // 
            lbUserPasswordChangeName.AutoSize = true;
            lbUserPasswordChangeName.Location = new Point(96, 126);
            lbUserPasswordChangeName.Name = "lbUserPasswordChangeName";
            lbUserPasswordChangeName.Size = new Size(143, 20);
            lbUserPasswordChangeName.TabIndex = 4;
            lbUserPasswordChangeName.Text = "Nombre de usuario*";
            // 
            // btnUserNewPasswordCancel
            // 
            btnUserNewPasswordCancel.Location = new Point(105, 288);
            btnUserNewPasswordCancel.Name = "btnUserNewPasswordCancel";
            btnUserNewPasswordCancel.Size = new Size(103, 38);
            btnUserNewPasswordCancel.TabIndex = 8;
            btnUserNewPasswordCancel.Text = "Cancelar";
            btnUserNewPasswordCancel.UseVisualStyleBackColor = true;
            btnUserNewPasswordCancel.Click += btnUserNewPasswordCancel_Click;
            // 
            // btnUserNewPasswordAcept
            // 
            btnUserNewPasswordAcept.Location = new Point(342, 288);
            btnUserNewPasswordAcept.Name = "btnUserNewPasswordAcept";
            btnUserNewPasswordAcept.Size = new Size(108, 38);
            btnUserNewPasswordAcept.TabIndex = 9;
            btnUserNewPasswordAcept.Text = "Aceptar";
            btnUserNewPasswordAcept.UseVisualStyleBackColor = true;
            btnUserNewPasswordAcept.Click += btnUserNewPasswordAcept_Click;
            // 
            // txtUserNewPassword
            // 
            txtUserNewPassword.Location = new Point(269, 228);
            txtUserNewPassword.Name = "txtUserNewPassword";
            txtUserNewPassword.Size = new Size(192, 27);
            txtUserNewPassword.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 231);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 10;
            label1.Text = "Nueva Contraseña*";
            // 
            // lbUserNewPassword
            // 
            lbUserNewPassword.AutoSize = true;
            lbUserNewPassword.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserNewPassword.Location = new Point(168, 62);
            lbUserNewPassword.Name = "lbUserNewPassword";
            lbUserNewPassword.Size = new Size(215, 25);
            lbUserNewPassword.TabIndex = 12;
            lbUserNewPassword.Text = "Nueva Contraseña";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(31, 20);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(99, 85);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 24;
            pictureLogo.TabStop = false;
            // 
            // frmUserPasswordChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(549, 400);
            Controls.Add(pictureLogo);
            Controls.Add(lbUserNewPassword);
            Controls.Add(txtUserNewPassword);
            Controls.Add(label1);
            Controls.Add(btnUserNewPasswordAcept);
            Controls.Add(btnUserNewPasswordCancel);
            Controls.Add(txtUserEmail);
            Controls.Add(textBox1);
            Controls.Add(lbUserPasswordChangeEmail);
            Controls.Add(lbUserPasswordChangeName);
            Name = "frmUserPasswordChange";
            Text = "frmUserPasswordChange";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserEmail;
        private TextBox textBox1;
        private Label lbUserPasswordChangeEmail;
        private Label lbUserPasswordChangeName;
        private Button btnUserNewPasswordCancel;
        private Button btnUserNewPasswordAcept;
        private TextBox txtUserNewPassword;
        private Label label1;
        private Label lbUserNewPassword;
        private PictureBox pictureLogo;
    }
}