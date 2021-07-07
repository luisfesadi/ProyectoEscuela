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
    public partial class FrmConsultarAlumno : Form
    {
        public FrmConsultarAlumno()
        {
            InitializeComponent();
        }

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

        private void FrmConsultarAlumno_Load(object sender, EventArgs e)
        {
            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
            conexion.cargarAlumno(dgvAlumnos);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex != -1)
            {
                String query = "Select* from Alumnos a inner join Genero b on a.Id_genero = b.Id_genero left join Encargados c on a.Id_encargado = c.Id_encargado where ";
                conexion.Busqueda(query, this.txtBuscar.Text, cmbFiltro.Text, dgvAlumnos);
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Focus();
        }
    }
}
