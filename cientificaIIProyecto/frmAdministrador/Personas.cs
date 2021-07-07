using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cientificaIIProyecto.frmAdministrador
{
    public class Personas
    {
        protected static string identidad;
        protected static string nombres;
        protected static string apellidos;
        protected static string genero;


        public string Identidad
        {
            get { return identidad; }
            set { identidad = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public virtual string Mensaje()
        {
            return "\nIdentidad: " + identidad +
                    "\nNombre completo: " + nombres + " " + apellidos +
                    "\nGénero: " + genero;
        }
          
    }
}
