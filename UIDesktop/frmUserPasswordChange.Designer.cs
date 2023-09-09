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
            txtIdUser = new TextBox();
            lbIdUser = new Label();
            btnUserNewPasswordCancel = new Button();
            btnUserNewPasswordAcept = new Button();
            txtUserNewPassword = new TextBox();
            label1 = new Label();
            lbUserNewPassword = new Label();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(269, 123);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(192, 27);
            txtIdUser.TabIndex = 6;
            // 
            // lbIdUser
            // 
            lbIdUser.AutoSize = true;
            lbIdUser.Location = new Point(96, 126);
            lbIdUser.Name = "lbIdUser";
            lbIdUser.Size = new Size(82, 20);
            lbIdUser.TabIndex = 4;
            lbIdUser.Text = "Id Usuario*";
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
            txtUserNewPassword.Location = new Point(269, 188);
            txtUserNewPassword.Name = "txtUserNewPassword";
            txtUserNewPassword.Size = new Size(192, 27);
            txtUserNewPassword.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 191);
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
            Controls.Add(txtIdUser);
            Controls.Add(lbIdUser);
            Name = "frmUserPasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserPasswordChange";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIdUser;
        private Label lbIdUser;
        private Button btnUserNewPasswordCancel;
        private Button btnUserNewPasswordAcept;
        private TextBox txtUserNewPassword;
        private Label label1;
        private Label lbUserNewPassword;
        private PictureBox pictureLogo;
    }
}