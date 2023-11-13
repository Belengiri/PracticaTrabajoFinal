namespace PracticaTrabajoFinal.Vistas
{
    partial class FormPracticasPorEspecialidad
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
            this.panelPracticasPorEspecialidadad = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.paneldgvpracticasporespecialidades = new System.Windows.Forms.Panel();
            this.dgvpracticasporespecialidad = new System.Windows.Forms.DataGridView();
            this.panelbuscardor = new System.Windows.Forms.Panel();
            this.cbespecialidades = new System.Windows.Forms.ComboBox();
            this.lblnombreespecialidad = new System.Windows.Forms.Label();
            this.btnbuscarpracticaporespecialidad = new System.Windows.Forms.Button();
            this.panelPracticasPorEspecialidadad.SuspendLayout();
            this.paneldgvpracticasporespecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpracticasporespecialidad)).BeginInit();
            this.panelbuscardor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPracticasPorEspecialidadad
            // 
            this.panelPracticasPorEspecialidadad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPracticasPorEspecialidadad.Controls.Add(this.label2);
            this.panelPracticasPorEspecialidadad.Controls.Add(this.paneldgvpracticasporespecialidades);
            this.panelPracticasPorEspecialidadad.Controls.Add(this.panelbuscardor);
            this.panelPracticasPorEspecialidadad.Location = new System.Drawing.Point(12, 0);
            this.panelPracticasPorEspecialidadad.Name = "panelPracticasPorEspecialidadad";
            this.panelPracticasPorEspecialidadad.Size = new System.Drawing.Size(569, 414);
            this.panelPracticasPorEspecialidadad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Practicas por Especialidad";
            // 
            // paneldgvpracticasporespecialidades
            // 
            this.paneldgvpracticasporespecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvpracticasporespecialidades.Controls.Add(this.dgvpracticasporespecialidad);
            this.paneldgvpracticasporespecialidades.Location = new System.Drawing.Point(72, 164);
            this.paneldgvpracticasporespecialidades.Name = "paneldgvpracticasporespecialidades";
            this.paneldgvpracticasporespecialidades.Size = new System.Drawing.Size(425, 241);
            this.paneldgvpracticasporespecialidades.TabIndex = 7;
            // 
            // dgvpracticasporespecialidad
            // 
            this.dgvpracticasporespecialidad.AllowUserToAddRows = false;
            this.dgvpracticasporespecialidad.AllowUserToDeleteRows = false;
            this.dgvpracticasporespecialidad.AllowUserToResizeColumns = false;
            this.dgvpracticasporespecialidad.AllowUserToResizeRows = false;
            this.dgvpracticasporespecialidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpracticasporespecialidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvpracticasporespecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpracticasporespecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpracticasporespecialidad.Location = new System.Drawing.Point(0, 0);
            this.dgvpracticasporespecialidad.Name = "dgvpracticasporespecialidad";
            this.dgvpracticasporespecialidad.Size = new System.Drawing.Size(425, 241);
            this.dgvpracticasporespecialidad.TabIndex = 0;
            // 
            // panelbuscardor
            // 
            this.panelbuscardor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbuscardor.Controls.Add(this.cbespecialidades);
            this.panelbuscardor.Controls.Add(this.lblnombreespecialidad);
            this.panelbuscardor.Controls.Add(this.btnbuscarpracticaporespecialidad);
            this.panelbuscardor.Location = new System.Drawing.Point(166, 51);
            this.panelbuscardor.Name = "panelbuscardor";
            this.panelbuscardor.Size = new System.Drawing.Size(257, 107);
            this.panelbuscardor.TabIndex = 6;
            // 
            // cbespecialidades
            // 
            this.cbespecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbespecialidades.FormattingEnabled = true;
            this.cbespecialidades.Location = new System.Drawing.Point(46, 39);
            this.cbespecialidades.Name = "cbespecialidades";
            this.cbespecialidades.Size = new System.Drawing.Size(175, 21);
            this.cbespecialidades.TabIndex = 7;
            // 
            // lblnombreespecialidad
            // 
            this.lblnombreespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblnombreespecialidad.AutoSize = true;
            this.lblnombreespecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreespecialidad.Location = new System.Drawing.Point(29, 17);
            this.lblnombreespecialidad.Name = "lblnombreespecialidad";
            this.lblnombreespecialidad.Size = new System.Drawing.Size(212, 20);
            this.lblnombreespecialidad.TabIndex = 3;
            this.lblnombreespecialidad.Text = "Seleccione una Especialidad";
            // 
            // btnbuscarpracticaporespecialidad
            // 
            this.btnbuscarpracticaporespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnbuscarpracticaporespecialidad.Location = new System.Drawing.Point(87, 66);
            this.btnbuscarpracticaporespecialidad.Name = "btnbuscarpracticaporespecialidad";
            this.btnbuscarpracticaporespecialidad.Size = new System.Drawing.Size(75, 31);
            this.btnbuscarpracticaporespecialidad.TabIndex = 5;
            this.btnbuscarpracticaporespecialidad.Text = "Buscar";
            this.btnbuscarpracticaporespecialidad.UseVisualStyleBackColor = true;
            this.btnbuscarpracticaporespecialidad.Click += new System.EventHandler(this.btnbuscarpracticaporespecialidad_Click);
            // 
            // FormPracticasPorEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.panelPracticasPorEspecialidadad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 150);
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormPracticasPorEspecialidad";
            this.Text = "FormPracticasPorEspecialidad";
            this.Load += new System.EventHandler(this.FormPracticasPorEspecialidad_Load);
            this.panelPracticasPorEspecialidadad.ResumeLayout(false);
            this.panelPracticasPorEspecialidadad.PerformLayout();
            this.paneldgvpracticasporespecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpracticasporespecialidad)).EndInit();
            this.panelbuscardor.ResumeLayout(false);
            this.panelbuscardor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPracticasPorEspecialidadad;
        private System.Windows.Forms.Panel panelbuscardor;
        private System.Windows.Forms.Button btnbuscarpracticaporespecialidad;
        private System.Windows.Forms.Label lblnombreespecialidad;
        private System.Windows.Forms.ComboBox cbespecialidades;
        private System.Windows.Forms.Panel paneldgvpracticasporespecialidades;
        private System.Windows.Forms.DataGridView dgvpracticasporespecialidad;
        private System.Windows.Forms.Label label2;
    }
}