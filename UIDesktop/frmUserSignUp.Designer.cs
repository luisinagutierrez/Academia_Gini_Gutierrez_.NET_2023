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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(209, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 169);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(240, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 2;
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
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmUserSignUp";
            Text = "frmUserSignUp";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbUserName;
        private Label lbUserPassword;
        private Label lbUserIdPerson;
        private Button btnUserSignUpAccept;
        private Button btnUserSignUpCancel;
        private Label lbTitleUserSignUp;
        private PictureBox pictureLogo;
    }
}