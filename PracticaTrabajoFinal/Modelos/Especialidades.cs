using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Modelos
{
    public  class Especialidades
    {
        private Conexion conexion;
        public void agregarespecialidad(string nombre)
        {
            try
            {
                conexion = new Conexion();
                //query que agrega especialidades a la base de datos
                string sql = "insert into Especialidades(nombre_especialidad)values('" + nombre + "')";
                SqlCommand comando = new SqlCommand(sql);
                comando.Connection=conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("registro AGREGADO");
            }catch (Exception ex)
            {
                MessageBox.Show("error al cargar los datos", ex.Message);
            }
        }
        public void modificarespecialidad(string nombre,int idespecialidad)
        {
            try
            {
                conexion = new Conexion();
                string sql = "update Especialidades set nombre_especialidad='"+nombre+"' where id_especialidad="+idespecialidad;
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conexion.GetSqlConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("registro MODIFICADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar los datos", ex.Message);
            }
        }
        public void eliminarespecialidad(int idespecialidad)
        {
            try
            {
                conexion = new Conexion();
                string sql = "delete from Especialidades where id_especialidad=" + idespecialidad;
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conexion.GetSqlConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("registro ELIMINADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar los datos", ex.Message);
            }
        }
    }
}
