using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTrabajoFinal.Modelos
{
    public class Pacientes
    {
        private string nombre_paciente { get => nombre_paciente; set => nombre_paciente = value; }
        private string apellido_paciente { get => apellido_paciente; set => apellido_paciente = value; }
        private DateTime fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        private int dni { get => dni; set => dni = value; }
        private string email { get => email; set => email = value; }
        private string telefono { get => telefono; set => telefono = value; }
        private string direccion_calle { get => direccion_calle; set => direccion_calle = value; }
        private int direccion_numero { get => direccion_numero; set => direccion_numero = value; }
        private int direccion_piso { get => direccion_piso; set => direccion_piso = value; }
        private int direccion_dpto { get => direccion_dpto; set => direccion_dpto = value; }
        private string localidad { get => localidad; set => localidad = value; }
    }
}
