namespace PracticaTrabajoFinal.Vistas
{
    partial class FormLocalidades
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
            this.paneldgvlocalidades = new System.Windows.Forms.Panel();
            this.dgvlocalidades = new System.Windows.Forms.DataGridView();
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btnagregarlocalidad = new System.Windows.Forms.Button();
            this.btnmodificarlocalidad = new System.Windows.Forms.Button();
            this.btneliminarlocalidad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelbtnaceptar = new System.Windows.Forms.Panel();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lblnombrelocalidad = new System.Windows.Forms.Label();
            this.txtnombrelocalidad = new System.Windows.Forms.TextBox();
            this.txtcodigopostal = new System.Windows.Forms.TextBox();
            this.lblcodigopostal = new System.Windows.Forms.Label();
            this.paneldgvlocalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocalidades)).BeginInit();
            this.panelbotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelbtnaceptar.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldgvlocalidades
            // 
            this.paneldgvlocalidades.Controls.Add(this.dgvlocalidades);
            this.paneldgvlocalidades.Location = new System.Drawing.Point(12, 12);
            this.paneldgvlocalidades.Name = "paneldgvlocalidades";
            this.paneldgvlocalidades.Size = new System.Drawing.Size(349, 250);
            this.paneldgvlocalidades.TabIndex = 0;
            // 
            // dgvlocalidades
            // 
            this.dgvlocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlocalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvlocalidades.Location = new System.Drawing.Point(0, 0);
            this.dgvlocalidades.Name = "dgvlocalidades";
            this.dgvlocalidades.Size = new System.Drawing.Size(349, 250);
            this.dgvlocalidades.TabIndex = 0;
            // 
            // panelbotones
            // 
            this.panelbotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotones.Controls.Add(this.btneliminarlocalidad);
            this.panelbotones.Controls.Add(this.btnmodificarlocalidad);
            this.panelbotones.Controls.Add(this.btnagregarlocalidad);
            this.panelbotones.Location = new System.Drawing.Point(12, 268);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(253, 51);
            this.panelbotones.TabIndex = 1;
            // 
            // btnagregarlocalidad
            // 
            this.btnagregarlocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnagregarlocalidad.Location = new System.Drawing.Point(3, 3);
            this.btnagregarlocalidad.Name = "btnagregarlocalidad";
            this.btnagregarlocalidad.Size = new System.Drawing.Size(75, 37);
            this.btnagregarlocalidad.TabIndex = 0;
            this.btnagregarlocalidad.Text = "Agregar";
            this.btnagregarlocalidad.UseVisualStyleBackColor = true;
            // 
            // btnmodificarlocalidad
            // 
            this.btnmodificarlocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnmodificarlocalidad.Location = new System.Drawing.Point(84, 3);
            this.btnmodificarlocalidad.Name = "btnmodificarlocalidad";
            this.btnmodificarlocalidad.Size = new System.Drawing.Size(75, 37);
            this.btnmodificarlocalidad.TabIndex = 1;
            this.btnmodificarlocalidad.Text = "Modificar";
            this.btnmodificarlocalidad.UseVisualStyleBackColor = true;
            // 
            // btneliminarlocalidad
            // 
            this.btneliminarlocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btneliminarlocalidad.Location = new System.Drawing.Point(165, 3);
            this.btneliminarlocalidad.Name = "btneliminarlocalidad";
            this.btneliminarlocalidad.Size = new System.Drawing.Size(75, 37);
            this.btneliminarlocalidad.TabIndex = 2;
            this.btneliminarlocalidad.Text = "Eliminar";
            this.btneliminarlocalidad.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtcodigopostal);
            this.panel1.Controls.Add(this.lblcodigopostal);
            this.panel1.Controls.Add(this.txtnombrelocalidad);
            this.panel1.Controls.Add(this.lblnombrelocalidad);
            this.panel1.Location = new System.Drawing.Point(367, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 250);
            this.panel1.TabIndex = 2;
            // 
            // panelbtnaceptar
            // 
            this.panelbtnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbtnaceptar.Controls.Add(this.btnaceptar);
            this.panelbtnaceptar.Location = new System.Drawing.Point(461, 271);
            this.panelbtnaceptar.Name = "panelbtnaceptar";
            this.panelbtnaceptar.Size = new System.Drawing.Size(90, 41);
            this.panelbtnaceptar.TabIndex = 3;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Location = new System.Drawing.Point(19, 4);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(68, 34);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // lblnombrelocalidad
            // 
            this.lblnombrelocalidad.AutoSize = true;
            this.lblnombrelocalidad.Location = new System.Drawing.Point(45, 34);
            this.lblnombrelocalidad.Name = "lblnombrelocalidad";
            this.lblnombrelocalidad.Size = new System.Drawing.Size(93, 13);
            this.lblnombrelocalidad.TabIndex = 0;
            this.lblnombrelocalidad.Text = "Nombre Localidad";
            // 
            // txtnombrelocalidad
            // 
            this.txtnombrelocalidad.Location = new System.Drawing.Point(38, 50);
            this.txtnombrelocalidad.Name = "txtnombrelocalidad";
            this.txtnombrelocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtnombrelocalidad.TabIndex = 1;
            // 
            // txtcodigopostal
            // 
            this.txtcodigopostal.Location = new System.Drawing.Point(38, 117);
            this.txtcodigopostal.Name = "txtcodigopostal";
            this.txtcodigopostal.Size = new System.Drawing.Size(100, 20);
            this.txtcodigopostal.TabIndex = 3;
            // 
            // lblcodigopostal
            // 
            this.lblcodigopostal.AutoSize = true;
            this.lblcodigopostal.Location = new System.Drawing.Point(45, 101);
            this.lblcodigopostal.Name = "lblcodigopostal";
            this.lblcodigopostal.Size = new System.Drawing.Size(72, 13);
            this.lblcodigopostal.TabIndex = 2;
            this.lblcodigopostal.Text = "Codigo Postal";
            // 
            // FormLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.panelbtnaceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.paneldgvlocalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormLocalidades";
            this.Text = "FormLocalidades";
            this.paneldgvlocalidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocalidades)).EndInit();
            this.panelbotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelbtnaceptar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldgvlocalidades;
        private System.Windows.Forms.DataGridView dgvlocalidades;
        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminarlocalidad;
        private System.Windows.Forms.Button btnmodificarlocalidad;
        private System.Windows.Forms.Button btnagregarlocalidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcodigopostal;
        private System.Windows.Forms.Label lblcodigopostal;
        private System.Windows.Forms.TextBox txtnombrelocalidad;
        private System.Windows.Forms.Label lblnombrelocalidad;
        private System.Windows.Forms.Panel panelbtnaceptar;
        private System.Windows.Forms.Button btnaceptar;
    }
}