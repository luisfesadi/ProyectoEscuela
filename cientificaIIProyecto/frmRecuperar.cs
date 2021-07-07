using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cientificaIIProyecto
{
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
        }

        frmAdministrador.Conexion conexion = new frmAdministrador.Conexion();

        private void frmRecuperar_Load(object sender, EventArgs e)
        {
            frmAdministrador.Conexion conexion = new frmAdministrador.Conexion();
            
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

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
            }
        }

        private void linkLRecuperacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
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
                    btnEnviar.Visible = false;
                    this.Close();
                    frmLogin login = new frmLogin();
                    login.Show();
                }
                
            }
        }

    }
}
