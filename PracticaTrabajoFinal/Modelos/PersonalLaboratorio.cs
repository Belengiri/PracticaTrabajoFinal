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

    }
}
