using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Modelos
{
    public class PersonalLaboratorio
    {
        private Conexion conexion;
        public void agregarcategoria(string nombre)
        {
            try
            {
                conexion = new Conexion();
                string existe = "select nombre_categoria from Categorias where nombre_categoria='" + nombre + "'";
                SqlCommand comando = new SqlCommand(existe);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                if (existe == nombre)
                {
                    MessageBox.Show("la localidad ya existe");
                }
                else
                {
                    conexion = new Conexion();
                    string sql = "insert into Categorias(nombre_categoria)values('" + nombre + "')";
                    comando = new SqlCommand(sql);
                    comando.Connection = conexion.GetSqlConnection();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("categoria AGREGADA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar la categoria", ex.Message);
            }
        }
        public void modificarcategoria(int id_categoria, string nombre)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Categorias set nombre_categoria = '" + nombre + "' where id_categoria = " + id_categoria;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("categoria MODIFICADA");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar categoria", ex.Message);
            }

        }
        public void eliminarcategoria(int id_categoria)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Categorias where id_categoria = " + id_categoria;
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.ExecuteNonQuery();
                MessageBox.Show("categoria ELIMINADA");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al eliminar categoria", ex.Message);
            }

        }
        public void agregarpersonal(int id_categoria,int id_especialidad, string nombre_personal_lab, string apellido_personal_lab, int matricula_personal_lab)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "insert into Personal_Laboratorio(id_categoria,id_especialidad,nombre_personal_lab ,apellido_personal_lab,matricula_personal_lab ) values (@id_categoria,@id_especialidad,@nombre_personal_lab,@apellido_personal_lab,@matricula_personal_lab)";
                SqlCommand comando = new SqlCommand(consulta);
                comando.Connection = conexion.GetSqlConnection();
                comando.Parameters.AddWithValue("@id_categoria", id_categoria);
                comando.Parameters.AddWithValue("@id_especialidad", id_especialidad);
                comando.Parameters.AddWithValue("@nombre_personal_lab", nombre_personal_lab);
                comando.Parameters.AddWithValue("@apellido_personal_lab", apellido_personal_lab);
                comando.Parameters.AddWithValue("@matricula_personal_lab", matricula_personal_lab);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }

        }
        public void modificarpersonal(int id_personal, int id_categoria,int id_especialidad, string nombre, string apellido, int matricula)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "update Personal_Laboratorio set id_categoria =" + id_categoria + ",id_especialidad="+id_especialidad+ ",nombre_personal_lab ='" + nombre + "',apellido_personal_lab ='" + apellido + "',matricula_personal_lab =" + matricula + "where id_personal_lab  =" + id_personal;
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
        public void eliminarpersonal(int id_personal)
        {
            try
            {
                conexion = new Conexion();
                string consulta = "delete from Personal_Laboratorio where id_personal_lab  = " + id_personal;
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
