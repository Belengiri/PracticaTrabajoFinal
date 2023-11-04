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
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btneliminarlocalidad = new System.Windows.Forms.Button();
            this.btnmodificarlocalidad = new System.Windows.Forms.Button();
            this.btnagregarlocalidad = new System.Windows.Forms.Button();
            this.paneldatoslocalidades = new System.Windows.Forms.Panel();
            this.llblcodigopostal = new System.Windows.Forms.Label();
            this.txtcodigopostal = new System.Windows.Forms.TextBox();
            this.btnaceptarlocalidad = new System.Windows.Forms.Button();
            this.lblnombrelocalidad = new System.Windows.Forms.Label();
            this.txtnombrelocalidad = new System.Windows.Forms.TextBox();
            this.paneldgvlocalidades = new System.Windows.Forms.Panel();
            this.dgvlocalidades = new System.Windows.Forms.DataGridView();
            this.panelbotones.SuspendLayout();
            this.paneldatoslocalidades.SuspendLayout();
            this.paneldgvlocalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbotones
            // 
            this.panelbotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotones.Controls.Add(this.btneliminarlocalidad);
            this.panelbotones.Controls.Add(this.btnmodificarlocalidad);
            this.panelbotones.Controls.Add(this.btnagregarlocalidad);
            this.panelbotones.Location = new System.Drawing.Point(9, 240);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(294, 66);
            this.panelbotones.TabIndex = 9;
            // 
            // btneliminarlocalidad
            // 
            this.btneliminarlocalidad.Location = new System.Drawing.Point(191, 0);
            this.btneliminarlocalidad.Name = "btneliminarlocalidad";
            this.btneliminarlocalidad.Size = new System.Drawing.Size(88, 34);
            this.btneliminarlocalidad.TabIndex = 2;
            this.btneliminarlocalidad.Text = "Eliminar";
            this.btneliminarlocalidad.UseVisualStyleBackColor = true;
            this.btneliminarlocalidad.Click += new System.EventHandler(this.btneliminarlocalidad_Click);
            // 
            // btnmodificarlocalidad
            // 
            this.btnmodificarlocalidad.Location = new System.Drawing.Point(97, 0);
            this.btnmodificarlocalidad.Name = "btnmodificarlocalidad";
            this.btnmodificarlocalidad.Size = new System.Drawing.Size(88, 34);
            this.btnmodificarlocalidad.TabIndex = 1;
            this.btnmodificarlocalidad.Text = "Modificar";
            this.btnmodificarlocalidad.UseVisualStyleBackColor = true;
            this.btnmodificarlocalidad.Click += new System.EventHandler(this.btnmodificarlocalidad_Click);
            // 
            // btnagregarlocalidad
            // 
            this.btnagregarlocalidad.Location = new System.Drawing.Point(3, 0);
            this.btnagregarlocalidad.Name = "btnagregarlocalidad";
            this.btnagregarlocalidad.Size = new System.Drawing.Size(88, 34);
            this.btnagregarlocalidad.TabIndex = 0;
            this.btnagregarlocalidad.Text = "Agregar";
            this.btnagregarlocalidad.UseVisualStyleBackColor = true;
            this.btnagregarlocalidad.Click += new System.EventHandler(this.btnagregarlocalidad_Click);
            // 
            // paneldatoslocalidades
            // 
            this.paneldatoslocalidades.Controls.Add(this.llblcodigopostal);
            this.paneldatoslocalidades.Controls.Add(this.txtcodigopostal);
            this.paneldatoslocalidades.Controls.Add(this.btnaceptarlocalidad);
            this.paneldatoslocalidades.Controls.Add(this.lblnombrelocalidad);
            this.paneldatoslocalidades.Controls.Add(this.txtnombrelocalidad);
            this.paneldatoslocalidades.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatoslocalidades.Location = new System.Drawing.Point(323, 0);
            this.paneldatoslocalidades.Name = "paneldatoslocalidades";
            this.paneldatoslocalidades.Size = new System.Drawing.Size(258, 417);
            this.paneldatoslocalidades.TabIndex = 8;
            this.paneldatoslocalidades.Visible = false;
            // 
            // llblcodigopostal
            // 
            this.llblcodigopostal.AutoSize = true;
            this.llblcodigopostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblcodigopostal.Location = new System.Drawing.Point(10, 113);
            this.llblcodigopostal.MinimumSize = new System.Drawing.Size(133, 13);
            this.llblcodigopostal.Name = "llblcodigopostal";
            this.llblcodigopostal.Size = new System.Drawing.Size(133, 20);
            this.llblcodigopostal.TabIndex = 6;
            this.llblcodigopostal.Text = "Codigo Postal";
            // 
            // txtcodigopostal
            // 
            this.txtcodigopostal.Location = new System.Drawing.Point(10, 150);
            this.txtcodigopostal.Name = "txtcodigopostal";
            this.txtcodigopostal.Size = new System.Drawing.Size(193, 20);
            this.txtcodigopostal.TabIndex = 7;
            // 
            // btnaceptarlocalidad
            // 
            this.btnaceptarlocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptarlocalidad.Location = new System.Drawing.Point(88, 373);
            this.btnaceptarlocalidad.Name = "btnaceptarlocalidad";
            this.btnaceptarlocalidad.Size = new System.Drawing.Size(98, 41);
            this.btnaceptarlocalidad.TabIndex = 5;
            this.btnaceptarlocalidad.Text = "Aceptar";
            this.btnaceptarlocalidad.UseVisualStyleBackColor = true;
            this.btnaceptarlocalidad.Click += new System.EventHandler(this.btnaceptarlocalidad_Click);
            // 
            // lblnombrelocalidad
            // 
            this.lblnombrelocalidad.AutoSize = true;
            this.lblnombrelocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrelocalidad.Location = new System.Drawing.Point(3, 21);
            this.lblnombrelocalidad.MinimumSize = new System.Drawing.Size(133, 13);
            this.lblnombrelocalidad.Name = "lblnombrelocalidad";
            this.lblnombrelocalidad.Size = new System.Drawing.Size(175, 20);
            this.lblnombrelocalidad.TabIndex = 3;
            this.lblnombrelocalidad.Text = "Nombre de la Localidad";
            // 
            // txtnombrelocalidad
            // 
            this.txtnombrelocalidad.Location = new System.Drawing.Point(3, 58);
            this.txtnombrelocalidad.Name = "txtnombrelocalidad";
            this.txtnombrelocalidad.Size = new System.Drawing.Size(193, 20);
            this.txtnombrelocalidad.TabIndex = 4;
            // 
            // paneldgvlocalidades
            // 
            this.paneldgvlocalidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvlocalidades.Controls.Add(this.dgvlocalidades);
            this.paneldgvlocalidades.Location = new System.Drawing.Point(6, 12);
            this.paneldgvlocalidades.Name = "paneldgvlocalidades";
            this.paneldgvlocalidades.Size = new System.Drawing.Size(305, 222);
            this.paneldgvlocalidades.TabIndex = 7;
            // 
            // dgvlocalidades
            // 
            this.dgvlocalidades.AllowUserToAddRows = false;
            this.dgvlocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlocalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvlocalidades.Location = new System.Drawing.Point(0, 0);
            this.dgvlocalidades.Name = "dgvlocalidades";
            this.dgvlocalidades.Size = new System.Drawing.Size(305, 222);
            this.dgvlocalidades.TabIndex = 11;
            this.dgvlocalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlocalidades_CellClick);
            // 
            // FormLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.paneldatoslocalidades);
            this.Controls.Add(this.paneldgvlocalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormLocalidades";
            this.Text = "FormLocalidades";
            this.panelbotones.ResumeLayout(false);
            this.paneldatoslocalidades.ResumeLayout(false);
            this.paneldatoslocalidades.PerformLayout();
            this.paneldgvlocalidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminarlocalidad;
        private System.Windows.Forms.Button btnmodificarlocalidad;
        private System.Windows.Forms.Button btnagregarlocalidad;
        private System.Windows.Forms.Panel paneldatoslocalidades;
        private System.Windows.Forms.Button btnaceptarlocalidad;
        private System.Windows.Forms.Label lblnombrelocalidad;
        private System.Windows.Forms.TextBox txtnombrelocalidad;
        private System.Windows.Forms.Panel paneldgvlocalidades;
        private System.Windows.Forms.DataGridView dgvlocalidades;
        private System.Windows.Forms.Label llblcodigopostal;
        private System.Windows.Forms.TextBox txtcodigopostal;
    }
}