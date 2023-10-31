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
            this.txtnombreespecialidad = new System.Windows.Forms.TextBox();
            this.lblnombreespecialidad = new System.Windows.Forms.Label();
            this.btnaceptarespecialidad = new System.Windows.Forms.Button();
            this.paneldatosespecialidad = new System.Windows.Forms.Panel();
            this.dgvespecialidades = new System.Windows.Forms.DataGridView();
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btnagregarespecialidad = new System.Windows.Forms.Button();
            this.btnmodificarespecialidad = new System.Windows.Forms.Button();
            this.btneliminarespecialidad = new System.Windows.Forms.Button();
            this.paneldgvespecialidades.SuspendLayout();
            this.paneldatosespecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvespecialidades)).BeginInit();
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
            // txtnombreespecialidad
            // 
            this.txtnombreespecialidad.Location = new System.Drawing.Point(3, 58);
            this.txtnombreespecialidad.Name = "txtnombreespecialidad";
            this.txtnombreespecialidad.Size = new System.Drawing.Size(193, 20);
            this.txtnombreespecialidad.TabIndex = 4;
            // 
            // lblnombreespecialidad
            // 
            this.lblnombreespecialidad.AutoSize = true;
            this.lblnombreespecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreespecialidad.Location = new System.Drawing.Point(3, 21);
            this.lblnombreespecialidad.MinimumSize = new System.Drawing.Size(133, 13);
            this.lblnombreespecialidad.Name = "lblnombreespecialidad";
            this.lblnombreespecialidad.Size = new System.Drawing.Size(197, 20);
            this.lblnombreespecialidad.TabIndex = 3;
            this.lblnombreespecialidad.Text = "Nombre de la Especialidad";
            // 
            // btnaceptarespecialidad
            // 
            this.btnaceptarespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptarespecialidad.Location = new System.Drawing.Point(88, 373);
            this.btnaceptarespecialidad.Name = "btnaceptarespecialidad";
            this.btnaceptarespecialidad.Size = new System.Drawing.Size(98, 41);
            this.btnaceptarespecialidad.TabIndex = 5;
            this.btnaceptarespecialidad.Text = "Aceptar";
            this.btnaceptarespecialidad.UseVisualStyleBackColor = true;
            this.btnaceptarespecialidad.Click += new System.EventHandler(this.btnaceptarespecialidad_Click);
            // 
            // paneldatosespecialidad
            // 
            this.paneldatosespecialidad.Controls.Add(this.btnaceptarespecialidad);
            this.paneldatosespecialidad.Controls.Add(this.lblnombreespecialidad);
            this.paneldatosespecialidad.Controls.Add(this.txtnombreespecialidad);
            this.paneldatosespecialidad.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatosespecialidad.Location = new System.Drawing.Point(323, 0);
            this.paneldatosespecialidad.Name = "paneldatosespecialidad";
            this.paneldatosespecialidad.Size = new System.Drawing.Size(258, 417);
            this.paneldatosespecialidad.TabIndex = 5;
            this.paneldatosespecialidad.Visible = false;
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
            // btnmodificarespecialidad
            // 
            this.btnmodificarespecialidad.Location = new System.Drawing.Point(97, 0);
            this.btnmodificarespecialidad.Name = "btnmodificarespecialidad";
            this.btnmodificarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btnmodificarespecialidad.TabIndex = 1;
            this.btnmodificarespecialidad.Text = "Modificar";
            this.btnmodificarespecialidad.UseVisualStyleBackColor = true;
            this.btnmodificarespecialidad.Click += new System.EventHandler(this.btnmodificarespecialidad_Click);
            // 
            // btneliminarespecialidad
            // 
            this.btneliminarespecialidad.Location = new System.Drawing.Point(191, 0);
            this.btneliminarespecialidad.Name = "btneliminarespecialidad";
            this.btneliminarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btneliminarespecialidad.TabIndex = 2;
            this.btneliminarespecialidad.Text = "Eliminar";
            this.btneliminarespecialidad.UseVisualStyleBackColor = true;
            this.btneliminarespecialidad.Click += new System.EventHandler(this.btneliminarespecialidad_Click);
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
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormEspecialidades";
            this.Text = "FormEspecialidades";
            this.Load += new System.EventHandler(this.FormEspecialidades_Load);
            this.paneldgvespecialidades.ResumeLayout(false);
            this.paneldatosespecialidad.ResumeLayout(false);
            this.paneldatosespecialidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvespecialidades)).EndInit();
            this.panelbotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldgvespecialidades;
        private System.Windows.Forms.Button btnaceptarespecialidad;
        private System.Windows.Forms.TextBox txtnombreespecialidad;
        private System.Windows.Forms.Label lblnombreespecialidad;
        private System.Windows.Forms.Panel paneldatosespecialidad;
        private System.Windows.Forms.DataGridView dgvespecialidades;
        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminarespecialidad;
        private System.Windows.Forms.Button btnmodificarespecialidad;
        private System.Windows.Forms.Button btnagregarespecialidad;
    }
}