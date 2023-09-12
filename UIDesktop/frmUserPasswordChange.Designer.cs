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
            txtUserName = new TextBox();
            lbIUserName = new Label();
            btnUserNewPasswordCancel = new Button();
            btnUserNewPasswordAcept = new Button();
            txtUserNewPassword = new TextBox();
            label1 = new Label();
            lbUserNewPassword = new Label();
            pictureLogo = new PictureBox();
            txtUserIdPerson = new TextBox();
            lbUserIdPerson = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(269, 123);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 27);
            txtUserName.TabIndex = 6;
            // 
            // lbIUserName
            // 
            lbIUserName.AutoSize = true;
            lbIUserName.Location = new Point(96, 126);
            lbIUserName.Name = "lbIUserName";
            lbIUserName.Size = new Size(145, 20);
            lbIUserName.TabIndex = 4;
            lbIUserName.Text = "Nombre de Usuario*";
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
            txtUserNewPassword.Location = new Point(269, 213);
            txtUserNewPassword.Name = "txtUserNewPassword";
            txtUserNewPassword.Size = new Size(192, 27);
            txtUserNewPassword.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 216);
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
            // txtUserIdPerson
            // 
            txtUserIdPerson.Location = new Point(269, 167);
            txtUserIdPerson.Name = "txtUserIdPerson";
            txtUserIdPerson.Size = new Size(123, 27);
            txtUserIdPerson.TabIndex = 26;
            // 
            // lbUserIdPerson
            // 
            lbUserIdPerson.AutoSize = true;
            lbUserIdPerson.Location = new Point(96, 170);
            lbUserIdPerson.Name = "lbUserIdPerson";
            lbUserIdPerson.Size = new Size(83, 20);
            lbUserIdPerson.TabIndex = 25;
            lbUserIdPerson.Text = "Id Persona*";
            // 
            // frmUserPasswordChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(549, 400);
            Controls.Add(txtUserIdPerson);
            Controls.Add(lbUserIdPerson);
            Controls.Add(pictureLogo);
            Controls.Add(lbUserNewPassword);
            Controls.Add(txtUserNewPassword);
            Controls.Add(label1);
            Controls.Add(btnUserNewPasswordAcept);
            Controls.Add(btnUserNewPasswordCancel);
            Controls.Add(txtUserName);
            Controls.Add(lbIUserName);
            Name = "frmUserPasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserPasswordChange";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private Label lbIUserName;
        private Button btnUserNewPasswordCancel;
        private Button btnUserNewPasswordAcept;
        private TextBox txtUserNewPassword;
        private Label label1;
        private Label lbUserNewPassword;
        private PictureBox pictureLogo;
        private TextBox txtUserIdPerson;
        private Label lbUserIdPerson;
    }
}