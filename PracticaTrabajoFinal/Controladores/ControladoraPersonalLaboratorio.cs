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
                    MessageBox.Show("datos incorrectos");
                }

            }
            catch (Exception ex)
            {
                //error si no pudo enviar los datos
                MessageBox.Show("la muestra es existente", ex.Message);
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

            }
            catch (Exception e)
            {
                //error si no puede enviar los datos
                MessageBox.Show("error al modificar el registro", e.ToString());
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
            }
            catch (Exception e)
            {
                //error si no puede mandarlo
                MessageBox.Show("error al eliminar el registro", e.ToString());
            }

        }
        public void Agregar_Personal(int id_categoria,int id_especialidad, string nombre, string apellido, int matricula)
        {
            try
            {
                if (id_categoria != 0 && nombre != "" && apellido != "" && matricula != 0&& id_especialidad!=0)
                {
                    pl.agregarpersonal(id_categoria,id_especialidad, nombre, apellido, matricula);
                }
                else
                {
                    MessageBox.Show("campos vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al agregar un Medico", ex.Message);
            }
        }
        public void Modificar_Personal(int id_personal, int id_categoria,int id_especialidad, string nombre, string apellido, int matricula)
        {
            try
            {
                if (id_personal != 0 && nombre != "" && id_categoria != 0 && apellido != "" && matricula != 0&& id_especialidad!=0)
                {
                    pl.modificarpersonal(id_personal,id_categoria, id_especialidad, nombre, apellido, matricula);
                }
                else
                {
                    MessageBox.Show("campos vacios");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("error al modificar un Medico", e.ToString());
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
                    MessageBox.Show("campos vacios");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error al eliminar un Medico", e.ToString());
            }
        }
    }
}
