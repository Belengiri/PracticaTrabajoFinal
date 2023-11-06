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
    public partial class FormPersonalMedico : Form
    {
        bool agregar=false;
        bool modificar =false;
        private Conexion conexion;
        ControladoraMedicos cm = new ControladoraMedicos();
        public FormPersonalMedico()
        {
            InitializeComponent();
            cargar_tabla();
            cargarcbservicio();
        }
        public void cargar_tabla()
        {
            conexion = new Conexion();
            string consulta = "select id_profesional as n, nombre_profesional as nombre, apellido_profesional as apellido,matricula as matricula, S.nombre_servicio as servicio from Profesionales P inner join Servicios S on P.id_servicio = S.id_servicio";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexion.GetSqlConnection();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvpmedicos.DataSource = dt;
        }
        public void cargarcbservicio()
        {
            try
            {
                conexion = new Conexion();
                cbservicio.DataSource = null;
                cbservicio.Items.Clear();
                string query = "select id_servicio,nombre_servicio as nombre from Servicios";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbservicio.ValueMember = "id_servicio";
                cbservicio.DisplayMember = "nombre";
                cbservicio.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            btnaceptar.Enabled = true;
            btnagregar.Enabled = false;
            paneldatosmedico.Visible = true;
            dgvpmedicos.ClearSelection();
            if (agregar == true)
            {
                try
                {
                    cm.Agregar_Medico(Convert.ToInt32(cbservicio.SelectedValue.ToString()), txtnombremedico.Text, txtapellidomedico.Text, Convert.ToInt32(txtmatriculamedico.Text));
                    cargar_tabla();
                    txtnombremedico.Focus();
                    txtnombremedico.Clear();
                    txtapellidomedico.Clear();
                    txtmatriculamedico.Clear();
                    dgvpmedicos.ClearSelection();
                    btnagregar.Enabled = true;
                    btnaceptar.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                }
                
            }
        }

        private void agregarservicio_CheckedChanged(object sender, EventArgs e)
        {
            panelnuevoservicio.Visible = true;
        }

        private void btncancelarservicio_Click(object sender, EventArgs e)
        {
            agregarservicio.Checked = false;
            panelnuevoservicio.Visible = false;
        }

        private void btnguardarservicio_Click(object sender, EventArgs e)
        {
            agregarservicio.Checked = false;
            cm.Agregar_Servicio(txtnombreservicio.Text);
            txtnombreservicio.Clear();
            txtnombreservicio.Focus();
            cargarcbservicio();
            panelnuevoservicio.Visible = false;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                btnagregar.Enabled = true;
                agregar = true;
                btnmodificar.Enabled = true;
                modificar = true;
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                txtnombremedico.Focus();
                txtnombremedico.Clear();
                txtapellidomedico.Clear();
                txtmatriculamedico.Clear();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            btnaceptar.Enabled = true;
            btnmodificar.Enabled = false;
            paneldatosmedico.Visible = true;
            if (modificar == true)
            {
                try
                {
                    cm.Modificar_Medico(Convert.ToInt32(dgvpmedicos.CurrentRow.Cells[0].Value.ToString()),Convert.ToInt32(cbservicio.SelectedValue.ToString()), txtnombremedico.Text, txtapellidomedico.Text, Convert.ToInt32(txtmatriculamedico.Text));
                    cargar_tabla();
                    txtnombremedico.Focus();
                    txtnombremedico.Clear();
                    txtapellidomedico.Clear();
                    txtmatriculamedico.Clear();
                    dgvpmedicos.ClearSelection();
                    btnmodificar.Enabled = true;
                    btnaceptar.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                }

            }
        }

        private void dgvpmedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnmodificar.Enabled == false)
            {
                txtnombremedico.Text = dgvpmedicos.CurrentRow.Cells[1].Value.ToString();
                txtapellidomedico.Text = dgvpmedicos.CurrentRow.Cells[2].Value.ToString();
                txtmatriculamedico.Text = dgvpmedicos.CurrentRow.Cells[3].Value.ToString();
                cbservicio.Text = dgvpmedicos.CurrentRow.Cells[4].Value.ToString();

            }
            btneliminar.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            btnaceptar.Visible = false;
            cm.Eliminar_Medico(Convert.ToInt32(dgvpmedicos.CurrentRow.Cells[0].Value.ToString()));
            cargar_tabla();
            txtnombremedico.Focus();
            txtnombremedico.Clear();
            txtapellidomedico.Clear();
            txtmatriculamedico.Clear();
            dgvpmedicos.ClearSelection();
            btneliminar.Enabled = true;
            btnaceptar.Enabled = false;
        }
    }
}
