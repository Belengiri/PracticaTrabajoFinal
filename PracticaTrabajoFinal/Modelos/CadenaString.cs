using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTrabajoFinal.Modelos
{
    public class CadenaString
    {
        SqlConnection cnn;
        string cadena ="workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal";
        public SqlConnection GetConnection()
        {
            if (cnn == null)
            {
                cnn = new SqlConnection(cadena);
                cnn.Open();
            }else if (cnn!=null)
            {
                cnn.Close();
            }
            return cnn;
        }
    }
}
