﻿using System;
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
        SqlConnection conexion = new SqlConnection("workstation id=TrabajoFinal.mssql.somee.com;packet size=4096;user id=belu_giri_SQLLogin_1;pwd=uepihkqvt1;data source=TrabajoFinal.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinal");
        public void agregarespecialidad(string nombre)
        {
            conexion.Open();
            //query que agrega especialidades a la base de datos
            string sql = "insert into Especialidades(nombre_especialidad)values('" + nombre + "')";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificarespecialidad(string nombre,int idespecialidad)
        {
            conexion.Open();
            string sql = "update Especialidades set nombre_especialidad='"+nombre+"' where id_especialidad="+idespecialidad;
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            
        }
        public void eliminarespecialidad(int idespecialidad)
        {
            conexion.Open();
            string sql = "delete from Especialidades where id_especialidad=" + idespecialidad;
            SqlCommand cmd = new SqlCommand(sql,conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
