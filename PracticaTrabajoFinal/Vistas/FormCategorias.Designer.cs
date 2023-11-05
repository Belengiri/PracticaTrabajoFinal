namespace PracticaTrabajoFinal.Vistas
{
    partial class FormCategorias
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
            this.panelbotones = new System.Windows.Forms.Panel();
            this.btneliminarcategoria = new System.Windows.Forms.Button();
            this.btnmodificarcategoria = new System.Windows.Forms.Button();
            this.btnagregarcategoria = new System.Windows.Forms.Button();
            this.paneldatoscategoria = new System.Windows.Forms.Panel();
            this.btnaceptarcategoria = new System.Windows.Forms.Button();
            this.lblnombrecategoria = new System.Windows.Forms.Label();
            this.txtnombrecategoria = new System.Windows.Forms.TextBox();
            this.paneldgvcategoria = new System.Windows.Forms.Panel();
            this.dgvcategoria = new System.Windows.Forms.DataGridView();
            this.panelbotones.SuspendLayout();
            this.paneldatoscategoria.SuspendLayout();
            this.paneldgvcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbotones
            // 
            this.panelbotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelbotones.Controls.Add(this.btneliminarcategoria);
            this.panelbotones.Controls.Add(this.btnmodificarcategoria);
            this.panelbotones.Controls.Add(this.btnagregarcategoria);
            this.panelbotones.Location = new System.Drawing.Point(9, 279);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(294, 66);
            this.panelbotones.TabIndex = 9;
            // 
            // btneliminarcategoria
            // 
            this.btneliminarcategoria.Location = new System.Drawing.Point(191, 0);
            this.btneliminarcategoria.Name = "btneliminarcategoria";
            this.btneliminarcategoria.Size = new System.Drawing.Size(88, 34);
            this.btneliminarcategoria.TabIndex = 2;
            this.btneliminarcategoria.Text = "Eliminar";
            this.btneliminarcategoria.UseVisualStyleBackColor = true;
            this.btneliminarcategoria.Click += new System.EventHandler(this.btneliminarcategoria_Click);
            // 
            // btnmodificarcategoria
            // 
            this.btnmodificarcategoria.Location = new System.Drawing.Point(97, 0);
            this.btnmodificarcategoria.Name = "btnmodificarcategoria";
            this.btnmodificarcategoria.Size = new System.Drawing.Size(88, 34);
            this.btnmodificarcategoria.TabIndex = 1;
            this.btnmodificarcategoria.Text = "Modificar";
            this.btnmodificarcategoria.UseVisualStyleBackColor = true;
            this.btnmodificarcategoria.Click += new System.EventHandler(this.btnmodificarcategoria_Click);
            // 
            // btnagregarcategoria
            // 
            this.btnagregarcategoria.Location = new System.Drawing.Point(3, 0);
            this.btnagregarcategoria.Name = "btnagregarcategoria";
            this.btnagregarcategoria.Size = new System.Drawing.Size(88, 34);
            this.btnagregarcategoria.TabIndex = 0;
            this.btnagregarcategoria.Text = "Agregar";
            this.btnagregarcategoria.UseVisualStyleBackColor = true;
            this.btnagregarcategoria.Click += new System.EventHandler(this.btnagregarcategoria_Click);
            // 
            // paneldatoscategoria
            // 
            this.paneldatoscategoria.Controls.Add(this.btnaceptarcategoria);
            this.paneldatoscategoria.Controls.Add(this.lblnombrecategoria);
            this.paneldatoscategoria.Controls.Add(this.txtnombrecategoria);
            this.paneldatoscategoria.Location = new System.Drawing.Point(327, 0);
            this.paneldatoscategoria.Name = "paneldatoscategoria";
            this.paneldatoscategoria.Size = new System.Drawing.Size(242, 417);
            this.paneldatoscategoria.TabIndex = 8;
            this.paneldatoscategoria.Visible = false;
            // 
            // btnaceptarcategoria
            // 
            this.btnaceptarcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptarcategoria.Location = new System.Drawing.Point(68, 361);
            this.btnaceptarcategoria.Name = "btnaceptarcategoria";
            this.btnaceptarcategoria.Size = new System.Drawing.Size(98, 41);
            this.btnaceptarcategoria.TabIndex = 5;
            this.btnaceptarcategoria.Text = "Aceptar";
            this.btnaceptarcategoria.UseVisualStyleBackColor = true;
            this.btnaceptarcategoria.Click += new System.EventHandler(this.btnaceptarcategoria_Click);
            // 
            // lblnombrecategoria
            // 
            this.lblnombrecategoria.AutoSize = true;
            this.lblnombrecategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrecategoria.Location = new System.Drawing.Point(29, 27);
            this.lblnombrecategoria.MinimumSize = new System.Drawing.Size(133, 13);
            this.lblnombrecategoria.Name = "lblnombrecategoria";
            this.lblnombrecategoria.Size = new System.Drawing.Size(133, 20);
            this.lblnombrecategoria.TabIndex = 3;
            this.lblnombrecategoria.Text = "Categoria ";
            // 
            // txtnombrecategoria
            // 
            this.txtnombrecategoria.Location = new System.Drawing.Point(18, 50);
            this.txtnombrecategoria.Name = "txtnombrecategoria";
            this.txtnombrecategoria.Size = new System.Drawing.Size(193, 20);
            this.txtnombrecategoria.TabIndex = 4;
            // 
            // paneldgvcategoria
            // 
            this.paneldgvcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldgvcategoria.Controls.Add(this.dgvcategoria);
            this.paneldgvcategoria.Location = new System.Drawing.Point(6, 12);
            this.paneldgvcategoria.Name = "paneldgvcategoria";
            this.paneldgvcategoria.Size = new System.Drawing.Size(321, 261);
            this.paneldgvcategoria.TabIndex = 7;
            // 
            // dgvcategoria
            // 
            this.dgvcategoria.AllowUserToAddRows = false;
            this.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcategoria.Location = new System.Drawing.Point(0, 0);
            this.dgvcategoria.Name = "dgvcategoria";
            this.dgvcategoria.Size = new System.Drawing.Size(321, 261);
            this.dgvcategoria.TabIndex = 11;
            this.dgvcategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategoria_CellContentClick);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.paneldatoscategoria);
            this.Controls.Add(this.paneldgvcategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(581, 417);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.panelbotones.ResumeLayout(false);
            this.paneldatoscategoria.ResumeLayout(false);
            this.paneldatoscategoria.PerformLayout();
            this.paneldgvcategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.Button btneliminarcategoria;
        private System.Windows.Forms.Button btnmodificarcategoria;
        private System.Windows.Forms.Button btnagregarcategoria;
        private System.Windows.Forms.Panel paneldatoscategoria;
        private System.Windows.Forms.Button btnaceptarcategoria;
        private System.Windows.Forms.Label lblnombrecategoria;
        private System.Windows.Forms.TextBox txtnombrecategoria;
        private System.Windows.Forms.Panel paneldgvcategoria;
        private System.Windows.Forms.DataGridView dgvcategoria;
    }
}