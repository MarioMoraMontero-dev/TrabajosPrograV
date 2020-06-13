using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02_MarioMoraMontero.Clases
{
    public class Persona
    {
        #region Atributos de la clase
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        public string nombre { get; set; } = "";
        public string primerApellido { get; set; } = "";
        public string segundoApellido { get; set; } = "";
        public int anhoNacimiento { get; set; } = 0;
        #endregion Fin de los atributos de la clase
        #region Constructor de la clase
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pPrimerApellido"></param>
        /// <param name="pSegundoApellido"></param>
        /// <param name="pAnhoNacimiento"></param>
        public Persona(string pNombre, string pPrimerApellido, string pSegundoApellido, int pAnhoNacimiento)
        {
            this.nombre = pNombre;
            this.primerApellido = pPrimerApellido;
            this.segundoApellido = pSegundoApellido;
            this.anhoNacimiento = pAnhoNacimiento;
        }
        #endregion Fin del constructor
        #region Método
        /// <summary>
        /// Método que devuelve el nombre completo
        /// </summary>
        /// <returns></returns>
        public String ObtenerNombreCompleto()
        {
            string NombreCompleto = this.nombre + " " + this.primerApellido + " " + this.segundoApellido;
            return NombreCompleto;
        }
        /// <summary>
        /// Método que calcula la edad
        /// </summary>
        /// <returns></returns>
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
        #endregion Fin de los método
    }
}