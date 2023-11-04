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
        private CadenaString conexion;
        ControladoraPacientes cpp = new ControladoraPacientes();
        bool agregar = false;
        bool modificar = false;
        bool eliminar = false;

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
                conexion = new CadenaString();
                cblocalidades.DataSource = null;
                cblocalidades.Items.Clear();
                string query = "select id_localidad,nombre_localidad as nombre from Localidades";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cblocalidades.ValueMember = "id_localidad";
                cblocalidades.DisplayMember = "nombre";
                cblocalidades.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }

        public void cargar_tabla()
        {
            try
            {
                conexion = new CadenaString();
                string consulta = "select p.id_paciente as n, nombre_paciente as nombre, apellido_paciente as apellido , dni,fecha_nacimiento as fecha,direccion_nombre as calle, direccion_numero as altura, direccion_piso as piso, direccion_departamento  as departamento,correo_paciente as correo,telefono_paciente as telefono ,L.nombre_localidad as localidad from Pacientes P inner join Localidades L on P.id_localidad = L.id_localidad";
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvpacientes.DataSource = dt;
            }catch(Exception e)
            {
                MessageBox.Show("error", e.Message);
            }
        }

        private void agregarlocalidad_CheckedChanged(object sender, EventArgs e)
        {
           if(agregarlocalidad.Checked==true)
            {
                panelnuevalocalidad.Visible = true;
                btnaceptar.Enabled = false;
            }
            else
            {
                panelnuevalocalidad.Visible = false;
                btnaceptar.Enabled = true;
            }
            
            
            txtnombrelocalidad.Focus();
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            dgvpacientes.ClearSelection();
            cargarcblocalidades();
            cargar_tabla();
        }

        private void btnagregarpaciente_Click(object sender, EventArgs e)
        {
            agregar = true;
            eliminar = false;
            modificar = false;
            dgvpacientes.ClearSelection();
            btnaceptar.Enabled = true;
            txtnombrepaciente.Clear();
            txtapellidopaciente.Clear();
            txtdnipaciente.Clear();
            dtfecha.Text="";
            txtcorreo.Clear();
            txttelefono.Clear();
            txtcalle.Clear();
            txtaltura.Clear();
            txtpiso.Clear();
            txtdepartamento.Clear();
            paneldatospaciente.Visible = true;
            panelbtnaceptarpaciente.Visible = true;
            agregarlocalidad.Visible = true;
        }

        private void btnmodificarpaciente_Click(object sender, EventArgs e)
        {
            modificar = true;
            eliminar = false;
            agregar = false;
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
            paneldatospaciente.Visible = true;
            panelbtnaceptarpaciente.Visible = true;
            agregarlocalidad.Visible = false;
            btnaceptar.Enabled = false;
        }

        private void btneliminarpaciente_Click(object sender, EventArgs e)
        {
            eliminar = true;
            agregar=false;
            modificar=false;
            dgvpacientes.ClearSelection();
            paneldatospaciente.Visible = false;
            panelbtnaceptarpaciente.Visible = true;
            btnaceptar.Enabled = false;
        }

        private void dgvpacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(modificar==true)
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
            }
            btnaceptar.Enabled = true;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                if (agregar == true)
                {
                    try
                    {
                        cpp.Agregar_Paciente(Convert.ToInt32(cblocalidades.SelectedValue.ToString()),txtnombrepaciente.Text,txtapellidopaciente.Text,Convert.ToInt32(txtdnipaciente.Text),dtfecha.Value.ToShortDateString(),txtcalle.Text,Convert.ToInt32(txtaltura.Text),Convert.ToInt32(txtpiso.Text),Convert.ToInt32(txtdepartamento.Text),txtcorreo.Text,txttelefono.Text);
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
                    }catch (Exception ex)
                    {
                        MessageBox.Show("error al cargar", ex.Message);
                    }

                    
                }
                else if (modificar == true)
                {
                    try
                    {
                        cpp.Modificar_Paciente(Convert.ToInt32(dgvpacientes.CurrentRow.Cells[0].Value.ToString()),Convert.ToInt32(cblocalidades.SelectedValue.ToString()),txtnombrepaciente.Text,txtapellidopaciente.Text,Convert.ToInt32(txtdnipaciente.Text),dtfecha.Value.ToShortDateString(),txtcalle.Text,Convert.ToInt32(txtaltura.Text),Convert.ToInt32(txtpiso.Text),Convert.ToInt32(txtdepartamento.Text),txtcorreo.Text,txttelefono.Text);
                        cargar_tabla();
                        dgvpacientes.ClearSelection();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("error al modificar", ex.Message);
                    }
                    
                }
                else if (eliminar == true)
                {
                    try
                    {
                        cpp.Eliminar_Paciente(Convert.ToInt32(dgvpacientes.CurrentRow.Cells[0].Value.ToString()));
                        cargar_tabla();
                        dgvpacientes.ClearSelection();
                    }catch (Exception ex)
                    {
                        MessageBox.Show("error al eliminar", ex.Message);
                    }
                    
                }

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                dgvpacientes.ClearSelection();
            }
        }

        private void btnguardarlocalidad_Click(object sender, EventArgs e)
        {
            try
            {
                btnaceptar.Enabled = false;
                cpp.Agregar_Localidad(txtnombrelocalidad.Text,Convert.ToInt32(txtcodigopostal.Text));
                cargarcblocalidades();
                txtnombrelocalidad.Clear();
                txtnombrelocalidad.Focus();
                txtcodigopostal.Clear();
                agregarlocalidad.Checked = false;
                panelnuevalocalidad.Visible = false;
                btnaceptar.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar la Localidad",ex.Message);
            }
            
        }

        private void btncancelarlocalidad_Click(object sender, EventArgs e)
        {
            agregarlocalidad.Checked = false;
            panelnuevalocalidad.Visible = false;
            btnaceptar.Enabled = true;
        }
    }
}
