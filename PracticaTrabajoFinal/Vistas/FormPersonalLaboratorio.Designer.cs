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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneldatosperlab = new System.Windows.Forms.Panel();
            this.lblcategoriaperlab = new System.Windows.Forms.Label();
            this.cbcategoriaperlab = new System.Windows.Forms.ComboBox();
            this.panelnuevalocalidad = new System.Windows.Forms.Panel();
            this.btncancelarservicio = new System.Windows.Forms.Button();
            this.btnguardarservicio = new System.Windows.Forms.Button();
            this.lblnombreservicio = new System.Windows.Forms.Label();
            this.txtnombreservicio = new System.Windows.Forms.TextBox();
            this.agregarservicio = new System.Windows.Forms.CheckBox();
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.paneldgvpacientes = new System.Windows.Forms.Panel();
            this.dgvpacientes = new System.Windows.Forms.DataGridView();
            this.lblespecialidadperlab = new System.Windows.Forms.Label();
            this.cbespecialidadperlab = new System.Windows.Forms.ComboBox();
            this.paneldatosperlab.SuspendLayout();
            this.panelnuevalocalidad.SuspendLayout();
            this.panelbotones.SuspendLayout();
            this.panelbtnaceptarpaciente.SuspendLayout();
            this.paneldgvpacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldatosperlab
            // 
            this.paneldatosperlab.Controls.Add(this.lblespecialidadperlab);
            this.paneldatosperlab.Controls.Add(this.cbespecialidadperlab);
            this.paneldatosperlab.Controls.Add(this.lblcategoriaperlab);
            this.paneldatosperlab.Controls.Add(this.cbcategoriaperlab);
            this.paneldatosperlab.Controls.Add(this.panelnuevalocalidad);
            this.paneldatosperlab.Controls.Add(this.agregarservicio);
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
            this.paneldatosperlab.Visible = false;
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
            // panelnuevalocalidad
            // 
            this.panelnuevalocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelnuevalocalidad.Controls.Add(this.btncancelarservicio);
            this.panelnuevalocalidad.Controls.Add(this.btnguardarservicio);
            this.panelnuevalocalidad.Controls.Add(this.lblnombreservicio);
            this.panelnuevalocalidad.Controls.Add(this.txtnombreservicio);
            this.panelnuevalocalidad.Location = new System.Drawing.Point(9, 247);
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
            // agregarservicio
            // 
            this.agregarservicio.AutoSize = true;
            this.agregarservicio.Location = new System.Drawing.Point(91, 224);
            this.agregarservicio.Name = "agregarservicio";
            this.agregarservicio.Size = new System.Drawing.Size(104, 17);
            this.agregarservicio.TabIndex = 22;
            this.agregarservicio.Text = "Agregar Servicio";
            this.agregarservicio.UseVisualStyleBackColor = true;
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
            this.panelbtnaceptarpaciente.Location = new System.Drawing.Point(235, 359);
            this.panelbtnaceptarpaciente.Name = "panelbtnaceptarpaciente";
            this.panelbtnaceptarpaciente.Size = new System.Drawing.Size(123, 58);
            this.panelbtnaceptarpaciente.TabIndex = 9;
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
            this.paneldgvpacientes.Location = new System.Drawing.Point(0, 38);
            this.paneldgvpacientes.Name = "paneldgvpacientes";
            this.paneldgvpacientes.Size = new System.Drawing.Size(346, 248);
            this.paneldgvpacientes.TabIndex = 8;
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
            // FormPersonalLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.paneldatosperlab);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.panelbtnaceptarpaciente);
            this.Controls.Add(this.paneldgvpacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormPersonalLaboratorio";
            this.Text = "FormPersonalLaboratorio";
            this.paneldatosperlab.ResumeLayout(false);
            this.paneldatosperlab.PerformLayout();
            this.panelnuevalocalidad.ResumeLayout(false);
            this.panelnuevalocalidad.PerformLayout();
            this.panelbotones.ResumeLayout(false);
            this.panelbtnaceptarpaciente.ResumeLayout(false);
            this.paneldgvpacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldatosperlab;
        private System.Windows.Forms.Label lblespecialidadperlab;
        private System.Windows.Forms.ComboBox cbespecialidadperlab;
        private System.Windows.Forms.Label lblcategoriaperlab;
        private System.Windows.Forms.ComboBox cbcategoriaperlab;
        private System.Windows.Forms.Panel panelnuevalocalidad;
        private System.Windows.Forms.Button btncancelarservicio;
        private System.Windows.Forms.Button btnguardarservicio;
        private System.Windows.Forms.Label lblnombreservicio;
        private System.Windows.Forms.TextBox txtnombreservicio;
        private System.Windows.Forms.CheckBox agregarservicio;
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
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Panel paneldgvpacientes;
        private System.Windows.Forms.DataGridView dgvpacientes;
    }
}