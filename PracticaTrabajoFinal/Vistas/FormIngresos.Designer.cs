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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneldatosingresos = new System.Windows.Forms.Panel();
            this.btnnuevomedico = new System.Windows.Forms.Button();
            this.btnnuevopaciente = new System.Windows.Forms.Button();
            this.btnrecargarpacientes = new System.Windows.Forms.Button();
            this.btnrecargarmedicos = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblfechaingresos = new System.Windows.Forms.Label();
            this.lblagreganuevopaciente = new System.Windows.Forms.Label();
            this.lblpaciente = new System.Windows.Forms.Label();
            this.cbpacientes = new System.Windows.Forms.ComboBox();
            this.lblagregarmedico = new System.Windows.Forms.Label();
            this.lblmedico = new System.Windows.Forms.Label();
            this.cbmedicos = new System.Windows.Forms.ComboBox();
            this.lblpracticas = new System.Windows.Forms.Label();
            this.checklistpracticas = new System.Windows.Forms.CheckedListBox();
            this.dtfecharetiro = new System.Windows.Forms.DateTimePicker();
            this.lblfecharetiro = new System.Windows.Forms.Label();
            this.dtfechaingreso = new System.Windows.Forms.DateTimePicker();
            this.panelbotonesingresos = new System.Windows.Forms.Panel();
            this.btneliminarespecialidad = new System.Windows.Forms.Button();
            this.btnmodificarespecialidad = new System.Windows.Forms.Button();
            this.btnagregarespecialidad = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.paneldgv = new System.Windows.Forms.Panel();
            this.dgvingresos = new System.Windows.Forms.DataGridView();
            this.panelcancelar = new System.Windows.Forms.Panel();
            this.paneldatosingresos.SuspendLayout();
            this.panelbotonesingresos.SuspendLayout();
            this.paneldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvingresos)).BeginInit();
            this.panelcancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldatosingresos
            // 
            this.paneldatosingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldatosingresos.Controls.Add(this.btnnuevomedico);
            this.paneldatosingresos.Controls.Add(this.btnnuevopaciente);
            this.paneldatosingresos.Controls.Add(this.btnrecargarpacientes);
            this.paneldatosingresos.Controls.Add(this.btnrecargarmedicos);
            this.paneldatosingresos.Controls.Add(this.btnsalir);
            this.paneldatosingresos.Controls.Add(this.lblfechaingresos);
            this.paneldatosingresos.Controls.Add(this.lblagreganuevopaciente);
            this.paneldatosingresos.Controls.Add(this.lblpaciente);
            this.paneldatosingresos.Controls.Add(this.cbpacientes);
            this.paneldatosingresos.Controls.Add(this.lblagregarmedico);
            this.paneldatosingresos.Controls.Add(this.lblmedico);
            this.paneldatosingresos.Controls.Add(this.cbmedicos);
            this.paneldatosingresos.Controls.Add(this.lblpracticas);
            this.paneldatosingresos.Controls.Add(this.checklistpracticas);
            this.paneldatosingresos.Controls.Add(this.dtfecharetiro);
            this.paneldatosingresos.Controls.Add(this.lblfecharetiro);
            this.paneldatosingresos.Controls.Add(this.dtfechaingreso);
            this.paneldatosingresos.Location = new System.Drawing.Point(334, 0);
            this.paneldatosingresos.Margin = new System.Windows.Forms.Padding(2);
            this.paneldatosingresos.Name = "paneldatosingresos";
            this.paneldatosingresos.Size = new System.Drawing.Size(248, 414);
            this.paneldatosingresos.TabIndex = 0;
            // 
            // btnnuevomedico
            // 
            this.btnnuevomedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevomedico.Location = new System.Drawing.Point(179, 145);
            this.btnnuevomedico.Name = "btnnuevomedico";
            this.btnnuevomedico.Size = new System.Drawing.Size(27, 30);
            this.btnnuevomedico.TabIndex = 24;
            this.btnnuevomedico.Text = "+";
            this.btnnuevomedico.UseVisualStyleBackColor = true;
            this.btnnuevomedico.Click += new System.EventHandler(this.btnnuevomedico_Click);
            // 
            // btnnuevopaciente
            // 
            this.btnnuevopaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevopaciente.Location = new System.Drawing.Point(179, 58);
            this.btnnuevopaciente.Name = "btnnuevopaciente";
            this.btnnuevopaciente.Size = new System.Drawing.Size(27, 30);
            this.btnnuevopaciente.TabIndex = 23;
            this.btnnuevopaciente.Text = "+";
            this.btnnuevopaciente.UseVisualStyleBackColor = true;
            this.btnnuevopaciente.Click += new System.EventHandler(this.btnnuevopaciente_Click);
            // 
            // btnrecargarpacientes
            // 
            this.btnrecargarpacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecargarpacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecargarpacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnrecargarpacientes.Image")));
            this.btnrecargarpacientes.Location = new System.Drawing.Point(147, 32);
            this.btnrecargarpacientes.Name = "btnrecargarpacientes";
            this.btnrecargarpacientes.Size = new System.Drawing.Size(24, 23);
            this.btnrecargarpacientes.TabIndex = 22;
            this.btnrecargarpacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnrecargarpacientes.UseVisualStyleBackColor = true;
            this.btnrecargarpacientes.Click += new System.EventHandler(this.btnrecargarpacientes_Click);
            // 
            // btnrecargarmedicos
            // 
            this.btnrecargarmedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecargarmedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecargarmedicos.Image = ((System.Drawing.Image)(resources.GetObject("btnrecargarmedicos.Image")));
            this.btnrecargarmedicos.Location = new System.Drawing.Point(147, 119);
            this.btnrecargarmedicos.Name = "btnrecargarmedicos";
            this.btnrecargarmedicos.Size = new System.Drawing.Size(24, 23);
            this.btnrecargarmedicos.TabIndex = 21;
            this.btnrecargarmedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnrecargarmedicos.UseVisualStyleBackColor = true;
            this.btnrecargarmedicos.Click += new System.EventHandler(this.btnrecargarmedicos_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Location = new System.Drawing.Point(226, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(22, 23);
            this.btnsalir.TabIndex = 20;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblfechaingresos
            // 
            this.lblfechaingresos.AutoSize = true;
            this.lblfechaingresos.Location = new System.Drawing.Point(10, 316);
            this.lblfechaingresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechaingresos.Name = "lblfechaingresos";
            this.lblfechaingresos.Size = new System.Drawing.Size(89, 13);
            this.lblfechaingresos.TabIndex = 19;
            this.lblfechaingresos.Text = "Fecha de ingreso";
            // 
            // lblagreganuevopaciente
            // 
            this.lblagreganuevopaciente.AutoSize = true;
            this.lblagreganuevopaciente.Location = new System.Drawing.Point(35, 68);
            this.lblagreganuevopaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblagreganuevopaciente.Name = "lblagreganuevopaciente";
            this.lblagreganuevopaciente.Size = new System.Drawing.Size(139, 13);
            this.lblagreganuevopaciente.TabIndex = 18;
            this.lblagreganuevopaciente.Text = "Agregar un nuevo paciente ";
            // 
            // lblpaciente
            // 
            this.lblpaciente.AutoSize = true;
            this.lblpaciente.Location = new System.Drawing.Point(4, 17);
            this.lblpaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpaciente.Name = "lblpaciente";
            this.lblpaciente.Size = new System.Drawing.Size(49, 13);
            this.lblpaciente.TabIndex = 14;
            this.lblpaciente.Text = "Paciente";
            // 
            // cbpacientes
            // 
            this.cbpacientes.FormattingEnabled = true;
            this.cbpacientes.Location = new System.Drawing.Point(5, 32);
            this.cbpacientes.Margin = new System.Windows.Forms.Padding(2);
            this.cbpacientes.Name = "cbpacientes";
            this.cbpacientes.Size = new System.Drawing.Size(137, 21);
            this.cbpacientes.TabIndex = 13;
            // 
            // lblagregarmedico
            // 
            this.lblagregarmedico.AutoSize = true;
            this.lblagregarmedico.Location = new System.Drawing.Point(35, 155);
            this.lblagregarmedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblagregarmedico.Name = "lblagregarmedico";
            this.lblagregarmedico.Size = new System.Drawing.Size(132, 13);
            this.lblagregarmedico.TabIndex = 11;
            this.lblagregarmedico.Text = "Agregar un nuevo medico ";
            // 
            // lblmedico
            // 
            this.lblmedico.AutoSize = true;
            this.lblmedico.Location = new System.Drawing.Point(2, 104);
            this.lblmedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmedico.Name = "lblmedico";
            this.lblmedico.Size = new System.Drawing.Size(92, 13);
            this.lblmedico.TabIndex = 9;
            this.lblmedico.Text = "Medico solicitante";
            // 
            // cbmedicos
            // 
            this.cbmedicos.FormattingEnabled = true;
            this.cbmedicos.Location = new System.Drawing.Point(5, 119);
            this.cbmedicos.Margin = new System.Windows.Forms.Padding(2);
            this.cbmedicos.Name = "cbmedicos";
            this.cbmedicos.Size = new System.Drawing.Size(137, 21);
            this.cbmedicos.TabIndex = 8;
            // 
            // lblpracticas
            // 
            this.lblpracticas.AutoSize = true;
            this.lblpracticas.Location = new System.Drawing.Point(2, 206);
            this.lblpracticas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpracticas.Name = "lblpracticas";
            this.lblpracticas.Size = new System.Drawing.Size(51, 13);
            this.lblpracticas.TabIndex = 7;
            this.lblpracticas.Text = "Practicas";
            // 
            // checklistpracticas
            // 
            this.checklistpracticas.FormattingEnabled = true;
            this.checklistpracticas.Location = new System.Drawing.Point(5, 221);
            this.checklistpracticas.Margin = new System.Windows.Forms.Padding(2);
            this.checklistpracticas.Name = "checklistpracticas";
            this.checklistpracticas.Size = new System.Drawing.Size(197, 79);
            this.checklistpracticas.Sorted = true;
            this.checklistpracticas.TabIndex = 4;
            this.checklistpracticas.ThreeDCheckBoxes = true;
            // 
            // dtfecharetiro
            // 
            this.dtfecharetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecharetiro.Location = new System.Drawing.Point(5, 378);
            this.dtfecharetiro.Margin = new System.Windows.Forms.Padding(2);
            this.dtfecharetiro.Name = "dtfecharetiro";
            this.dtfecharetiro.Size = new System.Drawing.Size(197, 20);
            this.dtfecharetiro.TabIndex = 3;
            // 
            // lblfecharetiro
            // 
            this.lblfecharetiro.AutoSize = true;
            this.lblfecharetiro.Location = new System.Drawing.Point(2, 363);
            this.lblfecharetiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecharetiro.Name = "lblfecharetiro";
            this.lblfecharetiro.Size = new System.Drawing.Size(78, 13);
            this.lblfecharetiro.TabIndex = 2;
            this.lblfecharetiro.Text = "Fecha de retiro";
            // 
            // dtfechaingreso
            // 
            this.dtfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfechaingreso.Location = new System.Drawing.Point(5, 335);
            this.dtfechaingreso.Margin = new System.Windows.Forms.Padding(2);
            this.dtfechaingreso.Name = "dtfechaingreso";
            this.dtfechaingreso.Size = new System.Drawing.Size(197, 20);
            this.dtfechaingreso.TabIndex = 1;
            // 
            // panelbotonesingresos
            // 
            this.panelbotonesingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotonesingresos.Controls.Add(this.btneliminarespecialidad);
            this.panelbotonesingresos.Controls.Add(this.btnmodificarespecialidad);
            this.panelbotonesingresos.Controls.Add(this.btnagregarespecialidad);
            this.panelbotonesingresos.Location = new System.Drawing.Point(8, 324);
            this.panelbotonesingresos.Margin = new System.Windows.Forms.Padding(2);
            this.panelbotonesingresos.Name = "panelbotonesingresos";
            this.panelbotonesingresos.Size = new System.Drawing.Size(321, 50);
            this.panelbotonesingresos.TabIndex = 2;
            // 
            // btneliminarespecialidad
            // 
            this.btneliminarespecialidad.Enabled = false;
            this.btneliminarespecialidad.Location = new System.Drawing.Point(192, 5);
            this.btneliminarespecialidad.Name = "btneliminarespecialidad";
            this.btneliminarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btneliminarespecialidad.TabIndex = 5;
            this.btneliminarespecialidad.Text = "Eliminar";
            this.btneliminarespecialidad.UseVisualStyleBackColor = true;
            // 
            // btnmodificarespecialidad
            // 
            this.btnmodificarespecialidad.Enabled = false;
            this.btnmodificarespecialidad.Location = new System.Drawing.Point(98, 5);
            this.btnmodificarespecialidad.Name = "btnmodificarespecialidad";
            this.btnmodificarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btnmodificarespecialidad.TabIndex = 4;
            this.btnmodificarespecialidad.Text = "Modificar";
            this.btnmodificarespecialidad.UseVisualStyleBackColor = true;
            // 
            // btnagregarespecialidad
            // 
            this.btnagregarespecialidad.Location = new System.Drawing.Point(4, 5);
            this.btnagregarespecialidad.Name = "btnagregarespecialidad";
            this.btnagregarespecialidad.Size = new System.Drawing.Size(88, 34);
            this.btnagregarespecialidad.TabIndex = 3;
            this.btnagregarespecialidad.Text = "Agregar";
            this.btnagregarespecialidad.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(3, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // paneldgv
            // 
            this.paneldgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgv.Controls.Add(this.dgvingresos);
            this.paneldgv.Location = new System.Drawing.Point(8, 8);
            this.paneldgv.Margin = new System.Windows.Forms.Padding(2);
            this.paneldgv.Name = "paneldgv";
            this.paneldgv.Size = new System.Drawing.Size(321, 300);
            this.paneldgv.TabIndex = 3;
            // 
            // dgvingresos
            // 
            this.dgvingresos.AllowUserToAddRows = false;
            this.dgvingresos.AllowUserToDeleteRows = false;
            this.dgvingresos.AllowUserToResizeColumns = false;
            this.dgvingresos.AllowUserToResizeRows = false;
            this.dgvingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvingresos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvingresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvingresos.Location = new System.Drawing.Point(0, 0);
            this.dgvingresos.MultiSelect = false;
            this.dgvingresos.Name = "dgvingresos";
            this.dgvingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvingresos.Size = new System.Drawing.Size(321, 300);
            this.dgvingresos.TabIndex = 7;
            // 
            // panelcancelar
            // 
            this.panelcancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcancelar.Controls.Add(this.btncancelar);
            this.panelcancelar.Location = new System.Drawing.Point(247, 379);
            this.panelcancelar.Name = "panelcancelar";
            this.panelcancelar.Size = new System.Drawing.Size(82, 32);
            this.panelcancelar.TabIndex = 8;
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.panelcancelar);
            this.Controls.Add(this.paneldgv);
            this.Controls.Add(this.panelbotonesingresos);
            this.Controls.Add(this.paneldatosingresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 150);
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormIngresos";
            this.Text = "FormIngresos";
            this.paneldatosingresos.ResumeLayout(false);
            this.paneldatosingresos.PerformLayout();
            this.panelbotonesingresos.ResumeLayout(false);
            this.paneldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvingresos)).EndInit();
            this.panelcancelar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldatosingresos;
        private System.Windows.Forms.Panel panelbotonesingresos;
        private System.Windows.Forms.Button btneliminarespecialidad;
        private System.Windows.Forms.Button btnmodificarespecialidad;
        private System.Windows.Forms.Button btnagregarespecialidad;
        private System.Windows.Forms.DateTimePicker dtfecharetiro;
        private System.Windows.Forms.Label lblfecharetiro;
        private System.Windows.Forms.DateTimePicker dtfechaingreso;
        private System.Windows.Forms.Panel paneldgv;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.CheckedListBox checklistpracticas;
        private System.Windows.Forms.Label lblagregarmedico;
        private System.Windows.Forms.Label lblmedico;
        private System.Windows.Forms.ComboBox cbmedicos;
        private System.Windows.Forms.Label lblpracticas;
        private System.Windows.Forms.Label lblpaciente;
        private System.Windows.Forms.ComboBox cbpacientes;
        private System.Windows.Forms.Panel panelcancelar;
        private System.Windows.Forms.Label lblagreganuevopaciente;
        private System.Windows.Forms.Label lblfechaingresos;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnrecargarmedicos;
        private System.Windows.Forms.Button btnrecargarpacientes;
        private System.Windows.Forms.Button btnnuevomedico;
        private System.Windows.Forms.Button btnnuevopaciente;
        private System.Windows.Forms.DataGridView dgvingresos;
    }
}