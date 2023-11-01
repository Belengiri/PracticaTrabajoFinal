using PracticaTrabajoFinal.Controladores;
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
        SqlConnection conexion = new SqlConnection("workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal");
        bool agregar = false;
        bool modificar = false;
        bool eliminar = false;

        public FormPacientes()
        {
            InitializeComponent();
            cargar_tabla();
        }
        public void cargarcblocalidades()
        {
            try
            {
                cblocalidades.DataSource = null;
                cblocalidades.Items.Clear();
                string query = "select id_localidad,nombre_localidad as nombre,codigo_postal as cp from Localidades";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
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
            finally
            {
                conexion.Close();
            }
        }

        public void cargar_tabla()
        {
            try
            {
                conexion.Open();
                string consulta = "select p.id_paciente as n, nombre_paciente as nombre, apellido_paciente as apellido , dni,fecha_nacimiento as fecha,direccion_nombre as calle, direccion_numero as altura, direccion_piso as piso, direccion_departamento  as departamento,correo_paciente as correo,telefono_paciente as telefono ,L.nombre_localidad as localidad from Pacientes P inner join Localidades L on P.id_localidad = L.id_localidad";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvpacientes.DataSource = dt;
            }catch(Exception e)
            {
                MessageBox.Show("error", e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void agregarlocalidad_CheckedChanged(object sender, EventArgs e)
        {
            panelnuevalocalidad.Visible = true;
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            cargarcblocalidades();
            cargar_tabla();
        }

        private void btnagregarpaciente_Click(object sender, EventArgs e)
        {
            paneldatospaciente.Visible = true;
            panelbtnaceptarpaciente.Visible = true;
            lblnombrepaciente.Visible = true;
            txtnombrepaciente.Visible = true;
            txtapellidopaciente.Visible = true;
            lblapellidopaciente.Visible = true;
            lbldnipaciente.Visible = true;
            txtdnipaciente.Visible = true;
            lblfechanacpaciente.Visible = true;
            txtfechanacpaciente.Visible = true;
            lblcorreopaciente.Visible = true;
            txtcorreo.Visible = true;
            lbltelefonopaciente.Visible = true;
            txttelefono.Visible = true;
            lblcallepaciente.Visible = true;
            txtcalle.Visible = true;
            lblalturacalle.Visible = true;
            txtaltura.Visible = true;
            lblpisocasa.Visible = true;
            txtpiso.Visible = true;
            lbldeptopaciente.Visible = true;
            txtdepartamento.Visible = true;
            lbllocalidad.Visible = true;
            cblocalidades.Visible = true;
            agregarlocalidad.Visible = true;
        }

        private void btnmodificarpaciente_Click(object sender, EventArgs e)
        {
            paneldatospaciente.Visible = true;
            panelbtnaceptarpaciente.Visible = true;
            lblnombrepaciente.Visible = true;
            txtnombrepaciente.Visible = true;
            txtapellidopaciente.Visible = true;
            lblapellidopaciente.Visible = true;
            lbldnipaciente.Visible = true;
            txtdnipaciente.Visible = true;
            lblfechanacpaciente.Visible = true;
            txtfechanacpaciente.Visible = true;
            lblcorreopaciente.Visible = true;
            txtcorreo.Visible = true;
            lbltelefonopaciente.Visible = true;
            txttelefono.Visible = true;
            lblcallepaciente.Visible = true;
            txtcalle.Visible = true;
            lblalturacalle.Visible = true;
            txtaltura.Visible = true;
            lblpisocasa.Visible = true;
            txtpiso.Visible = true;
            lbldeptopaciente.Visible = true;
            txtdepartamento.Visible = true;
            lbllocalidad.Visible = true;
            cblocalidades.Visible = true;
            agregarlocalidad.Visible = false;
            DataGridViewCellEventArgs even = new DataGridViewCellEventArgs(1,1);
            dgvpacientes_CellClick(dgvpacientes, even);

        }

        private void btneliminarpaciente_Click(object sender, EventArgs e)
        {
            paneldatospaciente.Visible = true;
            panelbtnaceptarpaciente.Visible = true;
            lblnombrepaciente.Visible = false;
            txtnombrepaciente.Visible = false;
            txtapellidopaciente.Visible = false;
            lblapellidopaciente.Visible = false;
            lbldnipaciente.Visible = false;
            txtdnipaciente.Visible = false;
            lblfechanacpaciente.Visible = false;
            txtfechanacpaciente.Visible = false;
            lblcorreopaciente.Visible = false;
            txtcorreo.Visible = false;
            lbltelefonopaciente.Visible = false;
            txttelefono.Visible = false;
            lblcallepaciente.Visible = false;
            txtcalle.Visible = false;
            lblalturacalle.Visible = false;
            txtaltura.Visible = false;
            lblpisocasa.Visible = false;
            txtpiso.Visible = false;
            lbldeptopaciente.Visible = false;
            txtdepartamento.Visible = false;
            lbllocalidad.Visible = false;
            cblocalidades.Visible = false;
            agregarlocalidad.Visible = false;
            DataGridViewCellEventArgs even = new DataGridViewCellEventArgs(0, 0);
            dgvpacientes_CellClick(dgvpacientes, even);
        }

        private void dgvpacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombrepaciente.Text = dgvpacientes.CurrentRow.Cells[1].Value.ToString();
            txtapellidopaciente.Text = dgvpacientes.CurrentRow.Cells[2].Value.ToString();
            txtdnipaciente.Text = dgvpacientes.CurrentRow.Cells[3].Value.ToString();
            txtfechanacpaciente.Text = dgvpacientes.CurrentRow.Cells[4].Value.ToString();
            txtcalle.Text = dgvpacientes.CurrentRow.Cells[5].Value.ToString();
            txtaltura.Text = dgvpacientes.CurrentRow.Cells[6].Value.ToString();
            txtpiso.Text = dgvpacientes.CurrentRow.Cells[7].Value.ToString();
            txtdepartamento.Text = dgvpacientes.CurrentRow.Cells[8].Value.ToString();
            txtcorreo.Text = dgvpacientes.CurrentRow.Cells[9].Value.ToString();
            txttelefono.Text = dgvpacientes.CurrentRow.Cells[10].Value.ToString();
            cblocalidades.Text = dgvpacientes.CurrentRow.Cells[11].Value.ToString();

        }
    }
}
