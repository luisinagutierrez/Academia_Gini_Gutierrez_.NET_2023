namespace UIDesktop
{
    partial class frmDeletePlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletePlans));
            pictureLogo = new PictureBox();
            btnDeletePlanAccept = new Button();
            btnCancel = new Button();
            lbPlans = new Label();
            dgvPlans = new DataGridView();
            txtDeletePlans = new TextBox();
            lbtxtDeletePlans = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(96, 84);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 23;
            pictureLogo.TabStop = false;
            // 
            // btnDeletePlanAccept
            // 
            btnDeletePlanAccept.Location = new Point(629, 425);
            btnDeletePlanAccept.Name = "btnDeletePlanAccept";
            btnDeletePlanAccept.Size = new Size(95, 39);
            btnDeletePlanAccept.TabIndex = 22;
            btnDeletePlanAccept.Text = "Aceptar";
            btnDeletePlanAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(399, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 39);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbPlans
            // 
            lbPlans.AutoSize = true;
            lbPlans.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPlans.Location = new Point(330, 46);
            lbPlans.Name = "lbPlans";
            lbPlans.Size = new Size(160, 25);
            lbPlans.TabIndex = 20;
            lbPlans.Text = "Eliminar plan";
            // 
            // dgvPlans
            // 
            dgvPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlans.Location = new Point(51, 124);
            dgvPlans.Name = "dgvPlans";
            dgvPlans.RowHeadersWidth = 51;
            dgvPlans.RowTemplate.Height = 29;
            dgvPlans.Size = new Size(673, 216);
            dgvPlans.TabIndex = 19;
            dgvPlans.CellContentClick += dgvPlans_CellContentClick;
            // 
            // txtDeletePlans
            // 
            txtDeletePlans.Location = new Point(170, 357);
            txtDeletePlans.Name = "txtDeletePlans";
            txtDeletePlans.Size = new Size(125, 27);
            txtDeletePlans.TabIndex = 18;
            // 
            // lbtxtDeletePlans
            // 
            lbtxtDeletePlans.AutoSize = true;
            lbtxtDeletePlans.Location = new Point(50, 364);
            lbtxtDeletePlans.Name = "lbtxtDeletePlans";
            lbtxtDeletePlans.Size = new Size(61, 20);
            lbtxtDeletePlans.TabIndex = 17;
            lbtxtDeletePlans.Text = "Id plan*";
            // 
            // frmDeletePlans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(794, 503);
            Controls.Add(pictureLogo);
            Controls.Add(btnDeletePlanAccept);
            Controls.Add(btnCancel);
            Controls.Add(lbPlans);
            Controls.Add(dgvPlans);
            Controls.Add(txtDeletePlans);
            Controls.Add(lbtxtDeletePlans);
            Name = "frmDeletePlans";
            Text = "Eliminar Plan";
            Load += frmDeletePlans_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnDeletePlanAccept;
        private Button btnCancel;
        private Label lbPlans;
        private DataGridView dgvPlans;
        private TextBox txtDeletePlans;
        private Label lbtxtDeletePlans;
    }
}