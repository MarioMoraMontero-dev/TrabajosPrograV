using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Lab02_MarioMoraMontero.Clases
{
    
    public class Estudiante
    {
        

        public Estudiante()
        {
            Curso cursos = new Curso(null, null);

        }

        public void DefinirCurso(string pNombre, string pNota)
        {
            Curso curso = new Curso(pNombre,pNota);
            
        }

        public void DefinirPersona(string pNombre, string pPrimerApellido, string pSegundoApellido, int pAnhoNacimiento)
        {

            Persona pe = new Persona(pNombre, pPrimerApellido, pSegundoApellido, pAnhoNacimiento);

        }

    }
}