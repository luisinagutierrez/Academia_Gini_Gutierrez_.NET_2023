namespace UIDesktop
{
    partial class frmCreateAndUpdatePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAndUpdatePeople));
            txtPeopleIdPlan = new TextBox();
            lbPeopleIdPlan = new Label();
            txtPeopleEmail = new TextBox();
            lbPeopleEmail = new Label();
            txtPeopleAddress = new TextBox();
            lbPeopleAddress = new Label();
            txtPeopleSurname = new TextBox();
            lbPeopleSurname = new Label();
            txtPeopleName = new TextBox();
            lbPeopleName = new Label();
            lbCreateUpdatePeople = new Label();
            pictureLogo = new PictureBox();
            dgvPeople = new DataGridView();
            btnUpdatePeople = new Button();
            btnCreatePeople = new Button();
            btnBack = new Button();
            txtIdPerson = new TextBox();
            lbIdPerson = new Label();
            txtPeoplePersonType = new TextBox();
            lbPeoplePersonType = new Label();
            txtPeopleFileId = new TextBox();
            lbPeopleFileId = new Label();
            txtPeopleBirthDate = new TextBox();
            lbPeopleBirthDate = new Label();
            txtPeopleTelephone = new TextBox();
            lbPeopleTelephone = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // txtPeopleIdPlan
            // 
            txtPeopleIdPlan.Location = new Point(1181, 225);
            txtPeopleIdPlan.Name = "txtPeopleIdPlan";
            txtPeopleIdPlan.Size = new Size(80, 27);
            txtPeopleIdPlan.TabIndex = 82;
            // 
            // lbPeopleIdPlan
            // 
            lbPeopleIdPlan.AutoSize = true;
            lbPeopleIdPlan.Location = new Point(1101, 228);
            lbPeopleIdPlan.Name = "lbPeopleIdPlan";
            lbPeopleIdPlan.Size = new Size(55, 20);
            lbPeopleIdPlan.TabIndex = 81;
            lbPeopleIdPlan.Text = "Id plan";
            // 
            // txtPeopleEmail
            // 
            txtPeopleEmail.Location = new Point(889, 307);
            txtPeopleEmail.Name = "txtPeopleEmail";
            txtPeopleEmail.Size = new Size(226, 27);
            txtPeopleEmail.TabIndex = 80;
            // 
            // lbPeopleEmail
            // 
            lbPeopleEmail.AutoSize = true;
            lbPeopleEmail.Location = new Point(766, 310);
            lbPeopleEmail.Name = "lbPeopleEmail";
            lbPeopleEmail.Size = new Size(52, 20);
            lbPeopleEmail.TabIndex = 79;
            lbPeopleEmail.Text = "e-mail";
            // 
            // txtPeopleAddress
            // 
            txtPeopleAddress.Location = new Point(889, 222);
            txtPeopleAddress.Name = "txtPeopleAddress";
            txtPeopleAddress.Size = new Size(183, 27);
            txtPeopleAddress.TabIndex = 78;
            // 
            // lbPeopleAddress
            // 
            lbPeopleAddress.AutoSize = true;
            lbPeopleAddress.Location = new Point(766, 225);
            lbPeopleAddress.Name = "lbPeopleAddress";
            lbPeopleAddress.Size = new Size(72, 20);
            lbPeopleAddress.TabIndex = 77;
            lbPeopleAddress.Text = "Direccion";
            // 
            // txtPeopleSurname
            // 
            txtPeopleSurname.Location = new Point(1181, 182);
            txtPeopleSurname.Name = "txtPeopleSurname";
            txtPeopleSurname.Size = new Size(124, 27);
            txtPeopleSurname.TabIndex = 76;
            // 
            // lbPeopleSurname
            // 
            lbPeopleSurname.AutoSize = true;
            lbPeopleSurname.Location = new Point(1090, 189);
            lbPeopleSurname.Name = "lbPeopleSurname";
            lbPeopleSurname.Size = new Size(66, 20);
            lbPeopleSurname.TabIndex = 75;
            lbPeopleSurname.Text = "Apellido";
            // 
            // txtPeopleName
            // 
            txtPeopleName.Location = new Point(889, 179);
            txtPeopleName.Name = "txtPeopleName";
            txtPeopleName.Size = new Size(124, 27);
            txtPeopleName.TabIndex = 74;
            // 
            // lbPeopleName
            // 
            lbPeopleName.AutoSize = true;
            lbPeopleName.Location = new Point(766, 182);
            lbPeopleName.Name = "lbPeopleName";
            lbPeopleName.Size = new Size(64, 20);
            lbPeopleName.TabIndex = 73;
            lbPeopleName.Text = "Nombre";
            // 
            // lbCreateUpdatePeople
            // 
            lbCreateUpdatePeople.AutoSize = true;
            lbCreateUpdatePeople.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdatePeople.Location = new Point(697, 58);
            lbCreateUpdatePeople.Name = "lbCreateUpdatePeople";
            lbCreateUpdatePeople.Size = new Size(115, 25);
            lbCreateUpdatePeople.TabIndex = 72;
            lbCreateUpdatePeople.Text = "Personas";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 90);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 71;
            pictureLogo.TabStop = false;
            // 
            // dgvPeople
            // 
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Location = new Point(28, 116);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.RowTemplate.Height = 29;
            dgvPeople.Size = new Size(713, 385);
            dgvPeople.TabIndex = 70;
            dgvPeople.CellContentClick += dgvPeople_CellContentClick;
            // 
            // btnUpdatePeople
            // 
            btnUpdatePeople.Location = new Point(1172, 453);
            btnUpdatePeople.Name = "btnUpdatePeople";
            btnUpdatePeople.Size = new Size(121, 48);
            btnUpdatePeople.TabIndex = 69;
            btnUpdatePeople.Text = "Actualizar datos persona";
            btnUpdatePeople.UseVisualStyleBackColor = true;
            // 
            // btnCreatePeople
            // 
            btnCreatePeople.Location = new Point(986, 453);
            btnCreatePeople.Name = "btnCreatePeople";
            btnCreatePeople.Size = new Size(121, 48);
            btnCreatePeople.TabIndex = 68;
            btnCreatePeople.Text = "Guardar nuevo persona";
            btnCreatePeople.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(804, 453);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 67;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtIdPerson
            // 
            txtIdPerson.Location = new Point(889, 137);
            txtIdPerson.Name = "txtIdPerson";
            txtIdPerson.Size = new Size(80, 27);
            txtIdPerson.TabIndex = 66;
            // 
            // lbIdPerson
            // 
            lbIdPerson.AutoSize = true;
            lbIdPerson.Location = new Point(766, 140);
            lbIdPerson.Name = "lbIdPerson";
            lbIdPerson.Size = new Size(79, 20);
            lbIdPerson.TabIndex = 65;
            lbIdPerson.Text = "Id persona";
            // 
            // txtPeoplePersonType
            // 
            txtPeoplePersonType.ForeColor = SystemColors.WindowFrame;
            txtPeoplePersonType.Location = new Point(918, 402);
            txtPeoplePersonType.Name = "txtPeoplePersonType";
            txtPeoplePersonType.Size = new Size(154, 27);
            txtPeoplePersonType.TabIndex = 90;
            txtPeoplePersonType.Text = "1-docente 2-alumno";
            // 
            // lbPeoplePersonType
            // 
            lbPeoplePersonType.AutoSize = true;
            lbPeoplePersonType.Location = new Point(766, 402);
            lbPeoplePersonType.Name = "lbPeoplePersonType";
            lbPeoplePersonType.Size = new Size(139, 20);
            lbPeoplePersonType.TabIndex = 89;
            lbPeoplePersonType.Text = "Rol en la institucion";
            // 
            // txtPeopleFileId
            // 
            txtPeopleFileId.Location = new Point(1181, 137);
            txtPeopleFileId.Name = "txtPeopleFileId";
            txtPeopleFileId.Size = new Size(87, 27);
            txtPeopleFileId.TabIndex = 88;
            // 
            // lbPeopleFileId
            // 
            lbPeopleFileId.AutoSize = true;
            lbPeopleFileId.Location = new Point(1090, 137);
            lbPeopleFileId.Name = "lbPeopleFileId";
            lbPeopleFileId.Size = new Size(54, 20);
            lbPeopleFileId.TabIndex = 87;
            lbPeopleFileId.Text = "Legajo";
            // 
            // txtPeopleBirthDate
            // 
            txtPeopleBirthDate.ForeColor = SystemColors.WindowFrame;
            txtPeopleBirthDate.Location = new Point(918, 264);
            txtPeopleBirthDate.Name = "txtPeopleBirthDate";
            txtPeopleBirthDate.Size = new Size(168, 27);
            txtPeopleBirthDate.TabIndex = 86;
            txtPeopleBirthDate.Text = "AA-MM-DD";
            // 
            // lbPeopleBirthDate
            // 
            lbPeopleBirthDate.AutoSize = true;
            lbPeopleBirthDate.Location = new Point(766, 267);
            lbPeopleBirthDate.Name = "lbPeopleBirthDate";
            lbPeopleBirthDate.Size = new Size(146, 20);
            lbPeopleBirthDate.TabIndex = 85;
            lbPeopleBirthDate.Text = "Fecha de nacimiento";
            // 
            // txtPeopleTelephone
            // 
            txtPeopleTelephone.Location = new Point(889, 352);
            txtPeopleTelephone.Name = "txtPeopleTelephone";
            txtPeopleTelephone.Size = new Size(124, 27);
            txtPeopleTelephone.TabIndex = 84;
            // 
            // lbPeopleTelephone
            // 
            lbPeopleTelephone.AutoSize = true;
            lbPeopleTelephone.Location = new Point(766, 355);
            lbPeopleTelephone.Name = "lbPeopleTelephone";
            lbPeopleTelephone.Size = new Size(67, 20);
            lbPeopleTelephone.TabIndex = 83;
            lbPeopleTelephone.Text = "Telefono";
            // 
            // frmCreateAndUpdatePeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1338, 525);
            Controls.Add(txtPeoplePersonType);
            Controls.Add(lbPeoplePersonType);
            Controls.Add(txtPeopleFileId);
            Controls.Add(lbPeopleFileId);
            Controls.Add(txtPeopleBirthDate);
            Controls.Add(lbPeopleBirthDate);
            Controls.Add(txtPeopleTelephone);
            Controls.Add(lbPeopleTelephone);
            Controls.Add(txtPeopleIdPlan);
            Controls.Add(lbPeopleIdPlan);
            Controls.Add(txtPeopleEmail);
            Controls.Add(lbPeopleEmail);
            Controls.Add(txtPeopleAddress);
            Controls.Add(lbPeopleAddress);
            Controls.Add(txtPeopleSurname);
            Controls.Add(lbPeopleSurname);
            Controls.Add(txtPeopleName);
            Controls.Add(lbPeopleName);
            Controls.Add(lbCreateUpdatePeople);
            Controls.Add(pictureLogo);
            Controls.Add(dgvPeople);
            Controls.Add(btnUpdatePeople);
            Controls.Add(btnCreatePeople);
            Controls.Add(btnBack);
            Controls.Add(txtIdPerson);
            Controls.Add(lbIdPerson);
            Name = "frmCreateAndUpdatePeople";
            Text = "Crear o actualizar persona";
            Load += frmCreateAndUpdatePeople_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPeopleIdPlan;
        private Label lbPeopleIdPlan;
        private TextBox txtPeopleEmail;
        private Label lbPeopleEmail;
        private TextBox txtPeopleAddress;
        private Label lbPeopleAddress;
        private TextBox txtPeopleSurname;
        private Label lbPeopleSurname;
        private TextBox txtPeopleName;
        private Label lbPeopleName;
        private Label lbCreateUpdatePeople;
        private PictureBox pictureLogo;
        private DataGridView dgvPeople;
        private Button btnUpdatePeople;
        private Button btnCreatePeople;
        private Button btnBack;
        private TextBox txtIdPerson;
        private Label lbIdPerson;
        private TextBox txtPeoplePersonType;
        private Label lbPeoplePersonType;
        private TextBox txtPeopleFileId;
        private Label lbPeopleFileId;
        private TextBox txtPeopleBirthDate;
        private Label lbPeopleBirthDate;
        private TextBox txtPeopleTelephone;
        private Label lbPeopleTelephone;
    }
}