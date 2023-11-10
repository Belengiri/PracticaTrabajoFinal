namespace PracticaTrabajoFinal.Vistas
{
    partial class FormEspecialidades
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
            this.paneldgvespecialidades = new System.Windows.Forms.Panel();
            this.dgvespecialidades = new System.Windows.Forms.DataGridView();
            this.txtnombreespecialidad = new System.Windows.Forms.TextBox();
            this.lblnombreespecialidad = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.paneldatosespecialidad = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btneliminarespecialidad = new System.Windows.Forms.Button();
            this.btnmodificarespecialidad = new System.Windows.Forms.Button();
            this.btnagregarespecialidad = new System.Windows.Forms.Button();
            this.paneldgvespecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvespecialidades)).BeginInit();
            this.paneldatosespecialidad.SuspendLayout();
            this.panelbotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldgvespecialidades
            // 
            this.paneldgvespecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvespecialidades.Controls.Add(this.dgvespecialidades);
            this.paneldgvespecialidades.Location = new System.Drawing.Point(12, 12);
            this.paneldgvespecialidades.Name = "paneldgvespecialidades";
            this.paneldgvespecialidades.Size = new System.Drawing.Size(305, 222);
            this.paneldgvespecialidades.TabIndex = 0;
            // 
            // dgvespecialidades
            // 
            this.dgvespecialidades.AllowUserToAddRows = false;
            this.dgvespecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvespecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvespecialidades.Location = new System.Drawing.Point(0, 0);
            this.dgvespecialidades.Name = "dgvespecialidades";
            this.dgvespecialidades.Size = new System.Drawing.Size(305, 222);
            this.dgvespecialidades.TabIndex = 10;
            this.dgvespecialidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvespecialidades_CellClick);
            // 
            // txtnombreespecialidad
            // 
            this.txtnombreespecialidad.Location = new System.Drawing.Point(3, 108);
            this.txtnombreespecialidad.Name = "txtnombreespecialidad";
            this.txtnombreespecialidad.Size = new System.Drawing.Size(193, 20);
            this.txtnombreespecialidad.TabIndex = 4;
            // 
            // lblnombreespecialidad
            // 
            this.lblnombreespecialidad.AutoSize = true;
            this.lblnombreespecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreespecialidad.Location = new System.Drawing.Point(3, 71);
            this.lblnombreespecialidad.MinimumSize = new System.Drawing.Size(133, 13);
            this.lblnombreespecialidad.Name = "lblnombreespecialidad";
            this.lblnombreespecialidad.Size = new System.Drawing.Size(197, 20);
            this.lblnombreespecialidad.TabIndex = 3;
            this.lblnombreespecialidad.Text = "Nombre de la Especialidad";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(88, 373);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(98, 41);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // paneldatosespecialidad
            // 
            this.paneldatosespecialidad.Controls.Add(this.btnsalir);
            this.paneldatosespecialidad.Controls.Add(this.btncancelar);
            this.paneldatosespecialidad.Controls.Add(this.lblnombreespecialidad);
            this.paneldatosespecialidad.Controls.Add(this.txtnombreespecialidad);
            this.paneldatosespecialidad.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatosespecialidad.Location = new System.Drawing.Point(323, 0);
            this.paneldatosespecialidad.Name = "paneldatosespecialidad";
            this.paneldatosespecialidad.Size = new System.Drawing.Size(258, 417);
            this.paneldatosespecialidad.TabIndex = 5;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Location = new System.Drawing.Point(238, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(20, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panelbotones
            // 
            this.panelbotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotones.Controls.Add(this.btneliminarespecialidad);
            this.panelbotones.Controls.Add(this.btnmodificarespecialidad);
            this.panelbotones.Controls.Add(this.btnagregarespecialidad);
            this.panelbotones.Location = new System.Drawing.Point(15, 240);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(294, 66);
            this.panelbotones.TabIndex = 6;
            // 
            // btneliminarespecialidad
            // 
            this.btneliminarespecialidad.Enabled = false;
            this.btneliminarespecialidad.Location = new System.Drawing.Point(191, 0);
            this.btneliminarespecialidad.Name = "btneliminarespecialidad";
            this.btneliminarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btneliminarespecialidad.TabIndex = 2;
            this.btneliminarespecialidad.Text = "Eliminar";
            this.btneliminarespecialidad.UseVisualStyleBackColor = true;
            this.btneliminarespecialidad.Click += new System.EventHandler(this.btneliminarespecialidad_Click);
            // 
            // btnmodificarespecialidad
            // 
            this.btnmodificarespecialidad.Enabled = false;
            this.btnmodificarespecialidad.Location = new System.Drawing.Point(97, 0);
            this.btnmodificarespecialidad.Name = "btnmodificarespecialidad";
            this.btnmodificarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btnmodificarespecialidad.TabIndex = 1;
            this.btnmodificarespecialidad.Text = "Modificar";
            this.btnmodificarespecialidad.UseVisualStyleBackColor = true;
            this.btnmodificarespecialidad.Click += new System.EventHandler(this.btnmodificarespecialidad_Click);
            // 
            // btnagregarespecialidad
            // 
            this.btnagregarespecialidad.Location = new System.Drawing.Point(3, 0);
            this.btnagregarespecialidad.Name = "btnagregarespecialidad";
            this.btnagregarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btnagregarespecialidad.TabIndex = 0;
            this.btnagregarespecialidad.Text = "Agregar";
            this.btnagregarespecialidad.UseVisualStyleBackColor = true;
            this.btnagregarespecialidad.Click += new System.EventHandler(this.btnagregarespecialidad_Click);
            // 
            // FormEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.paneldatosespecialidad);
            this.Controls.Add(this.paneldgvespecialidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 150);
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormEspecialidades";
            this.Text = "FormEspecialidades";
            this.Load += new System.EventHandler(this.FormEspecialidades_Load);
            this.paneldgvespecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvespecialidades)).EndInit();
            this.paneldatosespecialidad.ResumeLayout(false);
            this.paneldatosespecialidad.PerformLayout();
            this.panelbotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldgvespecialidades;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtnombreespecialidad;
        private System.Windows.Forms.Label lblnombreespecialidad;
        private System.Windows.Forms.Panel paneldatosespecialidad;
        private System.Windows.Forms.DataGridView dgvespecialidades;
        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminarespecialidad;
        private System.Windows.Forms.Button btnmodificarespecialidad;
        private System.Windows.Forms.Button btnagregarespecialidad;
        private System.Windows.Forms.Button btnsalir;
    }
}