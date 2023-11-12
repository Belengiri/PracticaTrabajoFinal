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
        public FormCategorias()
        {
            InitializeComponent();
            cargar_tabla();
            dgvcategoria.ClearSelection();
        }
        public void cargar_tabla()
        {
            conexion = new Conexion();
            string consulta = "select id_categoria as Nº,nombre_categoria as Categoria from Categorias";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexion.GetSqlConnection();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvcategoria.DataSource = dt;
        }

        private void btneliminarcategoria_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cc.Eliminar_Categoria(Convert.ToInt32(dgvcategoria.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    btneliminarcategoria.Enabled = false;
                    btnmodificarcategoria.Enabled = false;
                    btnagregarcategoria.Enabled = true;
                    txtnombrecategoria.Clear();
                    txtnombrecategoria.Focus();
                    dgvcategoria.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtnombrecategoria.Clear();
                    txtnombrecategoria.Focus();
                    dgvcategoria.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                txtnombrecategoria.Clear();
                txtnombrecategoria.Focus();
                dgvcategoria.ClearSelection();
            }
        }

        private void btnmodificarcategoria_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cc.Modificar_Categoria(txtnombrecategoria.Text, Convert.ToInt32(dgvcategoria.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    dgvcategoria.ClearSelection();
                    btnmodificarcategoria.Enabled = false;
                    btneliminarcategoria.Enabled = false;
                    btnagregarcategoria.Enabled = true;
                    txtnombrecategoria.Clear();
                    txtnombrecategoria.Focus();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtnombrecategoria.Clear();
                    txtnombrecategoria.Focus();
                    dgvcategoria.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                txtnombrecategoria.Clear();
                txtnombrecategoria.Focus();
                dgvcategoria.ClearSelection();
            }
        }

        private void btnagregarcategoria_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cc.Agregar_Categoria(txtnombrecategoria.Text);
                    cargar_tabla();
                    txtnombrecategoria.Clear();
                    txtnombrecategoria.Focus();
                    dgvcategoria.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtnombrecategoria.Clear();
                    txtnombrecategoria.Focus();
                    dgvcategoria.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                txtnombrecategoria.Clear();
                txtnombrecategoria.Focus();
                dgvcategoria.ClearSelection();
            }
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btneliminarcategoria.Enabled = false;
            btnmodificarcategoria.Enabled = false;
            btnagregarcategoria.Enabled = true;
            dgvcategoria.ClearSelection();
            txtnombrecategoria.Clear();
            txtnombrecategoria.Focus();
        }

        private void dgvcategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombrecategoria.Focus();
            txtnombrecategoria.Text = dgvcategoria.CurrentRow.Cells[1].Value.ToString();
            btneliminarcategoria.Enabled = true;
            btnmodificarcategoria.Enabled = true;
            btnagregarcategoria.Enabled = false;
        }
    }
}
