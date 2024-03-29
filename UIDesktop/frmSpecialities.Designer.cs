﻿namespace UIDesktop
{
    partial class frmSpecialities
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
            lbIdSpecialities = new Label();
            txtIdSpeciality = new TextBox();
            brnBack = new Button();
            btnCreateSpecialitie = new Button();
            btnUpdateSpecialitie = new Button();
            txtSpecialityDescription = new TextBox();
            lbSpecialityDescription = new Label();
            dgvSpecialities = new DataGridView();
            lbCreateUpdateSpecialities = new Label();
            btnDeleteSpeciality = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).BeginInit();
            SuspendLayout();
            // 
            // lbIdSpecialities
            // 
            lbIdSpecialities.AutoSize = true;
            lbIdSpecialities.Location = new Point(814, 180);
            lbIdSpecialities.Name = "lbIdSpecialities";
            lbIdSpecialities.Size = new Size(110, 20);
            lbIdSpecialities.TabIndex = 0;
            lbIdSpecialities.Text = "Id especialidad";
            // 
            // txtIdSpeciality
            // 
            txtIdSpeciality.Location = new Point(937, 180);
            txtIdSpeciality.Name = "txtIdSpeciality";
            txtIdSpeciality.Size = new Size(124, 27);
            txtIdSpeciality.TabIndex = 1;
            // 
            // brnBack
            // 
            brnBack.Location = new Point(416, 372);
            brnBack.Name = "brnBack";
            brnBack.Size = new Size(121, 48);
            brnBack.TabIndex = 2;
            brnBack.Text = "Atras";
            brnBack.UseVisualStyleBackColor = true;
            brnBack.Click += button1_Click;
            // 
            // btnCreateSpecialitie
            // 
            btnCreateSpecialitie.Location = new Point(598, 372);
            btnCreateSpecialitie.Name = "btnCreateSpecialitie";
            btnCreateSpecialitie.Size = new Size(121, 48);
            btnCreateSpecialitie.TabIndex = 3;
            btnCreateSpecialitie.Text = "Guardar nueva especialidad";
            btnCreateSpecialitie.UseVisualStyleBackColor = true;
            btnCreateSpecialitie.Click += btnCreateSpecialitie_Click;
            // 
            // btnUpdateSpecialitie
            // 
            btnUpdateSpecialitie.Location = new Point(784, 372);
            btnUpdateSpecialitie.Name = "btnUpdateSpecialitie";
            btnUpdateSpecialitie.Size = new Size(121, 48);
            btnUpdateSpecialitie.TabIndex = 4;
            btnUpdateSpecialitie.Text = "Actualizar especialidad";
            btnUpdateSpecialitie.UseVisualStyleBackColor = true;
            btnUpdateSpecialitie.Click += btnUpdateSpecialitie_Click;
            // 
            // txtSpecialityDescription
            // 
            txtSpecialityDescription.Location = new Point(931, 225);
            txtSpecialityDescription.Multiline = true;
            txtSpecialityDescription.Name = "txtSpecialityDescription";
            txtSpecialityDescription.Size = new Size(221, 71);
            txtSpecialityDescription.TabIndex = 6;
            // 
            // lbSpecialityDescription
            // 
            lbSpecialityDescription.AutoSize = true;
            lbSpecialityDescription.Location = new Point(814, 225);
            lbSpecialityDescription.Name = "lbSpecialityDescription";
            lbSpecialityDescription.Size = new Size(87, 20);
            lbSpecialityDescription.TabIndex = 5;
            lbSpecialityDescription.Text = "Descripcion";
            // 
            // dgvSpecialities
            // 
            dgvSpecialities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpecialities.Location = new Point(393, 139);
            dgvSpecialities.Name = "dgvSpecialities";
            dgvSpecialities.RowHeadersWidth = 51;
            dgvSpecialities.RowTemplate.Height = 29;
            dgvSpecialities.Size = new Size(339, 185);
            dgvSpecialities.TabIndex = 9;
            dgvSpecialities.CellContentClick += dgvSpecialities_CellContentClick;
            dgvSpecialities.SelectionChanged += dgvSpecialities_SelectionChanged;
            // 
            // lbCreateUpdateSpecialities
            // 
            lbCreateUpdateSpecialities.AutoSize = true;
            lbCreateUpdateSpecialities.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdateSpecialities.Location = new Point(598, 47);
            lbCreateUpdateSpecialities.Name = "lbCreateUpdateSpecialities";
            lbCreateUpdateSpecialities.Size = new Size(177, 25);
            lbCreateUpdateSpecialities.TabIndex = 14;
            lbCreateUpdateSpecialities.Text = "Especialidades";
            // 
            // btnDeleteSpeciality
            // 
            btnDeleteSpeciality.Location = new Point(977, 372);
            btnDeleteSpeciality.Name = "btnDeleteSpeciality";
            btnDeleteSpeciality.Size = new Size(121, 48);
            btnDeleteSpeciality.TabIndex = 15;
            btnDeleteSpeciality.Text = "Eliminar especialidad";
            btnDeleteSpeciality.UseVisualStyleBackColor = true;
            btnDeleteSpeciality.Click += btnDeleteSpeciality_Click;
            // 
            // frmSpecialities
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1397, 870);
            Controls.Add(btnDeleteSpeciality);
            Controls.Add(lbCreateUpdateSpecialities);
            Controls.Add(dgvSpecialities);
            Controls.Add(txtSpecialityDescription);
            Controls.Add(lbSpecialityDescription);
            Controls.Add(btnUpdateSpecialitie);
            Controls.Add(btnCreateSpecialitie);
            Controls.Add(brnBack);
            Controls.Add(txtIdSpeciality);
            Controls.Add(lbIdSpecialities);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSpecialities";
            Text = "Crear o Actualizar Especialidades";
            Load += frmSpecialities_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIdSpecialities;
        private TextBox txtIdSpeciality;
        private Button brnBack;
        private Button btnCreateSpecialitie;
        private Button btnUpdateSpecialitie;
        private TextBox txtSpecialityDescription;
        private Label lbSpecialityDescription;
        private DataGridView dgvSpecialities;
        private Label lbCreateUpdateSpecialities;
        private Button btnDeleteSpeciality;
    }
}