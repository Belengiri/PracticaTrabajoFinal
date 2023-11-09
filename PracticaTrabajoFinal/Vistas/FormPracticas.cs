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
    public partial class FormPracticas : Form
    {
        //instrancion un control de practicas para enviar los datos
        ControladoraPracticas cp = new ControladoraPracticas();
        //creo una nueva conexio a la base de datos 
        private Conexion conexion;
        public FormPracticas()
        {
            InitializeComponent();
            cargar_tabla();
        }
        //metodo para carga la grilla de practicas mostrando nombre de  especialidad y muestra
        public void cargar_tabla()
        {
            conexion = new Conexion();
            string consulta = "select p.id_practica as numero, nombre_practica as nombre, tiempo_resultado as demora, E.nombre_especialidad as especilidad,M.nombre_muestra as muestra from Practicas P inner join Especialidades E on P.id_especialidad = E.id_especialidad inner join Muestras M on P.id_muestra = M.id_muestra";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexion.GetSqlConnection();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvgrillapracticas.DataSource = dt;

        }
        //metodo para cargar el combobox de especialidades con las especialidades disponibles
        public void cargarcbespecialidades()
        {
            try
            {
                conexion = new Conexion();
                cbespacialidadpractica.DataSource = null;
                cbespacialidadpractica.Items.Clear();
                string query = "select id_especialidad,nombre_especialidad as nombre from Especialidades";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbespacialidadpractica.ValueMember = "id_especialidad";
                cbespacialidadpractica.DisplayMember = "nombre";
                cbespacialidadpractica.DataSource = dt;
            }catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
        //metodo para carga combobox con las muestras que ahi disponibles
        public void cargarcbmuestras()
        {
            try
            {
                conexion = new Conexion();
                cbtipodemuestra.DataSource = null;
                cbtipodemuestra.Items.Clear();
                string query = "select id_muestra,nombre_muestra as nombre from Muestras";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbtipodemuestra.ValueMember = "id_muestra";
                cbtipodemuestra.DisplayMember = "nombre";
                cbtipodemuestra.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
        private void FormPracticas_Load(object sender, EventArgs e)
        {
            dgvgrillapracticas.ClearSelection();
            cargarcbespecialidades();
            cargarcbmuestras();

        }
        //boton agregar practica
        private void btnagregarpractica_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cp.Agregar_Practica(txtnombrepractica.Text, Convert.ToInt32(txttiempoderesultado.Text), cbespacialidadpractica.SelectedValue.ToString(), cbtipodemuestra.SelectedValue.ToString());
                    cargar_tabla();
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                txtnombrepractica.Focus();
                txtnombrepractica.Clear();
                txttiempoderesultado.Clear();
                dgvgrillapracticas.ClearSelection();
            }
        }
        //boton modificar practica
        private void btnmodificarpractica_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cp.Modificar_Practica(txtnombrepractica.Text, Convert.ToInt32(txttiempoderesultado.Text), cbespacialidadpractica.SelectedValue.ToString(), cbtipodemuestra.SelectedValue.ToString(), Convert.ToInt32(dgvgrillapracticas.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    btnmodificarpractica.Enabled = false;
                    btneliminarpractica.Enabled = false;
                    btnagregarpractica.Enabled = true;
                    agregarmuestra.Visible = true;
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                txtnombrepractica.Focus();
                txtnombrepractica.Clear();
                txttiempoderesultado.Clear();
                dgvgrillapracticas.ClearSelection();
            }
        }
        //metodo de la grilla para cargar los textbox con los datos seleccionados
        private void dgvgrillapracticas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombrepractica.Text = dgvgrillapracticas.CurrentRow.Cells[1].Value.ToString();
            txttiempoderesultado.Text = dgvgrillapracticas.CurrentRow.Cells[2].Value.ToString();
            cbespacialidadpractica.Text = dgvgrillapracticas.CurrentRow.Cells[3].Value.ToString();
            cbtipodemuestra.Text = dgvgrillapracticas.CurrentRow.Cells[4].Value.ToString();
            btneliminarpractica.Enabled = true;
            btnmodificarpractica.Enabled = true;
            btnagregarpractica.Enabled = false;
            agregarmuestra.Visible = false;
        }
       
        //metodo del textbox para cambiar el foco del nombre ala demora con la tecla enter
        private void txtnombrepractica_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si presiona enter pasa el focus al siguiente txt
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txttiempoderesultado.Focus();
                e.Handled = true;
            }
        }
        //check box para darle la opcion de agregar una nueva muestra
        //y desabilita el boton aceptar
        private void agregarmuestra_CheckedChanged(object sender, EventArgs e)
        {
            lblnuevamuestra.Visible = true;
            txtnuevamuestra.Visible = true;
            btnguardarmuestra.Visible = true;
            btncancelarmuestra.Visible = true;
            txtnuevamuestra.Focus();
            btncancelar.Enabled=false;
        }
        //boton para guardar una nueva muestra
        private void btnguardarmuestra_Click(object sender, EventArgs e)
        {
            cp.Agregar_Muestra(txtnuevamuestra.Text);
            cargarcbmuestras();
            agregarmuestra.Checked = false;
            btnguardarmuestra.Visible = false;
            lblnuevamuestra.Visible = false;
            txtnuevamuestra.Visible = false;
            btncancelarmuestra.Visible = false;
            btncancelar.Enabled = true;
        }
        //boton para cancelar la accion de la carga de nueva muestra
        private void btncancelar_Click(object sender, EventArgs e)
        {
            agregarmuestra.Checked = false;
            btncancelarmuestra.Visible = false;
            lblnuevamuestra.Visible = false;
            txtnuevamuestra.Visible = false;
            btnguardarmuestra.Visible = false;
            btncancelar.Enabled = true;
            dgvgrillapracticas.ClearSelection();
        }
        //boton para eliminar una practica
        private void btneliminarpractica_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cp.Eliminar_Practica(Convert.ToInt32(dgvgrillapracticas.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    btnmodificarpractica.Enabled = false;
                    btneliminarpractica.Enabled = false;
                    btnagregarpractica.Enabled = true;
                    agregarmuestra.Visible = true;
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                txtnombrepractica.Focus();
                txtnombrepractica.Clear();
                txttiempoderesultado.Clear();
                dgvgrillapracticas.ClearSelection();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            btneliminarpractica.Enabled = false;
            btnmodificarpractica.Enabled = false;
            btnagregarpractica.Enabled = true;
            txtnombrepractica.Clear();
            txttiempoderesultado.Clear();
            txtnombrepractica.Focus();
            agregarmuestra.Visible = true;
            dgvgrillapracticas.ClearSelection();
            panelnuevamuestra.Visible = false;
        }
    }
}
