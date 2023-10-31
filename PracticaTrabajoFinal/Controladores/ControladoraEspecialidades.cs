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
                    MessageBox.Show("error al cargar la especialidad");
                }

            }catch(Exception e)
            {
                MessageBox.Show("error la especialidad ya existe", e.Message);
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
                    MessageBox.Show("error al modificar la especialidad");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error al modificar registro",e.Message);
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
                    MessageBox.Show("error al eliminar la especialidad");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error al eliminar registro", e.Message);
            }
        }
    }
}
