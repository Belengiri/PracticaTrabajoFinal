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
    public partial class FormCategorias : Form
    {
        private Conexion conexion = new Conexion();
        ControladoraPersonalLaboratorio cc = new ControladoraPersonalLaboratorio();
        bool agregar=false;
        bool eliminar = false;
        bool modificar=false;
        public FormCategorias()
        {
            InitializeComponent();
            cargar_tabla();
            dgvcategoria.ClearSelection();
        }
        public void cargar_tabla()
        {
            conexion = new Conexion();
            string consulta = "select id_categoria as n,nombre_categoria as nombre from Categorias";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexion.GetSqlConnection();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvcategoria.DataSource = dt;
        }

        private void btnaceptarcategoria_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (agregar == true)
                {
                    cc.Agregar_Categoria(txtnombrecategoria.Text);
                    cargar_tabla();
                    txtnombrecategoria.Clear();
                    txtnombrecategoria.Focus();
                    dgvcategoria.ClearSelection();
                }
                else if (modificar == true)
                {
                    cc.Modificar_Categoria(txtnombrecategoria.Text, Convert.ToInt32(dgvcategoria.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    dgvcategoria.ClearSelection();
                }
                else if (eliminar == true)
                {
                    cc.Eliminar_Categoria(Convert.ToInt32(dgvcategoria.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    txtnombrecategoria.Clear();
                    dgvcategoria.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                txtnombrecategoria.Clear();
                txtnombrecategoria.Focus();
                dgvcategoria.ClearSelection();
            }
        }

        private void btneliminarcategoria_Click(object sender, EventArgs e)
        {
            eliminar = true;
            agregar = false;
            eliminar = false;
            txtnombrecategoria.Clear();
            paneldatoscategoria.Visible = true;
            txtnombrecategoria.Visible = false;
            lblnombrecategoria.Visible = false;

        }

        private void btnmodificarcategoria_Click(object sender, EventArgs e)
        {
            modificar = true;
            agregar = false;
            eliminar = false;
            txtnombrecategoria.Clear();
            paneldatoscategoria.Visible = true;
            txtnombrecategoria.Visible = true;
            lblnombrecategoria.Visible = true;
        }

        private void btnagregarcategoria_Click(object sender, EventArgs e)
        {
            agregar = true;
            eliminar = false;
            modificar = false;
            txtnombrecategoria.Clear();
            paneldatoscategoria.Visible = true;
            txtnombrecategoria.Visible = true;
            lblnombrecategoria.Visible = true;
        }

        private void dgvcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == true)
            {
                txtnombrecategoria.Text = dgvcategoria.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
