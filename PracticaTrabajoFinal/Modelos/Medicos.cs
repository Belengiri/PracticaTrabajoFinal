﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Modelos
{
    public class Medicos
    {
        private Conexion conexion;

        public void agregarservicio(string nombre)
        {
            try
            {
                conexion = new Conexion();
                string existe = "select nombre_servicio  from Servicios where nombre_servicio='" + nombre + "'";
                SqlCommand comando = new SqlCommand(existe);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                if (existe == nombre)
                {
                    //mesaje si existe
                    MessageBox.Show("la muestra ya existe");
                }
                else
                {
                    conexion = new Conexion();
                    //query que la agrega a la base de datos si no existe
                    string sql = "insert into Servicios(nombre_servicio)values('" + nombre + "')";
                    //vuelvo a asignarñe otra query y conexion al comando 
                    comando = new SqlCommand(sql);
                    comando.Connection = conexion.GetSqlConnection();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar los datos", ex.Message);
            }
        }
        public void agregarmedico(int id_servicio,string nombre_profesional,string apellido_profesional,int matricula)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "insert into Profesionales(id_servicio,nombre_profesional,apellido_profesional,matricula) values (@id_servicio,@nombre_profesional,@apellido_profesional,@matricula)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.Parameters.AddWithValue("@id_servicio", id_servicio);
                comando.Parameters.AddWithValue("@nombre_profesional", nombre_profesional);
                comando.Parameters.AddWithValue("@apellido_profesional", apellido_profesional);
                comando.Parameters.AddWithValue("@matricula", matricula);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }

        }
        public void modificarmedico(int id_medico,int id_servicio, string nombre, string apellido, int matricula)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Profesionales set id_servicio =" + id_servicio + ",nombre_profesional='" + nombre + "',apellido_profesional='" + apellido + "',matricula=" + matricula + "where id_profesional =" + id_medico;
                SqlCommand comando = new SqlCommand(@consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro MODIFICADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }

        }
        public void eliminarmedico(int id_medico)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Profesionales where id_profesional = " + id_medico;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro ELIMINADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar registro", ex.Message);
            }

        }
    }
}
