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
    }
}
