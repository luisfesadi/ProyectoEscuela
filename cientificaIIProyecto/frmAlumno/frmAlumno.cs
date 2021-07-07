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
            CustomizeDesign();
        }

        int i = 0;

        cientificaIIProyecto.frmLogin login = new cientificaIIProyecto.frmLogin();

        private static int id;

        public int Id
        {
            get { return id; }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlMenúVertical_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        private void pnlBarraTítulo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnInformación_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnNotas_MouseHover(object sender, EventArgs e)
        {
        }

        private void pnlMenúVertical_MouseHover(object sender, EventArgs e)
        {
        }

        private void CustomizeDesign()
        {
            panelSubMenu1.Visible = false;

        }

        private void HideSubmenu()
        {
            if (panelSubMenu1.Visible == true)
                panelSubMenu1.Visible = false;

        }

        private void ShowSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                HideSubmenu();
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVerNotas_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmNotas());

        }

        private void btnInformacionAlumno_Click_1(object sender, EventArgs e)
        {
        }

        private void btnInformacionPersonalAlumno_Click(object sender, EventArgs e)
        {
            OpenForm(new frmInformaciónAlumno());

        }

        private Form activeForm = null;

        private void OpenForm(Form childForm)
        {
            lblHora.Hide();
            lblFecha.Hide();

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNotas());
        }

        private void pictureBoxAlumno_Click_1(object sender, EventArgs e)
        {
            frmAlumno alu = new frmAlumno();
            alu.Show();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            i = 1;
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            switch (respuesta)
            {
                case DialogResult.OK:

                    if (login.Imagen != null)
                    {
                        login.Imagen = null;
                    }
                    this.Close();
                    login.Show();
                    break;
                case DialogResult.Cancel:
                    i = 0; 
                    break;
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            id = login.Id;
            lblId.Text = Convert.ToString(login.Id);
            lblIdentidad.Text = login.Identidad;
            lblNombre.Text = login.Nombre;
            lblApellido.Text = login.Apellido;

            if(login.Imagen != null)
            {
                pictureUsuario.Image = login.Imagen;
            }
            else
            {
                pictureUsuario.Image = pictureUsuario.InitialImage;
            }

        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenForm(new frmNotas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new frmInformaciónAlumno());
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelSubMenu1);
        }

        private void frmAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (i == 0)
            {
                Application.Exit();
            }

        }
    }
}
