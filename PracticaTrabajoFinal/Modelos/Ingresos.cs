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
        private CadenaString conexion;
        
        
       public void agregaringreso(int id_paciente,int id_medico,string fecha_ingreso,string fecha_retiro)
        {
            try
            {
                conexion = new CadenaString();
                string consulta = "insert into Ingresos(id_paciente,id_profesional,fecha_ingreso,fecha_retiro ) values (@id_paciente,@id_medico,@fecha_ingreso,@fecha_retiro)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetConnection();
                comando.Parameters.AddWithValue("@id_paciente", id_paciente);
                comando.Parameters.AddWithValue("@id_medico", id_medico);
                comando.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                comando.Parameters.AddWithValue("@fecha_retiro", fecha_retiro);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro AGREGADO");

            }
            catch(Exception ex)
            {
                MessageBox.Show("error al cargar un ingreso", ex.Message);
            }
        }
    }
}
