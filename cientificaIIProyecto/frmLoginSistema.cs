using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices; // Para poder arrastar la ventana.

using Registro;

namespace cientificaIIProyecto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private static int id;
        private static string identidad;
        private static string nombre;
        private static string apellido;
        static Image imagen;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Identidad
        {
            get { return identidad; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public Image Imagen
        {
            set { imagen = value; }
            get { return imagen; }
        }

        frmAdministrador.Conexion conexion = new frmAdministrador.Conexion();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.UseSystemPasswordChar = false;
            }
        
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Identidad")
            {
                txtUsuario.Text = "";
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Identidad";
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmAdministrador.Conexion conexion = new frmAdministrador.Conexion();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (btnAcceder.Text == "Acceder")
            {
                if (txtUsuario.Text == "Identidad" || txtContraseña.Text == "Contraseña")
                {
                    MessageBox.Show("¡Error! Llene todos los campos para poder ingresar.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    label1.Visible = true;
                    txtUsuario.Text = "Identidad";
                    txtContraseña.Visible = true;
                    txtContraseña.Text = "Contraseña";
                    txtContraseña.UseSystemPasswordChar = false;
                    btnAcceder.Text = "Acceder";
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                }
                else
                {
                    int r = conexion.ingresar(txtUsuario.Text, txtContraseña.Text);

                    switch (r)
                    {
                        case 1:
                            identidad = txtUsuario.Text;
                            conexion.Datos(identidad, r);
                            FrmAdmin admin = new FrmAdmin();
                            label1.Visible = true;
                            txtUsuario.Text = "Identidad";
                            txtContraseña.Visible = true;
                            txtContraseña.Text = "Contraseña";
                            txtContraseña.UseSystemPasswordChar = false;
                            btnAcceder.Text = "Acceder";
                            txtUsuario.Focus();
                            admin.Show();
                            this.Hide();
                            break;
                        case 2:
                            identidad = txtUsuario.Text;
                            conexion.Datos(identidad, r);
                            FrmDocente.FrmDocente docente = new FrmDocente.FrmDocente();
                            docente.Show();
                            label1.Visible = true;
                            txtUsuario.Text = "Identidad";
                            txtContraseña.Visible = true;
                            txtContraseña.Text = "Contraseña";
                            txtContraseña.UseSystemPasswordChar = false;
                            btnAcceder.Text = "Acceder";
                            this.Hide();
                            break;
                        case 3:
                            identidad = txtUsuario.Text;
                            conexion.Datos(identidad, r);
                            Proyecto_Escuela.frmAlumno alumno = new Proyecto_Escuela.frmAlumno();
                            alumno.Show();
                            label1.Visible = true;
                            txtUsuario.Text = "Identidad";
                            txtContraseña.Visible = true;
                            txtContraseña.Text = "Contraseña";
                            txtContraseña.UseSystemPasswordChar = false;
                            btnAcceder.Text = "Acceder";
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("El usuario o la contrasena son incorrectos", "Advertencia", MessageBoxButtons.OK);
                            break;
                    }

                }

                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

        private void linkLRecuperacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmRecuperar recuperar = new FrmRecuperar();
            recuperar.Show();
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }

        private void barra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
