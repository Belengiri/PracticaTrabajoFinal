namespace PracticaTrabajoFinal.Vistas
{
    partial class FormPacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneldgvpacientes = new System.Windows.Forms.Panel();
            this.dgvpacientes = new System.Windows.Forms.DataGridView();
            this.panelbtnaceptarpaciente = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btneliminarpaciente = new System.Windows.Forms.Button();
            this.btnmodificarpaciente = new System.Windows.Forms.Button();
            this.btnagregarpaciente = new System.Windows.Forms.Button();
            this.paneldatospaciente = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.panelnuevalocalidad = new System.Windows.Forms.Panel();
            this.btncancelarlocalidad = new System.Windows.Forms.Button();
            this.btnguardarlocalidad = new System.Windows.Forms.Button();
            this.lblnombrelocalidad = new System.Windows.Forms.Label();
            this.lblcodigopostal = new System.Windows.Forms.Label();
            this.txtnombrelocalidad = new System.Windows.Forms.TextBox();
            this.txtcodigopostal = new System.Windows.Forms.TextBox();
            this.agregarlocalidad = new System.Windows.Forms.CheckBox();
            this.lbllocalidad = new System.Windows.Forms.Label();
            this.cblocalidades = new System.Windows.Forms.ComboBox();
            this.lblapellidopaciente = new System.Windows.Forms.Label();
            this.lbldnipaciente = new System.Windows.Forms.Label();
            this.lblfechanacpaciente = new System.Windows.Forms.Label();
            this.lbltelefonopaciente = new System.Windows.Forms.Label();
            this.lblcorreopaciente = new System.Windows.Forms.Label();
            this.lblcallepaciente = new System.Windows.Forms.Label();
            this.lblalturacalle = new System.Windows.Forms.Label();
            this.lblpisocasa = new System.Windows.Forms.Label();
            this.lbldeptopaciente = new System.Windows.Forms.Label();
            this.lblnombrepaciente = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.txtpiso = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdnipaciente = new System.Windows.Forms.TextBox();
            this.txtapellidopaciente = new System.Windows.Forms.TextBox();
            this.txtnombrepaciente = new System.Windows.Forms.TextBox();
            this.paneldgvpacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).BeginInit();
            this.panelbtnaceptarpaciente.SuspendLayout();
            this.panelbotones.SuspendLayout();
            this.paneldatospaciente.SuspendLayout();
            this.panelnuevalocalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldgvpacientes
            // 
            this.paneldgvpacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvpacientes.Controls.Add(this.dgvpacientes);
            this.paneldgvpacientes.Location = new System.Drawing.Point(3, 38);
            this.paneldgvpacientes.Name = "paneldgvpacientes";
            this.paneldgvpacientes.Size = new System.Drawing.Size(346, 248);
            this.paneldgvpacientes.TabIndex = 0;
            // 
            // dgvpacientes
            // 
            this.dgvpacientes.AllowUserToAddRows = false;
            this.dgvpacientes.AllowUserToDeleteRows = false;
            this.dgvpacientes.AllowUserToResizeColumns = false;
            this.dgvpacientes.AllowUserToResizeRows = false;
            this.dgvpacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvpacientes.MultiSelect = false;
            this.dgvpacientes.Name = "dgvpacientes";
            this.dgvpacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpacientes.Size = new System.Drawing.Size(346, 248);
            this.dgvpacientes.TabIndex = 5;
            this.dgvpacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpacientes_CellClick);
            // 
            // panelbtnaceptarpaciente
            // 
            this.panelbtnaceptarpaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbtnaceptarpaciente.Controls.Add(this.btncancelar);
            this.panelbtnaceptarpaciente.Location = new System.Drawing.Point(238, 359);
            this.panelbtnaceptarpaciente.Name = "panelbtnaceptarpaciente";
            this.panelbtnaceptarpaciente.Size = new System.Drawing.Size(123, 58);
            this.panelbtnaceptarpaciente.TabIndex = 1;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(20, 16);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 30);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // panelbotones
            // 
            this.panelbotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotones.Controls.Add(this.btneliminarpaciente);
            this.panelbotones.Controls.Add(this.btnmodificarpaciente);
            this.panelbotones.Controls.Add(this.btnagregarpaciente);
            this.panelbotones.Location = new System.Drawing.Point(3, 293);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(266, 60);
            this.panelbotones.TabIndex = 2;
            // 
            // btneliminarpaciente
            // 
            this.btneliminarpaciente.Enabled = false;
            this.btneliminarpaciente.Location = new System.Drawing.Point(174, 18);
            this.btneliminarpaciente.Name = "btneliminarpaciente";
            this.btneliminarpaciente.Size = new System.Drawing.Size(79, 39);
            this.btneliminarpaciente.TabIndex = 3;
            this.btneliminarpaciente.Text = "Eliminar";
            this.btneliminarpaciente.UseVisualStyleBackColor = true;
            this.btneliminarpaciente.Click += new System.EventHandler(this.btneliminarpaciente_Click);
            // 
            // btnmodificarpaciente
            // 
            this.btnmodificarpaciente.Enabled = false;
            this.btnmodificarpaciente.Location = new System.Drawing.Point(89, 18);
            this.btnmodificarpaciente.Name = "btnmodificarpaciente";
            this.btnmodificarpaciente.Size = new System.Drawing.Size(79, 39);
            this.btnmodificarpaciente.TabIndex = 2;
            this.btnmodificarpaciente.Text = "Modificar";
            this.btnmodificarpaciente.UseVisualStyleBackColor = true;
            this.btnmodificarpaciente.Click += new System.EventHandler(this.btnmodificarpaciente_Click);
            // 
            // btnagregarpaciente
            // 
            this.btnagregarpaciente.Location = new System.Drawing.Point(3, 18);
            this.btnagregarpaciente.Name = "btnagregarpaciente";
            this.btnagregarpaciente.Size = new System.Drawing.Size(80, 39);
            this.btnagregarpaciente.TabIndex = 1;
            this.btnagregarpaciente.Text = "Agregar";
            this.btnagregarpaciente.UseVisualStyleBackColor = true;
            this.btnagregarpaciente.Click += new System.EventHandler(this.btnagregarpaciente_Click);
            // 
            // paneldatospaciente
            // 
            this.paneldatospaciente.Controls.Add(this.btnsalir);
            this.paneldatospaciente.Controls.Add(this.dtfecha);
            this.paneldatospaciente.Controls.Add(this.panelnuevalocalidad);
            this.paneldatospaciente.Controls.Add(this.agregarlocalidad);
            this.paneldatospaciente.Controls.Add(this.lbllocalidad);
            this.paneldatospaciente.Controls.Add(this.cblocalidades);
            this.paneldatospaciente.Controls.Add(this.lblapellidopaciente);
            this.paneldatospaciente.Controls.Add(this.lbldnipaciente);
            this.paneldatospaciente.Controls.Add(this.lblfechanacpaciente);
            this.paneldatospaciente.Controls.Add(this.lbltelefonopaciente);
            this.paneldatospaciente.Controls.Add(this.lblcorreopaciente);
            this.paneldatospaciente.Controls.Add(this.lblcallepaciente);
            this.paneldatospaciente.Controls.Add(this.lblalturacalle);
            this.paneldatospaciente.Controls.Add(this.lblpisocasa);
            this.paneldatospaciente.Controls.Add(this.lbldeptopaciente);
            this.paneldatospaciente.Controls.Add(this.lblnombrepaciente);
            this.paneldatospaciente.Controls.Add(this.txtcorreo);
            this.paneldatospaciente.Controls.Add(this.txtdepartamento);
            this.paneldatospaciente.Controls.Add(this.txtpiso);
            this.paneldatospaciente.Controls.Add(this.txtcalle);
            this.paneldatospaciente.Controls.Add(this.txtaltura);
            this.paneldatospaciente.Controls.Add(this.txttelefono);
            this.paneldatospaciente.Controls.Add(this.txtdnipaciente);
            this.paneldatospaciente.Controls.Add(this.txtapellidopaciente);
            this.paneldatospaciente.Controls.Add(this.txtnombrepaciente);
            this.paneldatospaciente.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatospaciente.Location = new System.Drawing.Point(367, 0);
            this.paneldatospaciente.Name = "paneldatospaciente";
            this.paneldatospaciente.Size = new System.Drawing.Size(214, 417);
            this.paneldatospaciente.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Location = new System.Drawing.Point(189, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(25, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(111, 96);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(103, 20);
            this.dtfecha.TabIndex = 24;
            this.dtfecha.Value = new System.DateTime(2023, 11, 1, 19, 0, 53, 0);
            // 
            // panelnuevalocalidad
            // 
            this.panelnuevalocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelnuevalocalidad.Controls.Add(this.btncancelarlocalidad);
            this.panelnuevalocalidad.Controls.Add(this.btnguardarlocalidad);
            this.panelnuevalocalidad.Controls.Add(this.lblnombrelocalidad);
            this.panelnuevalocalidad.Controls.Add(this.lblcodigopostal);
            this.panelnuevalocalidad.Controls.Add(this.txtnombrelocalidad);
            this.panelnuevalocalidad.Controls.Add(this.txtcodigopostal);
            this.panelnuevalocalidad.Location = new System.Drawing.Point(9, 322);
            this.panelnuevalocalidad.Name = "panelnuevalocalidad";
            this.panelnuevalocalidad.Size = new System.Drawing.Size(201, 94);
            this.panelnuevalocalidad.TabIndex = 23;
            this.panelnuevalocalidad.Visible = false;
            // 
            // btncancelarlocalidad
            // 
            this.btncancelarlocalidad.Location = new System.Drawing.Point(111, 53);
            this.btncancelarlocalidad.Name = "btncancelarlocalidad";
            this.btncancelarlocalidad.Size = new System.Drawing.Size(75, 23);
            this.btncancelarlocalidad.TabIndex = 25;
            this.btncancelarlocalidad.Text = "Cancelar";
            this.btncancelarlocalidad.UseVisualStyleBackColor = true;
            this.btncancelarlocalidad.Click += new System.EventHandler(this.btncancelarlocalidad_Click);
            // 
            // btnguardarlocalidad
            // 
            this.btnguardarlocalidad.Location = new System.Drawing.Point(23, 53);
            this.btnguardarlocalidad.Name = "btnguardarlocalidad";
            this.btnguardarlocalidad.Size = new System.Drawing.Size(75, 23);
            this.btnguardarlocalidad.TabIndex = 24;
            this.btnguardarlocalidad.Text = "Guardar";
            this.btnguardarlocalidad.UseVisualStyleBackColor = true;
            this.btnguardarlocalidad.Click += new System.EventHandler(this.btnguardarlocalidad_Click);
            // 
            // lblnombrelocalidad
            // 
            this.lblnombrelocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombrelocalidad.AutoSize = true;
            this.lblnombrelocalidad.Location = new System.Drawing.Point(3, 10);
            this.lblnombrelocalidad.Name = "lblnombrelocalidad";
            this.lblnombrelocalidad.Size = new System.Drawing.Size(93, 13);
            this.lblnombrelocalidad.TabIndex = 23;
            this.lblnombrelocalidad.Text = "Nombre Localidad";
            // 
            // lblcodigopostal
            // 
            this.lblcodigopostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcodigopostal.AutoSize = true;
            this.lblcodigopostal.Location = new System.Drawing.Point(20, 32);
            this.lblcodigopostal.Name = "lblcodigopostal";
            this.lblcodigopostal.Size = new System.Drawing.Size(72, 13);
            this.lblcodigopostal.TabIndex = 22;
            this.lblcodigopostal.Text = "Codigo Postal";
            // 
            // txtnombrelocalidad
            // 
            this.txtnombrelocalidad.Location = new System.Drawing.Point(98, 3);
            this.txtnombrelocalidad.Name = "txtnombrelocalidad";
            this.txtnombrelocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtnombrelocalidad.TabIndex = 1;
            // 
            // txtcodigopostal
            // 
            this.txtcodigopostal.Location = new System.Drawing.Point(98, 29);
            this.txtcodigopostal.Name = "txtcodigopostal";
            this.txtcodigopostal.Size = new System.Drawing.Size(100, 20);
            this.txtcodigopostal.TabIndex = 0;
            // 
            // agregarlocalidad
            // 
            this.agregarlocalidad.AutoSize = true;
            this.agregarlocalidad.Location = new System.Drawing.Point(83, 302);
            this.agregarlocalidad.Name = "agregarlocalidad";
            this.agregarlocalidad.Size = new System.Drawing.Size(112, 17);
            this.agregarlocalidad.TabIndex = 22;
            this.agregarlocalidad.Text = "Agregar Localidad";
            this.agregarlocalidad.UseVisualStyleBackColor = true;
            this.agregarlocalidad.CheckedChanged += new System.EventHandler(this.agregarlocalidad_CheckedChanged);
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Location = new System.Drawing.Point(7, 278);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(53, 13);
            this.lbllocalidad.TabIndex = 21;
            this.lbllocalidad.Text = "Localidad";
            // 
            // cblocalidades
            // 
            this.cblocalidades.FormattingEnabled = true;
            this.cblocalidades.Location = new System.Drawing.Point(83, 275);
            this.cblocalidades.Name = "cblocalidades";
            this.cblocalidades.Size = new System.Drawing.Size(128, 21);
            this.cblocalidades.TabIndex = 20;
            // 
            // lblapellidopaciente
            // 
            this.lblapellidopaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblapellidopaciente.AutoSize = true;
            this.lblapellidopaciente.Location = new System.Drawing.Point(3, 50);
            this.lblapellidopaciente.Name = "lblapellidopaciente";
            this.lblapellidopaciente.Size = new System.Drawing.Size(44, 13);
            this.lblapellidopaciente.TabIndex = 19;
            this.lblapellidopaciente.Text = "Apellido";
            // 
            // lbldnipaciente
            // 
            this.lbldnipaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldnipaciente.AutoSize = true;
            this.lbldnipaciente.Location = new System.Drawing.Point(3, 76);
            this.lbldnipaciente.Name = "lbldnipaciente";
            this.lbldnipaciente.Size = new System.Drawing.Size(77, 13);
            this.lbldnipaciente.TabIndex = 18;
            this.lbldnipaciente.Text = "Nº Documento";
            // 
            // lblfechanacpaciente
            // 
            this.lblfechanacpaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfechanacpaciente.AutoSize = true;
            this.lblfechanacpaciente.Location = new System.Drawing.Point(7, 102);
            this.lblfechanacpaciente.Name = "lblfechanacpaciente";
            this.lblfechanacpaciente.Size = new System.Drawing.Size(108, 13);
            this.lblfechanacpaciente.TabIndex = 17;
            this.lblfechanacpaciente.Text = "Fecha de Nacimiento";
            // 
            // lbltelefonopaciente
            // 
            this.lbltelefonopaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltelefonopaciente.AutoSize = true;
            this.lbltelefonopaciente.Location = new System.Drawing.Point(3, 128);
            this.lbltelefonopaciente.Name = "lbltelefonopaciente";
            this.lbltelefonopaciente.Size = new System.Drawing.Size(49, 13);
            this.lbltelefonopaciente.TabIndex = 16;
            this.lbltelefonopaciente.Text = "Telefono";
            // 
            // lblcorreopaciente
            // 
            this.lblcorreopaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcorreopaciente.AutoSize = true;
            this.lblcorreopaciente.Location = new System.Drawing.Point(3, 154);
            this.lblcorreopaciente.Name = "lblcorreopaciente";
            this.lblcorreopaciente.Size = new System.Drawing.Size(94, 13);
            this.lblcorreopaciente.TabIndex = 15;
            this.lblcorreopaciente.Text = "Correo Electronico";
            // 
            // lblcallepaciente
            // 
            this.lblcallepaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcallepaciente.AutoSize = true;
            this.lblcallepaciente.Location = new System.Drawing.Point(9, 180);
            this.lblcallepaciente.Name = "lblcallepaciente";
            this.lblcallepaciente.Size = new System.Drawing.Size(33, 13);
            this.lblcallepaciente.TabIndex = 14;
            this.lblcallepaciente.Text = "Calle ";
            // 
            // lblalturacalle
            // 
            this.lblalturacalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblalturacalle.AutoSize = true;
            this.lblalturacalle.Location = new System.Drawing.Point(8, 203);
            this.lblalturacalle.Name = "lblalturacalle";
            this.lblalturacalle.Size = new System.Drawing.Size(34, 13);
            this.lblalturacalle.TabIndex = 13;
            this.lblalturacalle.Text = "Altura";
            // 
            // lblpisocasa
            // 
            this.lblpisocasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpisocasa.AutoSize = true;
            this.lblpisocasa.Location = new System.Drawing.Point(9, 229);
            this.lblpisocasa.Name = "lblpisocasa";
            this.lblpisocasa.Size = new System.Drawing.Size(27, 13);
            this.lblpisocasa.TabIndex = 12;
            this.lblpisocasa.Text = "Piso";
            // 
            // lbldeptopaciente
            // 
            this.lbldeptopaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldeptopaciente.AutoSize = true;
            this.lbldeptopaciente.Location = new System.Drawing.Point(7, 252);
            this.lbldeptopaciente.Name = "lbldeptopaciente";
            this.lbldeptopaciente.Size = new System.Drawing.Size(89, 13);
            this.lbldeptopaciente.TabIndex = 11;
            this.lbldeptopaciente.Text = "Nº Departamento";
            // 
            // lblnombrepaciente
            // 
            this.lblnombrepaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombrepaciente.AutoSize = true;
            this.lblnombrepaciente.Location = new System.Drawing.Point(3, 24);
            this.lblnombrepaciente.Name = "lblnombrepaciente";
            this.lblnombrepaciente.Size = new System.Drawing.Size(44, 13);
            this.lblnombrepaciente.TabIndex = 10;
            this.lblnombrepaciente.Text = "Nombre";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcorreo.Location = new System.Drawing.Point(111, 147);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 9;
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdepartamento.Location = new System.Drawing.Point(111, 249);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtdepartamento.TabIndex = 8;
            // 
            // txtpiso
            // 
            this.txtpiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpiso.Location = new System.Drawing.Point(83, 225);
            this.txtpiso.Name = "txtpiso";
            this.txtpiso.Size = new System.Drawing.Size(100, 20);
            this.txtpiso.TabIndex = 7;
            // 
            // txtcalle
            // 
            this.txtcalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcalle.Location = new System.Drawing.Point(83, 173);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(100, 20);
            this.txtcalle.TabIndex = 6;
            // 
            // txtaltura
            // 
            this.txtaltura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaltura.Location = new System.Drawing.Point(83, 199);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 5;
            // 
            // txttelefono
            // 
            this.txttelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttelefono.Location = new System.Drawing.Point(83, 121);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 4;
            // 
            // txtdnipaciente
            // 
            this.txtdnipaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdnipaciente.Location = new System.Drawing.Point(83, 69);
            this.txtdnipaciente.Name = "txtdnipaciente";
            this.txtdnipaciente.Size = new System.Drawing.Size(100, 20);
            this.txtdnipaciente.TabIndex = 2;
            // 
            // txtapellidopaciente
            // 
            this.txtapellidopaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellidopaciente.Location = new System.Drawing.Point(83, 43);
            this.txtapellidopaciente.Name = "txtapellidopaciente";
            this.txtapellidopaciente.Size = new System.Drawing.Size(100, 20);
            this.txtapellidopaciente.TabIndex = 1;
            // 
            // txtnombrepaciente
            // 
            this.txtnombrepaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombrepaciente.Location = new System.Drawing.Point(83, 17);
            this.txtnombrepaciente.Name = "txtnombrepaciente";
            this.txtnombrepaciente.Size = new System.Drawing.Size(100, 20);
            this.txtnombrepaciente.TabIndex = 0;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.paneldatospaciente);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.panelbtnaceptarpaciente);
            this.Controls.Add(this.paneldgvpacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormPacientes";
            this.Text = "FormPacientes";
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            this.paneldgvpacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).EndInit();
            this.panelbtnaceptarpaciente.ResumeLayout(false);
            this.panelbotones.ResumeLayout(false);
            this.paneldatospaciente.ResumeLayout(false);
            this.paneldatospaciente.PerformLayout();
            this.panelnuevalocalidad.ResumeLayout(false);
            this.panelnuevalocalidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldgvpacientes;
        private System.Windows.Forms.Panel panelbtnaceptarpaciente;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminarpaciente;
        private System.Windows.Forms.Button btnmodificarpaciente;
        private System.Windows.Forms.Button btnagregarpaciente;
        private System.Windows.Forms.Panel paneldatospaciente;
        private System.Windows.Forms.Label lblapellidopaciente;
        private System.Windows.Forms.Label lbldnipaciente;
        private System.Windows.Forms.Label lblfechanacpaciente;
        private System.Windows.Forms.Label lbltelefonopaciente;
        private System.Windows.Forms.Label lblcorreopaciente;
        private System.Windows.Forms.Label lblcallepaciente;
        private System.Windows.Forms.Label lblalturacalle;
        private System.Windows.Forms.Label lblpisocasa;
        private System.Windows.Forms.Label lbldeptopaciente;
        private System.Windows.Forms.Label lblnombrepaciente;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.TextBox txtpiso;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdnipaciente;
        private System.Windows.Forms.TextBox txtapellidopaciente;
        private System.Windows.Forms.TextBox txtnombrepaciente;
        private System.Windows.Forms.Panel panelnuevalocalidad;
        private System.Windows.Forms.Button btncancelarlocalidad;
        private System.Windows.Forms.Button btnguardarlocalidad;
        private System.Windows.Forms.Label lblnombrelocalidad;
        private System.Windows.Forms.Label lblcodigopostal;
        private System.Windows.Forms.TextBox txtnombrelocalidad;
        private System.Windows.Forms.TextBox txtcodigopostal;
        private System.Windows.Forms.CheckBox agregarlocalidad;
        private System.Windows.Forms.Label lbllocalidad;
        private System.Windows.Forms.ComboBox cblocalidades;
        private System.Windows.Forms.DataGridView dgvpacientes;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Button btnsalir;
    }
}