namespace UIDesktop
{
    partial class frmDeleteSubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteSubjects));
            pictureLogo = new PictureBox();
            btnDeleteSubjectAccept = new Button();
            btnCancel = new Button();
            lbSubjects = new Label();
            dgvSubjects = new DataGridView();
            txtDeleteSubjects = new TextBox();
            lbtxtDeleteSubjects = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
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
            // btnDeleteSubjectAccept
            // 
            btnDeleteSubjectAccept.Location = new Point(629, 425);
            btnDeleteSubjectAccept.Name = "btnDeleteSubjectAccept";
            btnDeleteSubjectAccept.Size = new Size(95, 39);
            btnDeleteSubjectAccept.TabIndex = 29;
            btnDeleteSubjectAccept.Text = "Aceptar";
            btnDeleteSubjectAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(399, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 39);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbSubjects
            // 
            lbSubjects.AutoSize = true;
            lbSubjects.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSubjects.Location = new Point(312, 41);
            lbSubjects.Name = "lbSubjects";
            lbSubjects.Size = new Size(198, 25);
            lbSubjects.TabIndex = 27;
            lbSubjects.Text = "Eliminar materia";
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(51, 124);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidth = 51;
            dgvSubjects.RowTemplate.Height = 29;
            dgvSubjects.Size = new Size(673, 216);
            dgvSubjects.TabIndex = 26;
            dgvSubjects.CellContentClick += dgvSubjects_CellContentClick;
            // 
            // txtDeleteSubjects
            // 
            txtDeleteSubjects.Location = new Point(170, 357);
            txtDeleteSubjects.Name = "txtDeleteSubjects";
            txtDeleteSubjects.Size = new Size(125, 27);
            txtDeleteSubjects.TabIndex = 25;
            // 
            // lbtxtDeleteSubjects
            // 
            lbtxtDeleteSubjects.AutoSize = true;
            lbtxtDeleteSubjects.Location = new Point(50, 364);
            lbtxtDeleteSubjects.Name = "lbtxtDeleteSubjects";
            lbtxtDeleteSubjects.Size = new Size(83, 20);
            lbtxtDeleteSubjects.TabIndex = 24;
            lbtxtDeleteSubjects.Text = "Id materia*";
            // 
            // frmDeleteSubjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 505);
            Controls.Add(pictureLogo);
            Controls.Add(btnDeleteSubjectAccept);
            Controls.Add(btnCancel);
            Controls.Add(lbSubjects);
            Controls.Add(dgvSubjects);
            Controls.Add(txtDeleteSubjects);
            Controls.Add(lbtxtDeleteSubjects);
            Name = "frmDeleteSubjects";
            Text = "Eliminar materia";
            Load += frmDeleteSubjects_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnDeleteSubjectAccept;
        private Button btnCancel;
        private Label lbSubjects;
        private DataGridView dgvSubjects;
        private TextBox txtDeleteSubjects;
        private Label lbtxtDeleteSubjects;
    }
}