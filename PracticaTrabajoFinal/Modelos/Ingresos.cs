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
                MessageBox.Show("Paciente AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
        public void NuevaPracticaPorIngreso(List<int> id_practica,int id_ingreso)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "insert into PracticasXingresos(id_practica,id_ingreso) values (@id_practica,@id_ingreso)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                foreach(int id in id_practica)
                {
                    comando.Parameters.AddWithValue("@id_practica", id_practica);
                }
                comando.Parameters.AddWithValue("@id_ingreso", id_ingreso);
                MessageBox.Show("Paciente AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
        }
    }
}
