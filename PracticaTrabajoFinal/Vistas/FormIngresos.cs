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
    public partial class FormIngresos : Form
    {
        SqlConnection conexion = new SqlConnection("workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal");
        public FormIngresos()
        {
            InitializeComponent();
        }
        List<string> listaespe = new List<string>();
        public void cargarchecklistespecialidades()
        {
            try
            {
                checklistespecialidades.DataSource = null;
                checklistespecialidades.Items.Clear();
                string sql = "select id_especialidad,nombre_especialidad as nombre from Especialidades";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    checklistespecialidades.Items.Add("nombre");
                }
                checklistespecialidades.ValueMember = "id_especialidad";
                checklistespecialidades.DisplayMember = "nombre";
                checklistespecialidades.DataSource = dt;

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
        public void cargarcbmedicos()
        {
            try
            {
                cbmedicos.DataSource = null;
                cbmedicos.Items.Clear();
                string sql = "select id_profesional,nombre_profesional+' '+apellido_profesional as 'apellido' from Profesionales";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbmedicos.Items.Add("apellido");
                }
                cbmedicos.ValueMember = "id_paciente";
                cbmedicos.DisplayMember = "apellido";
                cbmedicos.DataSource = dt;

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
       public void cargarcbpacientes()
        {   
           
            try
            {   
                cbpacienteapellido.DataSource = null;
                cbpacienteapellido.Items.Clear();
                string sql = "select id_paciente,nombre_paciente+' '+apellido_paciente as 'apellido' from Pacientes";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbpacienteapellido.Items.Add("apellido");
                }
                cbpacienteapellido.ValueMember = "id_paciente";
                cbpacienteapellido.DisplayMember = "apellido";
                cbpacienteapellido.DataSource = dt;

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

        private void FormIngresos_Load(object sender, EventArgs e)
        {
            cargarcbpacientes();
            cargarcbmedicos();
            cargarchecklistespecialidades();
        }

        private void checklistespecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaespe.Add(checklistespecialidades.SelectedValue.ToString());
        }
    }
}
