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

        public void AgregarLocalidad(string nombre_localidad)
        {
            try
            {
                if (nombre_localidad != "")
                {
                    pac.agregarlocalidad(nombre_localidad);
                }
                else
                {
                    MessageBox.Show("datos incorrectos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("la muestra es existente", ex.Message);
            }
        }
    }
}
