using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cientificaIIProyecto.frmAdministrador
{
    public class Alumnos:Personas
    {
        private string contraseña;
        private DateTime fecha_nacimiento;
        private int grado;

        public Alumnos(string con, DateTime fecha, int grad)
        {
            contraseña = con;
            fecha_nacimiento = fecha;
            grado = grad;
        }

        public override string Mensaje()
        {
            return "\nIdentidad: " + identidad +
                    "\nContraseña: " +contraseña + 
                    "\nNombre completo: " + nombres + " " + apellidos +
                    "\nFecha de nacimiento: " + fecha_nacimiento +
                    "\nGénero: " + genero +
                    "\nGrado: " + grado;           
        }
    }
}
