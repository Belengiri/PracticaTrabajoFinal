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
        private CadenaString conexion;
        public FormIngresos()
        {
            InitializeComponent();
        }

        List<string> listaespe = new List<string>();
        public void cargarchecklistespecialidades()
        {
            try
            {
                conexion = new CadenaString();
                checklistespecialidades.DataSource = null;
                checklistespecialidades.Items.Clear();
                string sql = "select id_especialidad,nombre_especialidad as nombre from Especialidades";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conexion.GetConnection();
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
        }
        public void cargarcbmedicos()
        {
            try
            {
                conexion = new CadenaString();
                cbmedicos.DataSource = null;
                cbmedicos.Items.Clear();
                string sql = "select id_profesional,nombre_profesional+' '+apellido_profesional as 'apellido' from Profesionales";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conexion.GetConnection();
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

        }
       public void cargarcbpacientes()
        {   
           
            try
            {
                conexion = new CadenaString();
                cbpacienteapellido.DataSource = null;
                cbpacienteapellido.Items.Clear();
                string sql = "select id_paciente,nombre_paciente+' '+apellido_paciente as 'apellido' from Pacientes";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conexion.GetConnection();
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
