using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cientificaIIProyecto.frmAdministrador
{
    public class Encargado:Personas
    {
        private string direccion;
        private string telefono;
        private string correo_electronico;

        public Encargado(string dir, string tel, string correo)
        {
            direccion = dir;
            telefono = tel;
            correo_electronico = correo;
        }

        public override string Mensaje()
        {
            return "\nIdentidad: " + identidad +
                    "\nNombre completo: " + nombres + " " + apellidos +
                    "\nGénero: " + genero +
                    "\nTeléfono: " + telefono +
                    "\nCorreo electrónico: " + correo_electronico +
                    "\nDirección: " + direccion;
        }

    }
}
