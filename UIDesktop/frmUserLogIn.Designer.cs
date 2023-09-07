namespace UIDesktop
{
    partial class frmUserLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogIn));
            lbUserLogInName = new Label();
            lbUserLogInPassword = new Label();
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            btnUserLogInCancel = new Button();
            btnUserLogInAccept = new Button();
            lbUserLogIn = new Label();
            llbUserPassword = new LinkLabel();
            pictureLogo = new PictureBox();
            llbSignUp = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // lbUserLogInName
            // 
            lbUserLogInName.AutoSize = true;
            lbUserLogInName.Location = new Point(50, 97);
            lbUserLogInName.Name = "lbUserLogInName";
            lbUserLogInName.Size = new Size(143, 20);
            lbUserLogInName.TabIndex = 0;
            lbUserLogInName.Text = "Nombre de usuario*";
            // 
            // lbUserLogInPassword
            // 
            lbUserLogInPassword.AutoSize = true;
            lbUserLogInPassword.Location = new Point(50, 165);
            lbUserLogInPassword.Name = "lbUserLogInPassword";
            lbUserLogInPassword.Size = new Size(89, 20);
            lbUserLogInPassword.TabIndex = 1;
            lbUserLogInPassword.Text = "Contraseña*";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(223, 94);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(223, 162);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PasswordChar = '*';
            txtUserPassword.Size = new Size(192, 27);
            txtUserPassword.TabIndex = 3;
            // 
            // btnUserLogInCancel
            // 
            btnUserLogInCancel.Location = new Point(88, 241);
            btnUserLogInCancel.Name = "btnUserLogInCancel";
            btnUserLogInCancel.Size = new Size(105, 39);
            btnUserLogInCancel.TabIndex = 4;
            btnUserLogInCancel.Text = "Cancelar";
            btnUserLogInCancel.UseVisualStyleBackColor = true;
            btnUserLogInCancel.Click += btnUserLogInCancel_Click;
            // 
            // btnUserLogInAccept
            // 
            btnUserLogInAccept.Location = new Point(320, 241);
            btnUserLogInAccept.Name = "btnUserLogInAccept";
            btnUserLogInAccept.Size = new Size(95, 39);
            btnUserLogInAccept.TabIndex = 5;
            btnUserLogInAccept.Text = "Aceptar";
            btnUserLogInAccept.UseVisualStyleBackColor = true;
            btnUserLogInAccept.Click += btnUserLogInAccept_Click;
            // 
            // lbUserLogIn
            // 
            lbUserLogIn.AutoSize = true;
            lbUserLogIn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserLogIn.Location = new Point(160, 41);
            lbUserLogIn.Name = "lbUserLogIn";
            lbUserLogIn.Size = new Size(156, 25);
            lbUserLogIn.TabIndex = 6;
            lbUserLogIn.Text = "Inicio sesión";
            // 
            // llbUserPassword
            // 
            llbUserPassword.AutoSize = true;
            llbUserPassword.Location = new Point(50, 196);
            llbUserPassword.Name = "llbUserPassword";
            llbUserPassword.Size = new Size(147, 20);
            llbUserPassword.TabIndex = 7;
            llbUserPassword.TabStop = true;
            llbUserPassword.Text = "olvide mi contraseña";
            llbUserPassword.LinkClicked += llbUserPassword_LinkClicked;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(83, 67);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 23;
            pictureLogo.TabStop = false;
            // 
            // llbSignUp
            // 
            llbSignUp.AutoSize = true;
            llbSignUp.Location = new Point(12, 309);
            llbSignUp.Name = "llbSignUp";
            llbSignUp.Size = new Size(82, 20);
            llbSignUp.TabIndex = 24;
            llbSignUp.TabStop = true;
            llbSignUp.Text = "Registrarse";
            llbSignUp.LinkClicked += llbSignUp_LinkClicked;
            // 
            // frmUserLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(482, 338);
            Controls.Add(llbSignUp);
            Controls.Add(pictureLogo);
            Controls.Add(llbUserPassword);
            Controls.Add(lbUserLogIn);
            Controls.Add(btnUserLogInAccept);
            Controls.Add(btnUserLogInCancel);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbUserLogInPassword);
            Controls.Add(lbUserLogInName);
            Name = "frmUserLogIn";
            Text = "Inicio sesión";
            Load += frmUserLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserLogInName;
        private Label lbUserLogInPassword;
        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private Button btnUserLogInCancel;
        private Button btnUserLogInAccept;
        private Label lbUserLogIn;
        private LinkLabel llbUserPassword;
        private PictureBox pictureLogo;
        private LinkLabel llbSignUp;
    }
}