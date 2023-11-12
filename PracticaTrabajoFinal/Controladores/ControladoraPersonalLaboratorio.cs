using PracticaTrabajoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Controladores
{
    public class ControladoraPersonalLaboratorio
    {
        PersonalLaboratorio pl = new PersonalLaboratorio();
        public void Agregar_Categoria(string nombre)
        {
            try
            {
                //controla que el nombre de la muestra no se encuentre vacia o nula
                if (nombre != "")
                {
                    //envia el dato al modelo
                    pl.agregarcategoria(nombre);
                }
                else
                {
                    MessageBox.Show("Error al Agregar la Categoria");
                }

            }
            catch (Exception ex)
            {
                //error si no pudo enviar los datos
                MessageBox.Show("Error al Agregar la Categoria", ex.Message);
            }
        }
        public void Modificar_Categoria(string nombre ,int id_categoria)
        {
            try
            {
                //controla que los datos no esten vacios 
                if (nombre != "" && id_categoria != 0)
                {
                    //manda los datos al modelo
                    pl.modificarcategoria(id_categoria,nombre);
                }
                else
                {
                    MessageBox.Show("Error al Modificar la Categoria");
                }

            }
            catch (Exception e)
            {
                //error si no puede enviar los datos
                MessageBox.Show("Error al Modificar la Categoria", e.Message);
            }
        }
        public void Eliminar_Categoria(int id_categoria)
        {
            try
            {
                //controla que el id no sea cero ya que no existe 0
                if (id_categoria != 0)
                {
                    //manda el id al modelo
                    pl.eliminarcategoria(id_categoria);
                }
                else
                {
                    MessageBox.Show("Error al Eliminar la Categoria");
                }
            }
            catch (Exception e)
            {
                //error si no puede mandarlo
                MessageBox.Show("Error al Eliminar la Categoria", e.Message);
            }

        }
        public void Agregar_Personal(int id_categoria,int id_especialidad, string nombre, string apellido, string matricula)
        {
            try
            {
                if (id_categoria != 0 && nombre != "" && apellido != "" && matricula != ""&& id_especialidad!=0)
                {
                    pl.agregarpersonal(id_categoria,id_especialidad, nombre, apellido, matricula);
                }
                else
                {
                    MessageBox.Show("Error al Agregar el Personal del Laboratorio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar el Personal del Laboratorio", ex.Message);
            }
        }
        public void Modificar_Personal(int id_personal, int id_categoria,int id_especialidad, string nombre, string apellido, string matricula)
        {
            try
            {
                if (id_personal != 0 && nombre != "" && id_categoria != 0 && apellido != "" && matricula != ""&& id_especialidad!=0)
                {
                    pl.modificarpersonal(id_personal,id_categoria, id_especialidad, nombre, apellido, matricula);
                }
                else
                {
                    MessageBox.Show("Error al Modificar el Personal del Laboratorio");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar el Personal del Laboratorio", e.Message);
            }
        }
        public void Eliminar_Personal(int id_personal)
        {
            try
            {
                if (id_personal != 0)
                {
                    pl.eliminarpersonal(id_personal);
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Personal del Laboratorio ");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Eliminar el Personal del Laboratorio", e.Message);
            }
        }
    }
}
