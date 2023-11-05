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
        bool agregar = false;
        bool modificar = false;
        bool eliminar = false;
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

        private void btnaceptarlocalidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (agregar == true)
                {

                    cl.Agregar_Localidad(txtnombrelocalidad.Text,Convert.ToInt32(txtcodigopostal.Text));
                    cargar_tabla();
                    txtnombrelocalidad.Clear();
                    txtcodigopostal.Clear();
                }
                else if (modificar == true)
                {
                    cl.Modificar_Localidad( Convert.ToInt32(dgvlocalidades.CurrentRow.Cells[0].Value.ToString()),txtnombrelocalidad.Text,Convert.ToInt32(txtcodigopostal.Text));
                    cargar_tabla();
                    txtnombrelocalidad.Clear();
                    txtcodigopostal.Clear();
                    dgvlocalidades.ClearSelection();
                }
                else if (eliminar == true)
                {
                    cl.Eliminar_Localidad(Convert.ToInt32(dgvlocalidades.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    dgvlocalidades.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                txtnombrelocalidad.Clear();
                txtcodigopostal.Clear();
                txtnombrelocalidad.Focus();
                dgvlocalidades.ClearSelection();
            }
        }

        private void dgvlocalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == true)
            {
                txtnombrelocalidad.Text = dgvlocalidades.CurrentRow.Cells[1].Value.ToString();
                txtcodigopostal.Text = dgvlocalidades.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnagregarlocalidad_Click(object sender, EventArgs e)
        {
            paneldatoslocalidades.Visible = true;
            txtnombrelocalidad.Clear();
            txtnombrelocalidad.Focus();
            txtcodigopostal.Clear();
            txtcodigopostal.Visible = true;
            txtnombrelocalidad.Visible = true;
            lblnombrelocalidad.Visible = true;
            llblcodigopostal.Visible = true;
            agregar = true;
            eliminar = false;
            modificar = false;
        }

        private void btnmodificarlocalidad_Click(object sender, EventArgs e)
        {
            
            paneldatoslocalidades.Visible = true;
            txtnombrelocalidad.Clear();
            txtcodigopostal.Clear();
            txtnombrelocalidad.Focus();
            txtcodigopostal.Visible = true;
            txtnombrelocalidad.Visible = true;
            lblnombrelocalidad.Visible = true;
            llblcodigopostal.Visible = true;
            modificar = true;
            agregar = false;
            eliminar = false;
        }

        private void btneliminarlocalidad_Click(object sender, EventArgs e)
        {
            eliminar = true;
            modificar = false;
            agregar = false;
            paneldatoslocalidades.Visible = true;
            txtcodigopostal.Visible = false;
            txtnombrelocalidad.Visible = false;
            lblnombrelocalidad.Visible = false;
            llblcodigopostal.Visible = false;
        }
    }
}
