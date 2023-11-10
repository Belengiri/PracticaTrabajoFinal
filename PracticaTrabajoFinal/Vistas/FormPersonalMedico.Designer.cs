namespace PracticaTrabajoFinal.Vistas
{
    partial class FormPersonalMedico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneldatosmedico = new System.Windows.Forms.Panel();
            this.btnsalirvista = new System.Windows.Forms.Button();
            this.lblserviciomedico = new System.Windows.Forms.Label();
            this.cbservicio = new System.Windows.Forms.ComboBox();
            this.panelnuevoservicio = new System.Windows.Forms.Panel();
            this.btncancelarservicio = new System.Windows.Forms.Button();
            this.btnguardarservicio = new System.Windows.Forms.Button();
            this.lblnombreservicio = new System.Windows.Forms.Label();
            this.txtnombreservicio = new System.Windows.Forms.TextBox();
            this.agregarservicio = new System.Windows.Forms.CheckBox();
            this.lblapellidomedico = new System.Windows.Forms.Label();
            this.lblmatriculamedico = new System.Windows.Forms.Label();
            this.lblnombremedico = new System.Windows.Forms.Label();
            this.txtmatriculamedico = new System.Windows.Forms.TextBox();
            this.txtapellidomedico = new System.Windows.Forms.TextBox();
            this.txtnombremedico = new System.Windows.Forms.TextBox();
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.panelbtnaceptar = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.paneldgvmedicos = new System.Windows.Forms.Panel();
            this.dgvpmedicos = new System.Windows.Forms.DataGridView();
            this.paneldatosmedico.SuspendLayout();
            this.panelnuevoservicio.SuspendLayout();
            this.panelbotones.SuspendLayout();
            this.panelbtnaceptar.SuspendLayout();
            this.paneldgvmedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpmedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldatosmedico
            // 
            this.paneldatosmedico.Controls.Add(this.btnsalirvista);
            this.paneldatosmedico.Controls.Add(this.lblserviciomedico);
            this.paneldatosmedico.Controls.Add(this.cbservicio);
            this.paneldatosmedico.Controls.Add(this.panelnuevoservicio);
            this.paneldatosmedico.Controls.Add(this.agregarservicio);
            this.paneldatosmedico.Controls.Add(this.lblapellidomedico);
            this.paneldatosmedico.Controls.Add(this.lblmatriculamedico);
            this.paneldatosmedico.Controls.Add(this.lblnombremedico);
            this.paneldatosmedico.Controls.Add(this.txtmatriculamedico);
            this.paneldatosmedico.Controls.Add(this.txtapellidomedico);
            this.paneldatosmedico.Controls.Add(this.txtnombremedico);
            this.paneldatosmedico.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatosmedico.Location = new System.Drawing.Point(367, 0);
            this.paneldatosmedico.Name = "paneldatosmedico";
            this.paneldatosmedico.Size = new System.Drawing.Size(214, 417);
            this.paneldatosmedico.TabIndex = 7;
            // 
            // btnsalirvista
            // 
            this.btnsalirvista.BackColor = System.Drawing.Color.Red;
            this.btnsalirvista.Location = new System.Drawing.Point(180, 3);
            this.btnsalirvista.Name = "btnsalirvista";
            this.btnsalirvista.Size = new System.Drawing.Size(27, 23);
            this.btnsalirvista.TabIndex = 8;
            this.btnsalirvista.Text = "X";
            this.btnsalirvista.UseVisualStyleBackColor = false;
            this.btnsalirvista.Click += new System.EventHandler(this.btnsalirvista_Click);
            // 
            // lblserviciomedico
            // 
            this.lblserviciomedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblserviciomedico.AutoSize = true;
            this.lblserviciomedico.Location = new System.Drawing.Point(6, 125);
            this.lblserviciomedico.Name = "lblserviciomedico";
            this.lblserviciomedico.Size = new System.Drawing.Size(45, 13);
            this.lblserviciomedico.TabIndex = 26;
            this.lblserviciomedico.Text = "Servicio";
            // 
            // cbservicio
            // 
            this.cbservicio.FormattingEnabled = true;
            this.cbservicio.Location = new System.Drawing.Point(82, 122);
            this.cbservicio.Name = "cbservicio";
            this.cbservicio.Size = new System.Drawing.Size(128, 21);
            this.cbservicio.TabIndex = 25;
            // 
            // panelnuevoservicio
            // 
            this.panelnuevoservicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelnuevoservicio.Controls.Add(this.btncancelarservicio);
            this.panelnuevoservicio.Controls.Add(this.btnguardarservicio);
            this.panelnuevoservicio.Controls.Add(this.lblnombreservicio);
            this.panelnuevoservicio.Controls.Add(this.txtnombreservicio);
            this.panelnuevoservicio.Location = new System.Drawing.Point(9, 192);
            this.panelnuevoservicio.Name = "panelnuevoservicio";
            this.panelnuevoservicio.Size = new System.Drawing.Size(201, 94);
            this.panelnuevoservicio.TabIndex = 24;
            this.panelnuevoservicio.Visible = false;
            // 
            // btncancelarservicio
            // 
            this.btncancelarservicio.Location = new System.Drawing.Point(111, 53);
            this.btncancelarservicio.Name = "btncancelarservicio";
            this.btncancelarservicio.Size = new System.Drawing.Size(75, 23);
            this.btncancelarservicio.TabIndex = 25;
            this.btncancelarservicio.Text = "Cancelar";
            this.btncancelarservicio.UseVisualStyleBackColor = true;
            this.btncancelarservicio.Click += new System.EventHandler(this.btncancelarservicio_Click);
            // 
            // btnguardarservicio
            // 
            this.btnguardarservicio.Location = new System.Drawing.Point(23, 53);
            this.btnguardarservicio.Name = "btnguardarservicio";
            this.btnguardarservicio.Size = new System.Drawing.Size(75, 23);
            this.btnguardarservicio.TabIndex = 24;
            this.btnguardarservicio.Text = "Guardar";
            this.btnguardarservicio.UseVisualStyleBackColor = true;
            this.btnguardarservicio.Click += new System.EventHandler(this.btnguardarservicio_Click);
            // 
            // lblnombreservicio
            // 
            this.lblnombreservicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombreservicio.AutoSize = true;
            this.lblnombreservicio.Location = new System.Drawing.Point(3, 10);
            this.lblnombreservicio.Name = "lblnombreservicio";
            this.lblnombreservicio.Size = new System.Drawing.Size(85, 13);
            this.lblnombreservicio.TabIndex = 23;
            this.lblnombreservicio.Text = "Nombre Servicio";
            // 
            // txtnombreservicio
            // 
            this.txtnombreservicio.Location = new System.Drawing.Point(98, 3);
            this.txtnombreservicio.Name = "txtnombreservicio";
            this.txtnombreservicio.Size = new System.Drawing.Size(100, 20);
            this.txtnombreservicio.TabIndex = 1;
            // 
            // agregarservicio
            // 
            this.agregarservicio.AutoSize = true;
            this.agregarservicio.Location = new System.Drawing.Point(83, 160);
            this.agregarservicio.Name = "agregarservicio";
            this.agregarservicio.Size = new System.Drawing.Size(104, 17);
            this.agregarservicio.TabIndex = 22;
            this.agregarservicio.Text = "Agregar Servicio";
            this.agregarservicio.UseVisualStyleBackColor = true;
            this.agregarservicio.CheckedChanged += new System.EventHandler(this.agregarservicio_CheckedChanged);
            // 
            // lblapellidomedico
            // 
            this.lblapellidomedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblapellidomedico.AutoSize = true;
            this.lblapellidomedico.Location = new System.Drawing.Point(15, 73);
            this.lblapellidomedico.Name = "lblapellidomedico";
            this.lblapellidomedico.Size = new System.Drawing.Size(44, 13);
            this.lblapellidomedico.TabIndex = 19;
            this.lblapellidomedico.Text = "Apellido";
            // 
            // lblmatriculamedico
            // 
            this.lblmatriculamedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmatriculamedico.AutoSize = true;
            this.lblmatriculamedico.Location = new System.Drawing.Point(15, 99);
            this.lblmatriculamedico.Name = "lblmatriculamedico";
            this.lblmatriculamedico.Size = new System.Drawing.Size(50, 13);
            this.lblmatriculamedico.TabIndex = 18;
            this.lblmatriculamedico.Text = "Matricula";
            // 
            // lblnombremedico
            // 
            this.lblnombremedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombremedico.AutoSize = true;
            this.lblnombremedico.Location = new System.Drawing.Point(15, 47);
            this.lblnombremedico.Name = "lblnombremedico";
            this.lblnombremedico.Size = new System.Drawing.Size(44, 13);
            this.lblnombremedico.TabIndex = 10;
            this.lblnombremedico.Text = "Nombre";
            // 
            // txtmatriculamedico
            // 
            this.txtmatriculamedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatriculamedico.Location = new System.Drawing.Point(95, 92);
            this.txtmatriculamedico.Name = "txtmatriculamedico";
            this.txtmatriculamedico.Size = new System.Drawing.Size(100, 20);
            this.txtmatriculamedico.TabIndex = 2;
            // 
            // txtapellidomedico
            // 
            this.txtapellidomedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellidomedico.Location = new System.Drawing.Point(95, 66);
            this.txtapellidomedico.Name = "txtapellidomedico";
            this.txtapellidomedico.Size = new System.Drawing.Size(100, 20);
            this.txtapellidomedico.TabIndex = 1;
            // 
            // txtnombremedico
            // 
            this.txtnombremedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombremedico.Location = new System.Drawing.Point(95, 40);
            this.txtnombremedico.Name = "txtnombremedico";
            this.txtnombremedico.Size = new System.Drawing.Size(100, 20);
            this.txtnombremedico.TabIndex = 0;
            // 
            // panelbotones
            // 
            this.panelbotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotones.Controls.Add(this.btneliminar);
            this.panelbotones.Controls.Add(this.btnmodificar);
            this.panelbotones.Controls.Add(this.btnagregar);
            this.panelbotones.Location = new System.Drawing.Point(1, 293);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(266, 60);
            this.panelbotones.TabIndex = 6;
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
            // panelbtnaceptar
            // 
            this.panelbtnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbtnaceptar.Controls.Add(this.btncancelar);
            this.panelbtnaceptar.Location = new System.Drawing.Point(260, 359);
            this.panelbtnaceptar.Name = "panelbtnaceptar";
            this.panelbtnaceptar.Size = new System.Drawing.Size(99, 58);
            this.panelbtnaceptar.TabIndex = 5;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(11, 16);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 30);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // paneldgvmedicos
            // 
            this.paneldgvmedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvmedicos.Controls.Add(this.dgvpmedicos);
            this.paneldgvmedicos.Location = new System.Drawing.Point(1, 38);
            this.paneldgvmedicos.Name = "paneldgvmedicos";
            this.paneldgvmedicos.Size = new System.Drawing.Size(346, 248);
            this.paneldgvmedicos.TabIndex = 4;
            // 
            // dgvpmedicos
            // 
            this.dgvpmedicos.AllowUserToAddRows = false;
            this.dgvpmedicos.AllowUserToDeleteRows = false;
            this.dgvpmedicos.AllowUserToResizeColumns = false;
            this.dgvpmedicos.AllowUserToResizeRows = false;
            this.dgvpmedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpmedicos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpmedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpmedicos.Location = new System.Drawing.Point(0, 0);
            this.dgvpmedicos.MultiSelect = false;
            this.dgvpmedicos.Name = "dgvpmedicos";
            this.dgvpmedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpmedicos.Size = new System.Drawing.Size(346, 248);
            this.dgvpmedicos.TabIndex = 6;
            this.dgvpmedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpmedicos_CellClick);
            // 
            // FormPersonalMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.paneldatosmedico);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.panelbtnaceptar);
            this.Controls.Add(this.paneldgvmedicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 150);
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormPersonalMedico";
            this.Text = "FormPersonalMedico";
            this.paneldatosmedico.ResumeLayout(false);
            this.paneldatosmedico.PerformLayout();
            this.panelnuevoservicio.ResumeLayout(false);
            this.panelnuevoservicio.PerformLayout();
            this.panelbotones.ResumeLayout(false);
            this.panelbtnaceptar.ResumeLayout(false);
            this.paneldgvmedicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpmedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldatosmedico;
        private System.Windows.Forms.Panel panelnuevoservicio;
        private System.Windows.Forms.Button btncancelarservicio;
        private System.Windows.Forms.Button btnguardarservicio;
        private System.Windows.Forms.Label lblnombreservicio;
        private System.Windows.Forms.TextBox txtnombreservicio;
        private System.Windows.Forms.CheckBox agregarservicio;
        private System.Windows.Forms.Label lblapellidomedico;
        private System.Windows.Forms.Label lblmatriculamedico;
        private System.Windows.Forms.Label lblnombremedico;
        private System.Windows.Forms.TextBox txtmatriculamedico;
        private System.Windows.Forms.TextBox txtapellidomedico;
        private System.Windows.Forms.TextBox txtnombremedico;
        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Panel panelbtnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel paneldgvmedicos;
        private System.Windows.Forms.Label lblserviciomedico;
        private System.Windows.Forms.ComboBox cbservicio;
        private System.Windows.Forms.DataGridView dgvpmedicos;
        private System.Windows.Forms.Button btnsalirvista;
    }
}