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
        private CadenaString conexion;
        ControladoraEspecialidades cespxprac = new ControladoraEspecialidades();
        public FormPracticasPorEspecialidad()
        {
            InitializeComponent();
            conexion= new CadenaString();
        }
        public void cargarcbespecialidades_practica()
        {
            try
            {
                cbespecialidades.DataSource = null;
                cbespecialidades.Items.Clear();
                string query = "select id_especialidad,nombre_especialidad as nombre from Especialidades";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbespecialidades.ValueMember = "id_especialidad";
                cbespecialidades.DisplayMember = "nombre";
                cbespecialidades.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
            
        }
        public void cargar_tabla_practica()
        {
            try
            {
               
                string consulta = "select id_practica as numero, nombre_practica as nombre,tiempo_resultado as demora, E.nombre_especialidad as especilidad,M.nombre_muestra as muestra from Practicas P  inner join Especialidades E on P.id_especialidad = E.id_especialidad inner join Muestras M on P.id_muestra = M.id_muestra where E.id_especialidad="+Convert.ToInt32(cbespecialidades.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetConnection();
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
            cargarcbespecialidades_practica();
            conexion = new CadenaString();
        }

        private void btnbuscarpracticaporespecialidad_Click(object sender, EventArgs e)
        {
            cargar_tabla_practica();
        }
    }
}
