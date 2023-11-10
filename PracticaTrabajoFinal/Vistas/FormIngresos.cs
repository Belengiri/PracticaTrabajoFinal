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
    public partial class FormIngresos : Form
    {
        private Conexion conexion;
        ControladoraIngresos ci = new ControladoraIngresos();
        public FormIngresos()
        {
            InitializeComponent();
            cargarcbpacientes();
            cargarcbmedicos();
            cargar_tabla();
            dgvingresos.ClearSelection();
            cargarchecklist();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cargarcbpacientes()
        {
            try
            {
                conexion = new Conexion();
                cbpacientes.DataSource = null;
                cbpacientes.Items.Clear();
                string query = "select id_paciente,apellido_paciente +' '+ nombre_paciente  as 'nombre' from Pacientes";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbpacientes.ValueMember = "id_paciente";
                cbpacientes.DisplayMember = "nombre";
                cbpacientes.DataSource = dt;
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
                conexion = new Conexion();
                cbmedicos.DataSource = null;
                cbmedicos.Items.Clear();
                string query = "select id_profesional,apellido_profesional +' '+ nombre_profesional  as 'nombre' from Profesionales";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbmedicos.ValueMember = "id_profesional";
                cbmedicos.DisplayMember = "nombre";
                cbmedicos.DataSource = dt;
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
                conexion = new Conexion();
                string consulta = "select I.id_ingreso as n, fecha_ingreso  as ingreso,fecha_retiro  as retiro,P.apellido_paciente +' '+P.nombre_paciente as 'paciente',M.apellido_profesional+' '+M.nombre_profesional as 'medico' from Ingresos I inner join Pacientes P on P.id_paciente = I.id_paciente inner join Profesionales M on M.id_profesional=I.id_profesional";
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvingresos.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("error", e.Message);
            }

        }
        
        public List<int> cargarchecklist()
        {
            List<int> ids_practicas = new List<int>();
            try
            {
                conexion = new Conexion();
                checklistpracticas.DataSource = null;
                checklistpracticas.Items.Clear();
                string query = "select id_practica,nombre_practica  as nombre from Practicas";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    checklistpracticas.Items.Add(data["nombre"].ToString());
                }
                checklistpracticas.ValueMember = "id_practica";
                checklistpracticas.DisplayMember = "nombre";
                
                while (data.Read())
                {
                    ids_practicas.Add(Convert.ToInt32(checklistpracticas.SelectedValue.ToString()));
                }
                return ids_practicas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
            return ids_practicas;
        }

        private void btnrecargarpacientes_Click(object sender, EventArgs e)
        {
            cargarcbpacientes();
        }

        private void btnrecargarmedicos_Click(object sender, EventArgs e)
        {
            cargarcbmedicos();
        }

        private void btnnuevopaciente_Click(object sender, EventArgs e)
        {
            FormPacientes fp= new FormPacientes();
            fp.Show();
        }

        private void btnnuevomedico_Click(object sender, EventArgs e)
        {
            FormPersonalMedico fm=new FormPersonalMedico();
            fm.Show();
        }

        private void btnagregaringreso_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    ci.Agregar_Ingreso(Convert.ToInt32(cbpacientes.SelectedValue.ToString()), Convert.ToInt32(cbmedicos.SelectedValue.ToString()),dtfechaingreso.Value.ToShortDateString(), dtfecharetiro.Value.ToShortDateString());
                    
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                    
                }
                //ci.AgregarPracticaPorIngreso();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
               
            }
        }
    }
}
