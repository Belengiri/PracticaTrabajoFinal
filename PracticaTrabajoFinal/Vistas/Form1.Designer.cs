namespace PracticaTrabajoFinal
{
    partial class Laboratorio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnsalirprogram = new System.Windows.Forms.Button();
            this.btnpracticasporespecialidad = new System.Windows.Forms.Button();
            this.btnpersonalporespecialidad = new System.Windows.Forms.Button();
            this.btnpracticas = new System.Windows.Forms.Button();
            this.btnespecialidades = new System.Windows.Forms.Button();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnpersonallaboratorio = new System.Windows.Forms.Button();
            this.btnpersonalmedico = new System.Windows.Forms.Button();
            this.btnlaboratorio = new System.Windows.Forms.Button();
            this.btningresos = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnpaciente = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.btnlocalidades = new System.Windows.Forms.Button();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelmenu.Controls.Add(this.btnlocalidades);
            this.panelmenu.Controls.Add(this.btnsalirprogram);
            this.panelmenu.Controls.Add(this.btnpracticasporespecialidad);
            this.panelmenu.Controls.Add(this.btnpersonalporespecialidad);
            this.panelmenu.Controls.Add(this.btnpracticas);
            this.panelmenu.Controls.Add(this.btnespecialidades);
            this.panelmenu.Controls.Add(this.btncategorias);
            this.panelmenu.Controls.Add(this.btnpersonallaboratorio);
            this.panelmenu.Controls.Add(this.btnpersonalmedico);
            this.panelmenu.Controls.Add(this.btnlaboratorio);
            this.panelmenu.Controls.Add(this.btningresos);
            this.panelmenu.Controls.Add(this.lbltitulo);
            this.panelmenu.Controls.Add(this.btnpaciente);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(181, 417);
            this.panelmenu.TabIndex = 0;
            // 
            // btnsalirprogram
            // 
            this.btnsalirprogram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalirprogram.Location = new System.Drawing.Point(103, 391);
            this.btnsalirprogram.Name = "btnsalirprogram";
            this.btnsalirprogram.Size = new System.Drawing.Size(75, 23);
            this.btnsalirprogram.TabIndex = 34;
            this.btnsalirprogram.Text = "Salir";
            this.btnsalirprogram.UseVisualStyleBackColor = true;
            this.btnsalirprogram.Click += new System.EventHandler(this.btnsalirprogram_Click);
            // 
            // btnpracticasporespecialidad
            // 
            this.btnpracticasporespecialidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpracticasporespecialidad.FlatAppearance.BorderSize = 2;
            this.btnpracticasporespecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpracticasporespecialidad.Location = new System.Drawing.Point(30, 355);
            this.btnpracticasporespecialidad.Name = "btnpracticasporespecialidad";
            this.btnpracticasporespecialidad.Size = new System.Drawing.Size(142, 23);
            this.btnpracticasporespecialidad.TabIndex = 33;
            this.btnpracticasporespecialidad.Text = "Practicas por Especialidad";
            this.btnpracticasporespecialidad.UseVisualStyleBackColor = true;
            this.btnpracticasporespecialidad.Visible = false;
            // 
            // btnpersonalporespecialidad
            // 
            this.btnpersonalporespecialidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpersonalporespecialidad.FlatAppearance.BorderSize = 2;
            this.btnpersonalporespecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpersonalporespecialidad.Location = new System.Drawing.Point(30, 326);
            this.btnpersonalporespecialidad.Name = "btnpersonalporespecialidad";
            this.btnpersonalporespecialidad.Size = new System.Drawing.Size(142, 23);
            this.btnpersonalporespecialidad.TabIndex = 32;
            this.btnpersonalporespecialidad.Text = "Personal por Especialidad";
            this.btnpersonalporespecialidad.UseVisualStyleBackColor = true;
            this.btnpersonalporespecialidad.Visible = false;
            // 
            // btnpracticas
            // 
            this.btnpracticas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpracticas.FlatAppearance.BorderSize = 2;
            this.btnpracticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpracticas.Location = new System.Drawing.Point(52, 297);
            this.btnpracticas.Name = "btnpracticas";
            this.btnpracticas.Size = new System.Drawing.Size(120, 23);
            this.btnpracticas.TabIndex = 31;
            this.btnpracticas.Text = "Practicas";
            this.btnpracticas.UseVisualStyleBackColor = true;
            this.btnpracticas.Visible = false;
            this.btnpracticas.Click += new System.EventHandler(this.btnpracticas_Click);
            // 
            // btnespecialidades
            // 
            this.btnespecialidades.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnespecialidades.FlatAppearance.BorderSize = 2;
            this.btnespecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnespecialidades.Location = new System.Drawing.Point(52, 268);
            this.btnespecialidades.Name = "btnespecialidades";
            this.btnespecialidades.Size = new System.Drawing.Size(120, 23);
            this.btnespecialidades.TabIndex = 30;
            this.btnespecialidades.Text = "Especialidades";
            this.btnespecialidades.UseVisualStyleBackColor = true;
            this.btnespecialidades.Visible = false;
            this.btnespecialidades.Click += new System.EventHandler(this.btnespecialidades_Click);
            // 
            // btncategorias
            // 
            this.btncategorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncategorias.FlatAppearance.BorderSize = 2;
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncategorias.Location = new System.Drawing.Point(52, 239);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(120, 23);
            this.btncategorias.TabIndex = 29;
            this.btncategorias.Text = "Categorias";
            this.btncategorias.UseVisualStyleBackColor = true;
            this.btncategorias.Visible = false;
            // 
            // btnpersonallaboratorio
            // 
            this.btnpersonallaboratorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpersonallaboratorio.FlatAppearance.BorderSize = 2;
            this.btnpersonallaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpersonallaboratorio.Location = new System.Drawing.Point(52, 210);
            this.btnpersonallaboratorio.Name = "btnpersonallaboratorio";
            this.btnpersonallaboratorio.Size = new System.Drawing.Size(120, 23);
            this.btnpersonallaboratorio.TabIndex = 28;
            this.btnpersonallaboratorio.Text = "Personal Laboratorio";
            this.btnpersonallaboratorio.UseVisualStyleBackColor = true;
            this.btnpersonallaboratorio.Visible = false;
            this.btnpersonallaboratorio.Click += new System.EventHandler(this.btnpersonallaboratorio_Click);
            // 
            // btnpersonalmedico
            // 
            this.btnpersonalmedico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpersonalmedico.FlatAppearance.BorderSize = 2;
            this.btnpersonalmedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpersonalmedico.Location = new System.Drawing.Point(52, 181);
            this.btnpersonalmedico.Name = "btnpersonalmedico";
            this.btnpersonalmedico.Size = new System.Drawing.Size(120, 23);
            this.btnpersonalmedico.TabIndex = 27;
            this.btnpersonalmedico.Text = "Personal Medico";
            this.btnpersonalmedico.UseVisualStyleBackColor = true;
            this.btnpersonalmedico.Visible = false;
            this.btnpersonalmedico.Click += new System.EventHandler(this.btnpersonalmedico_Click);
            // 
            // btnlaboratorio
            // 
            this.btnlaboratorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlaboratorio.FlatAppearance.BorderSize = 2;
            this.btnlaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlaboratorio.Location = new System.Drawing.Point(12, 123);
            this.btnlaboratorio.Name = "btnlaboratorio";
            this.btnlaboratorio.Size = new System.Drawing.Size(160, 23);
            this.btnlaboratorio.TabIndex = 25;
            this.btnlaboratorio.Text = "Laboratorio";
            this.btnlaboratorio.UseVisualStyleBackColor = true;
            this.btnlaboratorio.Click += new System.EventHandler(this.btnlaboratorio_Click);
            // 
            // btningresos
            // 
            this.btningresos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btningresos.FlatAppearance.BorderSize = 2;
            this.btningresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btningresos.Location = new System.Drawing.Point(12, 94);
            this.btningresos.Name = "btningresos";
            this.btningresos.Size = new System.Drawing.Size(160, 23);
            this.btningresos.TabIndex = 24;
            this.btningresos.Text = "Ingresos";
            this.btningresos.UseVisualStyleBackColor = true;
            this.btningresos.Click += new System.EventHandler(this.btningresos_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(25, 19);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(149, 31);
            this.lbltitulo.TabIndex = 11;
            this.lbltitulo.Text = "Laboratorio";
            // 
            // btnpaciente
            // 
            this.btnpaciente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpaciente.FlatAppearance.BorderSize = 2;
            this.btnpaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpaciente.Location = new System.Drawing.Point(12, 65);
            this.btnpaciente.Name = "btnpaciente";
            this.btnpaciente.Size = new System.Drawing.Size(160, 23);
            this.btnpaciente.TabIndex = 0;
            this.btnpaciente.Text = "Paciente";
            this.btnpaciente.UseVisualStyleBackColor = true;
            this.btnpaciente.Click += new System.EventHandler(this.btnpaciente_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(181, 0);
            this.panelcontenedor.MinimumSize = new System.Drawing.Size(489, 373);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(581, 417);
            this.panelcontenedor.TabIndex = 3;
            // 
            // btnlocalidades
            // 
            this.btnlocalidades.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlocalidades.FlatAppearance.BorderSize = 2;
            this.btnlocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlocalidades.Location = new System.Drawing.Point(52, 152);
            this.btnlocalidades.Name = "btnlocalidades";
            this.btnlocalidades.Size = new System.Drawing.Size(120, 23);
            this.btnlocalidades.TabIndex = 35;
            this.btnlocalidades.Text = "Localidades";
            this.btnlocalidades.UseVisualStyleBackColor = true;
            this.btnlocalidades.Visible = false;
            // 
            // Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 417);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelmenu);
            this.MinimumSize = new System.Drawing.Size(778, 456);
            this.Name = "Laboratorio";
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnpaciente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnpracticasporespecialidad;
        private System.Windows.Forms.Button btnpersonalporespecialidad;
        private System.Windows.Forms.Button btnpracticas;
        private System.Windows.Forms.Button btnespecialidades;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button btnpersonallaboratorio;
        private System.Windows.Forms.Button btnpersonalmedico;
        private System.Windows.Forms.Button btnlaboratorio;
        private System.Windows.Forms.Button btningresos;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Button btnsalirprogram;
        private System.Windows.Forms.Button btnlocalidades;
    }
}

