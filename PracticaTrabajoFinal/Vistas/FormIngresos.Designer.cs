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
            this.btnagregarpractica = new System.Windows.Forms.Button();
            this.lbpracticas = new System.Windows.Forms.ListBox();
            this.cbpracticas = new System.Windows.Forms.ComboBox();
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
            this.dtfecharetiro = new System.Windows.Forms.DateTimePicker();
            this.lblfecharetiro = new System.Windows.Forms.Label();
            this.dtfechaingreso = new System.Windows.Forms.DateTimePicker();
            this.panelbotonesingresos = new System.Windows.Forms.Panel();
            this.btneliminaringreso = new System.Windows.Forms.Button();
            this.btnmodificaringreso = new System.Windows.Forms.Button();
            this.btnagregaringreso = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.paneldgv = new System.Windows.Forms.Panel();
            this.dgvingresos = new System.Windows.Forms.DataGridView();
            this.panelcancelar = new System.Windows.Forms.Panel();
            this.panelpractXingre = new System.Windows.Forms.Panel();
            this.dgvpractXingreso = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paneldatosingresos.SuspendLayout();
            this.panelbotonesingresos.SuspendLayout();
            this.paneldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvingresos)).BeginInit();
            this.panelcancelar.SuspendLayout();
            this.panelpractXingre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpractXingreso)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldatosingresos
            // 
            this.paneldatosingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldatosingresos.Controls.Add(this.btnagregarpractica);
            this.paneldatosingresos.Controls.Add(this.lbpracticas);
            this.paneldatosingresos.Controls.Add(this.cbpracticas);
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
            this.paneldatosingresos.Controls.Add(this.dtfecharetiro);
            this.paneldatosingresos.Controls.Add(this.lblfecharetiro);
            this.paneldatosingresos.Controls.Add(this.dtfechaingreso);
            this.paneldatosingresos.Location = new System.Drawing.Point(352, 0);
            this.paneldatosingresos.Margin = new System.Windows.Forms.Padding(2);
            this.paneldatosingresos.Name = "paneldatosingresos";
            this.paneldatosingresos.Size = new System.Drawing.Size(230, 414);
            this.paneldatosingresos.TabIndex = 0;
            // 
            // btnagregarpractica
            // 
            this.btnagregarpractica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarpractica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarpractica.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarpractica.Image")));
            this.btnagregarpractica.Location = new System.Drawing.Point(153, 201);
            this.btnagregarpractica.Name = "btnagregarpractica";
            this.btnagregarpractica.Size = new System.Drawing.Size(21, 24);
            this.btnagregarpractica.TabIndex = 27;
            this.btnagregarpractica.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnagregarpractica.UseVisualStyleBackColor = true;
            this.btnagregarpractica.Click += new System.EventHandler(this.btnagregarpractica_Click);
            // 
            // lbpracticas
            // 
            this.lbpracticas.FormattingEnabled = true;
            this.lbpracticas.Location = new System.Drawing.Point(4, 228);
            this.lbpracticas.Name = "lbpracticas";
            this.lbpracticas.Size = new System.Drawing.Size(140, 56);
            this.lbpracticas.TabIndex = 26;
            // 
            // cbpracticas
            // 
            this.cbpracticas.FormattingEnabled = true;
            this.cbpracticas.Location = new System.Drawing.Point(0, 201);
            this.cbpracticas.Name = "cbpracticas";
            this.cbpracticas.Size = new System.Drawing.Size(144, 21);
            this.cbpracticas.TabIndex = 25;
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
            this.lblfechaingresos.Location = new System.Drawing.Point(2, 297);
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
            this.lblpracticas.Location = new System.Drawing.Point(4, 176);
            this.lblpracticas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpracticas.Name = "lblpracticas";
            this.lblpracticas.Size = new System.Drawing.Size(51, 13);
            this.lblpracticas.TabIndex = 7;
            this.lblpracticas.Text = "Practicas";
            // 
            // dtfecharetiro
            // 
            this.dtfecharetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecharetiro.Location = new System.Drawing.Point(2, 349);
            this.dtfecharetiro.Margin = new System.Windows.Forms.Padding(2);
            this.dtfecharetiro.Name = "dtfecharetiro";
            this.dtfecharetiro.Size = new System.Drawing.Size(197, 20);
            this.dtfecharetiro.TabIndex = 3;
            // 
            // lblfecharetiro
            // 
            this.lblfecharetiro.AutoSize = true;
            this.lblfecharetiro.Location = new System.Drawing.Point(4, 334);
            this.lblfecharetiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecharetiro.Name = "lblfecharetiro";
            this.lblfecharetiro.Size = new System.Drawing.Size(78, 13);
            this.lblfecharetiro.TabIndex = 2;
            this.lblfecharetiro.Text = "Fecha de retiro";
            // 
            // dtfechaingreso
            // 
            this.dtfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfechaingreso.Location = new System.Drawing.Point(2, 312);
            this.dtfechaingreso.Margin = new System.Windows.Forms.Padding(2);
            this.dtfechaingreso.Name = "dtfechaingreso";
            this.dtfechaingreso.Size = new System.Drawing.Size(197, 20);
            this.dtfechaingreso.TabIndex = 1;
            // 
            // panelbotonesingresos
            // 
            this.panelbotonesingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotonesingresos.Controls.Add(this.btneliminaringreso);
            this.panelbotonesingresos.Controls.Add(this.btnmodificaringreso);
            this.panelbotonesingresos.Controls.Add(this.btnagregaringreso);
            this.panelbotonesingresos.Location = new System.Drawing.Point(8, 324);
            this.panelbotonesingresos.Margin = new System.Windows.Forms.Padding(2);
            this.panelbotonesingresos.Name = "panelbotonesingresos";
            this.panelbotonesingresos.Size = new System.Drawing.Size(321, 50);
            this.panelbotonesingresos.TabIndex = 2;
            // 
            // btneliminaringreso
            // 
            this.btneliminaringreso.Enabled = false;
            this.btneliminaringreso.Location = new System.Drawing.Point(192, 5);
            this.btneliminaringreso.Name = "btneliminaringreso";
            this.btneliminaringreso.Size = new System.Drawing.Size(88, 34);
            this.btneliminaringreso.TabIndex = 5;
            this.btneliminaringreso.Text = "Eliminar";
            this.btneliminaringreso.UseVisualStyleBackColor = true;
            this.btneliminaringreso.Click += new System.EventHandler(this.btneliminaringreso_Click);
            // 
            // btnmodificaringreso
            // 
            this.btnmodificaringreso.Enabled = false;
            this.btnmodificaringreso.Location = new System.Drawing.Point(98, 5);
            this.btnmodificaringreso.Name = "btnmodificaringreso";
            this.btnmodificaringreso.Size = new System.Drawing.Size(88, 34);
            this.btnmodificaringreso.TabIndex = 4;
            this.btnmodificaringreso.Text = "Modificar";
            this.btnmodificaringreso.UseVisualStyleBackColor = true;
            this.btnmodificaringreso.Click += new System.EventHandler(this.btnmodificaringreso_Click);
            // 
            // btnagregaringreso
            // 
            this.btnagregaringreso.Location = new System.Drawing.Point(4, 5);
            this.btnagregaringreso.Name = "btnagregaringreso";
            this.btnagregaringreso.Size = new System.Drawing.Size(88, 34);
            this.btnagregaringreso.TabIndex = 3;
            this.btnagregaringreso.Text = "Agregar";
            this.btnagregaringreso.UseVisualStyleBackColor = true;
            this.btnagregaringreso.Click += new System.EventHandler(this.btnagregaringreso_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(3, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // paneldgv
            // 
            this.paneldgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgv.Controls.Add(this.dgvingresos);
            this.paneldgv.Location = new System.Drawing.Point(8, 32);
            this.paneldgv.Margin = new System.Windows.Forms.Padding(2);
            this.paneldgv.Name = "paneldgv";
            this.paneldgv.Size = new System.Drawing.Size(321, 120);
            this.paneldgv.TabIndex = 3;
            // 
            // dgvingresos
            // 
            this.dgvingresos.AllowUserToAddRows = false;
            this.dgvingresos.AllowUserToDeleteRows = false;
            this.dgvingresos.AllowUserToResizeColumns = false;
            this.dgvingresos.AllowUserToResizeRows = false;
            this.dgvingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvingresos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            this.dgvingresos.Size = new System.Drawing.Size(321, 120);
            this.dgvingresos.TabIndex = 13;
            this.dgvingresos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvingresos_CellClick_1);
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
            // panelpractXingre
            // 
            this.panelpractXingre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpractXingre.Controls.Add(this.dgvpractXingreso);
            this.panelpractXingre.Location = new System.Drawing.Point(8, 192);
            this.panelpractXingre.Name = "panelpractXingre";
            this.panelpractXingre.Size = new System.Drawing.Size(317, 127);
            this.panelpractXingre.TabIndex = 9;
            // 
            // dgvpractXingreso
            // 
            this.dgvpractXingreso.AllowUserToAddRows = false;
            this.dgvpractXingreso.AllowUserToDeleteRows = false;
            this.dgvpractXingreso.AllowUserToResizeColumns = false;
            this.dgvpractXingreso.AllowUserToResizeRows = false;
            this.dgvpractXingreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpractXingreso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvpractXingreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpractXingreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpractXingreso.Location = new System.Drawing.Point(0, 0);
            this.dgvpractXingreso.MultiSelect = false;
            this.dgvpractXingreso.Name = "dgvpractXingreso";
            this.dgvpractXingreso.Size = new System.Drawing.Size(317, 127);
            this.dgvpractXingreso.TabIndex = 6;
            this.dgvpractXingreso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpractXingreso_CellClick);
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(102, 9);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(95, 20);
            this.nombre.TabIndex = 11;
            this.nombre.Text = "Ingresos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Practicas por Ingresos";
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.panelpractXingre);
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
            this.panelpractXingre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpractXingreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneldatosingresos;
        private System.Windows.Forms.Panel panelbotonesingresos;
        private System.Windows.Forms.Button btneliminaringreso;
        private System.Windows.Forms.Button btnmodificaringreso;
        private System.Windows.Forms.Button btnagregaringreso;
        private System.Windows.Forms.DateTimePicker dtfecharetiro;
        private System.Windows.Forms.Label lblfecharetiro;
        private System.Windows.Forms.DateTimePicker dtfechaingreso;
        private System.Windows.Forms.Panel paneldgv;
        private System.Windows.Forms.Button btncancelar;
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
        private System.Windows.Forms.Panel panelpractXingre;
        private System.Windows.Forms.ListBox lbpracticas;
        private System.Windows.Forms.ComboBox cbpracticas;
        private System.Windows.Forms.Button btnagregarpractica;
        private System.Windows.Forms.DataGridView dgvingresos;
        private System.Windows.Forms.DataGridView dgvpractXingreso;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label2;
    }
}