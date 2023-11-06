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
            this.paneldatospaciente = new System.Windows.Forms.Panel();
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
            this.panelbtnaceptarpaciente = new System.Windows.Forms.Panel();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.paneldgvpacientes = new System.Windows.Forms.Panel();
            this.dgvpacientes = new System.Windows.Forms.DataGridView();
            this.panelnuevalocalidad = new System.Windows.Forms.Panel();
            this.btncancelarservicio = new System.Windows.Forms.Button();
            this.btnguardarservicio = new System.Windows.Forms.Button();
            this.lblnombreservicio = new System.Windows.Forms.Label();
            this.txtnombreservicio = new System.Windows.Forms.TextBox();
            this.lblserviciomedico = new System.Windows.Forms.Label();
            this.cblocalidades = new System.Windows.Forms.ComboBox();
            this.paneldatospaciente.SuspendLayout();
            this.panelbotones.SuspendLayout();
            this.panelbtnaceptarpaciente.SuspendLayout();
            this.paneldgvpacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).BeginInit();
            this.panelnuevalocalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldatospaciente
            // 
            this.paneldatospaciente.Controls.Add(this.lblserviciomedico);
            this.paneldatospaciente.Controls.Add(this.cblocalidades);
            this.paneldatospaciente.Controls.Add(this.panelnuevalocalidad);
            this.paneldatospaciente.Controls.Add(this.agregarservicio);
            this.paneldatospaciente.Controls.Add(this.lblapellidomedico);
            this.paneldatospaciente.Controls.Add(this.lblmatriculamedico);
            this.paneldatospaciente.Controls.Add(this.lblnombremedico);
            this.paneldatospaciente.Controls.Add(this.txtmatriculamedico);
            this.paneldatospaciente.Controls.Add(this.txtapellidomedico);
            this.paneldatospaciente.Controls.Add(this.txtnombremedico);
            this.paneldatospaciente.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatospaciente.Location = new System.Drawing.Point(367, 0);
            this.paneldatospaciente.Name = "paneldatospaciente";
            this.paneldatospaciente.Size = new System.Drawing.Size(214, 417);
            this.paneldatospaciente.TabIndex = 7;
            this.paneldatospaciente.Visible = false;
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
            this.btneliminar.Location = new System.Drawing.Point(174, 18);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(79, 39);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(89, 18);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(79, 39);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(3, 18);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(80, 39);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // panelbtnaceptarpaciente
            // 
            this.panelbtnaceptarpaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbtnaceptarpaciente.Controls.Add(this.btnaceptar);
            this.panelbtnaceptarpaciente.Location = new System.Drawing.Point(236, 359);
            this.panelbtnaceptarpaciente.Name = "panelbtnaceptarpaciente";
            this.panelbtnaceptarpaciente.Size = new System.Drawing.Size(123, 58);
            this.panelbtnaceptarpaciente.TabIndex = 5;
            this.panelbtnaceptarpaciente.Visible = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Location = new System.Drawing.Point(20, 16);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(78, 30);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // paneldgvpacientes
            // 
            this.paneldgvpacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvpacientes.Controls.Add(this.dgvpacientes);
            this.paneldgvpacientes.Location = new System.Drawing.Point(1, 38);
            this.paneldgvpacientes.Name = "paneldgvpacientes";
            this.paneldgvpacientes.Size = new System.Drawing.Size(346, 248);
            this.paneldgvpacientes.TabIndex = 4;
            // 
            // dgvpacientes
            // 
            this.dgvpacientes.AllowUserToAddRows = false;
            this.dgvpacientes.AllowUserToDeleteRows = false;
            this.dgvpacientes.AllowUserToResizeColumns = false;
            this.dgvpacientes.AllowUserToResizeRows = false;
            this.dgvpacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpacientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvpacientes.MultiSelect = false;
            this.dgvpacientes.Name = "dgvpacientes";
            this.dgvpacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpacientes.Size = new System.Drawing.Size(346, 248);
            this.dgvpacientes.TabIndex = 5;
            // 
            // panelnuevalocalidad
            // 
            this.panelnuevalocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelnuevalocalidad.Controls.Add(this.btncancelarservicio);
            this.panelnuevalocalidad.Controls.Add(this.btnguardarservicio);
            this.panelnuevalocalidad.Controls.Add(this.lblnombreservicio);
            this.panelnuevalocalidad.Controls.Add(this.txtnombreservicio);
            this.panelnuevalocalidad.Location = new System.Drawing.Point(9, 192);
            this.panelnuevalocalidad.Name = "panelnuevalocalidad";
            this.panelnuevalocalidad.Size = new System.Drawing.Size(201, 94);
            this.panelnuevalocalidad.TabIndex = 24;
            this.panelnuevalocalidad.Visible = false;
            // 
            // btncancelarservicio
            // 
            this.btncancelarservicio.Location = new System.Drawing.Point(111, 53);
            this.btncancelarservicio.Name = "btncancelarservicio";
            this.btncancelarservicio.Size = new System.Drawing.Size(75, 23);
            this.btncancelarservicio.TabIndex = 25;
            this.btncancelarservicio.Text = "Cancelar";
            this.btncancelarservicio.UseVisualStyleBackColor = true;
            // 
            // btnguardarservicio
            // 
            this.btnguardarservicio.Location = new System.Drawing.Point(23, 53);
            this.btnguardarservicio.Name = "btnguardarservicio";
            this.btnguardarservicio.Size = new System.Drawing.Size(75, 23);
            this.btnguardarservicio.TabIndex = 24;
            this.btnguardarservicio.Text = "Guardar";
            this.btnguardarservicio.UseVisualStyleBackColor = true;
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
            // cblocalidades
            // 
            this.cblocalidades.FormattingEnabled = true;
            this.cblocalidades.Location = new System.Drawing.Point(82, 122);
            this.cblocalidades.Name = "cblocalidades";
            this.cblocalidades.Size = new System.Drawing.Size(128, 21);
            this.cblocalidades.TabIndex = 25;
            // 
            // FormPersonalMedico
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
            this.Name = "FormPersonalMedico";
            this.Text = "FormPersonalMedico";
            this.paneldatospaciente.ResumeLayout(false);
            this.paneldatospaciente.PerformLayout();
            this.panelbotones.ResumeLayout(false);
            this.panelbtnaceptarpaciente.ResumeLayout(false);
            this.paneldgvpacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).EndInit();
            this.panelnuevalocalidad.ResumeLayout(false);
            this.panelnuevalocalidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldatospaciente;
        private System.Windows.Forms.Panel panelnuevalocalidad;
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
        private System.Windows.Forms.Panel panelbtnaceptarpaciente;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Panel paneldgvpacientes;
        private System.Windows.Forms.DataGridView dgvpacientes;
        private System.Windows.Forms.Label lblserviciomedico;
        private System.Windows.Forms.ComboBox cblocalidades;
    }
}