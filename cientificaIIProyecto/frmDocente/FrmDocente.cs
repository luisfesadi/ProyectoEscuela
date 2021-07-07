using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDocente
{
    public partial class FrmDocente : Form
    {
        public FrmDocente()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        int i = 0; 

        private static int id;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        cientificaIIProyecto.frmLogin login = new cientificaIIProyecto.frmLogin();

        private Form activeForm = null;

        private void OpenForm(Form childForm)
        {
            panelHoraFecha.Hide();
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


        private void FrmDocente_Load(object sender, EventArgs e)
        {
            id = login.Id;
            lblId.Text = Convert.ToString(login.Id);
            lblIdentidad.Text = login.Identidad;
            lblNombre.Text = login.Nombre;
            lblApellido.Text = login.Apellido;

            if (login.Imagen != null)
            {
                pictureUsuario.Image = login.Imagen;
            }
            else
            {
                pictureUsuario.Image = pictureUsuario.InitialImage;
            }

            Buho.BringToFront();
        }

        private void CustomizeDesign()
        {
            SubmenuNotas.Visible = false;
            
        }

        private void HideSubmenu()
        {
            if (SubmenuNotas.Visible == true)
                SubmenuNotas.Visible = false;

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

        private void btnNotas_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuNotas);
        }

        private void btnIngresarNotas_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            FrmIngresarNotas ingresonotas = new FrmIngresarNotas();
            ingresonotas.lblTitulo.Text = "Ingreso de Notas 1er Parcial";
            ingresonotas.dgvPrimerParcial.Visible = true;
            ingresonotas.dgvSegundoParcial.Visible = false;
            ingresonotas.dgvTercerParcial.Visible = false;
            ingresonotas.dgvCuartoParcial.Visible = false;
            ingresonotas.dgvRecuperacion.Visible = false;
            ingresonotas.btnIsertarNota1.Visible = true;
            ingresonotas.btnIsertarNota2.Visible = false;
            ingresonotas.btnIsertarNota3.Visible = false;
            ingresonotas.btnIsertarNota4.Visible = false;
            ingresonotas.btnIsertarRecuperacion.Visible = false;
            OpenForm(ingresonotas);
        }

        private void btnListarNotas_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            FrmIngresarNotas ingresonotas = new FrmIngresarNotas();
            ingresonotas.lblTitulo.Text = "Ingreso de Notas 2do Parcial";
            ingresonotas.dgvPrimerParcial.Visible = false;
            ingresonotas.dgvSegundoParcial.Visible = true;
            ingresonotas.dgvTercerParcial.Visible = false;
            ingresonotas.dgvCuartoParcial.Visible = false;
            ingresonotas.dgvRecuperacion.Visible = false;
            ingresonotas.btnIsertarNota1.Visible = false;
            ingresonotas.btnIsertarNota2.Visible = true;
            ingresonotas.btnIsertarNota3.Visible = false;
            ingresonotas.btnIsertarNota4.Visible = false;
            ingresonotas.btnIsertarRecuperacion.Visible = false;
            OpenForm(ingresonotas);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            i = 1;
            
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesion?", "Cerrar Sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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

        private void picLogo_Click(object sender, EventArgs e)
        {
        }

        private void lblIdentidad_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btn3erParcial_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            FrmIngresarNotas ingresonotas = new FrmIngresarNotas();
            ingresonotas.lblTitulo.Text = "Ingreso de Notas 3er Parcial";
            ingresonotas.dgvPrimerParcial.Visible = false;
            ingresonotas.dgvSegundoParcial.Visible = false;
            ingresonotas.dgvTercerParcial.Visible = true;
            ingresonotas.dgvCuartoParcial.Visible = false;
            ingresonotas.dgvRecuperacion.Visible = false;
            ingresonotas.btnIsertarNota1.Visible = false;
            ingresonotas.btnIsertarNota2.Visible = false;
            ingresonotas.btnIsertarNota3.Visible = true;
            ingresonotas.btnIsertarNota4.Visible = false;
            ingresonotas.btnIsertarRecuperacion.Visible = false;
            OpenForm(ingresonotas);
        }

        private void btn4toParcial_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            FrmIngresarNotas ingresonotas = new FrmIngresarNotas();
            ingresonotas.lblTitulo.Text = "Ingreso de Notas 4to Parcial";
            ingresonotas.dgvPrimerParcial.Visible = false;
            ingresonotas.dgvSegundoParcial.Visible = false;
            ingresonotas.dgvTercerParcial.Visible = false;
            ingresonotas.dgvCuartoParcial.Visible = true;
            ingresonotas.dgvRecuperacion.Visible = false;
            ingresonotas.btnIsertarNota1.Visible = false;
            ingresonotas.btnIsertarNota2.Visible = false;
            ingresonotas.btnIsertarNota3.Visible = false;
            ingresonotas.btnIsertarNota4.Visible = true;
            ingresonotas.btnIsertarRecuperacion.Visible = false;
            OpenForm(ingresonotas);
        }

        private void btnRecuperacion_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            FrmIngresarNotas ingresonotas = new FrmIngresarNotas();
            ingresonotas.lblTitulo.Text = "Ingreso de Notas Recuperación";
            ingresonotas.dgvPrimerParcial.Visible = false;
            ingresonotas.dgvSegundoParcial.Visible = false;
            ingresonotas.dgvTercerParcial.Visible = false;
            ingresonotas.dgvCuartoParcial.Visible = false;
            ingresonotas.dgvRecuperacion.Visible = true;
            ingresonotas.btnIsertarNota1.Visible = false;
            ingresonotas.btnIsertarNota2.Visible = false;
            ingresonotas.btnIsertarNota3.Visible = false;
            ingresonotas.btnIsertarNota4.Visible = false;
            ingresonotas.btnIsertarRecuperacion.Visible = true;
            OpenForm(ingresonotas);
        }

        private void FrmDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(i==0)
            {
                Application.Exit();
            } 

        }
    }
}
