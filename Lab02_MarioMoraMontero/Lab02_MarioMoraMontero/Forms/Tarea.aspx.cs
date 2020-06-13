using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab02_MarioMoraMontero.Clases;

namespace Lab02_MarioMoraMontero.Forms
{
    public partial class Tarea : System.Web.UI.Page
    {
        Estudiante es = new Estudiante();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResultado.Text = this.Datos();
        }

        private String Datos()
        {
            string salida = es.DefinirPersona(txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, Convert.ToInt32(txtAnodeNacimiento.Text));
            salida += "<br/>" + es.DefinirCurso(txtNombreDelCurso.Text, txtNota.Text);
            return salida;
        }
    }
}