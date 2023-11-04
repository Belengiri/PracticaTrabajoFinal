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
        string cadena = "workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal";
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
