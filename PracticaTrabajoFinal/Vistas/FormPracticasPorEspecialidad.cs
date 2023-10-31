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
    public partial class FormPracticasPorEspecialidad : Form
    {
        SqlConnection conexion = new SqlConnection("workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal");
        ControladoraEspecialidades cespxprac = new ControladoraEspecialidades();
        public FormPracticasPorEspecialidad()
        {
            InitializeComponent();
        }
        public void cargarcbespecialidades()
        {
            try
            {
                cbespecialidades.DataSource = null;
                cbespecialidades.Items.Clear();
                string query = "select id_especialidad,nombre_especialidad as nombre from Especialidades";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
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
                string consulta = "select id_practica as numero, nombre_practica as nombre,tiempo_resultado as demora, E.nombre_especialidad as especilidad,M.nombre_muestra as muestra from Practicas P  inner join Especialidades E on P.id_especialidad = E.id_especialidad inner join Muestras M on P.id_muestra = M.id_muestra where E.id_especialidad="+Convert.ToInt32(cbespecialidades.SelectedValue.ToString());
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvpracticasporespecialidad.DataSource = dt;

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
