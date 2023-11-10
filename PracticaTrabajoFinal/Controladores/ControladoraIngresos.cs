using PracticaTrabajoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTrabajoFinal.Controladores
{
    public class ControladoraIngresos
    {
        Ingresos ing = new Ingresos();
        
        public void AgregarPracticaPorIngreso(List<int> id_practica,int id_ingreso)
        {
            if (id_practica!=null && id_ingreso!=0)
            {
                ing.NuevaPracticaPorIngreso(id_practica, id_ingreso);
            }
        }
        public void Agregar_Ingreso(int id_paciente,int id_medico,string ingreso,string retiro)
        {
            if (id_medico != 0 && id_paciente != 0 && ingreso != "" && retiro != "")
            {
                ing.Nuevoingreso(id_paciente, id_medico, ingreso, retiro);
            }
        }
    }
}
