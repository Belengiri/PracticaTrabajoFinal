using PracticaTrabajoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Controladores
{
    public class ControladoraEspecialidades
    {
        Especialidades espe = new Especialidades();
        public void Agregar_Especialidad(string nombre)
        {
            try
            {
                if (nombre != "")
                {
                    espe.agregarespecialidad(nombre);
                }
                else
                {
                    MessageBox.Show("Error al Agregar la Especialidad");
                }

            }catch(Exception e)
            {
                MessageBox.Show("Error al Agregar Especialidad ", e.Message);
            }
        }
        public void Modificar_Especialidad(string nombre,int idespecialidad)
        {
            try
            {
                if (nombre !="" && idespecialidad != 0)
                {
                    espe.modificarespecialidad(nombre, idespecialidad);
                }
                else
                {
                    MessageBox.Show("Error al Modificar la Especialidad");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar la Especialidad",e.Message);
            }
            
        }
        public void Eliminar_Especialidad(int idespecialidad)
        {
            try
            {
                if (idespecialidad != 0)
                {
                    espe.eliminarespecialidad(idespecialidad);
                }
                else
                {
                    MessageBox.Show("Error al Eliminar la Especialidad");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Eliminar la Especialidad", e.Message);
            }
        }
    }
}
