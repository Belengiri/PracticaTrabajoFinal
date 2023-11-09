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
    public partial class FormPersonalLaboratorio : Form
    {
        ControladoraPersonalLaboratorio cpl = new ControladoraPersonalLaboratorio();
        private Conexion conexion;
        public FormPersonalLaboratorio()
        {
            InitializeComponent();
            cargacbcategoria();
            cargar_tabla();
        }
        public void cargar_tabla()
        {
            conexion = new Conexion();
            string consulta = "select id_personal_lab  as n, nombre_personal_lab  as nombre, apellido_personal_lab  as apellido,matricula_personal_lab  as matricula, E.nombre_especialidad as especialidad,C.nombre_categoria as categoria from Personal_Laboratorio P inner join Especialidades E on P.id_especialidad  = E.id_especialidad inner join Categorias C on P.id_categoria = C.id_categoria";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexion.GetSqlConnection();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvpacientes.DataSource = dt;
        }
        public void cargacbcategoria()
        {
            try
            {
                conexion = new Conexion();
                cbcategoriaperlab.DataSource = null;
                cbcategoriaperlab.Items.Clear();
                string query = "select id_categoria,nombre_categoria as nombre from Categorias";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbcategoriaperlab.ValueMember = "id_categoria";
                cbcategoriaperlab.DisplayMember = "nombre";
                cbcategoriaperlab.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
    }
}
