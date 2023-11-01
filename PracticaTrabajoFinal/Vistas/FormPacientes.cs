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
                cblocalidades.ValueMember = "id_especialidad";
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
            string consulta = "select p.id_paciente as n, nombre_paciente as nombre, apellido_paciente as apellido , dni as dni,direccion_nombre as calle, direccion_numero as altura, direccion_piso as piso, direccion_departamento  as departamento,correo_paciente as correo,telefono_paciente as telefono ,L.nombre_localidad as localidad from Pacientes P inner join Localidades L on P.id_localidad = L.id_localidad";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvpacientes.DataSource = dt;

        }

        private void agregarlocalidad_CheckedChanged(object sender, EventArgs e)
        {
            panelnuevalocalidad.Visible = true;
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            cargarcblocalidades();
        }
    }
}
