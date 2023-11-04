namespace PracticaTrabajoFinal.Vistas
{
    partial class FormIngresos
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
            this.paneldatosingresos = new System.Windows.Forms.Panel();
            this.btnagregarpaciente = new System.Windows.Forms.Button();
            this.lblpaciente = new System.Windows.Forms.Label();
            this.btnagregarmedico = new System.Windows.Forms.Button();
            this.lblagregarnuevomedico = new System.Windows.Forms.Label();
            this.lblmedicosolicitante = new System.Windows.Forms.Label();
            this.cbmedicos = new System.Windows.Forms.ComboBox();
            this.lblespecialidades = new System.Windows.Forms.Label();
            this.checklistespecialidades = new System.Windows.Forms.CheckedListBox();
            this.dtfecharetiro = new System.Windows.Forms.DateTimePicker();
            this.labelretiroingresos = new System.Windows.Forms.Label();
            this.dtfechaingreso = new System.Windows.Forms.DateTimePicker();
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btneliminarespecialidad = new System.Windows.Forms.Button();
            this.btnmodificarespecialidad = new System.Windows.Forms.Button();
            this.btnagregarespecialidad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvingresos = new System.Windows.Forms.DataGridView();
            this.panelaceptar = new System.Windows.Forms.Panel();
            this.lblagregarnuevopaciente = new System.Windows.Forms.Label();
            this.labelfechaingresos = new System.Windows.Forms.Label();
            this.cbpacienteapellido = new System.Windows.Forms.ComboBox();
            this.paneldatosingresos.SuspendLayout();
            this.panelbotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvingresos)).BeginInit();
            this.panelaceptar.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldatosingresos
            // 
            this.paneldatosingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldatosingresos.Controls.Add(this.cbpacienteapellido);
            this.paneldatosingresos.Controls.Add(this.labelfechaingresos);
            this.paneldatosingresos.Controls.Add(this.lblagregarnuevopaciente);
            this.paneldatosingresos.Controls.Add(this.btnagregarpaciente);
            this.paneldatosingresos.Controls.Add(this.lblpaciente);
            this.paneldatosingresos.Controls.Add(this.btnagregarmedico);
            this.paneldatosingresos.Controls.Add(this.lblagregarnuevomedico);
            this.paneldatosingresos.Controls.Add(this.lblmedicosolicitante);
            this.paneldatosingresos.Controls.Add(this.cbmedicos);
            this.paneldatosingresos.Controls.Add(this.lblespecialidades);
            this.paneldatosingresos.Controls.Add(this.checklistespecialidades);
            this.paneldatosingresos.Controls.Add(this.dtfecharetiro);
            this.paneldatosingresos.Controls.Add(this.labelretiroingresos);
            this.paneldatosingresos.Controls.Add(this.dtfechaingreso);
            this.paneldatosingresos.Location = new System.Drawing.Point(373, 8);
            this.paneldatosingresos.Margin = new System.Windows.Forms.Padding(2);
            this.paneldatosingresos.Name = "paneldatosingresos";
            this.paneldatosingresos.Size = new System.Drawing.Size(209, 406);
            this.paneldatosingresos.TabIndex = 0;
            // 
            // btnagregarpaciente
            // 
            this.btnagregarpaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarpaciente.Location = new System.Drawing.Point(182, 60);
            this.btnagregarpaciente.Name = "btnagregarpaciente";
            this.btnagregarpaciente.Size = new System.Drawing.Size(24, 23);
            this.btnagregarpaciente.TabIndex = 16;
            this.btnagregarpaciente.Text = "+";
            this.btnagregarpaciente.UseVisualStyleBackColor = true;
            // 
            // lblpaciente
            // 
            this.lblpaciente.AutoSize = true;
            this.lblpaciente.Location = new System.Drawing.Point(5, 11);
            this.lblpaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpaciente.Name = "lblpaciente";
            this.lblpaciente.Size = new System.Drawing.Size(49, 13);
            this.lblpaciente.TabIndex = 14;
            this.lblpaciente.Text = "Paciente";
            // 
            // btnagregarmedico
            // 
            this.btnagregarmedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarmedico.Location = new System.Drawing.Point(178, 158);
            this.btnagregarmedico.Name = "btnagregarmedico";
            this.btnagregarmedico.Size = new System.Drawing.Size(24, 23);
            this.btnagregarmedico.TabIndex = 12;
            this.btnagregarmedico.Text = "+";
            this.btnagregarmedico.UseVisualStyleBackColor = true;
            // 
            // lblagregarnuevomedico
            // 
            this.lblagregarnuevomedico.AutoSize = true;
            this.lblagregarnuevomedico.Location = new System.Drawing.Point(5, 168);
            this.lblagregarnuevomedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblagregarnuevomedico.Name = "lblagregarnuevomedico";
            this.lblagregarnuevomedico.Size = new System.Drawing.Size(132, 13);
            this.lblagregarnuevomedico.TabIndex = 11;
            this.lblagregarnuevomedico.Text = "Agregar un nuevo medico ";
            // 
            // lblmedicosolicitante
            // 
            this.lblmedicosolicitante.AutoSize = true;
            this.lblmedicosolicitante.Location = new System.Drawing.Point(5, 117);
            this.lblmedicosolicitante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmedicosolicitante.Name = "lblmedicosolicitante";
            this.lblmedicosolicitante.Size = new System.Drawing.Size(92, 13);
            this.lblmedicosolicitante.TabIndex = 9;
            this.lblmedicosolicitante.Text = "Medico solicitante";
            // 
            // cbmedicos
            // 
            this.cbmedicos.FormattingEnabled = true;
            this.cbmedicos.Location = new System.Drawing.Point(5, 132);
            this.cbmedicos.Margin = new System.Windows.Forms.Padding(2);
            this.cbmedicos.Name = "cbmedicos";
            this.cbmedicos.Size = new System.Drawing.Size(197, 21);
            this.cbmedicos.TabIndex = 8;
            // 
            // lblespecialidades
            // 
            this.lblespecialidades.AutoSize = true;
            this.lblespecialidades.Location = new System.Drawing.Point(5, 218);
            this.lblespecialidades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblespecialidades.Name = "lblespecialidades";
            this.lblespecialidades.Size = new System.Drawing.Size(78, 13);
            this.lblespecialidades.TabIndex = 7;
            this.lblespecialidades.Text = "Especialidades";
            // 
            // checklistespecialidades
            // 
            this.checklistespecialidades.FormattingEnabled = true;
            this.checklistespecialidades.Location = new System.Drawing.Point(5, 233);
            this.checklistespecialidades.Margin = new System.Windows.Forms.Padding(2);
            this.checklistespecialidades.Name = "checklistespecialidades";
            this.checklistespecialidades.Size = new System.Drawing.Size(197, 79);
            this.checklistespecialidades.Sorted = true;
            this.checklistespecialidades.TabIndex = 4;
            this.checklistespecialidades.ThreeDCheckBoxes = true;
            this.checklistespecialidades.SelectedIndexChanged += new System.EventHandler(this.checklistespecialidades_SelectedIndexChanged);
            // 
            // dtfecharetiro
            // 
            this.dtfecharetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecharetiro.Location = new System.Drawing.Point(5, 378);
            this.dtfecharetiro.Margin = new System.Windows.Forms.Padding(2);
            this.dtfecharetiro.Name = "dtfecharetiro";
            this.dtfecharetiro.Size = new System.Drawing.Size(113, 20);
            this.dtfecharetiro.TabIndex = 3;
            // 
            // labelretiroingresos
            // 
            this.labelretiroingresos.AutoSize = true;
            this.labelretiroingresos.Location = new System.Drawing.Point(2, 363);
            this.labelretiroingresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelretiroingresos.Name = "labelretiroingresos";
            this.labelretiroingresos.Size = new System.Drawing.Size(78, 13);
            this.labelretiroingresos.TabIndex = 2;
            this.labelretiroingresos.Text = "Fecha de retiro";
            // 
            // dtfechaingreso
            // 
            this.dtfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfechaingreso.Location = new System.Drawing.Point(5, 335);
            this.dtfechaingreso.Margin = new System.Windows.Forms.Padding(2);
            this.dtfechaingreso.Name = "dtfechaingreso";
            this.dtfechaingreso.Size = new System.Drawing.Size(113, 20);
            this.dtfechaingreso.TabIndex = 1;
            // 
            // panelbotones
            // 
            this.panelbotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotones.Controls.Add(this.btneliminarespecialidad);
            this.panelbotones.Controls.Add(this.btnmodificarespecialidad);
            this.panelbotones.Controls.Add(this.btnagregarespecialidad);
            this.panelbotones.Location = new System.Drawing.Point(8, 324);
            this.panelbotones.Margin = new System.Windows.Forms.Padding(2);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(361, 50);
            this.panelbotones.TabIndex = 2;
            // 
            // btneliminarespecialidad
            // 
            this.btneliminarespecialidad.Location = new System.Drawing.Point(230, 9);
            this.btneliminarespecialidad.Name = "btneliminarespecialidad";
            this.btneliminarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btneliminarespecialidad.TabIndex = 5;
            this.btneliminarespecialidad.Text = "Eliminar";
            this.btneliminarespecialidad.UseVisualStyleBackColor = true;
            // 
            // btnmodificarespecialidad
            // 
            this.btnmodificarespecialidad.Location = new System.Drawing.Point(137, 9);
            this.btnmodificarespecialidad.Name = "btnmodificarespecialidad";
            this.btnmodificarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btnmodificarespecialidad.TabIndex = 4;
            this.btnmodificarespecialidad.Text = "Modificar";
            this.btnmodificarespecialidad.UseVisualStyleBackColor = true;
            // 
            // btnagregarespecialidad
            // 
            this.btnagregarespecialidad.Location = new System.Drawing.Point(42, 9);
            this.btnagregarespecialidad.Name = "btnagregarespecialidad";
            this.btnagregarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btnagregarespecialidad.TabIndex = 3;
            this.btnagregarespecialidad.Text = "Agregar";
            this.btnagregarespecialidad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvingresos);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 312);
            this.panel1.TabIndex = 3;
            // 
            // dgvingresos
            // 
            this.dgvingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvingresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvingresos.Location = new System.Drawing.Point(0, 0);
            this.dgvingresos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvingresos.Name = "dgvingresos";
            this.dgvingresos.RowHeadersWidth = 62;
            this.dgvingresos.RowTemplate.Height = 28;
            this.dgvingresos.Size = new System.Drawing.Size(361, 312);
            this.dgvingresos.TabIndex = 0;
            // 
            // panelaceptar
            // 
            this.panelaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelaceptar.Controls.Add(this.button1);
            this.panelaceptar.Location = new System.Drawing.Point(264, 382);
            this.panelaceptar.Name = "panelaceptar";
            this.panelaceptar.Size = new System.Drawing.Size(106, 32);
            this.panelaceptar.TabIndex = 8;
            // 
            // lblagregarnuevopaciente
            // 
            this.lblagregarnuevopaciente.AutoSize = true;
            this.lblagregarnuevopaciente.Location = new System.Drawing.Point(5, 65);
            this.lblagregarnuevopaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblagregarnuevopaciente.Name = "lblagregarnuevopaciente";
            this.lblagregarnuevopaciente.Size = new System.Drawing.Size(139, 13);
            this.lblagregarnuevopaciente.TabIndex = 17;
            this.lblagregarnuevopaciente.Text = "Agregar un nuevo paciente ";
            // 
            // labelfechaingresos
            // 
            this.labelfechaingresos.AutoSize = true;
            this.labelfechaingresos.Location = new System.Drawing.Point(5, 316);
            this.labelfechaingresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfechaingresos.Name = "labelfechaingresos";
            this.labelfechaingresos.Size = new System.Drawing.Size(89, 13);
            this.labelfechaingresos.TabIndex = 18;
            this.labelfechaingresos.Text = "Fecha de ingreso";
            // 
            // cbpacienteapellido
            // 
            this.cbpacienteapellido.FormattingEnabled = true;
            this.cbpacienteapellido.Location = new System.Drawing.Point(5, 26);
            this.cbpacienteapellido.Margin = new System.Windows.Forms.Padding(2);
            this.cbpacienteapellido.Name = "cbpacienteapellido";
            this.cbpacienteapellido.Size = new System.Drawing.Size(192, 21);
            this.cbpacienteapellido.TabIndex = 20;
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.panelaceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.paneldatosingresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormIngresos";
            this.Text = "FormIngresos";
            this.Load += new System.EventHandler(this.FormIngresos_Load);
            this.paneldatosingresos.ResumeLayout(false);
            this.paneldatosingresos.PerformLayout();
            this.panelbotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvingresos)).EndInit();
            this.panelaceptar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldatosingresos;
        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminarespecialidad;
        private System.Windows.Forms.Button btnmodificarespecialidad;
        private System.Windows.Forms.Button btnagregarespecialidad;
        private System.Windows.Forms.DateTimePicker dtfecharetiro;
        private System.Windows.Forms.Label labelretiroingresos;
        private System.Windows.Forms.DateTimePicker dtfechaingreso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvingresos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checklistespecialidades;
        private System.Windows.Forms.Label lblagregarnuevomedico;
        private System.Windows.Forms.Label lblmedicosolicitante;
        private System.Windows.Forms.ComboBox cbmedicos;
        private System.Windows.Forms.Label lblespecialidades;
        private System.Windows.Forms.Button btnagregarmedico;
        private System.Windows.Forms.Button btnagregarpaciente;
        private System.Windows.Forms.Label lblpaciente;
        private System.Windows.Forms.Panel panelaceptar;
        private System.Windows.Forms.Label lblagregarnuevopaciente;
        private System.Windows.Forms.Label labelfechaingresos;
        private System.Windows.Forms.ComboBox cbpacienteapellido;
    }
}