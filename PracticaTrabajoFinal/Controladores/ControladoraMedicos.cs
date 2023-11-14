using PracticaTrabajoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Controladores
{
    public class ControladoraMedicos
    {
        Medicos medico = new Medicos();
        public void Eliminar_Servicio( int id_servicio)
        {
            try
            {
                if (id_servicio != 0 )
                {
                    medico.Eliminar_servicio( id_servicio);
                }
                else
                {
                    MessageBox.Show("Error al Eliminar un Servicio");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar un Servicio", ex.Message);
            }
        }
        public void Modificar_Servicio(string servicio,int id_servicio)
        {
            try
            {
                if (id_servicio!=0 && servicio!="")
                {
                    medico.Modificar_Servicio(servicio,id_servicio);
                }
                else
                {
                    MessageBox.Show("Error al Modificar un Servicio");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar un Servicio", ex.Message);
            }
        }
        public void Agregar_Servicio(string nombre)
        {
            try
            {
                if (nombre != "")
                {
                    medico.agregarservicio(nombre);
                }
                else
                {
                    MessageBox.Show("Error al Agregar un Servicio");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar un Servicio", ex.Message);
            }
        }
        public void Agregar_Medico(int id_servicio, string nombre, string apellido, string matricula)
        {
            try
            {
                if (id_servicio != 0 && nombre != "" && apellido != "" && matricula != "")
                {
                    medico.agregarmedico(id_servicio, nombre, apellido, matricula);
                }
                else
                {
                    MessageBox.Show("Error al Agregar un Medico");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar un Medico", ex.Message);
            }
        }
        public void Modificar_Medico(int id_medico, int id_servicio, string nombre, string apellido, string matricula)
        {
            try
            {
                if (id_medico != 0 && nombre != "" && id_servicio != 0 && apellido != "" && matricula != "")
                {
                    medico.modificarmedico(id_medico, id_servicio, nombre, apellido, matricula);
                }
                else
                {
                    MessageBox.Show("Error al Modificar un Medico");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar un Medico", e.ToString());
            }
        }
        public void Eliminar_Medico(int id_medico)
        {
            try
            {
                if (id_medico != 0)
                {
                    medico.eliminarmedico(id_medico);
                }
                else
                {
                    MessageBox.Show("Error al Eliminar un Medico");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Eliminar un Medico", e.ToString());
            }
        }
    }
}
