using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Modelos
{
    public class Pacientes
    {

        private Conexion conexion;

        public void agregarlocalidad(string nombre,int codigo_postal)
        {
            try
            {
                conexion = new Conexion();
                string existe = "select nombre_localidad from Localidades where nombre_localidad='" + nombre + "'";
                SqlCommand comando = new SqlCommand(existe);
                comando.Connection=conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                if (existe == nombre)
                {
                    MessageBox.Show("la localidad ya existe");
                }
                else
                {
                    string sql = "insert into Localidades(nombre_localidad,codigo_postal)values('" + nombre + "',"+codigo_postal+")";
                    comando = new SqlCommand(sql);
                    comando.Connection = conexion.GetSqlConnection();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Localidad AGREGADA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar los datos", ex.Message);
            }
        }
        public void modificarlocalidad(int id_localidad,string nombre_localidad,int codigo_postal)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Localidades set id_localidad =" + id_localidad + ",nombre_localidad = '" + nombre_localidad + "',codigo_postal = " + codigo_postal + " where id_localidad = " + id_localidad;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Paciente MODIFICADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }

        }
        public void eliminarlocalidad(int id_localidad)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Localidades where id_localidad = " + id_localidad;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Paciente ELIMINADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }

        }
        public void agregarpaciente(int idlocal,string nombre,string apellido,string fecha,int dni, string calle, int altura,int piso,int depto,string correo,string telefono)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "insert into Pacientes(id_localidad,nombre_paciente,apellido_paciente,fecha_nacimiento ,dni,direccion_nombre ,direccion_numero,direccion_piso,direccion_departamento,correo_paciente,telefono_paciente) values (@id_localidad,@nombre_paciente,@apellido_paciente,@fecha_nacimiento ,@dni,@direccion_nombre ,@direccion_numero,@direccion_piso,@direccion_departamento,@correo_paciente,@telefono_paciente)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.Parameters.AddWithValue("@id_localidad", idlocal);
                comando.Parameters.AddWithValue("@nombre_paciente", nombre);
                comando.Parameters.AddWithValue("@apellido_paciente", apellido);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@direccion_nombre ", calle);
                comando.Parameters.AddWithValue("@direccion_numero ", altura);
                comando.Parameters.AddWithValue("@direccion_piso ", piso);
                comando.Parameters.AddWithValue("@direccion_departamento ", depto);
                comando.Parameters.AddWithValue("@correo_paciente ", correo);
                comando.Parameters.AddWithValue("@telefono_paciente ", telefono);
                comando.ExecuteNonQuery();
                MessageBox.Show("Paciente AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
        public void modificarpaciente(int idlocal,string nombre,string apellido,string fecha,int dni,string calle,int altura,int piso,int depto,string correo,string telefono,int idpaciente)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Pacientes set id_localidad =" + idlocal + ",nombre_paciente = '" + nombre + "',apellido_paciente = '" + apellido + "',fecha_nacimiento = '" + fecha + "',dni = " + dni + ",direccion_nombre = '" + calle + "',direccion_numero = " + altura + ",direccion_piso =" + piso + ",direccion_departamento = " + depto + ",correo_paciente = '" + correo + "',telefono_paciente = '" + telefono + "' where id_paciente = " + idpaciente;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Paciente MODIFICADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }
        }
        public void eliminarpaciente(int idpaciente)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Pacientes where id_paciente = " + idpaciente;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Paciente ELIMINADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }
        }
    }
}
