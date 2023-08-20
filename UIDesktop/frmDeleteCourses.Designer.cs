namespace UIDesktop
{
    partial class frmDeleteCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteCourses));
            pictureLogo = new PictureBox();
            btnDeleteCourseAccept = new Button();
            btnCancel = new Button();
            lbCourses = new Label();
            dgvCourses = new DataGridView();
            txtDeleteCourses = new TextBox();
            lbtxtDeleteCourses = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
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
            // btnDeleteCourseAccept
            // 
            btnDeleteCourseAccept.Location = new Point(629, 416);
            btnDeleteCourseAccept.Name = "btnDeleteCourseAccept";
            btnDeleteCourseAccept.Size = new Size(95, 39);
            btnDeleteCourseAccept.TabIndex = 36;
            btnDeleteCourseAccept.Text = "Aceptar";
            btnDeleteCourseAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(399, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 39);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbCourses
            // 
            lbCourses.AutoSize = true;
            lbCourses.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourses.Location = new Point(330, 42);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(174, 25);
            lbCourses.TabIndex = 34;
            lbCourses.Text = "Eliminar curso";
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(51, 115);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.RowTemplate.Height = 29;
            dgvCourses.Size = new Size(673, 216);
            dgvCourses.TabIndex = 33;
            // 
            // txtDeleteCourses
            // 
            txtDeleteCourses.Location = new Point(170, 348);
            txtDeleteCourses.Name = "txtDeleteCourses";
            txtDeleteCourses.Size = new Size(125, 27);
            txtDeleteCourses.TabIndex = 32;
            // 
            // lbtxtDeleteCourses
            // 
            lbtxtDeleteCourses.AutoSize = true;
            lbtxtDeleteCourses.Location = new Point(50, 355);
            lbtxtDeleteCourses.Name = "lbtxtDeleteCourses";
            lbtxtDeleteCourses.Size = new Size(67, 20);
            lbtxtDeleteCourses.TabIndex = 31;
            lbtxtDeleteCourses.Text = "Id curso*";
            // 
            // frmDeleteCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(797, 496);
            Controls.Add(pictureLogo);
            Controls.Add(btnDeleteCourseAccept);
            Controls.Add(btnCancel);
            Controls.Add(lbCourses);
            Controls.Add(dgvCourses);
            Controls.Add(txtDeleteCourses);
            Controls.Add(lbtxtDeleteCourses);
            Name = "frmDeleteCourses";
            Text = "Eliminar Curso";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnDeleteCourseAccept;
        private Button btnCancel;
        private Label lbCourses;
        private DataGridView dgvCourses;
        private TextBox txtDeleteCourses;
        private Label lbtxtDeleteCourses;
    }
}