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

namespace Proyecto_Escuela
{
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
            AbrirForm(new frmInicio());
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
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlMenúVertical_MouseMove(object sender, MouseEventArgs e)
        {
            SubmenuNotas.Visible = false;
            SubmenuListado.Visible = false;
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            SubmenuNotas.Visible = true;
        }

        private void SubmenuNotas_MouseMove(object sender, MouseEventArgs e)
        {
            SubmenuNotas.Visible = true;
        }

        private void SubmenuNotas_MouseLeave(object sender, EventArgs e)
        {
            //SubmenuNotas.Visible = false;
        }

        private void SubmenuNotas_MouseHover(object sender, EventArgs e)
        {
            //SubmenuNotas.Visible = true;
        }

        private void btnIngresarNotas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmIngresarNotas());
            SubmenuNotas.Visible = false;
        }

        private void btnNotas_MouseHover(object sender, EventArgs e)
        {
            SubmenuNotas.Visible = true;
        }

        private void pnlBarraTítulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirForm(object form)
        {

            if (this.pnlContenedor.Controls.Count > 0) //Preguntamos si existe algun control dentro del panel.
            {
                this.pnlContenedor.Controls.RemoveAt(0); // Si existe se elimina.
            }

            //this.panelContenedor.Controls.Remove(lblFecha);
            //this.panelContenedor.Controls.Remove(lblHora);

            Form nueva_form = form as Form; //El objeto que se manda se convierte en form con el alias nueva_form.
            nueva_form.TopLevel = false; //No es formulario de nivel superior, sino secundario.
            nueva_form.Dock = DockStyle.Fill; //Hacemos que se acople al panel contenedor.
            this.pnlContenedor.Controls.Add(nueva_form); //Enviamos el form al panel contenedor.
            this.pnlContenedor.Tag = nueva_form; //Instanciamos nuestro contenedor, como un objeto que recibira una form.
            nueva_form.Show();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            SubmenuListado.Visible = true;
        }

        private void SubmenuListado_MouseMove(object sender, MouseEventArgs e)
        {
            SubmenuListado.Visible = true;
        }

        private void btnAlumnos_MouseHover(object sender, EventArgs e)
        {
            SubmenuListado.Visible = true;
        }

        private void pnlMenúVertical_Paint(object sender, PaintEventArgs e)
        {
            pnlMenúVertical.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmListadoNotas());
            SubmenuListado.Visible = false;
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio());
        }

    }
}
