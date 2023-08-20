namespace UIDesktop
{
    partial class frmCreateAndUpdateCommissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAndUpdateCommissions));
            txtCommissionSpecialityYear = new TextBox();
            lbCommissionSpecialityYear = new Label();
            lbCreateUpdateCommission = new Label();
            pictureLogo = new PictureBox();
            dgvCommissions = new DataGridView();
            txtCommissionDescription = new TextBox();
            lbCommissionDescription = new Label();
            btnUpdateCommission = new Button();
            btnCreateCommission = new Button();
            btnBack = new Button();
            txtIdCommission = new TextBox();
            lbIdCommission = new Label();
            txtCommissionPlan = new TextBox();
            lbCommissionIdPlan = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).BeginInit();
            SuspendLayout();
            // 
            // txtCommissionSpecialityYear
            // 
            txtCommissionSpecialityYear.Location = new Point(710, 262);
            txtCommissionSpecialityYear.Name = "txtCommissionSpecialityYear";
            txtCommissionSpecialityYear.Size = new Size(124, 27);
            txtCommissionSpecialityYear.TabIndex = 38;
            // 
            // lbCommissionSpecialityYear
            // 
            lbCommissionSpecialityYear.AutoSize = true;
            lbCommissionSpecialityYear.Location = new Point(587, 262);
            lbCommissionSpecialityYear.Name = "lbCommissionSpecialityYear";
            lbCommissionSpecialityYear.Size = new Size(92, 20);
            lbCommissionSpecialityYear.TabIndex = 37;
            lbCommissionSpecialityYear.Text = "Año cursado";
            // 
            // lbCreateUpdateCommission
            // 
            lbCreateUpdateCommission.AutoSize = true;
            lbCreateUpdateCommission.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdateCommission.Location = new Point(460, 54);
            lbCreateUpdateCommission.Name = "lbCreateUpdateCommission";
            lbCreateUpdateCommission.Size = new Size(140, 25);
            lbCreateUpdateCommission.TabIndex = 36;
            lbCreateUpdateCommission.Text = "Comisiones";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 90);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 35;
            pictureLogo.TabStop = false;
            // 
            // dgvCommissions
            // 
            dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommissions.Location = new Point(22, 128);
            dgvCommissions.Name = "dgvCommissions";
            dgvCommissions.RowHeadersWidth = 51;
            dgvCommissions.RowTemplate.Height = 29;
            dgvCommissions.Size = new Size(532, 212);
            dgvCommissions.TabIndex = 34;
            // 
            // txtCommissionDescription
            // 
            txtCommissionDescription.Location = new Point(710, 173);
            txtCommissionDescription.Multiline = true;
            txtCommissionDescription.Name = "txtCommissionDescription";
            txtCommissionDescription.Size = new Size(221, 71);
            txtCommissionDescription.TabIndex = 33;
            // 
            // lbCommissionDescription
            // 
            lbCommissionDescription.AutoSize = true;
            lbCommissionDescription.Location = new Point(587, 176);
            lbCommissionDescription.Name = "lbCommissionDescription";
            lbCommissionDescription.Size = new Size(87, 20);
            lbCommissionDescription.TabIndex = 32;
            lbCommissionDescription.Text = "Descripcion";
            // 
            // btnUpdateCommission
            // 
            btnUpdateCommission.Location = new Point(646, 381);
            btnUpdateCommission.Name = "btnUpdateCommission";
            btnUpdateCommission.Size = new Size(121, 48);
            btnUpdateCommission.TabIndex = 31;
            btnUpdateCommission.Text = "Actualizar comision";
            btnUpdateCommission.UseVisualStyleBackColor = true;
            // 
            // btnCreateCommission
            // 
            btnCreateCommission.Location = new Point(460, 381);
            btnCreateCommission.Name = "btnCreateCommission";
            btnCreateCommission.Size = new Size(121, 48);
            btnCreateCommission.TabIndex = 30;
            btnCreateCommission.Text = "Guardar nueva comision";
            btnCreateCommission.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(278, 381);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 29;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtIdCommission
            // 
            txtIdCommission.Location = new Point(710, 128);
            txtIdCommission.Name = "txtIdCommission";
            txtIdCommission.Size = new Size(124, 27);
            txtIdCommission.TabIndex = 28;
            // 
            // lbIdCommission
            // 
            lbIdCommission.AutoSize = true;
            lbIdCommission.Location = new Point(587, 131);
            lbIdCommission.Name = "lbIdCommission";
            lbIdCommission.Size = new Size(86, 20);
            lbIdCommission.TabIndex = 27;
            lbIdCommission.Text = "Id comision";
            // 
            // txtCommissionPlan
            // 
            txtCommissionPlan.Location = new Point(710, 313);
            txtCommissionPlan.Name = "txtCommissionPlan";
            txtCommissionPlan.Size = new Size(124, 27);
            txtCommissionPlan.TabIndex = 40;
            // 
            // lbCommissionIdPlan
            // 
            lbCommissionIdPlan.AutoSize = true;
            lbCommissionIdPlan.Location = new Point(587, 313);
            lbCommissionIdPlan.Name = "lbCommissionIdPlan";
            lbCommissionIdPlan.Size = new Size(55, 20);
            lbCommissionIdPlan.TabIndex = 39;
            lbCommissionIdPlan.Text = "Id plan";
            // 
            // frmCreateAndUpdateCommissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(985, 482);
            Controls.Add(txtCommissionPlan);
            Controls.Add(lbCommissionIdPlan);
            Controls.Add(txtCommissionSpecialityYear);
            Controls.Add(lbCommissionSpecialityYear);
            Controls.Add(lbCreateUpdateCommission);
            Controls.Add(pictureLogo);
            Controls.Add(dgvCommissions);
            Controls.Add(txtCommissionDescription);
            Controls.Add(lbCommissionDescription);
            Controls.Add(btnUpdateCommission);
            Controls.Add(btnCreateCommission);
            Controls.Add(btnBack);
            Controls.Add(txtIdCommission);
            Controls.Add(lbIdCommission);
            Name = "frmCreateAndUpdateCommissions";
            Text = "Crear o actualizar comision";
            Load += frmCreateAndUpdateCommissions_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCommissionSpecialityYear;
        private Label lbCommissionSpecialityYear;
        private Label lbCreateUpdateCommission;
        private PictureBox pictureLogo;
        private DataGridView dgvCommissions;
        private TextBox txtCommissionDescription;
        private Label lbCommissionDescription;
        private Button btnUpdateCommission;
        private Button btnCreateCommission;
        private Button btnBack;
        private TextBox txtIdCommission;
        private Label lbIdCommission;
        private TextBox txtCommissionPlan;
        private Label lbCommissionIdPlan;
    }
}