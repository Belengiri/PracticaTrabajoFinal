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
    public partial class FormPersonalPorEspecialidad : Form
    {
        private Conexion conexion;
        ControladoraEspecialidades cespxper = new ControladoraEspecialidades();
        public FormPersonalPorEspecialidad()
        {
            InitializeComponent();
            cargarcbespecialidades();
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
                string consulta = "select id_personal_lab as Nº,nombre_personal_lab as Nombre,apellido_personal_lab as Apellido,matricula_personal_lab as Matricula,C.nombre_categoria as Categoria, E.nombre_especialidad as Especialidad from Personal_Laboratorio P inner join Especialidades E on P.id_especialidad = E.id_especialidad inner join Categorias C on P.id_categoria = C.id_categoria where E.id_especialidad ="+ Convert.ToInt32(cbespecialidades.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvpersonalporespecialidad.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar los Datos", ex.Message);
            }
        }

        private void btnbuscarpersonalporespecialidad_Click(object sender, EventArgs e)
        {
            cargar_tabla();
        }
    }
}
