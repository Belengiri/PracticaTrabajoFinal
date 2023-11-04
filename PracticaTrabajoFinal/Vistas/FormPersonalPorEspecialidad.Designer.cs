namespace PracticaTrabajoFinal.Vistas
{
    partial class FormPersonalPorEspecialidad
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
            this.panelpersonalporespecialidad = new System.Windows.Forms.Panel();
            this.panedgvpersonalporespecialidad = new System.Windows.Forms.Panel();
            this.panelbuscardor = new System.Windows.Forms.Panel();
            this.cbespecialidades = new System.Windows.Forms.ComboBox();
            this.btnbuscarpracticaporespecialidad = new System.Windows.Forms.Button();
            this.lblnombreespecialidad = new System.Windows.Forms.Label();
            this.dgvpersonalporespecialidad = new System.Windows.Forms.DataGridView();
            this.panelpersonalporespecialidad.SuspendLayout();
            this.panedgvpersonalporespecialidad.SuspendLayout();
            this.panelbuscardor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonalporespecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panelpersonalporespecialidad
            // 
            this.panelpersonalporespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpersonalporespecialidad.Controls.Add(this.panedgvpersonalporespecialidad);
            this.panelpersonalporespecialidad.Controls.Add(this.panelbuscardor);
            this.panelpersonalporespecialidad.Location = new System.Drawing.Point(-2, -18);
            this.panelpersonalporespecialidad.Name = "panelpersonalporespecialidad";
            this.panelpersonalporespecialidad.Size = new System.Drawing.Size(569, 414);
            this.panelpersonalporespecialidad.TabIndex = 1;
            // 
            // panedgvpersonalporespecialidad
            // 
            this.panedgvpersonalporespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panedgvpersonalporespecialidad.Controls.Add(this.dgvpersonalporespecialidad);
            this.panedgvpersonalporespecialidad.Location = new System.Drawing.Point(76, 164);
            this.panedgvpersonalporespecialidad.Name = "panedgvpersonalporespecialidad";
            this.panedgvpersonalporespecialidad.Size = new System.Drawing.Size(416, 238);
            this.panedgvpersonalporespecialidad.TabIndex = 11;
            // 
            // panelbuscardor
            // 
            this.panelbuscardor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbuscardor.Controls.Add(this.cbespecialidades);
            this.panelbuscardor.Controls.Add(this.btnbuscarpracticaporespecialidad);
            this.panelbuscardor.Controls.Add(this.lblnombreespecialidad);
            this.panelbuscardor.Location = new System.Drawing.Point(142, 12);
            this.panelbuscardor.Name = "panelbuscardor";
            this.panelbuscardor.Size = new System.Drawing.Size(272, 146);
            this.panelbuscardor.TabIndex = 10;
            // 
            // cbespecialidades
            // 
            this.cbespecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbespecialidades.FormattingEnabled = true;
            this.cbespecialidades.Location = new System.Drawing.Point(56, 60);
            this.cbespecialidades.Name = "cbespecialidades";
            this.cbespecialidades.Size = new System.Drawing.Size(175, 21);
            this.cbespecialidades.TabIndex = 7;
            // 
            // btnbuscarpracticaporespecialidad
            // 
            this.btnbuscarpracticaporespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnbuscarpracticaporespecialidad.Location = new System.Drawing.Point(97, 87);
            this.btnbuscarpracticaporespecialidad.Name = "btnbuscarpracticaporespecialidad";
            this.btnbuscarpracticaporespecialidad.Size = new System.Drawing.Size(75, 22);
            this.btnbuscarpracticaporespecialidad.TabIndex = 5;
            this.btnbuscarpracticaporespecialidad.Text = "Buscar";
            this.btnbuscarpracticaporespecialidad.UseVisualStyleBackColor = true;
            this.btnbuscarpracticaporespecialidad.Click += new System.EventHandler(this.btnbuscarpracticaporespecialidad_Click);
            // 
            // lblnombreespecialidad
            // 
            this.lblnombreespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblnombreespecialidad.AutoSize = true;
            this.lblnombreespecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreespecialidad.Location = new System.Drawing.Point(39, 38);
            this.lblnombreespecialidad.Name = "lblnombreespecialidad";
            this.lblnombreespecialidad.Size = new System.Drawing.Size(212, 20);
            this.lblnombreespecialidad.TabIndex = 3;
            this.lblnombreespecialidad.Text = "Seleccione una Especialidad";
            // 
            // dgvpersonalporespecialidad
            // 
            this.dgvpersonalporespecialidad.AllowUserToAddRows = false;
            this.dgvpersonalporespecialidad.AllowUserToDeleteRows = false;
            this.dgvpersonalporespecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonalporespecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpersonalporespecialidad.Location = new System.Drawing.Point(0, 0);
            this.dgvpersonalporespecialidad.Name = "dgvpersonalporespecialidad";
            this.dgvpersonalporespecialidad.Size = new System.Drawing.Size(416, 238);
            this.dgvpersonalporespecialidad.TabIndex = 2;
            // 
            // FormPersonalPorEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 378);
            this.Controls.Add(this.panelpersonalporespecialidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormPersonalPorEspecialidad";
            this.Text = "FormPersonalPorEspecialidad";
            this.panelpersonalporespecialidad.ResumeLayout(false);
            this.panedgvpersonalporespecialidad.ResumeLayout(false);
            this.panelbuscardor.ResumeLayout(false);
            this.panelbuscardor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonalporespecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelpersonalporespecialidad;
        private System.Windows.Forms.Panel panedgvpersonalporespecialidad;
        private System.Windows.Forms.Panel panelbuscardor;
        private System.Windows.Forms.ComboBox cbespecialidades;
        private System.Windows.Forms.Button btnbuscarpracticaporespecialidad;
        private System.Windows.Forms.Label lblnombreespecialidad;
        private System.Windows.Forms.DataGridView dgvpersonalporespecialidad;
    }
}