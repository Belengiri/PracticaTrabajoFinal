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
                string consulta = "select id_practicaXingreso as Nº,R.apellido_paciente+' '+R.nombre_paciente as 'Paciente',N.nombre_practica as Practicas,Resultado from PracticasXingresos P inner join Ingresos I on I.id_ingreso=P.id_ingreso inner join Practicas N on P.id_practica=N.id_practica inner join Pacientes R on I.id_paciente=R.id_paciente where P.id_ingreso=" + Convert.ToInt32(dgvingresos.CurrentRow.Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand(consulta);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvpractXingreso.DataSource = dt;
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
                string consulta = "select I.id_ingreso as Nº,P.apellido_paciente +' '+P.nombre_paciente as 'paciente',M.apellido_profesional+' '+M.nombre_profesional as 'medico', fecha_ingreso  as ingreso,fecha_retiro  as retiro from Ingresos I inner join Pacientes P on P.id_paciente = I.id_paciente inner join Profesionales M on M.id_profesional=I.id_profesional";
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
                    lbpracticas.Items.Clear();
                    lbpracticas.Visible = true;
                    dgvpractXingreso.DataSource = null;
                    dgvingresos.ClearSelection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Datos Incorrectos",ex.Message);
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
                    dgvpractXingreso.ClearSelection();
                    lbpracticas.Items.Clear();
                    lbpracticas.Visible = true;
                    btnagregarpractica.Visible = true;
                }
               
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
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
                dgvpractXingreso.ClearSelection();
                lbpracticas.Items.Clear();
                lbpracticas.Visible = true;
                btnagregarpractica.Visible = true;

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
                    ci.Modificar_PXI(Convert.ToInt32(cbpracticas.SelectedValue.ToString()), Convert.ToInt32(dgvpractXingreso.CurrentRow.Cells[0].Value.ToString()));
                    if (txtresultado.Text != "")
                    {
                        ci.Agregar_Resultado(txtresultado.Text, Convert.ToInt32(dgvpractXingreso.CurrentRow.Cells[0].Value.ToString()));
                    }
                    cargar_tablaPXI();
                    txtresultado.Visible = false;
                    lblresultado.Visible = false;
                    dgvpractXingreso.DataSource = null;
                    lbpracticas.Visible = true;
                    cbpacientes.Enabled = true;
                    cbmedicos.Enabled = true;
                    dtfechaingreso.Enabled = true;
                    dtfecharetiro.Enabled = true;
                    lbpracticas.Items.Clear();
                    btnagregarpractica.Visible = true;
                    btnmodificaringreso.Enabled = false;
                    btneliminaringreso.Enabled = false;
                    btnagregaringreso.Enabled = true;
                    lblpracticas.Visible = true;
                    cbpracticas.Visible = true;
                    lblagreganuevopaciente.Visible = true;
                    lblagregarmedico.Visible = true;
                    btnnuevomedico.Visible = true;
                    btnnuevopaciente.Visible = true;
                    btnrecargarmedicos.Visible = true;
                    btnrecargarpacientes.Visible = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    dgvpractXingreso.ClearSelection();
                    lbpracticas.Items.Clear();
                    lbpracticas.Visible = true;
                    btnagregarpractica.Visible = true;
                }

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
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
                dgvpractXingreso.ClearSelection();
                lbpracticas.Items.Clear();
                lbpracticas.Visible = true;
                btnagregarpractica.Visible = true;

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
                    dgvpractXingreso.DataSource = null;
                    lbpracticas.Visible = true;
                    lbpracticas.Items.Clear();
                    btnagregarpractica.Visible = true;
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
                    dgvpractXingreso.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Datos Incorrectos");
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
                    dgvpractXingreso.ClearSelection();
                    lbpracticas.Items.Clear();
                    lbpracticas.Visible = true;
                    btnagregarpractica.Visible = true;
                }

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Accion no Confirmada");
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
                dgvpractXingreso.ClearSelection();
                lbpracticas.Items.Clear();
                lbpracticas.Visible = true;
                btnagregarpractica.Visible = true;

            }
        }

        public void practicas()
        {
            try
            {
                conexion = new Conexion();
                string query = "select P.nombre_practica from PracticasXingresos S inner join Practicas P on S.id_practica=P.id_practica where S.id_ingreso =" + Convert.ToInt32(dgvingresos.CurrentRow.Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbpracticas.Items.Add(dr.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar las Practicas", ex.Message);
            }
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
            dgvpractXingreso.ClearSelection();
            lbpracticas.Items.Clear();
            dgvpractXingreso.DataSource = null;
            lbpracticas.Visible = true;
            btnagregarpractica.Visible = true;
            btnagregarpractica.Enabled = true;
            cbpacientes.Enabled = true;
            btnnuevopaciente.Enabled = true;
            cbmedicos.Enabled = true;
            btnnuevomedico.Enabled = true;
            dtfechaingreso.Enabled = true;
            dtfecharetiro.Enabled = true;
            lblresultado.Visible = false;
            txtresultado.Visible = false;
        }
        List<int> ids = new List<int>();
        private void btnagregarpractica_Click(object sender, EventArgs e)
        {
            lbpracticas.Items.Add(cbpracticas.Text);
            ids.Add(Convert.ToInt32(cbpracticas.SelectedValue.ToString()));
        }
       

        private void dgvingresos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lbpracticas.Visible = false;
            lbpracticas.Items.Clear();
            cbpracticas.Visible = false;
            txtresultado.Visible = false;
            lblresultado.Visible = false;
            cbpacientes.Text = dgvingresos.CurrentRow.Cells[1].Value.ToString();
            cbmedicos.Text = dgvingresos.CurrentRow.Cells[2].Value.ToString();
            dtfechaingreso.Text = dgvingresos.CurrentRow.Cells[3].Value.ToString();
            dtfecharetiro.Text = dgvingresos.CurrentRow.Cells[4].Value.ToString();
            btneliminaringreso.Enabled = true;
            btnmodificaringreso.Enabled = false;
            btnagregaringreso.Enabled = false;
            lblagreganuevopaciente.Visible = false;
            lblagregarmedico.Visible = false;
            btnnuevomedico.Visible = false;
            btnnuevopaciente.Visible = false;
            btnrecargarmedicos.Visible = false;
            btnrecargarpacientes.Visible = false;
            lblpracticas.Visible = true;
            btnagregarpractica.Visible = false;
            practicas();
            dgvpractXingreso.ClearSelection();
            lblpracticas.Visible = false;
            cargar_tablaPXI();
            cbpacientes.Enabled = false;
            cbmedicos.Enabled = false;
            dtfechaingreso.Enabled = false;
            dtfecharetiro.Enabled = false;
        }

        private void dgvpractXingreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbpacientes.Enabled = true;
            btnnuevopaciente.Enabled = false;
            cbmedicos.Enabled = true;
            btnnuevomedico.Enabled = false;
            dtfechaingreso.Enabled = true;
            dtfecharetiro.Enabled = true;
            lbpracticas.Visible = false;
            lblpracticas.Visible = true;
            cbpracticas.Visible = true;
            lblresultado.Visible = true;
            txtresultado.Visible = true;
            btnagregarpractica.Visible = false;
            cbpracticas.Text = dgvpractXingreso.CurrentRow.Cells[2].Value.ToString();
            txtresultado.Text = dgvpractXingreso.CurrentRow.Cells[3].Value.ToString();
            btnmodificaringreso.Enabled = true;
            btneliminaringreso.Enabled = false;
            lblresultado.Visible = true;
        }
    }
}
