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
        
        SqlConnection conexion = new SqlConnection("workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal");

        public void agregarlocalidad(string nombre)
        {
            try
            {
                conexion.Open();
                string existe = "select nombre_localidad from Localidades where nombre_localidad='" + nombre + "'";
                SqlCommand comando = new SqlCommand(existe, conexion);
                comando.ExecuteNonQuery();
                if (existe == nombre)
                {
                    MessageBox.Show("la localidad ya existe");
                }
                else
                {
                    string sql = "insert into Localidades(nombre_localidad)values('" + nombre + "')";
                    comando = new SqlCommand(sql, conexion);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar los datos", ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void agregarpaciente(int idlocal,string nombre,string apellido,DateTime fecha,int dni, string calle, int altura,int piso,int depto,string correo,string telefono)
        {
            try
            {
                conexion.Open();
                string consulta = "insert into Pacientes(id_localidad,nombre_paciente,apellido_paciente,fecha_nacimiento ,dni,direccion_nombre ,direccion_numero,direccion_piso,direccion_departamento,correo_paciente,telefono_paciente) values (@id_localidad,@nombre_paciente,@apellido_paciente,@fecha_nacimiento ,@dni,@direccion_nombre ,@direccion_numero,@direccion_piso,@direccion_departamento,@correo_paciente,@telefono_paciente)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
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
                MessageBox.Show("Registro AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void modificarpaciente(int idlocal,string nombre,string apellido,DateTime fecha,int dni,string calle,int altura,int piso,int depto,string correo,string telefono,int idpaciente)
        {
            try
            {
                conexion.Open();
                string consulta = "update Pacientes set id_localidad =" + idlocal + ",nombre_paciente='" + nombre + "',apellido_paciente='" + apellido + "',fecha_nacimiento=" + fecha + ", dni="+dni+", domicilio_nombre='"+calle+"',domicilio_numero="+altura+",domicilio_piso="+piso+",domicilio_departamento="+depto+",correo_paciente='"+correo+"',telefono_paciente="+telefono+"where id_practica =" + idpaciente + "";
                SqlCommand comando = new SqlCommand(@consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro MODIFICADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void eliminarpaciente(int idpaciente)
        {
            try
            {
                conexion.Open();
                string consulta = "delete from Pacientes where id_paciente = " + idpaciente;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro ELIMINADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
