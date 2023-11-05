using PracticaTrabajoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Controladores
{
    
    public class ControladoraPacientes
    {
        Pacientes pac = new Pacientes();

        public void Agregar_Localidad(string nombre_localidad,int codigo_postal)
        {
            try
            {
                if (nombre_localidad != "" && codigo_postal!=0)
                {
                    pac.agregarlocalidad(nombre_localidad,codigo_postal);
                }
                else
                {
                    MessageBox.Show("campos vacios");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al agregar una localidad", ex.Message);
            }
        }
        public void Modificar_Localidad(int id_localidad,string nombre_localidad,int codigo_postal)
        {
            try
            {
                if (id_localidad!=0 && nombre_localidad!=""&&codigo_postal!=0) {
                    pac.modificarlocalidad(Convert.ToInt32(id_localidad),nombre_localidad,Convert.ToInt32(codigo_postal));
                }
                else
                {
                    MessageBox.Show("campos vacios");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("error al modificar la localidad", e.ToString());
            }

        }
        public void Eliminar_Localidad(int id_localidad)
        {
            try
            {
                if (id_localidad != 0)
                {
                    pac.eliminarlocalidad(id_localidad);
                }
                else
                {
                    MessageBox.Show("campos vacios");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error al eliminar la localidad", e.ToString());
            }
        }
        public void Agregar_Paciente(int idlocal,string nombre,string apellido,int dni, string fecha, string calle,int altura,int piso,int depto,string correo,string telefono)
        {

            try
            {
                if (idlocal!=0 && nombre != "" && apellido != "" && dni != 0 && fecha != null && calle != "" && altura != 0 && piso !=0 && depto !=0 && correo != "" && telefono != "")
                {
                    pac.agregarpaciente(idlocal, nombre, apellido, fecha, dni, calle, altura, piso, depto, correo, telefono);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error al agregar un pacinte", e.ToString());
            }
        }
        public void Modificar_Paciente(int idpaciente,int localidad, string nombre, string apellido, int dni, string fecha, string calle, int altura, int piso, int depto, string correo, string telefono)
        {
            try
            {
                if (idpaciente!=0 && nombre != "" && apellido != "" && fecha != null && dni != 0 && calle != "" && altura!=0 && piso!=0 && depto!=0 && correo!=""&& telefono!="")
                {
                    pac.modificarpaciente(Convert.ToInt32(localidad),nombre, apellido,fecha,dni,calle,altura,piso,depto,correo,telefono,idpaciente);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("error al modificar el paciente", e.ToString());
            }
        }
        public void Eliminar_Paciente(int idpaciente)
        {
            try
            {
                if (idpaciente != 0)
                {
                    pac.eliminarpaciente(idpaciente);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error al eliminar el paciente", e.ToString());
            }
        }
    }
}
