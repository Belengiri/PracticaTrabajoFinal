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
    public partial class FormEspecialidades : Form
    {
        private Conexion conexion;
        ControladoraEspecialidades ce = new ControladoraEspecialidades();
        bool agregar=false;
        bool modificar=false;
        bool eliminar = false;
        public FormEspecialidades()
        {
            InitializeComponent();
            cargar_tabla();
        }
        public void cargar_tabla()
        {
            conexion = new Conexion();
            string consulta = "select id_especialidad as numero,nombre_especialidad as nombre from Especialidades";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexion.GetSqlConnection();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvespecialidades.DataSource = dt;
        }

        private void btnagregarespecialidad_Click(object sender, EventArgs e)
        {   
            dgvespecialidades.ClearSelection();
            paneldatosespecialidad.Visible = true;
            lblnombreespecialidad.Visible = true;
            txtnombreespecialidad.Visible = true;
            txtnombreespecialidad.Clear();
            txtnombreespecialidad.Focus();
            agregar = true;
            modificar = false;
            eliminar = false;
        }

        private void btnmodificarespecialidad_Click(object sender, EventArgs e)
        {
            dgvespecialidades.ClearSelection();
            paneldatosespecialidad.Visible = true;
            lblnombreespecialidad.Visible = true;
            txtnombreespecialidad.Visible = true;
            modificar = true;
            agregar = false;
            eliminar = false;
            DataGridViewCellEventArgs evento = new DataGridViewCellEventArgs(0, 0);
            dgvespecialidades_CellClick(dgvespecialidades, evento);

        }

        private void btneliminarespecialidad_Click(object sender, EventArgs e)
        {
            dgvespecialidades.ClearSelection();
            paneldatosespecialidad.Visible = true;
            lblnombreespecialidad.Visible = false;
            txtnombreespecialidad.Visible = false;
            DataGridViewCellEventArgs evento = new DataGridViewCellEventArgs(0, 0);
            dgvespecialidades_CellClick(dgvespecialidades, evento);
            eliminar = true;
            modificar = false;
            agregar = false;
            

        }

        private void FormEspecialidades_Load(object sender, EventArgs e)
        {
            dgvespecialidades.ClearSelection();
        }

        private void btnaceptarespecialidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (agregar == true)
                {

                    ce.Agregar_Especialidad(txtnombreespecialidad.Text);
                    cargar_tabla();
                    txtnombreespecialidad.Clear();
                    txtnombreespecialidad.Focus();
                    dgvespecialidades.ClearSelection();
                }
                else if (modificar == true)
                {
                    ce.Modificar_Especialidad(txtnombreespecialidad.Text,Convert.ToInt32(dgvespecialidades.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    dgvespecialidades.ClearSelection();
                }
                else if (eliminar == true)
                {
                    ce.Eliminar_Especialidad(Convert.ToInt32(dgvespecialidades.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    dgvespecialidades.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                txtnombreespecialidad.Clear();
                txtnombreespecialidad.Focus();
                dgvespecialidades.ClearSelection();
            }
        }

        private void dgvespecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == true || eliminar==true)
            {
                txtnombreespecialidad.Text = dgvespecialidades.CurrentRow.Cells[1].Value.ToString();
            }
            
        }
    }
}
