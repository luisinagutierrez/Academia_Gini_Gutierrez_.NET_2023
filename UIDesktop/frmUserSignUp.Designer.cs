namespace UIDesktop
{
    partial class frmUserSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserSignUp));
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            txtIdPerson = new TextBox();
            lbUserName = new Label();
            lbUserPassword = new Label();
            lbUserIdPerson = new Label();
            btnUserSignUpAccept = new Button();
            btnUserSignUpCancel = new Button();
            lbTitleUserSignUp = new Label();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(209, 105);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(240, 27);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(209, 169);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PasswordChar = '*';
            txtUserPassword.Size = new Size(240, 27);
            txtUserPassword.TabIndex = 1;
            // 
            // txtIdPerson
            // 
            txtIdPerson.Location = new Point(209, 226);
            txtIdPerson.Name = "txtIdPerson";
            txtIdPerson.Size = new Size(151, 27);
            txtIdPerson.TabIndex = 2;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(48, 105);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(143, 20);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "Nombre de usuario*";
            // 
            // lbUserPassword
            // 
            lbUserPassword.AutoSize = true;
            lbUserPassword.Location = new Point(48, 169);
            lbUserPassword.Name = "lbUserPassword";
            lbUserPassword.Size = new Size(89, 20);
            lbUserPassword.TabIndex = 5;
            lbUserPassword.Text = "Contraseña*";
            // 
            // lbUserIdPerson
            // 
            lbUserIdPerson.AutoSize = true;
            lbUserIdPerson.Location = new Point(48, 233);
            lbUserIdPerson.Name = "lbUserIdPerson";
            lbUserIdPerson.Size = new Size(83, 20);
            lbUserIdPerson.TabIndex = 6;
            lbUserIdPerson.Text = "Id Persona*";
            // 
            // btnUserSignUpAccept
            // 
            btnUserSignUpAccept.ForeColor = Color.Black;
            btnUserSignUpAccept.Location = new Point(346, 320);
            btnUserSignUpAccept.Name = "btnUserSignUpAccept";
            btnUserSignUpAccept.Size = new Size(103, 39);
            btnUserSignUpAccept.TabIndex = 7;
            btnUserSignUpAccept.Text = "Aceptar";
            btnUserSignUpAccept.UseVisualStyleBackColor = true;
            btnUserSignUpAccept.Click += btnUserSignUpAccept_Click;
            // 
            // btnUserSignUpCancel
            // 
            btnUserSignUpCancel.Location = new Point(160, 320);
            btnUserSignUpCancel.Name = "btnUserSignUpCancel";
            btnUserSignUpCancel.Size = new Size(107, 39);
            btnUserSignUpCancel.TabIndex = 8;
            btnUserSignUpCancel.Text = "Cancelar";
            btnUserSignUpCancel.UseVisualStyleBackColor = true;
            btnUserSignUpCancel.Click += btnUserSignUpCancel_Click;
            // 
            // lbTitleUserSignUp
            // 
            lbTitleUserSignUp.AutoSize = true;
            lbTitleUserSignUp.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitleUserSignUp.Location = new Point(209, 28);
            lbTitleUserSignUp.Name = "lbTitleUserSignUp";
            lbTitleUserSignUp.Size = new Size(107, 25);
            lbTitleUserSignUp.TabIndex = 9;
            lbTitleUserSignUp.Text = "Registro";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(25, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(83, 67);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 24;
            pictureLogo.TabStop = false;
            // 
            // frmUserSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(522, 396);
            Controls.Add(pictureLogo);
            Controls.Add(lbTitleUserSignUp);
            Controls.Add(btnUserSignUpCancel);
            Controls.Add(btnUserSignUpAccept);
            Controls.Add(lbUserIdPerson);
            Controls.Add(lbUserPassword);
            Controls.Add(lbUserName);
            Controls.Add(txtIdPerson);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Name = "frmUserSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserSignUp";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private TextBox txtIdPerson;
        private Label lbUserName;
        private Label lbUserPassword;
        private Label lbUserIdPerson;
        private Button btnUserSignUpAccept;
        private Button btnUserSignUpCancel;
        private Label lbTitleUserSignUp;
        private PictureBox pictureLogo;
    }
}