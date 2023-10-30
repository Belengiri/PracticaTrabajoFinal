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
    public partial class FormPracticas : Form
    {
        //instrancion un control de practicas para enviar los datos
        ControladoraPracticas cp = new ControladoraPracticas();
        //creo una nueva conexio a la base de datos 
        SqlConnection conexion = new SqlConnection("workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal");
        //variables booleana para que el boton aceptar detecte la accion que debe realizar
        bool agregar = false;
        bool modificar = false;
        bool eliminar = false;
        public FormPracticas()
        {
            InitializeComponent();
            cargar_tabla();
        }
        //metodo para carga la grilla de practicas mostrando nombre de  especialidad y muestra
        public void cargar_tabla()
        {
            string consulta = "select p.id_practica as numero, nombre_practica as nombre, tiempo_resultado as demora, E.nombre_especialidad as especilidad,M.nombre_muestra as muestra from Practicas P inner join Especialidades E on P.id_especialidad = E.id_especialidad inner join Muestras M on P.id_muestra = M.id_muestra";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvgrillapracticas.DataSource = dt;

        }
        //metodo para cargar el combobox de especialidades con las especialidades disponibles
        public void cargarcbespecialidades()
        {
            cbespacialidadpractica.DataSource = null;
            cbespacialidadpractica.Items.Clear();
            string query = "select id_especialidad,nombre_especialidad as nombre from Especialidades";
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbespacialidadpractica.ValueMember = "id_especialidad";
                cbespacialidadpractica.DisplayMember = "nombre";
                cbespacialidadpractica.DataSource = dt;
            }catch (Exception e)
            {
                MessageBox.Show("error al cargar especialidades"+e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        //metodo para carga combobox con las muestras que ahi disponibles
        public void cargarcbmuestras()
        {
            cbtipodemuestra.DataSource = null;
            cbtipodemuestra.Items.Clear();
            string query = "select id_muestra,nombre_muestra as nombre from Muestras";
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbtipodemuestra.ValueMember = "id_muestra";
                cbtipodemuestra.DisplayMember = "nombre";
                cbtipodemuestra.DataSource = dt;
                
            }
            catch (Exception e)
            {
                MessageBox.Show("error al cargar especialidades" + e.Message);
            }finally
            {
                conexion.Close();
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
            //hago visible el panel para agregar los datos
            dgvgrillapracticas.ClearSelection();
            paneldatospracticas.Visible = true;
            lblnombrepractica.Visible = true;
            txtnombrepractica.Visible = true;
            lbltiempoderesultado.Visible = true;
            txttiempoderesultado.Visible = true;
            lblespecialidadpractica.Visible = true;
            cbespacialidadpractica.Visible = true;
            lbltipomuestra.Visible = true;
            cbtipodemuestra.Visible = true;
            agregarmuestra.Visible = true;
            agregarmuestra.Checked = false;
            lblnuevamuestra.Visible = false;
            txtnuevamuestra.Visible = false;
            btnguardarmuestra.Visible = false;
            btncancelar.Visible = false;
            txtnombrepractica.Clear();
            txttiempoderesultado.Clear();
            txtnombrepractica.Focus();
            agregar = true;
            modificar = false;
            eliminar = false;
            btnaceptarpractica.Enabled = true;
            
        }
        //boton modificar practica
        private void btnmodificarpractica_Click(object sender, EventArgs e)
        {
            //hago visible el panel para modificar los datos
            dgvgrillapracticas.ClearSelection();
            paneldatospracticas.Visible = true;
            paneldatospracticas.Visible = true;
            lblnombrepractica.Visible = true;
            txtnombrepractica.Visible = true;
            lbltiempoderesultado.Visible = true;
            txttiempoderesultado.Visible = true;
            lblespecialidadpractica.Visible = true;
            cbespacialidadpractica.Visible = true;
            lbltipomuestra.Visible = true;
            cbtipodemuestra.Visible = true;
            agregarmuestra.Visible = true;
            DataGridViewCellEventArgs evento = new DataGridViewCellEventArgs(0, 0);
            // Llama manualmente al evento de clic de celda
            dgvgrillapracticas_CellClick(dgvgrillapracticas, evento);
            modificar = true;
            agregar = false;
            eliminar = false;
            agregarmuestra.Visible = false;
            agregarmuestra.Checked = false;
            lblnuevamuestra.Visible = false;
            txtnuevamuestra.Visible = false;
            btnguardarmuestra.Visible = false;
            btncancelar.Visible = false;
            btnaceptarpractica.Enabled = true;
        }
        //metodo de la grilla para cargar los textbox con los datos seleccionados
        private void dgvgrillapracticas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //aca llena los textbox con los datos de la grilla para el boton modificar
            txtnombrepractica.Text = dgvgrillapracticas.CurrentRow.Cells[1].Value.ToString();
            txttiempoderesultado.Text = dgvgrillapracticas.CurrentRow.Cells[2].Value.ToString();
            cbespacialidadpractica.Text=dgvgrillapracticas.CurrentRow.Cells[3].Value.ToString();
            cbtipodemuestra.Text=dgvgrillapracticas.CurrentRow.Cells[4].Value.ToString();
        }
        //boton de Aceptar acciones de la practica 
        //en este boton envia los datos de la vista al controlador
        private void btnaceptarpractica_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                if (agregar == true)
                {

                    cp.Agregar_Practica(txtnombrepractica.Text, Convert.ToInt32(txttiempoderesultado.Text), cbespacialidadpractica.SelectedValue.ToString(), cbtipodemuestra.SelectedValue.ToString());
                    cargar_tabla();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
                else if (modificar == true)
                {
                    cp.Modificar_Practica(txtnombrepractica.Text, Convert.ToInt32(txttiempoderesultado.Text), cbespacialidadpractica.SelectedValue.ToString(), cbtipodemuestra.SelectedValue.ToString(), Convert.ToInt32(dgvgrillapracticas.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    dgvgrillapracticas.ClearSelection();
                } else if (eliminar == true)
                {
                    cp.Eliminar_Practica(Convert.ToInt32(dgvgrillapracticas.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    dgvgrillapracticas.ClearSelection();
                }
               
            }else if (dr==DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
                txtnombrepractica.Clear();
                txttiempoderesultado.Clear();
                dgvgrillapracticas.ClearSelection();
            }

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
            btncancelar.Visible = true;
            txtnuevamuestra.Focus();
            btnaceptarpractica.Enabled=false;
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
            btncancelar.Visible = false;
            btnaceptarpractica.Enabled = true;
        }
        //boton para cancelar la accion de la carga de nueva muestra
        private void btncancelar_Click(object sender, EventArgs e)
        {
            agregarmuestra.Checked = false;
            btncancelar.Visible = false;
            lblnuevamuestra.Visible = false;
            txtnuevamuestra.Visible = false;
            btnguardarmuestra.Visible = false;
            btnaceptarpractica.Enabled = true;
        }
        //boton para eliminar una practica
        private void btneliminarpractica_Click(object sender, EventArgs e)
        {
            dgvgrillapracticas.ClearSelection();
            paneldatospracticas.Visible = true;
            lblnombrepractica.Visible = false;
            txtnombrepractica.Visible = false;
            lbltiempoderesultado.Visible = false;
            txttiempoderesultado.Visible = false;
            lblespecialidadpractica.Visible = false;
            cbespacialidadpractica.Visible = false;
            lbltipomuestra.Visible = false;
            cbtipodemuestra.Visible = false;
            DataGridViewCellEventArgs evento = new DataGridViewCellEventArgs(0, 0);

            // Llama manualmente al evento de clic de celda
            dgvgrillapracticas_CellClick(dgvgrillapracticas, evento);
            modificar = false;
            agregar = false;
            eliminar = true;
            agregarmuestra.Visible = false;
            agregarmuestra.Checked = false;
            lblnuevamuestra.Visible = false;
            txtnuevamuestra.Visible = false;
            btnguardarmuestra.Visible = false;
            btncancelar.Visible = false;
            btnaceptarpractica.Enabled = true;
        }
    }
}
