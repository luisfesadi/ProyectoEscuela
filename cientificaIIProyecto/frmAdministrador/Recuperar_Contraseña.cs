using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace cientificaIIProyecto.frmAdministrador
{
    class Recuperar_Contraseña
    {
        public void EnviarCorreo(string direccion_correo, string contra)
        {
            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("sprtproyecto@gmail.com");
            mm.To.Add(direccion_correo);
            mm.Subject = "Recuperar contraseña Escuela";
            mm.Body = "Buen día, usted ha solicitado recuperar su contraseña \nla cual es: "+contra;
            mm.Priority = MailPriority.Normal;

            SmtpClient scorreo = new SmtpClient();
            scorreo.Credentials = new System.Net.NetworkCredential("sprtproyecto@gmail.com", "cientifica2");
            scorreo.Host = "smtp.gmail.com";
            scorreo.Port = 587;
            scorreo.EnableSsl = true;

            try
            {
                scorreo.Send(mm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar el correo: " + ex.ToString());
            }

        }
    }
}
