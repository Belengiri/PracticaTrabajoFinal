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
            this.panelbtingresos = new System.Windows.Forms.Panel();
            this.btneliminarespecialidad = new System.Windows.Forms.Button();
            this.btnmodificarespecialidad = new System.Windows.Forms.Button();
            this.btnagregarespecialidad = new System.Windows.Forms.Button();
            this.labelfechaingresos = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelretiroingresos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paneldatosingresos.SuspendLayout();
            this.panelbtingresos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldatosingresos
            // 
            this.paneldatosingresos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.paneldatosingresos.Controls.Add(this.comboBox1);
            this.paneldatosingresos.Controls.Add(this.checkedListBox1);
            this.paneldatosingresos.Controls.Add(this.dateTimePicker2);
            this.paneldatosingresos.Controls.Add(this.labelretiroingresos);
            this.paneldatosingresos.Controls.Add(this.dateTimePicker1);
            this.paneldatosingresos.Controls.Add(this.labelfechaingresos);
            this.paneldatosingresos.Location = new System.Drawing.Point(559, 12);
            this.paneldatosingresos.Name = "paneldatosingresos";
            this.paneldatosingresos.Size = new System.Drawing.Size(313, 625);
            this.paneldatosingresos.TabIndex = 0;
            // 
            // panelbtingresos
            // 
            this.panelbtingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbtingresos.Controls.Add(this.button1);
            this.panelbtingresos.Controls.Add(this.btneliminarespecialidad);
            this.panelbtingresos.Controls.Add(this.btnmodificarespecialidad);
            this.panelbtingresos.Controls.Add(this.btnagregarespecialidad);
            this.panelbtingresos.Location = new System.Drawing.Point(12, 498);
            this.panelbtingresos.Name = "panelbtingresos";
            this.panelbtingresos.Size = new System.Drawing.Size(541, 139);
            this.panelbtingresos.TabIndex = 2;
            // 
            // btneliminarespecialidad
            // 
            this.btneliminarespecialidad.Location = new System.Drawing.Point(345, 14);
            this.btneliminarespecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminarespecialidad.Name = "btneliminarespecialidad";
            this.btneliminarespecialidad.Size = new System.Drawing.Size(132, 52);
            this.btneliminarespecialidad.TabIndex = 5;
            this.btneliminarespecialidad.Text = "Eliminar";
            this.btneliminarespecialidad.UseVisualStyleBackColor = true;
            // 
            // btnmodificarespecialidad
            // 
            this.btnmodificarespecialidad.Location = new System.Drawing.Point(205, 14);
            this.btnmodificarespecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmodificarespecialidad.Name = "btnmodificarespecialidad";
            this.btnmodificarespecialidad.Size = new System.Drawing.Size(132, 52);
            this.btnmodificarespecialidad.TabIndex = 4;
            this.btnmodificarespecialidad.Text = "Modificar";
            this.btnmodificarespecialidad.UseVisualStyleBackColor = true;
            // 
            // btnagregarespecialidad
            // 
            this.btnagregarespecialidad.Location = new System.Drawing.Point(63, 14);
            this.btnagregarespecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregarespecialidad.Name = "btnagregarespecialidad";
            this.btnagregarespecialidad.Size = new System.Drawing.Size(132, 52);
            this.btnagregarespecialidad.TabIndex = 3;
            this.btnagregarespecialidad.Text = "Agregar";
            this.btnagregarespecialidad.UseVisualStyleBackColor = true;
            // 
            // labelfechaingresos
            // 
            this.labelfechaingresos.AutoSize = true;
            this.labelfechaingresos.Location = new System.Drawing.Point(3, 419);
            this.labelfechaingresos.Name = "labelfechaingresos";
            this.labelfechaingresos.Size = new System.Drawing.Size(132, 20);
            this.labelfechaingresos.TabIndex = 0;
            this.labelfechaingresos.Text = "Fecha de ingreso";
            this.labelfechaingresos.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 442);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(7, 507);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // labelretiroingresos
            // 
            this.labelretiroingresos.AutoSize = true;
            this.labelretiroingresos.Location = new System.Drawing.Point(3, 484);
            this.labelretiroingresos.Name = "labelretiroingresos";
            this.labelretiroingresos.Size = new System.Drawing.Size(116, 20);
            this.labelretiroingresos.TabIndex = 2;
            this.labelretiroingresos.Text = "Fecha de retiro";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 480);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(541, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cancer",
            "Corte",
            "Fractura",
            "Hemorragia",
            "Infección",
            "Infección",
            "Ser Negro",
            "Ser Peruano"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 293);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(294, 96);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbtingresos);
            this.Controls.Add(this.paneldatosingresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(872, 642);
            this.Name = "FormIngresos";
            this.Text = "FormIngresos";
            this.paneldatosingresos.ResumeLayout(false);
            this.paneldatosingresos.PerformLayout();
            this.panelbtingresos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldatosingresos;
        private System.Windows.Forms.Panel panelbtingresos;
        private System.Windows.Forms.Label labelfechaingresos;
        private System.Windows.Forms.Button btneliminarespecialidad;
        private System.Windows.Forms.Button btnmodificarespecialidad;
        private System.Windows.Forms.Button btnagregarespecialidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelretiroingresos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}