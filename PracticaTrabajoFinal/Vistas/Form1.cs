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
        }

        private void btnpersonallaboratorio_Click(object sender, EventArgs e)
        {
            abrirform(new FormPersonalLaboratorio());
        }

        private void btnpracticas_Click(object sender, EventArgs e)
        {
            abrirform(new FormPracticas());
        }

        private void btnsalirprogram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnespecialidades_Click(object sender, EventArgs e)
        {
            abrirform(new FormEspecialidades());
        }

        private void btnpracticasporespecialidad_Click(object sender, EventArgs e)
        {
            abrirform(new FormPracticasPorEspecialidad());
        }

        private void btnpersonalporespecialidad_Click(object sender, EventArgs e)
        {
            abrirform(new FormPersonalPorEspecialidad());
        }
    }
}
