namespace UIDesktop
{
    partial class frmCreateAndUpdatePlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAndUpdatePlans));
            lbCreateUpdatePlans = new Label();
            pictureLogo = new PictureBox();
            dgvPlans = new DataGridView();
            txtPlanDescription = new TextBox();
            lbPlanDescription = new Label();
            btnUpdatePlan = new Button();
            btnCreatePlan = new Button();
            btnBack = new Button();
            txtIdPlans = new TextBox();
            lbIdPlan = new Label();
            txtPlanSpeciality = new TextBox();
            lbPlanSpeciality = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).BeginInit();
            SuspendLayout();
            // 
            // lbCreateUpdatePlans
            // 
            lbCreateUpdatePlans.AutoSize = true;
            lbCreateUpdatePlans.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdatePlans.Location = new Point(447, 46);
            lbCreateUpdatePlans.Name = "lbCreateUpdatePlans";
            lbCreateUpdatePlans.Size = new Size(86, 25);
            lbCreateUpdatePlans.TabIndex = 24;
            lbCreateUpdatePlans.Text = "Planes";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(101, 90);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 23;
            pictureLogo.TabStop = false;
            // 
            // dgvPlans
            // 
            dgvPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlans.Location = new Point(60, 138);
            dgvPlans.Name = "dgvPlans";
            dgvPlans.RowHeadersWidth = 51;
            dgvPlans.RowTemplate.Height = 29;
            dgvPlans.Size = new Size(448, 185);
            dgvPlans.TabIndex = 22;
            dgvPlans.CellContentClick += dgvPlans_CellContentClick;
            // 
            // txtPlanDescription
            // 
            txtPlanDescription.Location = new Point(694, 197);
            txtPlanDescription.Multiline = true;
            txtPlanDescription.Name = "txtPlanDescription";
            txtPlanDescription.Size = new Size(221, 71);
            txtPlanDescription.TabIndex = 21;
            // 
            // lbPlanDescription
            // 
            lbPlanDescription.AutoSize = true;
            lbPlanDescription.Location = new Point(571, 197);
            lbPlanDescription.Name = "lbPlanDescription";
            lbPlanDescription.Size = new Size(87, 20);
            lbPlanDescription.TabIndex = 20;
            lbPlanDescription.Text = "Descripcion";
            // 
            // btnUpdatePlan
            // 
            btnUpdatePlan.Location = new Point(646, 381);
            btnUpdatePlan.Name = "btnUpdatePlan";
            btnUpdatePlan.Size = new Size(121, 48);
            btnUpdatePlan.TabIndex = 19;
            btnUpdatePlan.Text = "Actualizar plan";
            btnUpdatePlan.UseVisualStyleBackColor = true;
            // 
            // btnCreatePlan
            // 
            btnCreatePlan.Location = new Point(460, 381);
            btnCreatePlan.Name = "btnCreatePlan";
            btnCreatePlan.Size = new Size(121, 48);
            btnCreatePlan.TabIndex = 18;
            btnCreatePlan.Text = "Guardar nuevo plan";
            btnCreatePlan.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(278, 381);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 17;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += brnBack_Click;
            // 
            // txtIdPlans
            // 
            txtIdPlans.Location = new Point(694, 152);
            txtIdPlans.Name = "txtIdPlans";
            txtIdPlans.Size = new Size(124, 27);
            txtIdPlans.TabIndex = 16;
            // 
            // lbIdPlan
            // 
            lbIdPlan.AutoSize = true;
            lbIdPlan.Location = new Point(571, 152);
            lbIdPlan.Name = "lbIdPlan";
            lbIdPlan.Size = new Size(55, 20);
            lbIdPlan.TabIndex = 15;
            lbIdPlan.Text = "Id plan";
            // 
            // txtPlanSpeciality
            // 
            txtPlanSpeciality.Location = new Point(694, 287);
            txtPlanSpeciality.Name = "txtPlanSpeciality";
            txtPlanSpeciality.Size = new Size(124, 27);
            txtPlanSpeciality.TabIndex = 26;
            // 
            // lbPlanSpeciality
            // 
            lbPlanSpeciality.AutoSize = true;
            lbPlanSpeciality.Location = new Point(571, 287);
            lbPlanSpeciality.Name = "lbPlanSpeciality";
            lbPlanSpeciality.Size = new Size(117, 20);
            lbPlanSpeciality.TabIndex = 25;
            lbPlanSpeciality.Text = "Id escpecialidad";
            // 
            // frmCreateAndUpdatePlans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(986, 495);
            Controls.Add(txtPlanSpeciality);
            Controls.Add(lbPlanSpeciality);
            Controls.Add(lbCreateUpdatePlans);
            Controls.Add(pictureLogo);
            Controls.Add(dgvPlans);
            Controls.Add(txtPlanDescription);
            Controls.Add(lbPlanDescription);
            Controls.Add(btnUpdatePlan);
            Controls.Add(btnCreatePlan);
            Controls.Add(btnBack);
            Controls.Add(txtIdPlans);
            Controls.Add(lbIdPlan);
            Name = "frmCreateAndUpdatePlans";
            Text = "Crear o Actualizar planes";
            Load += frmCreateAndUpdatePlans_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreateUpdatePlans;
        private PictureBox pictureLogo;
        private DataGridView dgvPlans;
        private TextBox txtPlanDescription;
        private Label lbPlanDescription;
        private Button btnUpdatePlan;
        private Button btnCreatePlan;
        private Button btnBack;
        private TextBox txtIdPlans;
        private Label lbIdPlan;
        private TextBox txtPlanSpeciality;
        private Label lbPlanSpeciality;
    }
}