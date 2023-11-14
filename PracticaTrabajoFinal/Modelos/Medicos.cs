using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Modelos
{
    public class Medicos
    {
        private Conexion conexion;

        public void Eliminar_servicio(int id_servicio)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Servicios where id_servicio = " + id_servicio;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Servicio ELIMINADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar un Servicio", ex.Message);
            }
        }
        public void Modificar_Servicio(string servicio,int id_servicio)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Servicios set nombre_servicio  ='" + servicio + "' where id_servicio =" + id_servicio;
                SqlCommand comando = new SqlCommand(@consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Servicio MODIFICADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar un Servicio", ex.Message);
            }
        }
        public void agregarservicio(string nombre)
        {
            try
            {
                conexion = new Conexion();
                string existe = "select nombre_servicio  from Servicios where nombre_servicio='" + nombre + "'";
                SqlCommand comando = new SqlCommand(existe);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                if (existe == nombre)
                {
                    //mesaje si existe
                    MessageBox.Show("El Servicio ya existe");
                }
                else
                {
                    conexion = new Conexion();
                    //query que la agrega a la base de datos si no existe
                    string sql = "insert into Servicios(nombre_servicio)values('" + nombre + "')";
                    //vuelvo a asignarñe otra query y conexion al comando 
                    comando = new SqlCommand(sql);
                    comando.Connection = conexion.GetSqlConnection();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar un Servicio", ex.Message);
            }
        }
        public void agregarmedico(int id_servicio,string nombre_profesional,string apellido_profesional,string matricula)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "insert into Profesionales(id_servicio,nombre_profesional,apellido_profesional,matricula) values (@id_servicio,@nombre_profesional,@apellido_profesional,@matricula)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.Parameters.AddWithValue("@id_servicio", id_servicio);
                comando.Parameters.AddWithValue("@nombre_profesional", nombre_profesional);
                comando.Parameters.AddWithValue("@apellido_profesional", apellido_profesional);
                comando.Parameters.AddWithValue("@matricula", matricula);
                comando.ExecuteNonQuery();
                MessageBox.Show("Medico AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar un Medico", ex.Message);
            }

        }
        public void modificarmedico(int id_medico,int id_servicio, string nombre, string apellido, string matricula)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Profesionales set id_servicio =" + id_servicio + ",nombre_profesional='" + nombre + "',apellido_profesional='" + apellido + "',matricula='" + matricula + "' where id_profesional =" + id_medico;
                SqlCommand comando = new SqlCommand(@consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Medico MODIFICADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar un Medico", ex.Message);
            }

        }
        public void eliminarmedico(int id_medico)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Profesionales where id_profesional = " + id_medico;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Medico ELIMINADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar un Medico", ex.Message);
            }

        }
    }
}
