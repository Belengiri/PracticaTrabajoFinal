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
    public partial class FormPacientes : Form
    {
        ControladoraPacientes cpp = new ControladoraPacientes();
        private Conexion conexion;

        public FormPacientes()
        {
            InitializeComponent();
            cargar_tabla();
            dgvpacientes.ClearSelection();
        }
        public void cargarcblocalidades()
        {
            try
            {
                conexion = new Conexion();
                cblocalidades.DataSource = null;
                cblocalidades.Items.Clear();
                string query = "select id_localidad,nombre_localidad as nombre,codigo_postal as cp from Localidades";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cblocalidades.ValueMember = "id_localidad";
                cblocalidades.DisplayMember = "nombre";
                cblocalidades.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar las Localidades", ex.Message);
            }
        }

        public void cargar_tabla()
        {
            try
            {
                conexion = new Conexion();
                string consulta = "select p.id_paciente as Nº, nombre_paciente as Nombre, apellido_paciente as Apellido , dni as DNI,fecha_nacimiento as Fecha_Nacimiento,direccion_nombre as Calle, direccion_numero as Altura_Calle, direccion_piso as Piso, direccion_departamento  as Departamento,correo_paciente as Correo,telefono_paciente as Telefono ,L.nombre_localidad as Localidad from Pacientes P inner join Localidades L on P.id_localidad = L.id_localidad";
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvpacientes.DataSource = dt;
            }catch(Exception e)
            {
                MessageBox.Show("Error al Cargar los Datos", e.Message);
            }
            
        }

        private void agregarlocalidad_CheckedChanged(object sender, EventArgs e)
        {
            panelnuevalocalidad.Visible = true;
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            dgvpacientes.ClearSelection();
            cargarcblocalidades();
            cargar_tabla();
        }

        private void btnagregarpaciente_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cpp.Agregar_Paciente(Convert.ToInt32(cblocalidades.SelectedValue.ToString()), txtnombrepaciente.Text, txtapellidopaciente.Text, Convert.ToInt32(txtdnipaciente.Text), dtfecha.Value.ToShortDateString(), txtcalle.Text, Convert.ToInt32(txtaltura.Text), Convert.ToInt32(txtpiso.Text), Convert.ToInt32(txtdepartamento.Text), txtcorreo.Text, txttelefono.Text);
                    cargar_tabla();
                    dgvpacientes.ClearSelection();
                    txtnombrepaciente.Clear();
                    txtapellidopaciente.Clear();
                    txtdnipaciente.Clear();
                    dtfecha.Text = "";
                    txtcorreo.Clear();
                    txttelefono.Clear();
                    txtcalle.Clear();
                    txtaltura.Clear();
                    txtpiso.Clear();
                    txtdepartamento.Clear();
                    btnagregarpaciente.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                dgvpacientes.ClearSelection();
                txtnombrepaciente.Clear();
                txtapellidopaciente.Clear();
                txtdnipaciente.Clear();
                dtfecha.Text = "";
                txtcorreo.Clear();
                txttelefono.Clear();
                txtcalle.Clear();
                txtaltura.Clear();
                txtpiso.Clear();
                txtdepartamento.Clear();
                agregarlocalidad.Visible = true;
            }
        }

        private void btnmodificarpaciente_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cpp.Modificar_Paciente(Convert.ToInt32(dgvpacientes.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(cblocalidades.SelectedValue.ToString()), txtnombrepaciente.Text, txtapellidopaciente.Text, Convert.ToInt32(txtdnipaciente.Text), dtfecha.Value.ToShortDateString(), txtcalle.Text, Convert.ToInt32(txtaltura.Text), Convert.ToInt32(txtpiso.Text), Convert.ToInt32(txtdepartamento.Text), txtcorreo.Text, txttelefono.Text);
                    cargar_tabla();
                    btnagregarpaciente.Enabled = true;
                    btneliminarpaciente.Enabled = false;
                    btnmodificarpaciente.Enabled = false;
                    agregarlocalidad.Visible = true;
                    dgvpacientes.ClearSelection();
                    txtnombrepaciente.Clear();
                    txtapellidopaciente.Clear();
                    txtdnipaciente.Clear();
                    dtfecha.Text = "";
                    txtcorreo.Clear();
                    txttelefono.Clear();
                    txtcalle.Clear();
                    txtaltura.Clear();
                    txtpiso.Clear();
                    txtdepartamento.Clear();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    dgvpacientes.ClearSelection();
                    txtnombrepaciente.Clear();
                    txtapellidopaciente.Clear();
                    txtdnipaciente.Clear();
                    dtfecha.Text = "";
                    txtcorreo.Clear();
                    txttelefono.Clear();
                    txtcalle.Clear();
                    txtaltura.Clear();
                    txtpiso.Clear();
                    txtdepartamento.Clear();
                }

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                dgvpacientes.ClearSelection();
                txtnombrepaciente.Clear();
                txtapellidopaciente.Clear();
                txtdnipaciente.Clear();
                dtfecha.Text = "";
                txtcorreo.Clear();
                txttelefono.Clear();
                txtcalle.Clear();
                txtaltura.Clear();
                txtpiso.Clear();
                txtdepartamento.Clear();
            }
        }

        private void btneliminarpaciente_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cpp.Eliminar_Paciente(Convert.ToInt32(dgvpacientes.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    btnagregarpaciente.Enabled = true;
                    btneliminarpaciente.Enabled = false;
                    btnmodificarpaciente.Enabled = false;
                    agregarlocalidad.Visible = true;
                    dgvpacientes.ClearSelection();
                    txtnombrepaciente.Clear();
                    txtapellidopaciente.Clear();
                    txtdnipaciente.Clear();
                    dtfecha.Text = "";
                    txtcorreo.Clear();
                    txttelefono.Clear();
                    txtcalle.Clear();
                    txtaltura.Clear();
                    txtpiso.Clear();
                    txtdepartamento.Clear();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    dgvpacientes.ClearSelection();
                    txtnombrepaciente.Clear();
                    txtapellidopaciente.Clear();
                    txtdnipaciente.Clear();
                    dtfecha.Text = "";
                    txtcorreo.Clear();
                    txttelefono.Clear();
                    txtcalle.Clear();
                    txtaltura.Clear();
                    txtpiso.Clear();
                    txtdepartamento.Clear();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                txtnombrepaciente.Clear();
                txtapellidopaciente.Clear();
                txtdnipaciente.Clear();
                dtfecha.Text = "";
                txtcorreo.Clear();
                txttelefono.Clear();
                txtcalle.Clear();
                txtaltura.Clear();
                txtpiso.Clear();
                txtdepartamento.Clear();
            }
        }

        private void dgvpacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombrepaciente.Text = dgvpacientes.CurrentRow.Cells[1].Value.ToString();
            txtapellidopaciente.Text = dgvpacientes.CurrentRow.Cells[2].Value.ToString();
            txtdnipaciente.Text = dgvpacientes.CurrentRow.Cells[3].Value.ToString();
            dtfecha.Text = dgvpacientes.CurrentRow.Cells[4].Value.ToString();
            txtcalle.Text = dgvpacientes.CurrentRow.Cells[5].Value.ToString();
            txtaltura.Text = dgvpacientes.CurrentRow.Cells[6].Value.ToString();
            txtpiso.Text = dgvpacientes.CurrentRow.Cells[7].Value.ToString();
            txtdepartamento.Text = dgvpacientes.CurrentRow.Cells[8].Value.ToString();
            txtcorreo.Text = dgvpacientes.CurrentRow.Cells[9].Value.ToString();
            txttelefono.Text = dgvpacientes.CurrentRow.Cells[10].Value.ToString();
            cblocalidades.Text = dgvpacientes.CurrentRow.Cells[11].Value.ToString();
            btneliminarpaciente.Enabled = true;
            btnmodificarpaciente.Enabled = true;
            btnagregarpaciente.Enabled = false;
            agregarlocalidad.Visible = false;
        }

        private void btnguardarlocalidad_Click(object sender, EventArgs e)
        {
            try
            {
                cpp.Agregar_Localidad(txtnombrelocalidad.Text,Convert.ToInt32(txtcodigopostal.Text));
                cargarcblocalidades();
                txtnombrelocalidad.Clear();
                txtnombrelocalidad.Focus();
                txtcodigopostal.Clear();
                agregarlocalidad.Checked = false;
                panelnuevalocalidad.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al Guardar la Localidad",ex.Message);
            }
            
        }

        private void btncancelarlocalidad_Click(object sender, EventArgs e)
        {
            agregarlocalidad.Checked = false;
            panelnuevalocalidad.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btneliminarpaciente.Enabled = false;
            btnmodificarpaciente.Enabled = false;
            btnagregarpaciente.Enabled = true;
            dgvpacientes.ClearSelection();
            txtnombrepaciente.Clear();
            txtapellidopaciente.Clear();
            txtdnipaciente.Clear();
            dtfecha.Text = "";
            txtcorreo.Clear();
            txttelefono.Clear();
            txtcalle.Clear();
            txtaltura.Clear();
            txtpiso.Clear();
            txtdepartamento.Clear();
            agregarlocalidad.Visible = true;
            panelnuevalocalidad.Visible = false;
        }
    }
}
