using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void panelMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void CustomizeDesign()
        {
            SubmenuAlumnos.Visible = false;
            SubmenuDocentes.Visible = false;
            SubmenuEncargados.Visible = false;
            SubmenuRegistro.Visible = false;
            SubmenuAsignacion.Visible = false;
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

            if (SubmenuAsignacion.Visible == true)
                SubmenuAsignacion.Visible = false;
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
            HideSubmenu();
        }

        private void btnEditarRegistro_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnConsultarRegistro_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuDocentes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuAsignacion);
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
            HideSubmenu();
        }

        private void btnEditarDocentes_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEliminarDocentes_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnConsultarDocentes_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
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

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

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
            HideSubmenu();
        }

        private void btnEditarAlumnos_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEliminarAlumnos_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnConsultarAlumnos_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnAgregarEncargados_Click_1(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEditarEncargados_Click_1(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEliminarEncargados_Click_1(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnConsultarEncargados_Click_1(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnAgregarAsignacion_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnEditarAsignacion_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }
    }
}
