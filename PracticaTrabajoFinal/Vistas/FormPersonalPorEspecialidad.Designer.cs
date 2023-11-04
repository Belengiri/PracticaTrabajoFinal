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
            this.panelPersonalPorEspecialidadad = new System.Windows.Forms.Panel();
            this.paneldgvpersonalporespecialidades = new System.Windows.Forms.Panel();
            this.dgvpersonalporespecialidad = new System.Windows.Forms.DataGridView();
            this.panelbuscardor = new System.Windows.Forms.Panel();
            this.cbespecialidades = new System.Windows.Forms.ComboBox();
            this.btnbuscarpersonalporespecialidad = new System.Windows.Forms.Button();
            this.lblnombreespecialidad = new System.Windows.Forms.Label();
            this.panelPersonalPorEspecialidadad.SuspendLayout();
            this.paneldgvpersonalporespecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonalporespecialidad)).BeginInit();
            this.panelbuscardor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPersonalPorEspecialidadad
            // 
            this.panelPersonalPorEspecialidadad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPersonalPorEspecialidadad.Controls.Add(this.paneldgvpersonalporespecialidades);
            this.panelPersonalPorEspecialidadad.Controls.Add(this.panelbuscardor);
            this.panelPersonalPorEspecialidadad.Location = new System.Drawing.Point(-2, -18);
            this.panelPersonalPorEspecialidadad.Name = "panelPersonalPorEspecialidadad";
            this.panelPersonalPorEspecialidadad.Size = new System.Drawing.Size(569, 414);
            this.panelPersonalPorEspecialidadad.TabIndex = 1;
            // 
            // paneldgvpersonalporespecialidades
            // 
            this.paneldgvpersonalporespecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvpersonalporespecialidades.Controls.Add(this.dgvpersonalporespecialidad);
            this.paneldgvpersonalporespecialidades.Location = new System.Drawing.Point(72, 164);
            this.paneldgvpersonalporespecialidades.Name = "paneldgvpersonalporespecialidades";
            this.paneldgvpersonalporespecialidades.Size = new System.Drawing.Size(425, 241);
            this.paneldgvpersonalporespecialidades.TabIndex = 7;
            // 
            // dgvpersonalporespecialidad
            // 
            this.dgvpersonalporespecialidad.AllowUserToAddRows = false;
            this.dgvpersonalporespecialidad.AllowUserToDeleteRows = false;
            this.dgvpersonalporespecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonalporespecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpersonalporespecialidad.Location = new System.Drawing.Point(0, 0);
            this.dgvpersonalporespecialidad.Name = "dgvpersonalporespecialidad";
            this.dgvpersonalporespecialidad.Size = new System.Drawing.Size(425, 241);
            this.dgvpersonalporespecialidad.TabIndex = 1;
            // 
            // panelbuscardor
            // 
            this.panelbuscardor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbuscardor.Controls.Add(this.cbespecialidades);
            this.panelbuscardor.Controls.Add(this.btnbuscarpersonalporespecialidad);
            this.panelbuscardor.Controls.Add(this.lblnombreespecialidad);
            this.panelbuscardor.Location = new System.Drawing.Point(137, 3);
            this.panelbuscardor.Name = "panelbuscardor";
            this.panelbuscardor.Size = new System.Drawing.Size(282, 155);
            this.panelbuscardor.TabIndex = 6;
            // 
            // cbespecialidades
            // 
            this.cbespecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbespecialidades.FormattingEnabled = true;
            this.cbespecialidades.Location = new System.Drawing.Point(61, 60);
            this.cbespecialidades.Name = "cbespecialidades";
            this.cbespecialidades.Size = new System.Drawing.Size(175, 21);
            this.cbespecialidades.TabIndex = 7;
            // 
            // btnbuscarpersonalporespecialidad
            // 
            this.btnbuscarpersonalporespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnbuscarpersonalporespecialidad.Location = new System.Drawing.Point(102, 87);
            this.btnbuscarpersonalporespecialidad.Name = "btnbuscarpersonalporespecialidad";
            this.btnbuscarpersonalporespecialidad.Size = new System.Drawing.Size(75, 31);
            this.btnbuscarpersonalporespecialidad.TabIndex = 5;
            this.btnbuscarpersonalporespecialidad.Text = "Buscar";
            this.btnbuscarpersonalporespecialidad.UseVisualStyleBackColor = true;
            this.btnbuscarpersonalporespecialidad.Click += new System.EventHandler(this.btnbuscarpersonalporespecialidad_Click);
            // 
            // lblnombreespecialidad
            // 
            this.lblnombreespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblnombreespecialidad.AutoSize = true;
            this.lblnombreespecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreespecialidad.Location = new System.Drawing.Point(44, 38);
            this.lblnombreespecialidad.Name = "lblnombreespecialidad";
            this.lblnombreespecialidad.Size = new System.Drawing.Size(212, 20);
            this.lblnombreespecialidad.TabIndex = 3;
            this.lblnombreespecialidad.Text = "Seleccione una Especialidad";
            // 
            // FormPersonalPorEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.panelPersonalPorEspecialidadad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormPersonalPorEspecialidad";
            this.Text = "FormPersonalPorEspecialidad";
            this.panelPersonalPorEspecialidadad.ResumeLayout(false);
            this.paneldgvpersonalporespecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonalporespecialidad)).EndInit();
            this.panelbuscardor.ResumeLayout(false);
            this.panelbuscardor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPersonalPorEspecialidadad;
        private System.Windows.Forms.Panel paneldgvpersonalporespecialidades;
        private System.Windows.Forms.DataGridView dgvpersonalporespecialidad;
        private System.Windows.Forms.Panel panelbuscardor;
        private System.Windows.Forms.ComboBox cbespecialidades;
        private System.Windows.Forms.Button btnbuscarpersonalporespecialidad;
        private System.Windows.Forms.Label lblnombreespecialidad;
    }
}