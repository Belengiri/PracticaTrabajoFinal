using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTrabajoFinal.Modelos
{
    internal class Conexion
    {
        SqlConnection conexion;
        string cadena = "Server=localhost;Database=TrabajoFinal;Trusted_Connection=True;";
        public SqlConnection GetSqlConnection()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(cadena);
                conexion.Open();
            }else if (conexion != null){
                conexion.Close();
            }
            return conexion;
        }
    }
}
