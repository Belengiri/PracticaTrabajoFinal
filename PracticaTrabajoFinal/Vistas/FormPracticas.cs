﻿using PracticaTrabajoFinal.Controladores;
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
            try
            {
                conexion = new Conexion();
                string consulta = "select p.id_practica as Nº, nombre_practica as Practica, tiempo_resultado as Demora, E.nombre_especialidad as Especilidad,M.nombre_muestra as Muestra from Practicas P inner join Especialidades E on P.id_especialidad = E.id_especialidad inner join Muestras M on P.id_muestra = M.id_muestra";
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvgrillapracticas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar los Datos", ex.Message);
            }

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
                MessageBox.Show("Error al Cargar las Especialidades", ex.Message);
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
                MessageBox.Show("Error al Cargar las Muestras", ex.Message);
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
                    MessageBox.Show("Datos Incorrectos");
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
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
                    MessageBox.Show("Datos Incorrectos");
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
                txtnombrepractica.Focus();
                txtnombrepractica.Clear();
                txttiempoderesultado.Clear();
                dgvgrillapracticas.ClearSelection();
            }
        }
        //metodo de la grilla para cargar los textbox con los datos seleccionados
       
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
        
        //boton para guardar una nueva muestra
        private void btnguardarmuestra_Click(object sender, EventArgs e)
        {
            cp.Agregar_Muestra(txtnuevamuestra.Text);
            paneldgvmuestras.Visible = false;
            cargarcbmuestras();
            agregarmuestra.Checked = false;
            paneldgvmuestras.Visible = false;
            panelnuevamuestra.Visible = false;
            txtnuevamuestra.Clear();
        }
        //boton para cancelar la accion de la carga de nueva muestra
       
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
                    MessageBox.Show("Datos Incorrectos");
                    txtnombrepractica.Focus();
                    txtnombrepractica.Clear();
                    txttiempoderesultado.Clear();
                    dgvgrillapracticas.ClearSelection();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
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

        private void dgvgrillapracticas_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
        public void Cargar_Muestras()
        {
            try
            {
                conexion = new Conexion();
                dgvmuestra.DataSource = null;
                string consulta = "select nombre_muestra  as Muestras,id_muestra as Nº from Muestras";
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvmuestra.DataSource = dt;
                txtnuevamuestra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvmuestra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnuevamuestra.Text = dgvmuestra.CurrentRow.Cells[0].Value.ToString();
        }

        private void btneliminarmuestra_Click(object sender, EventArgs e)
        {
            cp.Eliminar_muestra(Convert.ToInt32(dgvmuestra.CurrentRow.Cells[1].Value.ToString()));
            cargarcbmuestras();
            agregarmuestra.Checked = false;
            paneldgvmuestras.Visible = false;
            panelnuevamuestra.Visible = false;
        }

        private void btnmodificarmuestra_Click(object sender, EventArgs e)
        {
            cp.Modificar_Muestra(txtnuevamuestra.Text, Convert.ToInt32(dgvmuestra.CurrentRow.Cells[1].Value.ToString()));
            cargarcbmuestras();
            agregarmuestra.Checked = false;
            paneldgvmuestras.Visible = false;
            panelnuevamuestra.Visible = false;
        }

       

        private void agregarmuestra_CheckedChanged(object sender, EventArgs e)
        {
            paneldgvmuestras.Visible = true;
            panelnuevamuestra.Visible = true;
            Cargar_Muestras();
            txtnuevamuestra.Focus();
            txtnuevamuestra.Clear();
        }

        private void btncancelarmuestra_Click(object sender, EventArgs e)
        {
            agregarmuestra.Checked = false;
            btneliminarpractica.Enabled = false;
            btnmodificarpractica.Enabled = false;
            btnagregarpractica.Enabled = true;
            txtnombrepractica.Clear();
            txttiempoderesultado.Clear();
            txtnombrepractica.Focus();
            agregarmuestra.Visible = true;
            dgvgrillapracticas.ClearSelection();
            panelnuevamuestra.Visible = false;
            paneldgvmuestras.Visible = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            agregarmuestra.Checked = false;
            btneliminarpractica.Enabled = false;
            btnmodificarpractica.Enabled = false;
            btnagregarpractica.Enabled = true;
            txtnombrepractica.Clear();
            txttiempoderesultado.Clear();
            txtnombrepractica.Focus();
            agregarmuestra.Visible = true;
            dgvgrillapracticas.ClearSelection();
            panelnuevamuestra.Visible = false;
            paneldgvmuestras.Visible = false;
        }
    }
}
