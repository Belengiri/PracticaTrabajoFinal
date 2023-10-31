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
       
        SqlConnection conexion = new SqlConnection("workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal");

        //agrega una muestra nueva a la base de datos
        public void agregarmuestra(string nombre)
        {
            try
            {
                conexion.Open();
                //query que corrobora que no exista la muestra nueva en la base de datos
                string existe = "select nombre_muestra from Muestras where nombre_muestra='" + nombre + "'";
                SqlCommand comando = new SqlCommand(existe, conexion);
                comando.ExecuteNonQuery();
                if (existe == nombre)
                {
                    //mesaje si existe
                    MessageBox.Show("la muestra ya existe");
                }
                else
                {
                    //query que la agrega a la base de datos si no existe
                    string sql = "insert into Muestras(nombre_muestra)values('" + nombre + "')";
                    //vuelvo a asignarñe otra query y conexion al comando 
                    comando = new SqlCommand(sql, conexion);
                    comando.ExecuteNonQuery();  
                }
            }catch (Exception ex)
            {
                MessageBox.Show("error al modificar los datos", ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        //agrega una nueva practica a la base de datos
        public void agregarpractica(string nombre,int tiemporesultado,int especialidad,int tipomuestra)
        {

            conexion.Open(); 
            string consulta = "insert into Practicas(id_especialidad,id_muestra,nombre_practica,tiempo_resultado) values (@id_especialidades,@id_muestra,@nombre_practica,@tiempo_resultado)";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@id_especialidades", especialidad);
            comando.Parameters.AddWithValue("@id_muestra", tipomuestra);
            comando.Parameters.AddWithValue("@tiempo_resultado", tiemporesultado);
            comando.Parameters.AddWithValue("@nombre_practica", nombre);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro AGREGADO");
            conexion.Close();
        }
        //modifica una practica en la base de datos
        public void modificarpractica(string nombre,int tiemporesultado,int especialidad,int tipomuestra,int idpractica)
        {
            try
            {
                conexion.Open();
                string consulta = "update Practicas set id_especialidad ="+especialidad+",id_muestra="+tipomuestra+",nombre_practica='"+nombre+"',tiempo_resultado="+tiemporesultado+"where id_practica ="+idpractica+"";
                SqlCommand comando = new SqlCommand(@consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro MODIFICADO");
            }catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro",ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            
            
        }
        //elimina una practica de la base de datos
        public void eliminarpractica(int idpractica)
        {
            conexion.Open();
            string consulta = "delete from Practicas where id_practica = "+idpractica;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro ELIMINADO");
            conexion.Close();
        }
    }
}