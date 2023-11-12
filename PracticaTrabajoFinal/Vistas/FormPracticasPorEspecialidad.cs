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
    public partial class FormPracticasPorEspecialidad : Form
    {
        private Conexion conexion;
        ControladoraEspecialidades cespxprac = new ControladoraEspecialidades();
        public FormPracticasPorEspecialidad()
        {
            InitializeComponent();
        }
        public void cargarcbespecialidades()
        {
            try
            {
                conexion = new Conexion();
                cbespecialidades.DataSource = null;
                cbespecialidades.Items.Clear();
                string query = "select id_especialidad,nombre_especialidad as nombre from Especialidades";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbespecialidades.ValueMember = "id_especialidad";
                cbespecialidades.DisplayMember = "nombre";
                cbespecialidades.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar las Especialidades", ex.Message);
            }
        }
        public void cargar_tabla()
        {
            try
            {
                conexion = new Conexion();
                string consulta = "select id_practica as Nº, nombre_practica as Practicas,tiempo_resultado as Demora, E.nombre_especialidad as Especilidad,M.nombre_muestra as Muestra from Practicas P  inner join Especialidades E on P.id_especialidad = E.id_especialidad inner join Muestras M on P.id_muestra = M.id_muestra where E.id_especialidad="+Convert.ToInt32(cbespecialidades.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvpracticasporespecialidad.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }

        }

        private void FormPracticasPorEspecialidad_Load(object sender, EventArgs e)
        {
            cargarcbespecialidades();
        }

        private void btnbuscarpracticaporespecialidad_Click(object sender, EventArgs e)
        {
            cargar_tabla();
        }
    }
}
