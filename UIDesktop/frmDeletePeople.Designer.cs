namespace UIDesktop
{
    partial class frmDeletePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletePeople));
            pictureLogo = new PictureBox();
            btnDeletePeopleAccept = new Button();
            btnCancel = new Button();
            lbPlans = new Label();
            dgvPeople = new DataGridView();
            txtDeletePeople = new TextBox();
            lbtxtDeletePeople = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(96, 84);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 37;
            pictureLogo.TabStop = false;
            // 
            // btnDeletePeopleAccept
            // 
            btnDeletePeopleAccept.Location = new Point(629, 425);
            btnDeletePeopleAccept.Name = "btnDeletePeopleAccept";
            btnDeletePeopleAccept.Size = new Size(95, 39);
            btnDeletePeopleAccept.TabIndex = 36;
            btnDeletePeopleAccept.Text = "Aceptar";
            btnDeletePeopleAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(451, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 39);
            btnCancel.TabIndex = 35;
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
            lbPlans.Size = new Size(202, 25);
            lbPlans.TabIndex = 34;
            lbPlans.Text = "Eliminar persona";
            // 
            // dgvPeople
            // 
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Location = new Point(51, 124);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.RowTemplate.Height = 29;
            dgvPeople.Size = new Size(673, 216);
            dgvPeople.TabIndex = 33;
            // 
            // txtDeletePeople
            // 
            txtDeletePeople.Location = new Point(168, 374);
            txtDeletePeople.Name = "txtDeletePeople";
            txtDeletePeople.Size = new Size(125, 27);
            txtDeletePeople.TabIndex = 32;
            // 
            // lbtxtDeletePeople
            // 
            lbtxtDeletePeople.AutoSize = true;
            lbtxtDeletePeople.Location = new Point(48, 381);
            lbtxtDeletePeople.Name = "lbtxtDeletePeople";
            lbtxtDeletePeople.Size = new Size(85, 20);
            lbtxtDeletePeople.TabIndex = 31;
            lbtxtDeletePeople.Text = "Id persona*";
            // 
            // frmDeletePeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(787, 488);
            Controls.Add(pictureLogo);
            Controls.Add(btnDeletePeopleAccept);
            Controls.Add(btnCancel);
            Controls.Add(lbPlans);
            Controls.Add(dgvPeople);
            Controls.Add(txtDeletePeople);
            Controls.Add(lbtxtDeletePeople);
            Name = "frmDeletePeople";
            Text = "Eliminar Persona";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnDeletePeopleAccept;
        private Button btnCancel;
        private Label lbPlans;
        private DataGridView dgvPeople;
        private TextBox txtDeletePeople;
        private Label lbtxtDeletePeople;
    }
}