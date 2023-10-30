
using PracticaTrabajoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTrabajoFinal.Controladores
{
    //controla las Practicas y Las muestras 
    public class ControladoraPracticas
    {
        // aca se hacen todos los controles de los datos que vienen de la vista y van al modelo
        Practicas prac = new Practicas();//instancion una nueva practica para mandarle los datos 
        
        //metodo que manda los datos para agregar una muestra al modelo
        public void Agregar_Muestra(string nombre_muestra)
        {
            try
            {
                //controla que el nombre de la muestra no se encuentre vacia o nula
                if (nombre_muestra != "")
                {
                    //envia el dato al modelo
                    prac.agregarmuestra(nombre_muestra);
                }else
                {
                    MessageBox.Show("datos incorrectos");
                }

            }catch (Exception ex)
            {
                //error si no pudo enviar los datos
                MessageBox.Show("la muestra es existente", ex.Message);
            }
        }
        //metodo que manda los datos para agregar una practica al modelo
        public void Agregar_Practica(string nombre_practica,int tiempo_resultado,string especialidad_practica,string tipo_muestra)
        {

            try
            {
                //controla que los datos no esten vacios
                if (nombre_practica != "" && especialidad_practica != "" && tipo_muestra != "" && tiempo_resultado != 0)
                {
                    //manda los datos al modelo
                    prac.agregarpractica(nombre_practica, tiempo_resultado,Convert.ToInt32( especialidad_practica),Convert.ToInt32( tipo_muestra));
                }

            }
            catch(Exception e)
            {
                //error si no pudo enviar los datos
                MessageBox.Show("error",e.ToString());
            }
        }
        //metodo que manda los datos para modificar una practica al modelo
        public void Modificar_Practica(string nombre,int resultado,string especialidad,string tipomuestra,int idpractica)
        {
            try
            {
                //controla que los datos no esten vacios 
                if(nombre!="" && resultado!=0 && especialidad!="" && tipomuestra != ""&&idpractica!=0)
                {
                    //manda los datos al modelo
                    prac.modificarpractica(nombre, resultado, Convert.ToInt32(especialidad), Convert.ToInt32(tipomuestra),idpractica);
                }

            }catch(Exception e)
            {
                //error si no puede enviar los datos
                MessageBox.Show("error al modificar el registro", e.ToString());
            }
        }
        //metodo que manda el id de la practica al modelo para eliminar una practica 
        public void Eliminar_Practica(int idpractica)
        {
            try
            {
                //controla que el id no sea cero ya que no existe 0
                if (idpractica != 0)
                {
                    //manda el id al modelo
                    prac.eliminarpractica(idpractica);
                }
            }catch (Exception e)
            {
                //error si no puede mandarlo
                MessageBox.Show("error al eliminar el registro", e.ToString());
            }
            
        }
    }
}
