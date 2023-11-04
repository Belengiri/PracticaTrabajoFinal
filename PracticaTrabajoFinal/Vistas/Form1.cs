using PracticaTrabajoFinal.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal
{
    public partial class Laboratorio : Form
    {
        public Laboratorio()
        {
            InitializeComponent();
            abrirform(new Inicio());
        }

        private void btnpaciente_Click(object sender, EventArgs e)
        {
            abrirform(new FormPacientes());
            btnpaciente.BackColor = SystemColors.Window;
            btningresos.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.BackColor = SystemColors.ActiveCaption;
            btnpersonalmedico.BackColor = SystemColors.ActiveCaption;
            btnpersonallaboratorio.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnespecialidades.BackColor = SystemColors.ActiveCaption;
            btnpracticas.BackColor = SystemColors.ActiveCaption;
            btnpersonalporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnpracticasporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.Visible = false;
            btnpersonalmedico.Visible = false;
            btnpersonallaboratorio.Visible = false;
            btncategorias.Visible = false;
            btnespecialidades.Visible = false;
            btnpracticas.Visible = false;
            btnpersonalporespecialidad.Visible = false;
            btnpracticasporespecialidad.Visible = false;

        }
        public void abrirform(object form)
        {
            if (panelcontenedor.Controls.Count>0)
            {
                this.panelcontenedor.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock=DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void btningresos_Click(object sender, EventArgs e)
        {
            abrirform(new FormIngresos());
            btningresos.BackColor = SystemColors.Window;
            btnpaciente.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.BackColor = SystemColors.ActiveCaption;
            btnpersonalmedico.BackColor = SystemColors.ActiveCaption;
            btnpersonallaboratorio.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnespecialidades.BackColor = SystemColors.ActiveCaption;
            btnpracticas.BackColor = SystemColors.ActiveCaption;
            btnpersonalporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnpracticasporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.Visible = false;
            btnpersonalmedico.Visible = false;
            btnpersonallaboratorio.Visible = false;
            btncategorias.Visible = false;
            btnespecialidades.Visible = false;
            btnpracticas.Visible = false;
            btnpersonalporespecialidad.Visible = false;
            btnpracticasporespecialidad.Visible = false;

        }

        private void btnlaboratorio_Click(object sender, EventArgs e)
        {
            btningresos.BackColor = SystemColors.ActiveCaption;
            btnpaciente.BackColor = SystemColors.ActiveCaption;
            btnpersonalmedico.BackColor = SystemColors.ActiveCaption;
            btnpersonallaboratorio.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnespecialidades.BackColor = SystemColors.ActiveCaption;
            btnpracticas.BackColor = SystemColors.ActiveCaption;
            btnpersonalporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnpracticasporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.Visible = true;
            btnpersonalmedico.Visible = true;
            btnpersonallaboratorio.Visible = true;
            btncategorias.Visible = true;
            btnespecialidades.Visible = true;
            btnpracticas.Visible = true;
            btnpersonalporespecialidad.Visible = true;
            btnpracticasporespecialidad.Visible = true;
        }

        private void btnpersonalmedico_Click(object sender, EventArgs e)
        {
            abrirform(new FormPersonalMedico());
            btnpersonalmedico.BackColor = SystemColors.Window;
            btningresos.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.BackColor = SystemColors.ActiveCaption;
            btnpaciente.BackColor = SystemColors.ActiveCaption;
            btnpersonallaboratorio.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnespecialidades.BackColor = SystemColors.ActiveCaption;
            btnpracticas.BackColor = SystemColors.ActiveCaption;
            btnpersonalporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnpracticasporespecialidad.BackColor = SystemColors.ActiveCaption;
        }

        private void btnpersonallaboratorio_Click(object sender, EventArgs e)
        {
            abrirform(new FormPersonalLaboratorio());
            btnpersonallaboratorio.BackColor = SystemColors.Window;
            btningresos.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.BackColor = SystemColors.ActiveCaption;
            btnpersonalmedico.BackColor = SystemColors.ActiveCaption;
            btnpaciente.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnespecialidades.BackColor = SystemColors.ActiveCaption;
            btnpracticas.BackColor = SystemColors.ActiveCaption;
            btnpersonalporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnpracticasporespecialidad.BackColor = SystemColors.ActiveCaption;
        }

        private void btnpracticas_Click(object sender, EventArgs e)
        {
            abrirform(new FormPracticas());
            btnpracticas.BackColor = SystemColors.Window;
            btningresos.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.BackColor = SystemColors.ActiveCaption;
            btnpersonalmedico.BackColor = SystemColors.ActiveCaption;
            btnpersonallaboratorio.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnespecialidades.BackColor = SystemColors.ActiveCaption;
            btnpaciente.BackColor = SystemColors.ActiveCaption;
            btnpersonalporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnpracticasporespecialidad.BackColor = SystemColors.ActiveCaption;
        }

        private void btnsalirprogram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnespecialidades_Click(object sender, EventArgs e)
        {
            abrirform(new FormEspecialidades());
            btnespecialidades.BackColor = SystemColors.Window;
            btningresos.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.BackColor = SystemColors.ActiveCaption;
            btnpersonalmedico.BackColor = SystemColors.ActiveCaption;
            btnpersonallaboratorio.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnpaciente.BackColor = SystemColors.ActiveCaption;
            btnpracticas.BackColor = SystemColors.ActiveCaption;
            btnpersonalporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnpracticasporespecialidad.BackColor = SystemColors.ActiveCaption;
        }

        private void btnpracticasporespecialidad_Click(object sender, EventArgs e)
        {
            abrirform(new FormPracticasPorEspecialidad());
            btnpracticasporespecialidad.BackColor = SystemColors.Window;
            btningresos.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.BackColor = SystemColors.ActiveCaption;
            btnpersonalmedico.BackColor = SystemColors.ActiveCaption;
            btnpersonallaboratorio.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnespecialidades.BackColor = SystemColors.ActiveCaption;
            btnpaciente.BackColor = SystemColors.ActiveCaption;
            btnpersonalporespecialidad.BackColor = SystemColors.ActiveCaption;
            btnpracticas.BackColor = SystemColors.ActiveCaption;
        }

        private void btnpersonalporespecialidad_Click(object sender, EventArgs e)
        {
            abrirform(new FormPersonalPorEspecialidad());
            btnpersonalporespecialidad.BackColor = SystemColors.Window;
            btningresos.BackColor = SystemColors.ActiveCaption;
            btnlocalidades.BackColor = SystemColors.ActiveCaption;
            btnpersonalmedico.BackColor = SystemColors.ActiveCaption;
            btnpersonallaboratorio.BackColor = SystemColors.ActiveCaption;
            btncategorias.BackColor = SystemColors.ActiveCaption;
            btnespecialidades.BackColor = SystemColors.ActiveCaption;
            btnpaciente.BackColor = SystemColors.ActiveCaption;
            btnpracticas.BackColor = SystemColors.ActiveCaption;
            btnpracticasporespecialidad.BackColor = SystemColors.ActiveCaption;
        }
    }
}
