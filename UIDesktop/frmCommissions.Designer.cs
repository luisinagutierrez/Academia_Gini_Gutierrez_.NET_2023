namespace UIDesktop
{
    partial class frmCommissions
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
            txtCommissionSpecialityYear = new TextBox();
            lbCommissionSpecialityYear = new Label();
            lbCreateUpdateCommission = new Label();
            dgvCommissions = new DataGridView();
            txtCommissionDescription = new TextBox();
            lbCommissionDescription = new Label();
            btnUpdateCommission = new Button();
            btnCreateCommission = new Button();
            btnBack = new Button();
            txtIdCommission = new TextBox();
            lbIdCommission = new Label();
            lbCommissionIdPlan = new Label();
            btnDeleteCommission = new Button();
            cBoxIdPlan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).BeginInit();
            SuspendLayout();
            // 
            // txtCommissionSpecialityYear
            // 
            txtCommissionSpecialityYear.Location = new Point(1069, 282);
            txtCommissionSpecialityYear.Name = "txtCommissionSpecialityYear";
            txtCommissionSpecialityYear.Size = new Size(124, 27);
            txtCommissionSpecialityYear.TabIndex = 38;
            // 
            // lbCommissionSpecialityYear
            // 
            lbCommissionSpecialityYear.AutoSize = true;
            lbCommissionSpecialityYear.Location = new Point(946, 282);
            lbCommissionSpecialityYear.Name = "lbCommissionSpecialityYear";
            lbCommissionSpecialityYear.Size = new Size(92, 20);
            lbCommissionSpecialityYear.TabIndex = 37;
            lbCommissionSpecialityYear.Text = "Año cursado";
            // 
            // lbCreateUpdateCommission
            // 
            lbCreateUpdateCommission.AutoSize = true;
            lbCreateUpdateCommission.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdateCommission.Location = new Point(756, 53);
            lbCreateUpdateCommission.Name = "lbCreateUpdateCommission";
            lbCreateUpdateCommission.Size = new Size(140, 25);
            lbCreateUpdateCommission.TabIndex = 36;
            lbCreateUpdateCommission.Text = "Comisiones";
            // 
            // dgvCommissions
            // 
            dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommissions.Location = new Point(381, 148);
            dgvCommissions.Name = "dgvCommissions";
            dgvCommissions.RowHeadersWidth = 51;
            dgvCommissions.RowTemplate.Height = 29;
            dgvCommissions.Size = new Size(532, 212);
            dgvCommissions.TabIndex = 34;
            dgvCommissions.CellContentClick += dgvCommissions_CellContentClick;
            dgvCommissions.SelectionChanged += dgvCommissions_SelectionChanged;
            // 
            // txtCommissionDescription
            // 
            txtCommissionDescription.Location = new Point(1069, 193);
            txtCommissionDescription.Multiline = true;
            txtCommissionDescription.Name = "txtCommissionDescription";
            txtCommissionDescription.Size = new Size(221, 71);
            txtCommissionDescription.TabIndex = 33;
            // 
            // lbCommissionDescription
            // 
            lbCommissionDescription.AutoSize = true;
            lbCommissionDescription.Location = new Point(946, 196);
            lbCommissionDescription.Name = "lbCommissionDescription";
            lbCommissionDescription.Size = new Size(87, 20);
            lbCommissionDescription.TabIndex = 32;
            lbCommissionDescription.Text = "Descripcion";
            // 
            // btnUpdateCommission
            // 
            btnUpdateCommission.Location = new Point(905, 467);
            btnUpdateCommission.Name = "btnUpdateCommission";
            btnUpdateCommission.Size = new Size(121, 48);
            btnUpdateCommission.TabIndex = 31;
            btnUpdateCommission.Text = "Actualizar comision";
            btnUpdateCommission.UseVisualStyleBackColor = true;
            btnUpdateCommission.Click += btnUpdateCommission_Click;
            // 
            // btnCreateCommission
            // 
            btnCreateCommission.Location = new Point(719, 467);
            btnCreateCommission.Name = "btnCreateCommission";
            btnCreateCommission.Size = new Size(121, 48);
            btnCreateCommission.TabIndex = 30;
            btnCreateCommission.Text = "Guardar nueva comision";
            btnCreateCommission.UseVisualStyleBackColor = true;
            btnCreateCommission.Click += btnCreateCommission_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(537, 467);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 29;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtIdCommission
            // 
            txtIdCommission.Location = new Point(1069, 148);
            txtIdCommission.Name = "txtIdCommission";
            txtIdCommission.Size = new Size(124, 27);
            txtIdCommission.TabIndex = 28;
            // 
            // lbIdCommission
            // 
            lbIdCommission.AutoSize = true;
            lbIdCommission.Location = new Point(946, 151);
            lbIdCommission.Name = "lbIdCommission";
            lbIdCommission.Size = new Size(86, 20);
            lbIdCommission.TabIndex = 27;
            lbIdCommission.Text = "Id comision";
            // 
            // lbCommissionIdPlan
            // 
            lbCommissionIdPlan.AutoSize = true;
            lbCommissionIdPlan.Location = new Point(946, 333);
            lbCommissionIdPlan.Name = "lbCommissionIdPlan";
            lbCommissionIdPlan.Size = new Size(55, 20);
            lbCommissionIdPlan.TabIndex = 39;
            lbCommissionIdPlan.Text = "Id plan";
            // 
            // btnDeleteCommission
            // 
            btnDeleteCommission.Location = new Point(1086, 467);
            btnDeleteCommission.Name = "btnDeleteCommission";
            btnDeleteCommission.Size = new Size(121, 48);
            btnDeleteCommission.TabIndex = 41;
            btnDeleteCommission.Text = "Eliminar comision\r\n";
            btnDeleteCommission.UseVisualStyleBackColor = true;
            btnDeleteCommission.Click += btnDeleteCommission_Click;
            // 
            // cBoxIdPlan
            // 
            cBoxIdPlan.FormattingEnabled = true;
            cBoxIdPlan.Location = new Point(1069, 333);
            cBoxIdPlan.Name = "cBoxIdPlan";
            cBoxIdPlan.Size = new Size(85, 28);
            cBoxIdPlan.TabIndex = 42;
            // 
            // frmCommissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1633, 763);
            Controls.Add(cBoxIdPlan);
            Controls.Add(btnDeleteCommission);
            Controls.Add(lbCommissionIdPlan);
            Controls.Add(txtCommissionSpecialityYear);
            Controls.Add(lbCommissionSpecialityYear);
            Controls.Add(lbCreateUpdateCommission);
            Controls.Add(dgvCommissions);
            Controls.Add(txtCommissionDescription);
            Controls.Add(lbCommissionDescription);
            Controls.Add(btnUpdateCommission);
            Controls.Add(btnCreateCommission);
            Controls.Add(btnBack);
            Controls.Add(txtIdCommission);
            Controls.Add(lbIdCommission);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCommissions";
            Text = "Crear o actualizar comision";
            Load += frmCreateAndUpdateCommissions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCommissionSpecialityYear;
        private Label lbCommissionSpecialityYear;
        private Label lbCreateUpdateCommission;
        private DataGridView dgvCommissions;
        private TextBox txtCommissionDescription;
        private Label lbCommissionDescription;
        private Button btnUpdateCommission;
        private Button btnCreateCommission;
        private Button btnBack;
        private TextBox txtIdCommission;
        private Label lbIdCommission;
        private Label lbCommissionIdPlan;
        private Button btnDeleteCommission;
        private ComboBox cBoxIdPlan;
    }
}