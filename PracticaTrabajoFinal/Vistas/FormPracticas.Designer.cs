namespace PracticaTrabajoFinal.Vistas
{
    partial class FormPracticas
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
            this.lblnombrepractica = new System.Windows.Forms.Label();
            this.txtnombrepractica = new System.Windows.Forms.TextBox();
            this.lbltiempoderesultado = new System.Windows.Forms.Label();
            this.txttiempoderesultado = new System.Windows.Forms.TextBox();
            this.lblespecialidadpractica = new System.Windows.Forms.Label();
            this.cbespacialidadpractica = new System.Windows.Forms.ComboBox();
            this.lbltipomuestra = new System.Windows.Forms.Label();
            this.cbtipodemuestra = new System.Windows.Forms.ComboBox();
            this.paneldatospracticas = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panelnuevamuestra = new System.Windows.Forms.Panel();
            this.lblnuevamuestra = new System.Windows.Forms.Label();
            this.btncancelarmuestra = new System.Windows.Forms.Button();
            this.btnguardarmuestra = new System.Windows.Forms.Button();
            this.txtnuevamuestra = new System.Windows.Forms.TextBox();
            this.agregarmuestra = new System.Windows.Forms.CheckBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.paneldgvpracticas = new System.Windows.Forms.Panel();
            this.dgvgrillapracticas = new System.Windows.Forms.DataGridView();
            this.btnagregarpractica = new System.Windows.Forms.Button();
            this.btnmodificarpractica = new System.Windows.Forms.Button();
            this.btneliminarpractica = new System.Windows.Forms.Button();
            this.paneldatospracticas.SuspendLayout();
            this.panelnuevamuestra.SuspendLayout();
            this.paneldgvpracticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrillapracticas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombrepractica
            // 
            this.lblnombrepractica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblnombrepractica.AutoSize = true;
            this.lblnombrepractica.Location = new System.Drawing.Point(21, 9);
            this.lblnombrepractica.Name = "lblnombrepractica";
            this.lblnombrepractica.Size = new System.Drawing.Size(112, 13);
            this.lblnombrepractica.TabIndex = 0;
            this.lblnombrepractica.Text = "Nombre de la Practica";
            // 
            // txtnombrepractica
            // 
            this.txtnombrepractica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtnombrepractica.Location = new System.Drawing.Point(24, 34);
            this.txtnombrepractica.Name = "txtnombrepractica";
            this.txtnombrepractica.Size = new System.Drawing.Size(90, 20);
            this.txtnombrepractica.TabIndex = 1;
            this.txtnombrepractica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrepractica_KeyPress);
            // 
            // lbltiempoderesultado
            // 
            this.lbltiempoderesultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltiempoderesultado.AutoSize = true;
            this.lbltiempoderesultado.Location = new System.Drawing.Point(21, 71);
            this.lbltiempoderesultado.Name = "lbltiempoderesultado";
            this.lbltiempoderesultado.Size = new System.Drawing.Size(110, 13);
            this.lbltiempoderesultado.TabIndex = 2;
            this.lbltiempoderesultado.Text = "Demora de Resultado";
            // 
            // txttiempoderesultado
            // 
            this.txttiempoderesultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttiempoderesultado.Location = new System.Drawing.Point(24, 97);
            this.txttiempoderesultado.Name = "txttiempoderesultado";
            this.txttiempoderesultado.Size = new System.Drawing.Size(90, 20);
            this.txttiempoderesultado.TabIndex = 3;
            // 
            // lblespecialidadpractica
            // 
            this.lblespecialidadpractica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblespecialidadpractica.AutoSize = true;
            this.lblespecialidadpractica.Location = new System.Drawing.Point(21, 139);
            this.lblespecialidadpractica.Name = "lblespecialidadpractica";
            this.lblespecialidadpractica.Size = new System.Drawing.Size(134, 13);
            this.lblespecialidadpractica.TabIndex = 4;
            this.lblespecialidadpractica.Text = "Especialidad de la practica";
            // 
            // cbespacialidadpractica
            // 
            this.cbespacialidadpractica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbespacialidadpractica.FormattingEnabled = true;
            this.cbespacialidadpractica.Location = new System.Drawing.Point(24, 168);
            this.cbespacialidadpractica.Name = "cbespacialidadpractica";
            this.cbespacialidadpractica.Size = new System.Drawing.Size(90, 21);
            this.cbespacialidadpractica.TabIndex = 5;
            // 
            // lbltipomuestra
            // 
            this.lbltipomuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltipomuestra.AutoSize = true;
            this.lbltipomuestra.Location = new System.Drawing.Point(21, 206);
            this.lbltipomuestra.Name = "lbltipomuestra";
            this.lbltipomuestra.Size = new System.Drawing.Size(84, 13);
            this.lbltipomuestra.TabIndex = 6;
            this.lbltipomuestra.Text = "Tipo de Muestra";
            // 
            // cbtipodemuestra
            // 
            this.cbtipodemuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbtipodemuestra.FormattingEnabled = true;
            this.cbtipodemuestra.Location = new System.Drawing.Point(24, 233);
            this.cbtipodemuestra.Name = "cbtipodemuestra";
            this.cbtipodemuestra.Size = new System.Drawing.Size(90, 21);
            this.cbtipodemuestra.TabIndex = 7;
            // 
            // paneldatospracticas
            // 
            this.paneldatospracticas.Controls.Add(this.btnsalir);
            this.paneldatospracticas.Controls.Add(this.panelnuevamuestra);
            this.paneldatospracticas.Controls.Add(this.agregarmuestra);
            this.paneldatospracticas.Controls.Add(this.btncancelar);
            this.paneldatospracticas.Controls.Add(this.lblnombrepractica);
            this.paneldatospracticas.Controls.Add(this.cbtipodemuestra);
            this.paneldatospracticas.Controls.Add(this.txtnombrepractica);
            this.paneldatospracticas.Controls.Add(this.lbltipomuestra);
            this.paneldatospracticas.Controls.Add(this.lbltiempoderesultado);
            this.paneldatospracticas.Controls.Add(this.cbespacialidadpractica);
            this.paneldatospracticas.Controls.Add(this.txttiempoderesultado);
            this.paneldatospracticas.Controls.Add(this.lblespecialidadpractica);
            this.paneldatospracticas.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatospracticas.Location = new System.Drawing.Point(340, 0);
            this.paneldatospracticas.Name = "paneldatospracticas";
            this.paneldatospracticas.Size = new System.Drawing.Size(241, 417);
            this.paneldatospracticas.TabIndex = 8;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Location = new System.Drawing.Point(211, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(27, 23);
            this.btnsalir.TabIndex = 34;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panelnuevamuestra
            // 
            this.panelnuevamuestra.Controls.Add(this.lblnuevamuestra);
            this.panelnuevamuestra.Controls.Add(this.btncancelarmuestra);
            this.panelnuevamuestra.Controls.Add(this.btnguardarmuestra);
            this.panelnuevamuestra.Controls.Add(this.txtnuevamuestra);
            this.panelnuevamuestra.Location = new System.Drawing.Point(24, 283);
            this.panelnuevamuestra.Name = "panelnuevamuestra";
            this.panelnuevamuestra.Size = new System.Drawing.Size(200, 100);
            this.panelnuevamuestra.TabIndex = 33;
            this.panelnuevamuestra.Visible = false;
            // 
            // lblnuevamuestra
            // 
            this.lblnuevamuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblnuevamuestra.AutoSize = true;
            this.lblnuevamuestra.Location = new System.Drawing.Point(51, 12);
            this.lblnuevamuestra.Name = "lblnuevamuestra";
            this.lblnuevamuestra.Size = new System.Drawing.Size(80, 13);
            this.lblnuevamuestra.TabIndex = 30;
            this.lblnuevamuestra.Text = "Nueva Muestra";
            this.lblnuevamuestra.Visible = false;
            // 
            // btncancelarmuestra
            // 
            this.btncancelarmuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btncancelarmuestra.Location = new System.Drawing.Point(101, 51);
            this.btncancelarmuestra.Name = "btncancelarmuestra";
            this.btncancelarmuestra.Size = new System.Drawing.Size(58, 23);
            this.btncancelarmuestra.TabIndex = 32;
            this.btncancelarmuestra.Text = "Cancelar";
            this.btncancelarmuestra.UseVisualStyleBackColor = true;
            this.btncancelarmuestra.Visible = false;
            this.btncancelarmuestra.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardarmuestra
            // 
            this.btnguardarmuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnguardarmuestra.Location = new System.Drawing.Point(32, 51);
            this.btnguardarmuestra.Name = "btnguardarmuestra";
            this.btnguardarmuestra.Size = new System.Drawing.Size(58, 23);
            this.btnguardarmuestra.TabIndex = 29;
            this.btnguardarmuestra.Text = "Guardar";
            this.btnguardarmuestra.UseVisualStyleBackColor = true;
            this.btnguardarmuestra.Visible = false;
            this.btnguardarmuestra.Click += new System.EventHandler(this.btnguardarmuestra_Click);
            // 
            // txtnuevamuestra
            // 
            this.txtnuevamuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtnuevamuestra.Location = new System.Drawing.Point(45, 28);
            this.txtnuevamuestra.Name = "txtnuevamuestra";
            this.txtnuevamuestra.Size = new System.Drawing.Size(100, 20);
            this.txtnuevamuestra.TabIndex = 31;
            this.txtnuevamuestra.Visible = false;
            // 
            // agregarmuestra
            // 
            this.agregarmuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.agregarmuestra.AutoSize = true;
            this.agregarmuestra.Location = new System.Drawing.Point(24, 260);
            this.agregarmuestra.Name = "agregarmuestra";
            this.agregarmuestra.Size = new System.Drawing.Size(104, 17);
            this.agregarmuestra.TabIndex = 14;
            this.agregarmuestra.Text = "Agregar Muestra";
            this.agregarmuestra.UseVisualStyleBackColor = true;
            this.agregarmuestra.CheckedChanged += new System.EventHandler(this.agregarmuestra_CheckedChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(85, 391);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // paneldgvpracticas
            // 
            this.paneldgvpracticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvpracticas.Controls.Add(this.dgvgrillapracticas);
            this.paneldgvpracticas.Location = new System.Drawing.Point(12, 12);
            this.paneldgvpracticas.Name = "paneldgvpracticas";
            this.paneldgvpracticas.Size = new System.Drawing.Size(322, 312);
            this.paneldgvpracticas.TabIndex = 9;
            // 
            // dgvgrillapracticas
            // 
            this.dgvgrillapracticas.AllowUserToAddRows = false;
            this.dgvgrillapracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrillapracticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvgrillapracticas.Location = new System.Drawing.Point(0, 0);
            this.dgvgrillapracticas.Name = "dgvgrillapracticas";
            this.dgvgrillapracticas.Size = new System.Drawing.Size(322, 312);
            this.dgvgrillapracticas.TabIndex = 11;
            this.dgvgrillapracticas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgrillapracticas_CellClick);
            // 
            // btnagregarpractica
            // 
            this.btnagregarpractica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnagregarpractica.Location = new System.Drawing.Point(12, 330);
            this.btnagregarpractica.Name = "btnagregarpractica";
            this.btnagregarpractica.Size = new System.Drawing.Size(75, 23);
            this.btnagregarpractica.TabIndex = 10;
            this.btnagregarpractica.Text = "Agregar";
            this.btnagregarpractica.UseVisualStyleBackColor = true;
            this.btnagregarpractica.Click += new System.EventHandler(this.btnagregarpractica_Click);
            // 
            // btnmodificarpractica
            // 
            this.btnmodificarpractica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnmodificarpractica.Enabled = false;
            this.btnmodificarpractica.Location = new System.Drawing.Point(93, 330);
            this.btnmodificarpractica.Name = "btnmodificarpractica";
            this.btnmodificarpractica.Size = new System.Drawing.Size(75, 23);
            this.btnmodificarpractica.TabIndex = 11;
            this.btnmodificarpractica.Text = "Modificar";
            this.btnmodificarpractica.UseVisualStyleBackColor = true;
            this.btnmodificarpractica.Click += new System.EventHandler(this.btnmodificarpractica_Click);
            // 
            // btneliminarpractica
            // 
            this.btneliminarpractica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btneliminarpractica.Enabled = false;
            this.btneliminarpractica.Location = new System.Drawing.Point(174, 330);
            this.btneliminarpractica.Name = "btneliminarpractica";
            this.btneliminarpractica.Size = new System.Drawing.Size(75, 23);
            this.btneliminarpractica.TabIndex = 13;
            this.btneliminarpractica.Text = "Eliminar";
            this.btneliminarpractica.UseVisualStyleBackColor = true;
            this.btneliminarpractica.Click += new System.EventHandler(this.btneliminarpractica_Click);
            // 
            // FormPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.btneliminarpractica);
            this.Controls.Add(this.btnmodificarpractica);
            this.Controls.Add(this.btnagregarpractica);
            this.Controls.Add(this.paneldgvpracticas);
            this.Controls.Add(this.paneldatospracticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 150);
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormPracticas";
            this.Text = "FormPracticas";
            this.Load += new System.EventHandler(this.FormPracticas_Load);
            this.paneldatospracticas.ResumeLayout(false);
            this.paneldatospracticas.PerformLayout();
            this.panelnuevamuestra.ResumeLayout(false);
            this.panelnuevamuestra.PerformLayout();
            this.paneldgvpracticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrillapracticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnombrepractica;
        private System.Windows.Forms.TextBox txtnombrepractica;
        private System.Windows.Forms.Label lbltiempoderesultado;
        private System.Windows.Forms.TextBox txttiempoderesultado;
        private System.Windows.Forms.Label lblespecialidadpractica;
        private System.Windows.Forms.ComboBox cbespacialidadpractica;
        private System.Windows.Forms.Label lbltipomuestra;
        private System.Windows.Forms.ComboBox cbtipodemuestra;
        private System.Windows.Forms.Panel paneldatospracticas;
        private System.Windows.Forms.Panel paneldgvpracticas;
        private System.Windows.Forms.Button btnagregarpractica;
        private System.Windows.Forms.Button btnmodificarpractica;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminarpractica;
        private System.Windows.Forms.CheckBox agregarmuestra;
        private System.Windows.Forms.Button btnguardarmuestra;
        private System.Windows.Forms.TextBox txtnuevamuestra;
        private System.Windows.Forms.Label lblnuevamuestra;
        private System.Windows.Forms.Button btncancelarmuestra;
        private System.Windows.Forms.DataGridView dgvgrillapracticas;
        private System.Windows.Forms.Panel panelnuevamuestra;
        private System.Windows.Forms.Button btnsalir;
    }
}