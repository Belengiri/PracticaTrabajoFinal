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
            this.paneldgvingresos = new System.Windows.Forms.Panel();
            this.panelbtingresos = new System.Windows.Forms.Panel();
            this.dgvingresos = new System.Windows.Forms.DataGridView();
            this.btneliminarespecialidad = new System.Windows.Forms.Button();
            this.btnmodificarespecialidad = new System.Windows.Forms.Button();
            this.btnagregarespecialidad = new System.Windows.Forms.Button();
            this.labelfechaingresos = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelretiroingresos = new System.Windows.Forms.Label();
            this.paneldatosingresos.SuspendLayout();
            this.paneldgvingresos.SuspendLayout();
            this.panelbtingresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvingresos)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldatosingresos
            // 
            this.paneldatosingresos.Controls.Add(this.dateTimePicker2);
            this.paneldatosingresos.Controls.Add(this.labelretiroingresos);
            this.paneldatosingresos.Controls.Add(this.dateTimePicker1);
            this.paneldatosingresos.Controls.Add(this.labelfechaingresos);
            this.paneldatosingresos.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldatosingresos.Location = new System.Drawing.Point(559, 0);
            this.paneldatosingresos.Name = "paneldatosingresos";
            this.paneldatosingresos.Size = new System.Drawing.Size(313, 642);
            this.paneldatosingresos.TabIndex = 0;
            // 
            // paneldgvingresos
            // 
            this.paneldgvingresos.Controls.Add(this.dgvingresos);
            this.paneldgvingresos.Location = new System.Drawing.Point(12, 12);
            this.paneldgvingresos.Name = "paneldgvingresos";
            this.paneldgvingresos.Size = new System.Drawing.Size(541, 447);
            this.paneldgvingresos.TabIndex = 1;
            // 
            // panelbtingresos
            // 
            this.panelbtingresos.Controls.Add(this.btneliminarespecialidad);
            this.panelbtingresos.Controls.Add(this.btnmodificarespecialidad);
            this.panelbtingresos.Controls.Add(this.btnagregarespecialidad);
            this.panelbtingresos.Location = new System.Drawing.Point(12, 495);
            this.panelbtingresos.Name = "panelbtingresos";
            this.panelbtingresos.Size = new System.Drawing.Size(541, 81);
            this.panelbtingresos.TabIndex = 2;
            // 
            // dgvingresos
            // 
            this.dgvingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvingresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvingresos.Location = new System.Drawing.Point(0, 0);
            this.dgvingresos.Name = "dgvingresos";
            this.dgvingresos.RowHeadersWidth = 62;
            this.dgvingresos.RowTemplate.Height = 28;
            this.dgvingresos.Size = new System.Drawing.Size(541, 447);
            this.dgvingresos.TabIndex = 0;
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
            this.labelfechaingresos.Location = new System.Drawing.Point(3, 71);
            this.labelfechaingresos.Name = "labelfechaingresos";
            this.labelfechaingresos.Size = new System.Drawing.Size(132, 20);
            this.labelfechaingresos.TabIndex = 0;
            this.labelfechaingresos.Text = "Fecha de ingreso";
            this.labelfechaingresos.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(7, 303);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // labelretiroingresos
            // 
            this.labelretiroingresos.AutoSize = true;
            this.labelretiroingresos.Location = new System.Drawing.Point(3, 242);
            this.labelretiroingresos.Name = "labelretiroingresos";
            this.labelretiroingresos.Size = new System.Drawing.Size(116, 20);
            this.labelretiroingresos.TabIndex = 2;
            this.labelretiroingresos.Text = "Fecha de retiro";
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 642);
            this.Controls.Add(this.panelbtingresos);
            this.Controls.Add(this.paneldgvingresos);
            this.Controls.Add(this.paneldatosingresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(872, 642);
            this.Name = "FormIngresos";
            this.Text = "FormIngresos";
            this.paneldatosingresos.ResumeLayout(false);
            this.paneldatosingresos.PerformLayout();
            this.paneldgvingresos.ResumeLayout(false);
            this.panelbtingresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvingresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldatosingresos;
        private System.Windows.Forms.Panel paneldgvingresos;
        private System.Windows.Forms.DataGridView dgvingresos;
        private System.Windows.Forms.Panel panelbtingresos;
        private System.Windows.Forms.Label labelfechaingresos;
        private System.Windows.Forms.Button btneliminarespecialidad;
        private System.Windows.Forms.Button btnmodificarespecialidad;
        private System.Windows.Forms.Button btnagregarespecialidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelretiroingresos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}