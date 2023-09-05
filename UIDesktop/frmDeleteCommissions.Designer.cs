namespace UIDesktop
{
    partial class frmDeleteCommissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteCommissions));
            pictureLogo = new PictureBox();
            btnDeleteCommissionAccept = new Button();
            btnCancel = new Button();
            lbPlans = new Label();
            dgvCommissions = new DataGridView();
            txtDeleteCommission = new TextBox();
            lbtxtDeleteCommssion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(96, 84);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 30;
            pictureLogo.TabStop = false;
            // 
            // btnDeleteCommissionAccept
            // 
            btnDeleteCommissionAccept.Location = new Point(629, 425);
            btnDeleteCommissionAccept.Name = "btnDeleteCommissionAccept";
            btnDeleteCommissionAccept.Size = new Size(95, 39);
            btnDeleteCommissionAccept.TabIndex = 29;
            btnDeleteCommissionAccept.Text = "Aceptar";
            btnDeleteCommissionAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(451, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 39);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbPlans
            // 
            lbPlans.AutoSize = true;
            lbPlans.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPlans.Location = new Point(306, 37);
            lbPlans.Name = "lbPlans";
            lbPlans.Size = new Size(213, 25);
            lbPlans.TabIndex = 27;
            lbPlans.Text = "Eliminar comision";
            // 
            // dgvCommissions
            // 
            dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommissions.Location = new Point(51, 124);
            dgvCommissions.Name = "dgvCommissions";
            dgvCommissions.RowHeadersWidth = 51;
            dgvCommissions.RowTemplate.Height = 29;
            dgvCommissions.Size = new Size(673, 216);
            dgvCommissions.TabIndex = 26;
            dgvCommissions.CellContentClick += dgvCommissions_CellContentClick;
            // 
            // txtDeleteCommission
            // 
            txtDeleteCommission.Location = new Point(168, 374);
            txtDeleteCommission.Name = "txtDeleteCommission";
            txtDeleteCommission.Size = new Size(125, 27);
            txtDeleteCommission.TabIndex = 25;
            // 
            // lbtxtDeleteCommssion
            // 
            lbtxtDeleteCommssion.AutoSize = true;
            lbtxtDeleteCommssion.Location = new Point(48, 381);
            lbtxtDeleteCommssion.Name = "lbtxtDeleteCommssion";
            lbtxtDeleteCommssion.Size = new Size(92, 20);
            lbtxtDeleteCommssion.TabIndex = 24;
            lbtxtDeleteCommssion.Text = "Id comision*";
            // 
            // frmDeleteCommissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(795, 514);
            Controls.Add(pictureLogo);
            Controls.Add(btnDeleteCommissionAccept);
            Controls.Add(btnCancel);
            Controls.Add(lbPlans);
            Controls.Add(dgvCommissions);
            Controls.Add(txtDeleteCommission);
            Controls.Add(lbtxtDeleteCommssion);
            Name = "frmDeleteCommissions";
            Text = "Eliminar comision";
            Load += frmDeleteCommissions_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommissions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnDeleteCommissionAccept;
        private Button btnCancel;
        private Label lbPlans;
        private DataGridView dgvCommissions;
        private TextBox txtDeleteCommission;
        private Label lbtxtDeleteCommssion;
    }
}