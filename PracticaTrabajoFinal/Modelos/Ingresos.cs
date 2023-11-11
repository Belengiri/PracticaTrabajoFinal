using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Modelos
{
    public class Ingresos
    {
        private Conexion conexion;
        public void eliminarpracXingre(int id_ingreso)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from PracticasXingresos where id_ingreso="+id_ingreso;
                SqlCommand comando = new SqlCommand(@consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
        public void Nuevoingreso(int id_paciente,int id_profesional, string ingreso, string retiro)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "insert into Ingresos(id_paciente,id_profesional,fecha_ingreso ,fecha_retiro) values (@id_paciente,@id_profesional,@ingreso,@retiro)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.Parameters.AddWithValue("@id_paciente", id_paciente);
                comando.Parameters.AddWithValue("@id_profesional", id_profesional);
                comando.Parameters.AddWithValue("@ingreso", ingreso);
                comando.Parameters.AddWithValue("@retiro", retiro);
                comando.ExecuteNonQuery();
                MessageBox.Show("ingreso AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
        public void eliminaringreso(int id_ingreso)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Ingresos where id_ingreso = " + id_ingreso;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro ELIMINADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }
        }
        public void Modificaringreso(int id_ingreso,int id_paciente,int id_medico,string ingreso,string retiro)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Ingresos set id_paciente =" + id_paciente + ",id_profesional=" + id_medico + ",fecha_ingreso ='" + ingreso + "',fecha_retiro='" + retiro + "' where id_ingreso =" + id_ingreso;
                SqlCommand comando = new SqlCommand(@consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro MODIFICADO");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
        public int ObteneridMax()
        {
            int ultimoid=0;
            try
            {
                conexion = new Conexion();
                string query = "select MAX(id_ingreso)from Ingresos";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conexion.GetSqlConnection();
                ultimoid = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
            return ultimoid;
        }
        public void NuevaPracticaPorIngreso(int id_practica)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "insert into PracticasXingresos(id_ingreso,id_practica) values (@id_ingreso,@id_practica)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.Parameters.AddWithValue("@id_ingreso", ObteneridMax());
                comando.Parameters.AddWithValue("@id_practica", id_practica);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
    }
}
