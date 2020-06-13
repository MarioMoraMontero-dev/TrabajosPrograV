using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02_MarioMoraMontero.Clases
{
    public class Persona
    {

        public string nombre { get; set; } = "";
        public string primerApellido { get; set; } = "";
        public string segundoApellido { get; set; } = "";
        public int anhoNacimiento { get; set; } = 0;

        public Persona(string pNombre, string pPrimerApellido, string pSegundoApellido, int pAnhoNacimiento)
        {
            this.nombre = pNombre;
            this.primerApellido = pPrimerApellido;
            this.segundoApellido = pSegundoApellido;
            this.anhoNacimiento = pAnhoNacimiento;
        }


        public String ObtenerNombreCompleto()
        {
            string NombreCompleto = this.nombre + " " + this.primerApellido + " " + this.segundoApellido;
            return NombreCompleto;
        }

        public int CalcularEdad()
        {
            int edad;
            
            if( anhoNacimiento != DateTime.Now.Year)
            {
                edad = this.anhoNacimiento - DateTime.Now.Year;
            }
            else
            {
                edad = 0;
            }
            return edad;
        }
    }
}