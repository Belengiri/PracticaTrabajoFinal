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
            cargarcbpracticas();
            cargar_tablaPXI();
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
       public void cargar_tablaPXI()
        {
            try
            {
                conexion = new Conexion();
                string consulta = "select R.apellido_paciente+' '+R.nombre_paciente as 'paciente',N.nombre_practica as Practicas from PracticasXingresos P inner join Ingresos I on I.id_ingreso=P.id_ingreso inner join Practicas N on P.id_practica=N.id_practica inner join Pacientes R on I.id_paciente=R.id_paciente";
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvpractXespecialidad.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("error", e.Message);
            }

        }
        public void cargar_tabla()
        {
            try
            {
                conexion = new Conexion();
                string consulta = "select I.id_ingreso as n,P.apellido_paciente +' '+P.nombre_paciente as 'paciente',M.apellido_profesional+' '+M.nombre_profesional as 'medico', fecha_ingreso  as ingreso,fecha_retiro  as retiro from Ingresos I inner join Pacientes P on P.id_paciente = I.id_paciente inner join Profesionales M on M.id_profesional=I.id_profesional";
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
        public void cargarcbpracticas()
        {
            try
            {
                conexion = new Conexion();
                cbpracticas.DataSource = null;
                cbpracticas.Items.Clear();
                string query = "select id_practica,nombre_practica as nombre from Practicas";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbpracticas.ValueMember = "id_practica";
                cbpracticas.DisplayMember = "nombre";
                cbpracticas.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("error", e.Message);
            }
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
                    cargar_tabla();
                    foreach(int item in ids)
                    {
                       ci.AgregarPracticaPorIngreso(item);
                    }
                    cargar_tablaPXI();
                    dgvpractXespecialidad.ClearSelection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("datos incorrectos",ex.Message);
                }
               
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");
               
            }
        }

        private void btnmodificaringreso_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {

                    ci.Modificar_Ingreso(Convert.ToInt32(dgvingresos.CurrentRow.Cells[0].Value.ToString()) ,Convert.ToInt32(cbpacientes.SelectedValue.ToString()), Convert.ToInt32(cbmedicos.SelectedValue.ToString()), dtfechaingreso.Value.ToShortDateString(), dtfecharetiro.Value.ToShortDateString());
                    cargar_tabla();
                    btnmodificaringreso.Enabled = false;
                    btneliminaringreso.Enabled = false;
                    btnagregaringreso.Enabled = true;
                    lblpracticas.Visible = true;
                    cbpracticas.Visible = true;
                    dgvingresos.ClearSelection();
                    lblagreganuevopaciente.Visible = true;
                    lblagregarmedico.Visible = true;
                    btnnuevomedico.Visible = true;
                    btnnuevopaciente.Visible = true;
                    btnrecargarmedicos.Visible = true;
                    btnrecargarpacientes.Visible = true;
                    dgvpractXespecialidad.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                }

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");

            }

        }

        private void btneliminaringreso_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmacion = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirme la accion", "Confirmar", confirmacion, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    ci.Eliminar_PracXing(Convert.ToInt32(dgvingresos.CurrentRow.Cells[0].Value.ToString()));
                    ci.Eliminar_Ingreso(Convert.ToInt32(dgvingresos.CurrentRow.Cells[0].Value.ToString()));
                    cargar_tabla();
                    cargar_tablaPXI();
                    btnmodificaringreso.Enabled = false;
                    btneliminaringreso.Enabled = false;
                    btnagregaringreso.Enabled = true;
                    lblpracticas.Visible = true;
                    cbpracticas.Visible = true;
                    dgvingresos.ClearSelection();
                    lblagreganuevopaciente.Visible = true;
                    lblagregarmedico.Visible = true;
                    btnnuevomedico.Visible = true;
                    btnnuevopaciente.Visible = true;
                    btnrecargarmedicos.Visible = true;
                    btnrecargarpacientes.Visible = true;
                    dgvpractXespecialidad.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("datos incorrectos");
                }

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no confirmada");

            }
        }

        private void dgvingresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbpacientes.Text = dgvingresos.CurrentRow.Cells[1].Value.ToString();
            cbmedicos.Text = dgvingresos.CurrentRow.Cells[2].Value.ToString();
            dtfechaingreso.Text = dgvingresos.CurrentRow.Cells[3].Value.ToString();
            dtfecharetiro.Text = dgvingresos.CurrentRow.Cells[4].Value.ToString();
            btneliminaringreso.Enabled = true;
            btnmodificaringreso.Enabled = true;
            btnagregaringreso.Enabled = false;
            cbpracticas.Visible = false;
            lblpracticas.Visible = false;
            lblagreganuevopaciente.Visible = false;
            lblagregarmedico.Visible = false;
            btnnuevomedico.Visible = false;
            btnnuevopaciente.Visible = false;
            btnrecargarmedicos.Visible = false;
            btnrecargarpacientes.Visible = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btnagregaringreso.Enabled = true;
            btneliminaringreso.Enabled = false;
            btnmodificaringreso.Enabled = false;
            cbpracticas.Visible = true;
            lblpracticas.Visible = true;
            dgvingresos.ClearSelection();
            lblagreganuevopaciente.Visible = true;
            lblagregarmedico.Visible = true;
            btnnuevomedico.Visible = true;
            btnnuevopaciente.Visible = true;
            btnrecargarmedicos.Visible = true;
            btnrecargarpacientes.Visible = true;
            dgvpractXespecialidad.ClearSelection();
        }
        List<int> ids = new List<int>();
        private void btnagregarpractica_Click(object sender, EventArgs e)
        {
            lbpracticas.Items.Add(cbpracticas.Text);
            ids.Add(Convert.ToInt32(cbpracticas.SelectedValue.ToString()));
        }
    }
}
