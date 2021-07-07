using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cientificaIIProyecto.frmAdministrador
{
    class Registro : Personas
    {
        private static string contraseña;
        private static DateTime fecha_nacimiento;
        private static string correo_electronico;
        private static string estado;

        public Registro(string con, DateTime fecha, string correo, string est)
        {
            contraseña = con;
            fecha_nacimiento = fecha;
            correo_electronico = correo;
            estado = est;
        }

        public override string Mensaje()
        {
            return "\nIdentidad: " + identidad +
                    "\nContraseña: " + contraseña +
                    "\nNombre completo: " + nombres + " " + apellidos +
                    "\nFecha de nacimiento: " + fecha_nacimiento +
                    "\nGénero: " + genero +
                    "\nEstado Civil: " + estado +
                    "\nCorreo electrónico: " + correo_electronico;
        }
    }
}
