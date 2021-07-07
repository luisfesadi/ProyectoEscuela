using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escuela;
using System.Runtime.InteropServices;

namespace cientificaIIProyecto
{
    public partial class frmSeleccionarFormas : Form
    {
        public frmSeleccionarFormas()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            Registro.FrmAdmin frmAdmin = new Registro.FrmAdmin();
            frmAdmin.Show();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            FrmDocente.FrmDocente FrmDocente = new FrmDocente.FrmDocente();
            FrmDocente.Show();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Proyecto_Escuela.frmAlumno frmAlumno = new Proyecto_Escuela.frmAlumno();
            frmAlumno.Show();
        }

        private void frmSeleccionarFormas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
