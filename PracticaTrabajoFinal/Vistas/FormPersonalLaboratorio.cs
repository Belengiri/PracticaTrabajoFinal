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
        ControladoraEspecialidades ce = new ControladoraEspecialidades();
        private Conexion conexion;
        public FormPersonalLaboratorio()
        {
            InitializeComponent();
            cargacbcategoria();
            cargar_tabla();
            cargacbespecialidad();
            dgvperlab.ClearSelection();
        }
        public void cargar_tabla()
        {
            try
            {
                conexion = new Conexion();
                string consulta = "select id_personal_lab  as Nº, nombre_personal_lab  as Nombre, apellido_personal_lab  as Apellido,matricula_personal_lab  as Matricula, E.nombre_especialidad as Especialidad,C.nombre_categoria as Categoria from Personal_Laboratorio P inner join Especialidades E on P.id_especialidad  = E.id_especialidad inner join Categorias C on P.id_categoria = C.id_categoria";
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvperlab.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error al Cargar los Datos");
            }
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
                MessageBox.Show("Error al Cargar las Categorias", ex.Message);
            }
        }
        public void cargacbespecialidad()
        {
            try
            {
                conexion = new Conexion();
                cbespecialidadperlab.DataSource = null;
                cbespecialidadperlab.Items.Clear();
                string query = "select id_especialidad,nombre_especialidad as nombre from Especialidades";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbespecialidadperlab.ValueMember = "id_especialidad";
                cbespecialidadperlab.DisplayMember = "nombre";
                cbespecialidadperlab.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar las Especialidades", ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;
            btnagregar.Enabled = true;
            txtnombreperlab.Clear();
            txtapellidoperlab.Clear();
            txtmatriculaperlab.Clear();
            agregarnuevacategoria.Visible = true;
            agregarnuevaespecialidad.Visible = true;
            panelnuevacategoria.Visible = false;
            panelagregarnuevaespecialidad.Visible = false;
            dgvperlab.ClearSelection();
        }



        private void agregarnuevacategoria_CheckedChanged(object sender, EventArgs e)
        {
            panelnuevacategoria.Visible = true;
            panelagregarnuevaespecialidad.Visible=false;
            agregarnuevaespecialidad.Checked = false;
        }

        private void agregarnuevaespecialidad_CheckedChanged(object sender, EventArgs e)
        {
            panelnuevacategoria.Visible = false ;
            panelagregarnuevaespecialidad.Visible = true;
            agregarnuevacategoria.Checked = false;
        }

        private void btncancelarcategoria_Click(object sender, EventArgs e)
        {
            agregarnuevacategoria.Checked = false;
            panelnuevacategoria.Visible = false;
        }

        private void btnguardarcategoria_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    agregarnuevacategoria.Checked = false;
                    cpl.Agregar_Categoria(txtnombrecategoria.Text);
                    txtnombrecategoria.Clear();
                    panelnuevacategoria.Visible = false;
                    cargacbcategoria();
                    dgvperlab.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    dgvperlab.ClearSelection();
                    txtnombrecategoria.Focus();
                    txtnombrecategoria.Clear();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                dgvperlab.ClearSelection();
                txtnombrecategoria.Focus();
                txtnombrecategoria.Clear();
            }
         }

        private void dgvperlab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombreperlab.Focus();
            txtnombreperlab.Text = dgvperlab.CurrentRow.Cells[1].Value.ToString();
            txtapellidoperlab.Text = dgvperlab.CurrentRow.Cells[2].Value.ToString();
            txtmatriculaperlab.Text = dgvperlab.CurrentRow.Cells[3].Value.ToString();
            cbespecialidadperlab.Text = dgvperlab.CurrentRow.Cells[4].Value.ToString();
            cbcategoriaperlab.Text = dgvperlab.CurrentRow.Cells[5].Value.ToString();
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;
            btnagregar.Enabled = false;
            agregarnuevaespecialidad.Visible = false;
            agregarnuevacategoria.Visible = false;
        }

        private void btnguardarespecialidad_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    agregarnuevaespecialidad.Checked = false;
                    ce.Agregar_Especialidad(txtespecialidadperlab.Text);
                    txtespecialidadperlab.Clear();
                    panelagregarnuevaespecialidad.Visible = false;
                    cargacbespecialidad();
                    dgvperlab.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    dgvperlab.ClearSelection();
                    txtespecialidadperlab.Focus();
                    txtespecialidadperlab.Clear();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                dgvperlab.ClearSelection();
                txtespecialidadperlab.Focus();
                txtespecialidadperlab.Clear();
            }
        }

        private void btncancelarespecialidad_Click(object sender, EventArgs e)
        {
            agregarnuevaespecialidad.Checked = false;
            panelagregarnuevaespecialidad.Visible = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cpl.Eliminar_Personal(Convert.ToInt32(dgvperlab.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    btneliminar.Enabled = false;
                    btnmodificar.Enabled = false;
                    btnagregar.Enabled = true;
                    agregarnuevacategoria.Visible = true;
                    agregarnuevaespecialidad.Visible = true;
                    dgvperlab.ClearSelection();
                    txtnombreperlab.Focus();
                    txtnombreperlab.Clear();
                    txtapellidoperlab.Clear();
                    txtmatriculaperlab.Clear();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    dgvperlab.ClearSelection();
                    txtnombreperlab.Focus();
                    txtnombreperlab.Clear();
                    txtapellidoperlab.Clear();
                    txtmatriculaperlab.Clear();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                dgvperlab.ClearSelection();
                txtnombreperlab.Focus();
                txtnombreperlab.Clear();
                txtapellidoperlab.Clear();
                txtmatriculaperlab.Clear();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cpl.Modificar_Personal(Convert.ToInt32(dgvperlab.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(cbcategoriaperlab.SelectedValue.ToString()), Convert.ToInt32(cbespecialidadperlab.SelectedValue.ToString()), txtnombreperlab.Text, txtapellidoperlab.Text, Convert.ToInt32(txtmatriculaperlab.Text));
                    cargar_tabla();
                    btnmodificar.Enabled = false;
                    btneliminar.Enabled = false;
                    btnagregar.Enabled = true;
                    agregarnuevacategoria.Visible = true;
                    agregarnuevaespecialidad.Visible = true;
                    dgvperlab.ClearSelection();
                    txtnombreperlab.Focus();
                    txtnombreperlab.Clear();
                    txtapellidoperlab.Clear();
                    txtmatriculaperlab.Clear();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    dgvperlab.ClearSelection();
                    txtnombreperlab.Focus();
                    txtnombreperlab.Clear();
                    txtapellidoperlab.Clear();
                    txtmatriculaperlab.Clear();
                }

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                dgvperlab.ClearSelection();
                txtnombreperlab.Focus();
                txtnombreperlab.Clear();
                txtapellidoperlab.Clear();
                txtmatriculaperlab.Clear();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cpl.Agregar_Personal(Convert.ToInt32(cbcategoriaperlab.SelectedValue.ToString()), Convert.ToInt32(cbcategoriaperlab.SelectedValue.ToString()), txtnombreperlab.Text, txtapellidoperlab.Text, Convert.ToInt32(txtmatriculaperlab.Text));
                    cargar_tabla();
                    dgvperlab.ClearSelection();
                    txtnombreperlab.Focus();
                    txtnombreperlab.Clear();
                    txtapellidoperlab.Clear();
                    txtmatriculaperlab.Clear();
                    btnagregar.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
                    dgvperlab.ClearSelection();
                    txtnombreperlab.Focus();
                    txtnombreperlab.Clear();
                    txtapellidoperlab.Clear();
                    txtmatriculaperlab.Clear();
                }


            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                dgvperlab.ClearSelection();
                txtnombreperlab.Focus();
                txtnombreperlab.Clear();
                txtapellidoperlab.Clear();
                txtmatriculaperlab.Clear();
            }
        }
    }
}
