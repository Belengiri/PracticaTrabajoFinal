using PracticaTrabajoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Controladores
{
    public class ControladoraIngresos
    {
        Ingresos ing = new Ingresos();
        
        public void AgregarPracticaPorIngreso(int id_practica)
        {
            if (id_practica!=0)
            {
                ing.NuevaPracticaPorIngreso(id_practica);
            }
        }
        public void Agregar_Ingreso(int id_paciente,int id_medico,string ingreso,string retiro)
        {
            if (id_medico != 0 && id_paciente != 0 && ingreso != "" && retiro != "")
            {
                ing.Nuevoingreso(id_paciente, id_medico, ingreso, retiro);
            }
        }
        public void Modificar_Ingreso(int id_ingreso,int id_paciente, int id_medico, string ingreso, string retiro)
        {
            try
            {
                if (id_medico != 0 && ingreso != "" && id_ingreso != 0 && retiro != "" && id_paciente != 0)
                {
                    ing.Modificaringreso(id_ingreso, id_paciente, id_medico, ingreso, retiro);
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
        public void Eliminar_Ingreso(int id_ingreso)
        {
            try
            {
                if (id_ingreso != 0)
                {
                    ing.eliminaringreso(id_ingreso);
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
        public void Eliminar_PracXing(int id_ingreso)
        {
            try
            {
                if (id_ingreso!=0)
                {
                    ing.eliminarpracXingre(id_ingreso);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error al eliminar un Medico", e.ToString());
            }
        }
    }
}
