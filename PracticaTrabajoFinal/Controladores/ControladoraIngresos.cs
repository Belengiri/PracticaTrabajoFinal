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
        
        public void Agregar_Resultado(string resultado,int id_practica)
        {
            try
            {
                if (id_practica != 0)
                {
                    ing.Agregar_Resultado(resultado, id_practica);
                }
                else
                {
                    MessageBox.Show("Error al Agregar las Practicas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Agregar las Practicas ", e.Message);
            }

        }
        public void AgregarPracticaPorIngreso(int id_practica)
        {
            try
            {
                if (id_practica!=0)
                {
                    ing.NuevaPracticaPorIngreso(id_practica);
                }
                else
                {
                    MessageBox.Show("Error al Agregar las Practicas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Agregar las Practicas ", e.Message);
            }

        }
        public void Agregar_Ingreso(int id_paciente,int id_medico,string ingreso,string retiro)
        {
            try
            {
                if (id_medico != 0 && id_paciente != 0 && ingreso != "" && retiro != "")
                {
                    ing.Nuevoingreso(id_paciente, id_medico, ingreso, retiro);
                }
                else
                {
                    MessageBox.Show("Error al Agregar el Ingreso");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Agregar el Ingreso ", e.Message);
            }
        }
        public void Modificar_PXI(int id_practica,int id_prac_x_ingr)
        {
            try
            {
                if (id_practica != 0 && id_prac_x_ingr != 0)
                {
                    ing.ModificarPracticasPorIngreso(id_practica, id_prac_x_ingr);
                }
                else
                {
                    MessageBox.Show("Error al Modificar las Practicas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar las Practicas ", e.Message);
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
                    MessageBox.Show("Error al Modificar el Ingreso");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar el Ingreso", e.Message);
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
                    MessageBox.Show("Error al Eliminar el Ingreso");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Eliminar el Ingreso", e.Message);
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
                else
                {
                    MessageBox.Show("Error al Eliminar las Practicas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Eliminar las Practicas", e.Message);
            }
        }
    }
}
