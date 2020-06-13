using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Lab02_MarioMoraMontero.Clases
{
    public class Curso
    {
        #region Propiedades 
        /// <summary>
        /// Propiedades de la clase
        /// Nombre y Nota
        /// </summary>
        public string nombre { get; set; }
        public string nota { get; set; }
        #endregion Fin de las Propiedades
        #region Constructor
        /// <summary>
        /// Constructor de la clase Curso
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pNota"></param>
        public Curso(string pNombre, string pNota)
        {
            this.nombre = pNombre;
            this.nota = pNota;
        }
        #endregion Fin del Construnctor
        #region Método
        /// <summary>
        /// Método de tipo string que retorna el estado según la nota
        /// </summary>
        /// <returns></returns>
        public String ObtenerEstado()
        {
            string Estado = "";
            int Estado_Nota = Convert.ToInt32(this.nota);
            if( Estado_Nota >+ 70)
            {
                Estado = "Aprobado";

            }
            else
            {
                if(Estado_Nota >+ 60 && Estado_Nota < 70)
                {
                    Estado = "Aplazado";
                }
                else
                {
                    if (Estado_Nota < 60)
                    {
                        Estado = "Reprobado";
                    }
                }
            }

            return Estado;
        }
        #endregion Fin los Método
    }
}