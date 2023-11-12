using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Modelos
{
    public class Practicas
    {

        private Conexion conexion;

        //agrega una muestra nueva a la base de datos
        public void agregarmuestra(string nombre)
        {
            try
            {
                conexion = new Conexion();
                //query que corrobora que no exista la muestra nueva en la base de datos
                string existe = "select nombre_muestra from Muestras where nombre_muestra='" + nombre + "'";
                SqlCommand comando = new SqlCommand(existe);
                comando.Connection=conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                if (existe == nombre)
                {
                    //mesaje si existe
                    MessageBox.Show("La Muestra ya existe");
                }
                else
                {
                    conexion = new Conexion();
                    //query que la agrega a la base de datos si no existe
                    string sql = "insert into Muestras(nombre_muestra)values('" + nombre + "')";
                    //vuelvo a asignarñe otra query y conexion al comando 
                    comando = new SqlCommand(sql);
                    comando.Connection = conexion.GetSqlConnection();
                    comando.ExecuteNonQuery();  
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar la Muestra", ex.Message);
            }
        }
        //agrega una nueva practica a la base de datos
        public void agregarpractica(string nombre,int tiemporesultado,int especialidad,int tipomuestra)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "insert into Practicas(id_especialidad,id_muestra,nombre_practica,tiempo_resultado) values (@id_especialidades,@id_muestra,@nombre_practica,@tiempo_resultado)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.Parameters.AddWithValue("@id_especialidades", especialidad);
                comando.Parameters.AddWithValue("@id_muestra", tipomuestra);
                comando.Parameters.AddWithValue("@tiempo_resultado", tiemporesultado);
                comando.Parameters.AddWithValue("@nombre_practica", nombre);
                comando.ExecuteNonQuery();
                MessageBox.Show("Practica AGREGADA");
            }catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar una Practica",ex.Message);
            }
        }
        //modifica una practica en la base de datos
        public void modificarpractica(string nombre,int tiemporesultado,int especialidad,int tipomuestra,int idpractica)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Practicas set id_especialidad =" + especialidad + ",id_muestra=" + tipomuestra + ",nombre_practica='" + nombre + "',tiempo_resultado=" + tiemporesultado + "where id_practica =" + idpractica + "";
                SqlCommand comando = new SqlCommand(@consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Practica MODIFICADA");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar la Practica", ex.Message);
            }
        }
        //elimina una practica de la base de datos
        public void eliminarpractica(int idpractica)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Practicas where id_practica = "+idpractica;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Practica ELIMINADA");
            }catch(Exception ex)
            {
                MessageBox.Show("Error al Eliminar la Practica", ex.Message);
            }
        }
    }
}