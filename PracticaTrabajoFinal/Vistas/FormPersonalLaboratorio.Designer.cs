namespace PracticaTrabajoFinal.Vistas
{
    partial class FormPersonalLaboratorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneldatosperlab = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.agregarnuevaespecialidad = new System.Windows.Forms.CheckBox();
            this.lblespecialidadperlab = new System.Windows.Forms.Label();
            this.cbespecialidadperlab = new System.Windows.Forms.ComboBox();
            this.lblcategoriaperlab = new System.Windows.Forms.Label();
            this.cbcategoriaperlab = new System.Windows.Forms.ComboBox();
            this.panelnuevacategoria = new System.Windows.Forms.Panel();
            this.btncancelarcategoria = new System.Windows.Forms.Button();
            this.panelagregarnuevaespecialidad = new System.Windows.Forms.Panel();
            this.btncancelarespecialidad = new System.Windows.Forms.Button();
            this.btnguardarespecialidad = new System.Windows.Forms.Button();
            this.lblnombreespecialidad = new System.Windows.Forms.Label();
            this.txtespecialidadperlab = new System.Windows.Forms.TextBox();
            this.btnguardarcategoria = new System.Windows.Forms.Button();
            this.lblnombrecategoria = new System.Windows.Forms.Label();
            this.txtnombrecategoria = new System.Windows.Forms.TextBox();
            this.agregarnuevacategoria = new System.Windows.Forms.CheckBox();
            this.lblapellidoperlab = new System.Windows.Forms.Label();
            this.lblmatriculaperlab = new System.Windows.Forms.Label();
            this.lblnombreperlab = new System.Windows.Forms.Label();
            this.txtmatriculaperlab = new System.Windows.Forms.TextBox();
            this.txtapellidoperlab = new System.Windows.Forms.TextBox();
            this.txtnombreperlab = new System.Windows.Forms.TextBox();
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.panelbtnaceptarpaciente = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.paneldgvpacientes = new System.Windows.Forms.Panel();
            this.dgvperlab = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.Label();
            this.paneldatosperlab.SuspendLayout();
            this.panelnuevacategoria.SuspendLayout();
            this.panelagregarnuevaespecialidad.SuspendLayout();
            this.panelbotones.SuspendLayout();
            this.panelbtnaceptarpaciente.SuspendLayout();
            this.paneldgvpacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvperlab)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldatosperlab
            // 
            this.paneldatosperlab.Controls.Add(this.btnsalir);
            this.paneldatosperlab.Controls.Add(this.panelagregarnuevaespecialidad);
            this.paneldatosperlab.Controls.Add(this.agregarnuevaespecialidad);
            this.paneldatosperlab.Controls.Add(this.lblespecialidadperlab);
            this.paneldatosperlab.Controls.Add(this.cbespecialidadperlab);
            this.paneldatosperlab.Controls.Add(this.lblcategoriaperlab);
            this.paneldatosperlab.Controls.Add(this.cbcategoriaperlab);
            this.paneldatosperlab.Controls.Add(this.panelnuevacategoria);
            this.paneldatosperlab.Controls.Add(this.agregarnuevacategoria);
            this.paneldatosperlab.Controls.Add(this.lblapellidoperlab);
            this.paneldatosperlab.Controls.Add(this.lblmatriculaperlab);
            this.paneldatosperlab.Controls.Add(this.lblnombreperlab);
            this.paneldatosperlab.Controls.Add(this.txtmatriculaperlab);
            this.paneldatosperlab.Controls.Add(this.txtapellidoperlab);
            this.paneldatosperlab.Controls.Add(this.txtnombreperlab);
            this.paneldatosperlab.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatosperlab.Location = new System.Drawing.Point(367, 0);
            this.paneldatosperlab.Name = "paneldatosperlab";
            this.paneldatosperlab.Size = new System.Drawing.Size(214, 417);
            this.paneldatosperlab.TabIndex = 11;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Location = new System.Drawing.Point(183, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(28, 23);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // agregarnuevaespecialidad
            // 
            this.agregarnuevaespecialidad.AutoSize = true;
            this.agregarnuevaespecialidad.Location = new System.Drawing.Point(82, 204);
            this.agregarnuevaespecialidad.Name = "agregarnuevaespecialidad";
            this.agregarnuevaespecialidad.Size = new System.Drawing.Size(126, 17);
            this.agregarnuevaespecialidad.TabIndex = 29;
            this.agregarnuevaespecialidad.Text = "Agregar Especialidad";
            this.agregarnuevaespecialidad.UseVisualStyleBackColor = true;
            this.agregarnuevaespecialidad.CheckedChanged += new System.EventHandler(this.agregarnuevaespecialidad_CheckedChanged);
            // 
            // lblespecialidadperlab
            // 
            this.lblespecialidadperlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblespecialidadperlab.AutoSize = true;
            this.lblespecialidadperlab.Location = new System.Drawing.Point(7, 157);
            this.lblespecialidadperlab.Name = "lblespecialidadperlab";
            this.lblespecialidadperlab.Size = new System.Drawing.Size(67, 13);
            this.lblespecialidadperlab.TabIndex = 28;
            this.lblespecialidadperlab.Text = "Especialidad";
            // 
            // cbespecialidadperlab
            // 
            this.cbespecialidadperlab.FormattingEnabled = true;
            this.cbespecialidadperlab.Location = new System.Drawing.Point(83, 154);
            this.cbespecialidadperlab.Name = "cbespecialidadperlab";
            this.cbespecialidadperlab.Size = new System.Drawing.Size(128, 21);
            this.cbespecialidadperlab.TabIndex = 27;
            // 
            // lblcategoriaperlab
            // 
            this.lblcategoriaperlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcategoriaperlab.AutoSize = true;
            this.lblcategoriaperlab.Location = new System.Drawing.Point(6, 125);
            this.lblcategoriaperlab.Name = "lblcategoriaperlab";
            this.lblcategoriaperlab.Size = new System.Drawing.Size(52, 13);
            this.lblcategoriaperlab.TabIndex = 26;
            this.lblcategoriaperlab.Text = "Categoria";
            // 
            // cbcategoriaperlab
            // 
            this.cbcategoriaperlab.FormattingEnabled = true;
            this.cbcategoriaperlab.Location = new System.Drawing.Point(82, 122);
            this.cbcategoriaperlab.Name = "cbcategoriaperlab";
            this.cbcategoriaperlab.Size = new System.Drawing.Size(128, 21);
            this.cbcategoriaperlab.TabIndex = 25;
            // 
            // panelnuevacategoria
            // 
            this.panelnuevacategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelnuevacategoria.Controls.Add(this.btncancelarcategoria);
            this.panelnuevacategoria.Controls.Add(this.btnguardarcategoria);
            this.panelnuevacategoria.Controls.Add(this.lblnombrecategoria);
            this.panelnuevacategoria.Controls.Add(this.txtnombrecategoria);
            this.panelnuevacategoria.Location = new System.Drawing.Point(3, 223);
            this.panelnuevacategoria.Name = "panelnuevacategoria";
            this.panelnuevacategoria.Size = new System.Drawing.Size(208, 94);
            this.panelnuevacategoria.TabIndex = 24;
            this.panelnuevacategoria.Visible = false;
            // 
            // btncancelarcategoria
            // 
            this.btncancelarcategoria.Location = new System.Drawing.Point(111, 53);
            this.btncancelarcategoria.Name = "btncancelarcategoria";
            this.btncancelarcategoria.Size = new System.Drawing.Size(75, 23);
            this.btncancelarcategoria.TabIndex = 25;
            this.btncancelarcategoria.Text = "Cancelar";
            this.btncancelarcategoria.UseVisualStyleBackColor = true;
            this.btncancelarcategoria.Click += new System.EventHandler(this.btncancelarcategoria_Click);
            // 
            // panelagregarnuevaespecialidad
            // 
            this.panelagregarnuevaespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelagregarnuevaespecialidad.Controls.Add(this.btncancelarespecialidad);
            this.panelagregarnuevaespecialidad.Controls.Add(this.btnguardarespecialidad);
            this.panelagregarnuevaespecialidad.Controls.Add(this.lblnombreespecialidad);
            this.panelagregarnuevaespecialidad.Controls.Add(this.txtespecialidadperlab);
            this.panelagregarnuevaespecialidad.Location = new System.Drawing.Point(3, 323);
            this.panelagregarnuevaespecialidad.Name = "panelagregarnuevaespecialidad";
            this.panelagregarnuevaespecialidad.Size = new System.Drawing.Size(208, 94);
            this.panelagregarnuevaespecialidad.TabIndex = 26;
            this.panelagregarnuevaespecialidad.Visible = false;
            // 
            // btncancelarespecialidad
            // 
            this.btncancelarespecialidad.Location = new System.Drawing.Point(111, 53);
            this.btncancelarespecialidad.Name = "btncancelarespecialidad";
            this.btncancelarespecialidad.Size = new System.Drawing.Size(75, 23);
            this.btncancelarespecialidad.TabIndex = 25;
            this.btncancelarespecialidad.Text = "Cancelar";
            this.btncancelarespecialidad.UseVisualStyleBackColor = true;
            this.btncancelarespecialidad.Click += new System.EventHandler(this.btncancelarespecialidad_Click);
            // 
            // btnguardarespecialidad
            // 
            this.btnguardarespecialidad.Location = new System.Drawing.Point(23, 53);
            this.btnguardarespecialidad.Name = "btnguardarespecialidad";
            this.btnguardarespecialidad.Size = new System.Drawing.Size(75, 23);
            this.btnguardarespecialidad.TabIndex = 24;
            this.btnguardarespecialidad.Text = "Guardar";
            this.btnguardarespecialidad.UseVisualStyleBackColor = true;
            this.btnguardarespecialidad.Click += new System.EventHandler(this.btnguardarespecialidad_Click);
            // 
            // lblnombreespecialidad
            // 
            this.lblnombreespecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombreespecialidad.AutoSize = true;
            this.lblnombreespecialidad.Location = new System.Drawing.Point(51, 7);
            this.lblnombreespecialidad.Name = "lblnombreespecialidad";
            this.lblnombreespecialidad.Size = new System.Drawing.Size(107, 13);
            this.lblnombreespecialidad.TabIndex = 23;
            this.lblnombreespecialidad.Text = "Nombre Especialidad";
            // 
            // txtespecialidadperlab
            // 
            this.txtespecialidadperlab.Location = new System.Drawing.Point(54, 23);
            this.txtespecialidadperlab.Name = "txtespecialidadperlab";
            this.txtespecialidadperlab.Size = new System.Drawing.Size(100, 20);
            this.txtespecialidadperlab.TabIndex = 1;
            // 
            // btnguardarcategoria
            // 
            this.btnguardarcategoria.Location = new System.Drawing.Point(23, 53);
            this.btnguardarcategoria.Name = "btnguardarcategoria";
            this.btnguardarcategoria.Size = new System.Drawing.Size(75, 23);
            this.btnguardarcategoria.TabIndex = 24;
            this.btnguardarcategoria.Text = "Guardar";
            this.btnguardarcategoria.UseVisualStyleBackColor = true;
            this.btnguardarcategoria.Click += new System.EventHandler(this.btnguardarcategoria_Click);
            // 
            // lblnombrecategoria
            // 
            this.lblnombrecategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombrecategoria.AutoSize = true;
            this.lblnombrecategoria.Location = new System.Drawing.Point(55, 11);
            this.lblnombrecategoria.Name = "lblnombrecategoria";
            this.lblnombrecategoria.Size = new System.Drawing.Size(92, 13);
            this.lblnombrecategoria.TabIndex = 23;
            this.lblnombrecategoria.Text = "Nombre Categoria";
            // 
            // txtnombrecategoria
            // 
            this.txtnombrecategoria.Location = new System.Drawing.Point(51, 27);
            this.txtnombrecategoria.Name = "txtnombrecategoria";
            this.txtnombrecategoria.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecategoria.TabIndex = 1;
            // 
            // agregarnuevacategoria
            // 
            this.agregarnuevacategoria.AutoSize = true;
            this.agregarnuevacategoria.Location = new System.Drawing.Point(83, 181);
            this.agregarnuevacategoria.Name = "agregarnuevacategoria";
            this.agregarnuevacategoria.Size = new System.Drawing.Size(111, 17);
            this.agregarnuevacategoria.TabIndex = 22;
            this.agregarnuevacategoria.Text = "Agregar Categoria";
            this.agregarnuevacategoria.UseVisualStyleBackColor = true;
            this.agregarnuevacategoria.CheckedChanged += new System.EventHandler(this.agregarnuevacategoria_CheckedChanged);
            // 
            // lblapellidoperlab
            // 
            this.lblapellidoperlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblapellidoperlab.AutoSize = true;
            this.lblapellidoperlab.Location = new System.Drawing.Point(15, 73);
            this.lblapellidoperlab.Name = "lblapellidoperlab";
            this.lblapellidoperlab.Size = new System.Drawing.Size(44, 13);
            this.lblapellidoperlab.TabIndex = 19;
            this.lblapellidoperlab.Text = "Apellido";
            // 
            // lblmatriculaperlab
            // 
            this.lblmatriculaperlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmatriculaperlab.AutoSize = true;
            this.lblmatriculaperlab.Location = new System.Drawing.Point(15, 99);
            this.lblmatriculaperlab.Name = "lblmatriculaperlab";
            this.lblmatriculaperlab.Size = new System.Drawing.Size(50, 13);
            this.lblmatriculaperlab.TabIndex = 18;
            this.lblmatriculaperlab.Text = "Matricula";
            // 
            // lblnombreperlab
            // 
            this.lblnombreperlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombreperlab.AutoSize = true;
            this.lblnombreperlab.Location = new System.Drawing.Point(15, 47);
            this.lblnombreperlab.Name = "lblnombreperlab";
            this.lblnombreperlab.Size = new System.Drawing.Size(44, 13);
            this.lblnombreperlab.TabIndex = 10;
            this.lblnombreperlab.Text = "Nombre";
            // 
            // txtmatriculaperlab
            // 
            this.txtmatriculaperlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatriculaperlab.Location = new System.Drawing.Point(83, 92);
            this.txtmatriculaperlab.Name = "txtmatriculaperlab";
            this.txtmatriculaperlab.Size = new System.Drawing.Size(127, 20);
            this.txtmatriculaperlab.TabIndex = 2;
            // 
            // txtapellidoperlab
            // 
            this.txtapellidoperlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellidoperlab.Location = new System.Drawing.Point(83, 66);
            this.txtapellidoperlab.Name = "txtapellidoperlab";
            this.txtapellidoperlab.Size = new System.Drawing.Size(124, 20);
            this.txtapellidoperlab.TabIndex = 1;
            // 
            // txtnombreperlab
            // 
            this.txtnombreperlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombreperlab.Location = new System.Drawing.Point(82, 40);
            this.txtnombreperlab.Name = "txtnombreperlab";
            this.txtnombreperlab.Size = new System.Drawing.Size(125, 20);
            this.txtnombreperlab.TabIndex = 0;
            // 
            // panelbotones
            // 
            this.panelbotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotones.Controls.Add(this.btneliminar);
            this.panelbotones.Controls.Add(this.btnmodificar);
            this.panelbotones.Controls.Add(this.btnagregar);
            this.panelbotones.Location = new System.Drawing.Point(0, 293);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(266, 60);
            this.panelbotones.TabIndex = 10;
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(174, 18);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(79, 39);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Location = new System.Drawing.Point(89, 18);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(79, 39);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(3, 18);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(80, 39);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // panelbtnaceptarpaciente
            // 
            this.panelbtnaceptarpaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbtnaceptarpaciente.Controls.Add(this.btncancelar);
            this.panelbtnaceptarpaciente.Location = new System.Drawing.Point(235, 359);
            this.panelbtnaceptarpaciente.Name = "panelbtnaceptarpaciente";
            this.panelbtnaceptarpaciente.Size = new System.Drawing.Size(123, 58);
            this.panelbtnaceptarpaciente.TabIndex = 9;
            // 
            // btncancelar
            // 
            this.btncancelar.CausesValidation = false;
            this.btncancelar.Location = new System.Drawing.Point(20, 16);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 30);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // paneldgvpacientes
            // 
            this.paneldgvpacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvpacientes.Controls.Add(this.dgvperlab);
            this.paneldgvpacientes.Location = new System.Drawing.Point(0, 38);
            this.paneldgvpacientes.Name = "paneldgvpacientes";
            this.paneldgvpacientes.Size = new System.Drawing.Size(346, 248);
            this.paneldgvpacientes.TabIndex = 8;
            // 
            // dgvperlab
            // 
            this.dgvperlab.AllowUserToAddRows = false;
            this.dgvperlab.AllowUserToDeleteRows = false;
            this.dgvperlab.AllowUserToResizeColumns = false;
            this.dgvperlab.AllowUserToResizeRows = false;
            this.dgvperlab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvperlab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvperlab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvperlab.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvperlab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvperlab.Location = new System.Drawing.Point(0, 0);
            this.dgvperlab.MultiSelect = false;
            this.dgvperlab.Name = "dgvperlab";
            this.dgvperlab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvperlab.Size = new System.Drawing.Size(346, 248);
            this.dgvperlab.TabIndex = 5;
            this.dgvperlab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvperlab_CellClick);
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(36, 9);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(262, 20);
            this.nombre.TabIndex = 12;
            this.nombre.Text = "Personal del Laboratorio";
            // 
            // FormPersonalLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.paneldatosperlab);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.panelbtnaceptarpaciente);
            this.Controls.Add(this.paneldgvpacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 150);
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormPersonalLaboratorio";
            this.Text = "FormPersonalLaboratorio";
            this.paneldatosperlab.ResumeLayout(false);
            this.paneldatosperlab.PerformLayout();
            this.panelnuevacategoria.ResumeLayout(false);
            this.panelnuevacategoria.PerformLayout();
            this.panelagregarnuevaespecialidad.ResumeLayout(false);
            this.panelagregarnuevaespecialidad.PerformLayout();
            this.panelbotones.ResumeLayout(false);
            this.panelbtnaceptarpaciente.ResumeLayout(false);
            this.paneldgvpacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvperlab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneldatosperlab;
        private System.Windows.Forms.Label lblespecialidadperlab;
        private System.Windows.Forms.ComboBox cbespecialidadperlab;
        private System.Windows.Forms.Label lblcategoriaperlab;
        private System.Windows.Forms.ComboBox cbcategoriaperlab;
        private System.Windows.Forms.Panel panelnuevacategoria;
        private System.Windows.Forms.Button btncancelarcategoria;
        private System.Windows.Forms.Button btnguardarcategoria;
        private System.Windows.Forms.Label lblnombrecategoria;
        private System.Windows.Forms.TextBox txtnombrecategoria;
        private System.Windows.Forms.CheckBox agregarnuevacategoria;
        private System.Windows.Forms.Label lblapellidoperlab;
        private System.Windows.Forms.Label lblmatriculaperlab;
        private System.Windows.Forms.Label lblnombreperlab;
        private System.Windows.Forms.TextBox txtmatriculaperlab;
        private System.Windows.Forms.TextBox txtapellidoperlab;
        private System.Windows.Forms.TextBox txtnombreperlab;
        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Panel panelbtnaceptarpaciente;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel paneldgvpacientes;
        private System.Windows.Forms.DataGridView dgvperlab;
        private System.Windows.Forms.CheckBox agregarnuevaespecialidad;
        private System.Windows.Forms.Panel panelagregarnuevaespecialidad;
        private System.Windows.Forms.Button btncancelarespecialidad;
        private System.Windows.Forms.Button btnguardarespecialidad;
        private System.Windows.Forms.Label lblnombreespecialidad;
        private System.Windows.Forms.TextBox txtespecialidadperlab;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label nombre;
    }
}