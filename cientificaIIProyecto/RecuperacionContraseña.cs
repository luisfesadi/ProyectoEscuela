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

namespace cientificaIIProyecto
{
    public partial class FrmRecuperar : Form
    {
        public FrmRecuperar()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        frmAdministrador.Conexion conexion = new frmAdministrador.Conexion();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
                if (txtUsuario.Text == "Identidad")
                    MessageBox.Show("¡Error! No ha ingresado un numero de identidad.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    txtCorreo.Text = conexion.Correo(txtUsuario.Text);
                    if (txtCorreo.Text == "")
                    {
                        txtCorreo.Text = "Correo";
                        MessageBox.Show("La identidad ingresada no se encuentra dentro del sistema.", "Advertencia", MessageBoxButtons.OK);
                    }       
                    else
                    {
                        btnContinuar.Visible = false;
                        btnEnviar.Visible = true;   
                        lblAviso.Visible = true;
                        txtUsuario.Enabled = false;
                    }
                 }
        }

        private void FrmRecuperar_Load(object sender, EventArgs e)
        {
            frmAdministrador.Conexion conexion = new frmAdministrador.Conexion();
        }

        private void linkLRecuperacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Identidad" || txtCorreo.Text == "Correo")
            {
                MessageBox.Show("¡Error! Llene todos los campos para poder ingresar.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblRecuperar.Visible = true;
                txtCorreo.Enabled = true;
                txtCorreo.Visible = true;
                txtCorreo.Text = "Correo";
                txtUsuario.Text = "Identidad";
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
            else
            {

                string pwd = conexion.contra(txtUsuario.Text, txtCorreo.Text); //El txtUsuario esta siendo reutilizado para ingresar el correo

                cientificaIIProyecto.frmAdministrador.Recuperar_Contraseña rc = new cientificaIIProyecto.frmAdministrador.Recuperar_Contraseña();

                if (pwd != "")
                {
                    rc.EnviarCorreo(txtCorreo.Text, pwd);

                    lblRecuperar.Visible = false;
                    txtUsuario.Text = "Identidad";
                    txtCorreo.Visible = false;
                    txtUsuario.Clear();
                    txtCorreo.Clear();
                    txtUsuario.Focus();
                    btnContinuar.Visible = false;
                    this.Close();
                    frmLogin login = new frmLogin();
                    login.Show();
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void barra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
