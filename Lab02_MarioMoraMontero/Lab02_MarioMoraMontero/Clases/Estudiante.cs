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

        public string DefinirCurso(string pNombre, string pNota)
        {
            Curso curso = new Curso(pNombre,pNota);
            string datos = "<strong>Nombre del curso:</strong> " + pNombre + " <strong>Nota:</strong> " + pNota + " <strong>Estado:</strong> " + curso.ObtenerEstado();
            return datos;
        }

        public string DefinirPersona(string pNombre, string pPrimerApellido, string pSegundoApellido, int pAnhoNacimiento)
        {

            Persona pe = new Persona(pNombre, pPrimerApellido, pSegundoApellido, pAnhoNacimiento);
            string nombre ="<strong>Nombre Completo:</strong> "+ pe.ObtenerNombreCompleto() + " <strong>Edad:</strong> "+ Convert.ToString(pe.CalcularEdad());

            return nombre;

        }

    }
}