using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registro
{
    public partial class FrmAdmin : Form
    {

        public FrmAdmin()
        {
            InitializeComponent();
            CustomizeDesign();
        }


        int i = 0;

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

        private void CustomizeDesign()
        {
            SubmenuAlumnos.Visible = false;
            SubmenuDocentes.Visible = false;
            SubmenuEncargados.Visible = false;
            SubmenuRegistro.Visible = false;
        }

        private void HideSubmenu()
        {
            if (SubmenuAlumnos.Visible == true)
                SubmenuAlumnos.Visible = false;

            if (SubmenuDocentes.Visible == true)
                SubmenuDocentes.Visible = false;

            if (SubmenuEncargados.Visible == true)
                SubmenuEncargados.Visible = false;

            if (SubmenuRegistro.Visible == true)
                SubmenuRegistro.Visible = false;

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

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuRegistro);
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            FrmAgregarDocenteRegistro FrmAgregarRegistro = new FrmAgregarDocenteRegistro();
            FrmAgregarRegistro.lblTituloAgregar.Text = "AGREGAR REGISTRO";
            FrmAgregarRegistro.dgvRegistro.Visible = true;
            FrmAgregarRegistro.dgvDocentes.Visible = false;
            FrmAgregarRegistro.lblProfesion.Visible = false;
            FrmAgregarRegistro.cmbProfesion.Visible = false;
            FrmAgregarRegistro.btnAgregarRegs.Visible = true;
            FrmAgregarRegistro.btnAgregarDoc.Visible = false;
            OpenForm(FrmAgregarRegistro);
            
            HideSubmenu();
        }


        private void btnEditarRegistro_Click(object sender, EventArgs e)
        {
            FrmEditarDocenteRegistro FrmEditarRegistro = new FrmEditarDocenteRegistro();
            FrmEditarRegistro.lblTituloEditar.Text = "EDITAR REGISTRO";
            FrmEditarRegistro.dgvRegistro.Visible = true;
            FrmEditarRegistro.dgvDocentes.Visible = false;
            FrmEditarRegistro.lblProfesion.Visible = false;
            FrmEditarRegistro.cmbProfesion.Visible = false;
            FrmEditarRegistro.btnEditarRegs.Visible = true;
            FrmEditarRegistro.btnEditarDoc.Visible = false;
            OpenForm(FrmEditarRegistro);

            HideSubmenu();
        }

        private void btnEliminarRegistro_Click( object sender, EventArgs e)
        {
            FrmEliminarDocenteRegistro FrmEliminarRegistro = new FrmEliminarDocenteRegistro();
            FrmEliminarRegistro.lblTituloEliminar.Text = "ELIMINAR REGISTRO";
            FrmEliminarRegistro.dgvRegistro.Visible = true;
            FrmEliminarRegistro.dgvDocentes.Visible = false;
            FrmEliminarRegistro.lblProfesion.Visible = false;
            FrmEliminarRegistro.cmbProfesion.Visible = false;
            FrmEliminarRegistro.btnEliminarRegs.Visible = true;
            FrmEliminarRegistro.btnEliminarDoc.Visible = false;
            OpenForm(FrmEliminarRegistro);
            HideSubmenu();
        }

        private void btnConsultarRegistro_Click(object sender, EventArgs e)
        {
            FrmConsultarDocenteRegistro FrmConsultarRegistro = new FrmConsultarDocenteRegistro();
            FrmConsultarRegistro.lblTituloConsultar.Text = "CONSULTAR REGISTRO";
            FrmConsultarRegistro.dgvRegistro.Visible = true;
            FrmConsultarRegistro.dgvDocentes.Visible = false;
            OpenForm(FrmConsultarRegistro);
            HideSubmenu();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuDocentes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAsignacionClases());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuAlumnos);
        }

        private void btnEncargados_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuEncargados);
        }

        private void btnAgregarDocentes_Click(object sender, EventArgs e)
        {
            FrmAgregarDocenteRegistro FrmAgregarDocente = new FrmAgregarDocenteRegistro();
            FrmAgregarDocente.lblTituloAgregar.Text = "AGREGAR DOCENTE";
            FrmAgregarDocente.dgvRegistro.Visible = false;
            FrmAgregarDocente.dgvDocentes.Visible = true;
            FrmAgregarDocente.lblProfesion.Visible = true;
            FrmAgregarDocente.cmbProfesion.Visible = true;
            FrmAgregarDocente.btnAgregarRegs.Visible = false;
            FrmAgregarDocente.btnAgregarDoc.Visible = true;

            OpenForm(FrmAgregarDocente);
            HideSubmenu();
        }

        private void btnEditarDocentes_Click(object sender, EventArgs e)
        {
            FrmEditarDocenteRegistro FrmEditarDocente = new FrmEditarDocenteRegistro();
            FrmEditarDocente.lblTituloEditar.Text = "EDITAR DOCENTE";
            FrmEditarDocente.dgvRegistro.Visible = false;
            FrmEditarDocente.dgvDocentes.Visible = true;
            FrmEditarDocente.lblProfesion.Visible = true;
            FrmEditarDocente.cmbProfesion.Visible = true;
            FrmEditarDocente.btnEditarRegs.Visible = false;
            FrmEditarDocente.btnEditarDoc.Visible = true;

            OpenForm(FrmEditarDocente);
            HideSubmenu();
        }

        private void btnEliminarDocentes_Click(object sender, EventArgs e)
        {
            FrmEliminarDocenteRegistro FrmEliminarDocente = new FrmEliminarDocenteRegistro();
            FrmEliminarDocente.lblTituloEliminar.Text = "ELIMINAR DOCENTE";
            FrmEliminarDocente.dgvRegistro.Visible = false;
            FrmEliminarDocente.dgvDocentes.Visible = true;
            FrmEliminarDocente.lblProfesion.Visible = true;
            FrmEliminarDocente.cmbProfesion.Visible = true;
            FrmEliminarDocente.btnEliminarRegs.Visible = false;
            FrmEliminarDocente.btnEliminarDoc.Visible = true;

            OpenForm(FrmEliminarDocente);
            HideSubmenu();
        }

        private void btnConsultarDocentes_Click(object sender, EventArgs e)
        {
            FrmConsultarDocenteRegistro FrmConsultarDocente = new FrmConsultarDocenteRegistro();
            FrmConsultarDocente.lblTituloConsultar.Text = "CONSULTAR DOCENTE";
            FrmConsultarDocente.dgvRegistro.Visible = false;
            FrmConsultarDocente.dgvDocentes.Visible = true;
            OpenForm(FrmConsultarDocente);
            HideSubmenu();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAgregarAlumno());
            HideSubmenu();
        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnConsultarAlumno_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnAgregarEncargados_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEditarEncargados_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEliminarEncargados_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnConsultarEncargados_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuAlumnos);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuEncargados);
        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAgregarAlumno());
            HideSubmenu();
        }

        private void btnEditarAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmEditarAlumno());
            HideSubmenu();
        }

        private void btnEliminarAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmEliminarAlumno());
            HideSubmenu();
        }

        private void btnConsultarAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmConsultarAlumno());
            HideSubmenu();
        }

        private void btnAgregarEncargados_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmAgregarEncargado());
            HideSubmenu();
        }

        private void btnEditarEncargados_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmEditarEncargado());
            HideSubmenu();
        }

        private void btnEliminarEncargados_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmEliminarEncargado());
            HideSubmenu();
        }

        private void btnConsultarEncargados_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmConsultarEncargado());
            HideSubmenu();
        }


        private void timer1_Tick(object sender, EventArgs e)
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

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (i==0)
            {
                Application.Exit();
            }

        }
    }
}
