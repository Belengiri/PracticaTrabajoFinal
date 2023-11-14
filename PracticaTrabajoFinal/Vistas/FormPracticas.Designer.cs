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
            this.paneldgvmuestras = new System.Windows.Forms.Panel();
            this.dgvmuestra = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panelnuevamuestra = new System.Windows.Forms.Panel();
            this.btneliminarmuestra = new System.Windows.Forms.Button();
            this.txtnuevamuestra = new System.Windows.Forms.TextBox();
            this.btnguardarmuestra = new System.Windows.Forms.Button();
            this.btnmodificarmuestra = new System.Windows.Forms.Button();
            this.btncancelarmuestra = new System.Windows.Forms.Button();
            this.lblnuevamuestra = new System.Windows.Forms.Label();
            this.agregarmuestra = new System.Windows.Forms.CheckBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.paneldgvpracticas = new System.Windows.Forms.Panel();
            this.dgvgrillapracticas = new System.Windows.Forms.DataGridView();
            this.btnagregarpractica = new System.Windows.Forms.Button();
            this.btnmodificarpractica = new System.Windows.Forms.Button();
            this.btneliminarpractica = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.paneldatospracticas.SuspendLayout();
            this.paneldgvmuestras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmuestra)).BeginInit();
            this.panelnuevamuestra.SuspendLayout();
            this.paneldgvpracticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrillapracticas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombrepractica
            // 
            this.lblnombrepractica.AutoSize = true;
            this.lblnombrepractica.Location = new System.Drawing.Point(3, 4);
            this.lblnombrepractica.Name = "lblnombrepractica";
            this.lblnombrepractica.Size = new System.Drawing.Size(112, 13);
            this.lblnombrepractica.TabIndex = 0;
            this.lblnombrepractica.Text = "Nombre de la Practica";
            // 
            // txtnombrepractica
            // 
            this.txtnombrepractica.Location = new System.Drawing.Point(6, 20);
            this.txtnombrepractica.Name = "txtnombrepractica";
            this.txtnombrepractica.Size = new System.Drawing.Size(90, 20);
            this.txtnombrepractica.TabIndex = 1;
            this.txtnombrepractica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrepractica_KeyPress);
            // 
            // lbltiempoderesultado
            // 
            this.lbltiempoderesultado.AutoSize = true;
            this.lbltiempoderesultado.Location = new System.Drawing.Point(5, 45);
            this.lbltiempoderesultado.Name = "lbltiempoderesultado";
            this.lbltiempoderesultado.Size = new System.Drawing.Size(110, 13);
            this.lbltiempoderesultado.TabIndex = 2;
            this.lbltiempoderesultado.Text = "Demora de Resultado";
            // 
            // txttiempoderesultado
            // 
            this.txttiempoderesultado.Location = new System.Drawing.Point(8, 61);
            this.txttiempoderesultado.Name = "txttiempoderesultado";
            this.txttiempoderesultado.Size = new System.Drawing.Size(90, 20);
            this.txttiempoderesultado.TabIndex = 3;
            // 
            // lblespecialidadpractica
            // 
            this.lblespecialidadpractica.AutoSize = true;
            this.lblespecialidadpractica.Location = new System.Drawing.Point(5, 84);
            this.lblespecialidadpractica.Name = "lblespecialidadpractica";
            this.lblespecialidadpractica.Size = new System.Drawing.Size(134, 13);
            this.lblespecialidadpractica.TabIndex = 4;
            this.lblespecialidadpractica.Text = "Especialidad de la practica";
            // 
            // cbespacialidadpractica
            // 
            this.cbespacialidadpractica.FormattingEnabled = true;
            this.cbespacialidadpractica.Location = new System.Drawing.Point(6, 100);
            this.cbespacialidadpractica.Name = "cbespacialidadpractica";
            this.cbespacialidadpractica.Size = new System.Drawing.Size(90, 21);
            this.cbespacialidadpractica.TabIndex = 5;
            // 
            // lbltipomuestra
            // 
            this.lbltipomuestra.AutoSize = true;
            this.lbltipomuestra.Location = new System.Drawing.Point(3, 124);
            this.lbltipomuestra.Name = "lbltipomuestra";
            this.lbltipomuestra.Size = new System.Drawing.Size(84, 13);
            this.lbltipomuestra.TabIndex = 6;
            this.lbltipomuestra.Text = "Tipo de Muestra";
            // 
            // cbtipodemuestra
            // 
            this.cbtipodemuestra.FormattingEnabled = true;
            this.cbtipodemuestra.Location = new System.Drawing.Point(6, 140);
            this.cbtipodemuestra.Name = "cbtipodemuestra";
            this.cbtipodemuestra.Size = new System.Drawing.Size(90, 21);
            this.cbtipodemuestra.TabIndex = 7;
            // 
            // paneldatospracticas
            // 
            this.paneldatospracticas.Controls.Add(this.paneldgvmuestras);
            this.paneldatospracticas.Controls.Add(this.btnsalir);
            this.paneldatospracticas.Controls.Add(this.panelnuevamuestra);
            this.paneldatospracticas.Controls.Add(this.agregarmuestra);
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
            // paneldgvmuestras
            // 
            this.paneldgvmuestras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvmuestras.Controls.Add(this.dgvmuestra);
            this.paneldgvmuestras.Location = new System.Drawing.Point(8, 198);
            this.paneldgvmuestras.Name = "paneldgvmuestras";
            this.paneldgvmuestras.Size = new System.Drawing.Size(221, 100);
            this.paneldgvmuestras.TabIndex = 35;
            this.paneldgvmuestras.Visible = false;
            // 
            // dgvmuestra
            // 
            this.dgvmuestra.AllowUserToAddRows = false;
            this.dgvmuestra.AllowUserToDeleteRows = false;
            this.dgvmuestra.AllowUserToResizeColumns = false;
            this.dgvmuestra.AllowUserToResizeRows = false;
            this.dgvmuestra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvmuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmuestra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmuestra.Location = new System.Drawing.Point(0, 0);
            this.dgvmuestra.Name = "dgvmuestra";
            this.dgvmuestra.Size = new System.Drawing.Size(221, 100);
            this.dgvmuestra.TabIndex = 0;
            this.dgvmuestra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmuestra_CellClick);
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
            this.panelnuevamuestra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelnuevamuestra.Controls.Add(this.btneliminarmuestra);
            this.panelnuevamuestra.Controls.Add(this.txtnuevamuestra);
            this.panelnuevamuestra.Controls.Add(this.btnguardarmuestra);
            this.panelnuevamuestra.Controls.Add(this.btnmodificarmuestra);
            this.panelnuevamuestra.Controls.Add(this.btncancelarmuestra);
            this.panelnuevamuestra.Controls.Add(this.lblnuevamuestra);
            this.panelnuevamuestra.Location = new System.Drawing.Point(8, 304);
            this.panelnuevamuestra.Name = "panelnuevamuestra";
            this.panelnuevamuestra.Size = new System.Drawing.Size(221, 101);
            this.panelnuevamuestra.TabIndex = 33;
            this.panelnuevamuestra.Visible = false;
            // 
            // btneliminarmuestra
            // 
            this.btneliminarmuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btneliminarmuestra.Location = new System.Drawing.Point(114, 66);
            this.btneliminarmuestra.Name = "btneliminarmuestra";
            this.btneliminarmuestra.Size = new System.Drawing.Size(71, 28);
            this.btneliminarmuestra.TabIndex = 34;
            this.btneliminarmuestra.Text = "Eliminar";
            this.btneliminarmuestra.UseVisualStyleBackColor = true;
            this.btneliminarmuestra.Click += new System.EventHandler(this.btneliminarmuestra_Click);
            // 
            // txtnuevamuestra
            // 
            this.txtnuevamuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtnuevamuestra.Location = new System.Drawing.Point(101, 3);
            this.txtnuevamuestra.Name = "txtnuevamuestra";
            this.txtnuevamuestra.Size = new System.Drawing.Size(84, 20);
            this.txtnuevamuestra.TabIndex = 31;
            // 
            // btnguardarmuestra
            // 
            this.btnguardarmuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnguardarmuestra.Location = new System.Drawing.Point(37, 33);
            this.btnguardarmuestra.Name = "btnguardarmuestra";
            this.btnguardarmuestra.Size = new System.Drawing.Size(71, 28);
            this.btnguardarmuestra.TabIndex = 29;
            this.btnguardarmuestra.Text = "Agregar";
            this.btnguardarmuestra.UseVisualStyleBackColor = true;
            this.btnguardarmuestra.Click += new System.EventHandler(this.btnguardarmuestra_Click);
            // 
            // btnmodificarmuestra
            // 
            this.btnmodificarmuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnmodificarmuestra.Location = new System.Drawing.Point(114, 33);
            this.btnmodificarmuestra.Name = "btnmodificarmuestra";
            this.btnmodificarmuestra.Size = new System.Drawing.Size(71, 28);
            this.btnmodificarmuestra.TabIndex = 33;
            this.btnmodificarmuestra.Text = "Modificar";
            this.btnmodificarmuestra.UseVisualStyleBackColor = true;
            this.btnmodificarmuestra.Click += new System.EventHandler(this.btnmodificarmuestra_Click);
            // 
            // btncancelarmuestra
            // 
            this.btncancelarmuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btncancelarmuestra.Location = new System.Drawing.Point(37, 67);
            this.btncancelarmuestra.Name = "btncancelarmuestra";
            this.btncancelarmuestra.Size = new System.Drawing.Size(71, 28);
            this.btncancelarmuestra.TabIndex = 32;
            this.btncancelarmuestra.Text = "Cancelar";
            this.btncancelarmuestra.UseVisualStyleBackColor = true;
            this.btncancelarmuestra.Click += new System.EventHandler(this.btncancelarmuestra_Click);
            // 
            // lblnuevamuestra
            // 
            this.lblnuevamuestra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblnuevamuestra.AutoSize = true;
            this.lblnuevamuestra.Location = new System.Drawing.Point(34, 10);
            this.lblnuevamuestra.Name = "lblnuevamuestra";
            this.lblnuevamuestra.Size = new System.Drawing.Size(48, 13);
            this.lblnuevamuestra.TabIndex = 30;
            this.lblnuevamuestra.Text = " Muestra";
            // 
            // agregarmuestra
            // 
            this.agregarmuestra.AutoSize = true;
            this.agregarmuestra.Location = new System.Drawing.Point(8, 167);
            this.agregarmuestra.Name = "agregarmuestra";
            this.agregarmuestra.Size = new System.Drawing.Size(104, 17);
            this.agregarmuestra.TabIndex = 14;
            this.agregarmuestra.Text = "Agregar Muestra";
            this.agregarmuestra.UseVisualStyleBackColor = true;
            this.agregarmuestra.CheckedChanged += new System.EventHandler(this.agregarmuestra_CheckedChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(260, 390);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 27);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // paneldgvpracticas
            // 
            this.paneldgvpracticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvpracticas.Controls.Add(this.dgvgrillapracticas);
            this.paneldgvpracticas.Location = new System.Drawing.Point(12, 45);
            this.paneldgvpracticas.Name = "paneldgvpracticas";
            this.paneldgvpracticas.Size = new System.Drawing.Size(322, 312);
            this.paneldgvpracticas.TabIndex = 9;
            // 
            // dgvgrillapracticas
            // 
            this.dgvgrillapracticas.AllowUserToAddRows = false;
            this.dgvgrillapracticas.AllowUserToDeleteRows = false;
            this.dgvgrillapracticas.AllowUserToResizeColumns = false;
            this.dgvgrillapracticas.AllowUserToResizeRows = false;
            this.dgvgrillapracticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgrillapracticas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvgrillapracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrillapracticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvgrillapracticas.Location = new System.Drawing.Point(0, 0);
            this.dgvgrillapracticas.Name = "dgvgrillapracticas";
            this.dgvgrillapracticas.Size = new System.Drawing.Size(322, 312);
            this.dgvgrillapracticas.TabIndex = 12;
            this.dgvgrillapracticas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgrillapracticas_CellClick_1);
            // 
            // btnagregarpractica
            // 
            this.btnagregarpractica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnagregarpractica.Location = new System.Drawing.Point(12, 360);
            this.btnagregarpractica.Name = "btnagregarpractica";
            this.btnagregarpractica.Size = new System.Drawing.Size(80, 34);
            this.btnagregarpractica.TabIndex = 10;
            this.btnagregarpractica.Text = "Agregar";
            this.btnagregarpractica.UseVisualStyleBackColor = true;
            this.btnagregarpractica.Click += new System.EventHandler(this.btnagregarpractica_Click);
            // 
            // btnmodificarpractica
            // 
            this.btnmodificarpractica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnmodificarpractica.Enabled = false;
            this.btnmodificarpractica.Location = new System.Drawing.Point(93, 360);
            this.btnmodificarpractica.Name = "btnmodificarpractica";
            this.btnmodificarpractica.Size = new System.Drawing.Size(80, 34);
            this.btnmodificarpractica.TabIndex = 11;
            this.btnmodificarpractica.Text = "Modificar";
            this.btnmodificarpractica.UseVisualStyleBackColor = true;
            this.btnmodificarpractica.Click += new System.EventHandler(this.btnmodificarpractica_Click);
            // 
            // btneliminarpractica
            // 
            this.btneliminarpractica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btneliminarpractica.Enabled = false;
            this.btneliminarpractica.Location = new System.Drawing.Point(174, 360);
            this.btneliminarpractica.Name = "btneliminarpractica";
            this.btneliminarpractica.Size = new System.Drawing.Size(80, 34);
            this.btneliminarpractica.TabIndex = 13;
            this.btneliminarpractica.Text = "Eliminar";
            this.btneliminarpractica.UseVisualStyleBackColor = true;
            this.btneliminarpractica.Click += new System.EventHandler(this.btneliminarpractica_Click);
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(111, 22);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(105, 20);
            this.nombre.TabIndex = 14;
            this.nombre.Text = "Practicas";
            // 
            // FormPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btneliminarpractica);
            this.Controls.Add(this.btnmodificarpractica);
            this.Controls.Add(this.btncancelar);
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
            this.paneldgvmuestras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmuestra)).EndInit();
            this.panelnuevamuestra.ResumeLayout(false);
            this.panelnuevamuestra.PerformLayout();
            this.paneldgvpracticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrillapracticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panelnuevamuestra;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvgrillapracticas;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Panel paneldgvmuestras;
        private System.Windows.Forms.Button btneliminarmuestra;
        private System.Windows.Forms.Button btnmodificarmuestra;
        private System.Windows.Forms.DataGridView dgvmuestra;
    }
}