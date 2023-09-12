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
            txtChangePassword = new TextBox();
            lbChangePassword = new Label();
            txtStatus = new TextBox();
            lbStatus = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtUserName = new TextBox();
            lbUserName = new Label();
            txtIdUser = new TextBox();
            lbIdUser = new Label();
            txtIdPerson = new TextBox();
            lbIdPerson = new Label();
            txtPrivilege = new TextBox();
            lbPrivilege = new Label();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            brnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lbUsersAdmin
            // 
            lbUsersAdmin.AutoSize = true;
            lbUsersAdmin.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsersAdmin.Location = new Point(451, 22);
            lbUsersAdmin.Name = "lbUsersAdmin";
            lbUsersAdmin.Size = new Size(110, 25);
            lbUsersAdmin.TabIndex = 15;
            lbUsersAdmin.Text = "Usuarios";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 77);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.Size = new Size(653, 281);
            dgvUsers.TabIndex = 16;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // txtChangePassword
            // 
            txtChangePassword.Location = new Point(854, 247);
            txtChangePassword.Name = "txtChangePassword";
            txtChangePassword.Size = new Size(124, 27);
            txtChangePassword.TabIndex = 72;
            // 
            // lbChangePassword
            // 
            lbChangePassword.AutoSize = true;
            lbChangePassword.Location = new Point(709, 250);
            lbChangePassword.Name = "lbChangePassword";
            lbChangePassword.Size = new Size(138, 20);
            lbChangePassword.TabIndex = 71;
            lbChangePassword.Text = "Cambia Contraseña";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(854, 205);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(124, 27);
            txtStatus.TabIndex = 70;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(709, 208);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(54, 20);
            lbStatus.TabIndex = 69;
            lbStatus.Text = "Estado";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(854, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(124, 27);
            txtPassword.TabIndex = 68;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(709, 166);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(83, 20);
            lbPassword.TabIndex = 67;
            lbPassword.Text = "Contraseña";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(854, 120);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(124, 27);
            txtUserName.TabIndex = 66;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(709, 123);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(139, 20);
            lbUserName.TabIndex = 65;
            lbUserName.Text = "Nombre de Usuario";
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(854, 78);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(124, 27);
            txtIdUser.TabIndex = 64;
            // 
            // lbIdUser
            // 
            lbIdUser.AutoSize = true;
            lbIdUser.Location = new Point(709, 81);
            lbIdUser.Name = "lbIdUser";
            lbIdUser.Size = new Size(76, 20);
            lbIdUser.TabIndex = 63;
            lbIdUser.Text = "Id Usuario";
            // 
            // txtIdPerson
            // 
            txtIdPerson.Location = new Point(854, 289);
            txtIdPerson.Name = "txtIdPerson";
            txtIdPerson.Size = new Size(124, 27);
            txtIdPerson.TabIndex = 74;
            // 
            // lbIdPerson
            // 
            lbIdPerson.AutoSize = true;
            lbIdPerson.Location = new Point(709, 292);
            lbIdPerson.Name = "lbIdPerson";
            lbIdPerson.Size = new Size(79, 20);
            lbIdPerson.TabIndex = 73;
            lbIdPerson.Text = "Id persona";
            // 
            // txtPrivilege
            // 
            txtPrivilege.Location = new Point(854, 331);
            txtPrivilege.Name = "txtPrivilege";
            txtPrivilege.Size = new Size(124, 27);
            txtPrivilege.TabIndex = 76;
            // 
            // lbPrivilege
            // 
            lbPrivilege.AutoSize = true;
            lbPrivilege.Location = new Point(709, 334);
            lbPrivilege.Name = "lbPrivilege";
            lbPrivilege.Size = new Size(71, 20);
            lbPrivilege.TabIndex = 75;
            lbPrivilege.Text = "Privilegio";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(700, 401);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(121, 48);
            btnDeleteUser.TabIndex = 80;
            btnDeleteUser.Text = "Eliminar Usuario";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(497, 401);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(121, 48);
            btnUpdateUser.TabIndex = 79;
            btnUpdateUser.Text = "Actualizar Usuario";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // brnBack
            // 
            brnBack.Location = new Point(266, 401);
            brnBack.Name = "brnBack";
            brnBack.Size = new Size(121, 48);
            brnBack.TabIndex = 77;
            brnBack.Text = "Atras";
            brnBack.UseVisualStyleBackColor = true;
            brnBack.Click += brnBack_Click;
            // 
            // frmUsersAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1024, 533);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(brnBack);
            Controls.Add(txtPrivilege);
            Controls.Add(lbPrivilege);
            Controls.Add(txtIdPerson);
            Controls.Add(lbIdPerson);
            Controls.Add(txtChangePassword);
            Controls.Add(lbChangePassword);
            Controls.Add(txtStatus);
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
        private TextBox txtChangePassword;
        private Label lbChangePassword;
        private TextBox txtStatus;
        private Label lbStatus;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtUserName;
        private Label lbUserName;
        private TextBox txtIdUser;
        private Label lbIdUser;
        private TextBox txtIdPerson;
        private Label lbIdPerson;
        private TextBox txtPrivilege;
        private Label lbPrivilege;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button brnBack;
    }
}