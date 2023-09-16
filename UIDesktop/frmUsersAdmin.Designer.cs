namespace UIDesktop
{
    partial class frmUsersAdmin
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
            lbUsersAdmin = new Label();
            dgvUsers = new DataGridView();
            lbChangePassword = new Label();
            lbStatus = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtUserName = new TextBox();
            lbUserName = new Label();
            txtIdUser = new TextBox();
            lbIdUser = new Label();
            txtIdPerson = new TextBox();
            lbIdPerson = new Label();
            lbPrivilege = new Label();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            brnBack = new Button();
            cBoxChangedPassword = new ComboBox();
            cBoxStatus = new ComboBox();
            cBoxPrivilege = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lbUsersAdmin
            // 
            lbUsersAdmin.AutoSize = true;
            lbUsersAdmin.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsersAdmin.Location = new Point(794, 46);
            lbUsersAdmin.Name = "lbUsersAdmin";
            lbUsersAdmin.Size = new Size(110, 25);
            lbUsersAdmin.TabIndex = 15;
            lbUsersAdmin.Text = "Usuarios";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(268, 132);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.Size = new Size(653, 281);
            dgvUsers.TabIndex = 16;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // lbChangePassword
            // 
            lbChangePassword.AutoSize = true;
            lbChangePassword.Location = new Point(1010, 305);
            lbChangePassword.Name = "lbChangePassword";
            lbChangePassword.Size = new Size(138, 20);
            lbChangePassword.TabIndex = 71;
            lbChangePassword.Text = "Cambia Contraseña";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(1010, 263);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(54, 20);
            lbStatus.TabIndex = 69;
            lbStatus.Text = "Estado";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1155, 218);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(124, 27);
            txtPassword.TabIndex = 68;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(1010, 221);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(83, 20);
            lbPassword.TabIndex = 67;
            lbPassword.Text = "Contraseña";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(1155, 175);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(124, 27);
            txtUserName.TabIndex = 66;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(1010, 178);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(139, 20);
            lbUserName.TabIndex = 65;
            lbUserName.Text = "Nombre de Usuario";
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(1155, 133);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(124, 27);
            txtIdUser.TabIndex = 64;
            // 
            // lbIdUser
            // 
            lbIdUser.AutoSize = true;
            lbIdUser.Location = new Point(1010, 136);
            lbIdUser.Name = "lbIdUser";
            lbIdUser.Size = new Size(76, 20);
            lbIdUser.TabIndex = 63;
            lbIdUser.Text = "Id Usuario";
            // 
            // txtIdPerson
            // 
            txtIdPerson.Location = new Point(1155, 344);
            txtIdPerson.Name = "txtIdPerson";
            txtIdPerson.Size = new Size(124, 27);
            txtIdPerson.TabIndex = 74;
            // 
            // lbIdPerson
            // 
            lbIdPerson.AutoSize = true;
            lbIdPerson.Location = new Point(1010, 347);
            lbIdPerson.Name = "lbIdPerson";
            lbIdPerson.Size = new Size(79, 20);
            lbIdPerson.TabIndex = 73;
            lbIdPerson.Text = "Id persona";
            // 
            // lbPrivilege
            // 
            lbPrivilege.AutoSize = true;
            lbPrivilege.Location = new Point(1010, 389);
            lbPrivilege.Name = "lbPrivilege";
            lbPrivilege.Size = new Size(71, 20);
            lbPrivilege.TabIndex = 75;
            lbPrivilege.Text = "Privilegio";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(960, 472);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(121, 48);
            btnDeleteUser.TabIndex = 80;
            btnDeleteUser.Text = "Eliminar Usuario";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(757, 472);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(121, 48);
            btnUpdateUser.TabIndex = 79;
            btnUpdateUser.Text = "Actualizar Usuario";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // brnBack
            // 
            brnBack.Location = new Point(526, 472);
            brnBack.Name = "brnBack";
            brnBack.Size = new Size(121, 48);
            brnBack.TabIndex = 77;
            brnBack.Text = "Atras";
            brnBack.UseVisualStyleBackColor = true;
            brnBack.Click += brnBack_Click;
            // 
            // cBoxChangedPassword
            // 
            cBoxChangedPassword.FormattingEnabled = true;
            cBoxChangedPassword.Items.AddRange(new object[] { "true", "false" });
            cBoxChangedPassword.Location = new Point(1154, 302);
            cBoxChangedPassword.Name = "cBoxChangedPassword";
            cBoxChangedPassword.Size = new Size(125, 28);
            cBoxChangedPassword.TabIndex = 82;
            // 
            // cBoxStatus
            // 
            cBoxStatus.FormattingEnabled = true;
            cBoxStatus.Items.AddRange(new object[] { "true", "false" });
            cBoxStatus.Location = new Point(1155, 255);
            cBoxStatus.Name = "cBoxStatus";
            cBoxStatus.Size = new Size(124, 28);
            cBoxStatus.TabIndex = 83;
            // 
            // cBoxPrivilege
            // 
            cBoxPrivilege.FormattingEnabled = true;
            cBoxPrivilege.Items.AddRange(new object[] { "1", "2", "3" });
            cBoxPrivilege.Location = new Point(1155, 389);
            cBoxPrivilege.Name = "cBoxPrivilege";
            cBoxPrivilege.Size = new Size(124, 28);
            cBoxPrivilege.TabIndex = 84;
            // 
            // frmUsersAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1476, 721);
            Controls.Add(cBoxPrivilege);
            Controls.Add(cBoxStatus);
            Controls.Add(cBoxChangedPassword);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(brnBack);
            Controls.Add(lbPrivilege);
            Controls.Add(txtIdPerson);
            Controls.Add(lbIdPerson);
            Controls.Add(lbChangePassword);
            Controls.Add(lbStatus);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Controls.Add(txtIdUser);
            Controls.Add(lbIdUser);
            Controls.Add(dgvUsers);
            Controls.Add(lbUsersAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsersAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmUsersAdmin";
            Load += frmUsersAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsersAdmin;
        private DataGridView dgvUsers;
        private Label lbChangePassword;
        private Label lbStatus;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtUserName;
        private Label lbUserName;
        private TextBox txtIdUser;
        private Label lbIdUser;
        private TextBox txtIdPerson;
        private Label lbIdPerson;
        private Label lbPrivilege;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button brnBack;
        private ComboBox cBoxChangedPassword;
        private ComboBox cBoxStatus;
        private ComboBox cBoxPrivilege;
    }
}