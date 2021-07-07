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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlMenúVertical_Paint(object sender, PaintEventArgs e)
        {
            pnlMenúVertical.BackColor = Color.FromArgb(100, 88, 44, 55);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
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

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {
            pnlContenedor.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnInformación_MouseHover(object sender, EventArgs e)
        {
            pnlSubmenúInformación.Visible = true;
        }

        private void btnNotas_MouseHover(object sender, EventArgs e)
        {
            pnlSubmenúNotas.Visible = true;
        }

        private void pnlMenúVertical_MouseHover(object sender, EventArgs e)
        {
            pnlSubmenúInformación.Visible = false;
            pnlSubmenúNotas.Visible       = false;
        }

        private void AbrirForm(object form)
        {

            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }

            this.pnlContenedor.Controls.Remove(lblFecha);
            this.pnlContenedor.Controls.Remove(lblHora);

            Form nueva_form     = form as Form;
            nueva_form.TopLevel = false;
            nueva_form.Dock     = DockStyle.Fill;

            this.pnlContenedor.Controls.Add(nueva_form);
            this.pnlContenedor.Tag = nueva_form;
            nueva_form.Show();
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmNotas());
        }
    }
}
