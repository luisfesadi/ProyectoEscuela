using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cientificaIIProyecto.frmAdministrador
{
    public class Docentes:Personas
    {
        private string contraseña;
        private DateTime fecha_nacimiento;
        private string correo_electronico;
        private string profesion;
        private string estado;

        public Docentes(string con, DateTime fecha, string correo, string prof, string est)
        {
            contraseña = con;
            fecha_nacimiento = fecha;
            correo_electronico = correo;
            profesion = prof;
            estado = est;
        }

        public override string Mensaje()
        {
            return "\nIdentidad: " + identidad +
                    "\nContraseña: " + contraseña +
                    "\nNombre completo: " + nombres + " " + apellidos +
                    "\nFecha de nacimiento: " + fecha_nacimiento +
                    "\nGénero: " + genero +
                    "\nProfesión: " + profesion +
                    "\nEstado: " + estado +
                    "\nCorreo electrónico: " + correo_electronico;     
        }


    }
}
