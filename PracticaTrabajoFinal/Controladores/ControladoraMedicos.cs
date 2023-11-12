﻿using PracticaTrabajoFinal.Modelos;
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
        public void Agregar_Medico(int id_servicio, string nombre, string apellido, int matricula)
        {
            try
            {
                if (id_servicio != 0 && nombre != "" && apellido != "" && matricula != 0)
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
        public void Modificar_Medico(int id_medico, int id_servicio, string nombre, string apellido, int matricula)
        {
            try
            {
                if (id_medico != 0 && nombre != "" && id_servicio != 0 && apellido != "" && matricula != 0)
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
