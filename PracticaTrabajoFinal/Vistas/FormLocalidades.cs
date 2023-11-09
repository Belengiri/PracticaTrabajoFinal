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
    public partial class FormLocalidades : Form
    {
        private Conexion conexion;
        ControladoraPacientes cl = new ControladoraPacientes();
        public FormLocalidades()
        {
            InitializeComponent();
            cargar_tabla();
        }
        public void cargar_tabla()
        {
            conexion = new Conexion();
            string consulta = "select id_localidad as n,nombre_localidad as nombre,codigo_postal as CP from Localidades";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexion.GetSqlConnection();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvlocalidades.DataSource = dt;
        }

        private void dgvlocalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombrelocalidad.Text = dgvlocalidades.CurrentRow.Cells[1].Value.ToString();
            txtcodigopostal.Text = dgvlocalidades.CurrentRow.Cells[2].Value.ToString();
            btneliminarlocalidad.Enabled = true;
            btnmodificarlocalidad.Enabled = true;
            btnagregarlocalidad.Enabled = false;
            
        }

        private void btnagregarlocalidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cl.Agregar_Localidad(txtnombrelocalidad.Text, Convert.ToInt32(txtcodigopostal.Text));
                    cargar_tabla();
                    txtnombrelocalidad.Focus();
                    txtnombrelocalidad.Clear();
                    txtcodigopostal.Clear();
                    dgvlocalidades.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                    dgvlocalidades.ClearSelection();
                    txtnombrelocalidad.Focus();
                    txtnombrelocalidad.Clear();
                    txtcodigopostal.Clear();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                dgvlocalidades.ClearSelection();
                txtnombrelocalidad.Focus();
                txtnombrelocalidad.Clear();
                txtcodigopostal.Clear();
            }
        }

        private void btnmodificarlocalidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cl.Modificar_Localidad(Convert.ToInt32(dgvlocalidades.CurrentRow.Cells[0].Value.ToString()), txtnombrelocalidad.Text, Convert.ToInt32(txtcodigopostal.Text));
                    cargar_tabla();
                    btneliminarlocalidad.Enabled = false;
                    btnmodificarlocalidad.Enabled = false;
                    btnagregarlocalidad.Enabled = true;
                    txtnombrelocalidad.Focus();
                    txtnombrelocalidad.Clear();
                    txtcodigopostal.Clear();
                    dgvlocalidades.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                    dgvlocalidades.ClearSelection();
                    txtnombrelocalidad.Focus();
                    txtnombrelocalidad.Clear();
                    txtcodigopostal.Clear();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                dgvlocalidades.ClearSelection();
                txtnombrelocalidad.Focus();
                txtnombrelocalidad.Clear();
                txtcodigopostal.Clear();
            }
        }

        private void btneliminarlocalidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cl.Eliminar_Localidad(Convert.ToInt32(dgvlocalidades.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    btneliminarlocalidad.Enabled = false;
                    btnmodificarlocalidad.Enabled = false;
                    btnagregarlocalidad.Enabled = true;
                    dgvlocalidades.ClearSelection();
                    txtnombrelocalidad.Focus();
                    txtnombrelocalidad.Clear();
                    txtcodigopostal.Clear();
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                    dgvlocalidades.ClearSelection();
                    txtnombrelocalidad.Focus();
                    txtnombrelocalidad.Clear();
                    txtcodigopostal.Clear();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                dgvlocalidades.ClearSelection();
                txtnombrelocalidad.Focus();
                txtnombrelocalidad.Clear();
                txtcodigopostal.Clear();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btneliminarlocalidad.Enabled = false;
            btnmodificarlocalidad.Enabled = false;
            btnagregarlocalidad.Enabled = true;
            txtnombrelocalidad.Clear();
            txtcodigopostal.Clear();
            txtnombrelocalidad.Focus();
        }
    }
}
