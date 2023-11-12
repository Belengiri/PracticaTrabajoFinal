using PracticaTrabajoFinal.Controladores;
using PracticaTrabajoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Vistas
{
    public partial class FormEspecialidades : Form
    {
        private Conexion conexion;
        ControladoraEspecialidades ce = new ControladoraEspecialidades();
        public FormEspecialidades()
        {
            InitializeComponent();
            cargar_tabla();
        }
        public void cargar_tabla()
        {
            conexion = new Conexion();
            string consulta = "select id_especialidad as Nº,nombre_especialidad as Especialidad from Especialidades";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexion.GetSqlConnection();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvespecialidades.DataSource = dt;
        }

        private void btnagregarespecialidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    ce.Agregar_Especialidad(txtnombreespecialidad.Text);
                    cargar_tabla();
                    txtnombreespecialidad.Clear();
                    txtnombreespecialidad.Focus();
                    dgvespecialidades.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtnombreespecialidad.Clear();
                    txtnombreespecialidad.Focus();
                    dgvespecialidades.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                txtnombreespecialidad.Clear();
                txtnombreespecialidad.Focus();
                dgvespecialidades.ClearSelection();
            }
        }

        private void btnmodificarespecialidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    ce.Modificar_Especialidad(txtnombreespecialidad.Text, Convert.ToInt32(dgvespecialidades.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    txtnombreespecialidad.Clear();
                    txtnombreespecialidad.Focus();
                    btneliminarespecialidad.Enabled = false;
                    btnmodificarespecialidad.Enabled = false;
                    btnagregarespecialidad.Enabled = true;
                    dgvespecialidades.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtnombreespecialidad.Clear();
                    txtnombreespecialidad.Focus();
                    dgvespecialidades.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                txtnombreespecialidad.Clear();
                txtnombreespecialidad.Focus();
                dgvespecialidades.ClearSelection();
            }

        }

        private void btneliminarespecialidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    ce.Eliminar_Especialidad(Convert.ToInt32(dgvespecialidades.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    btneliminarespecialidad.Enabled = false;
                    btnmodificarespecialidad.Enabled = false;
                    btnagregarespecialidad.Enabled = true;
                    txtnombreespecialidad.Clear();
                    txtnombreespecialidad.Focus();
                    dgvespecialidades.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtnombreespecialidad.Clear();
                    txtnombreespecialidad.Focus();
                    dgvespecialidades.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                txtnombreespecialidad.Clear();
                txtnombreespecialidad.Focus();
                dgvespecialidades.ClearSelection();
            }
        }

        private void FormEspecialidades_Load(object sender, EventArgs e)
        {
            dgvespecialidades.ClearSelection();
            txtnombreespecialidad.Focus();
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btneliminarespecialidad.Enabled = false;
            btnmodificarespecialidad.Enabled = false;
            btnagregarespecialidad.Enabled = true;
            txtnombreespecialidad.Clear();
            txtnombreespecialidad.Focus();
            dgvespecialidades.ClearSelection();
        }

        private void dgvespecialidades_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtnombreespecialidad.Text = dgvespecialidades.CurrentRow.Cells[1].Value.ToString();
            btneliminarespecialidad.Enabled = true;
            btnmodificarespecialidad.Enabled = true;
            btnagregarespecialidad.Enabled = false;
        }
    }
}
