using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Registro
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
  
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlMenúVertical_Paint(object sender, PaintEventArgs e)
        {
            pnlMenúVertical.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {


        }


        private void frmAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void pnlBarraTítulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirForm(object form)
        {
      
            if (this.panelContenedor.Controls.Count > 0) //Preguntamos si existe algun control dentro del panel.
            {
                this.panelContenedor.Controls.RemoveAt(0); // Si existe se elimina.
            }

            this.panelContenedor.Controls.Remove(lblFecha);
            this.panelContenedor.Controls.Remove(lblHora);

            Form nueva_form = form as Form; //El objeto que se manda se convierte en form con el alias nueva_form.
            nueva_form.TopLevel = false; //No es formulario de nivel superior, sino secundario.
            nueva_form.Dock = DockStyle.Fill; //Hacemos que se acople al panel contenedor.
            this.panelContenedor.Controls.Add(nueva_form); //Enviamos el form al panel contenedor.
            this.panelContenedor.Tag = nueva_form; //Instanciamos nuestro contenedor, como un objeto que recibira una form.
            nueva_form.Show();
        }

        private void btnRegistro_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlMenúVertical_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
