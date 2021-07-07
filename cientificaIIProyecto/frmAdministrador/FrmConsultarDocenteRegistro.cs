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
    public partial class FrmConsultarDocenteRegistro : Form
    {
        public FrmConsultarDocenteRegistro()
        {
            InitializeComponent();
        }

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

        private void FrmConsultarDocenteRegistro_Load(object sender, EventArgs e)
        {
            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

            if (dgvRegistro.Visible == true)
            {
                conexion.cargarRegistro(dgvRegistro);
                dgvRegistro.ClearSelection();
            }

            if (dgvDocentes.Visible == true)
            {
                conexion.cargarDocente(dgvDocentes);
                dgvDocentes.ClearSelection();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dgvRegistro.Visible == true)
            {
                if (cmbFiltro.SelectedIndex != -1)
                {
                    String query = "select * from Administradores a inner join [Estado Civil] b on a.Id_estado = b.Id_estado inner join Genero c on a.Id_genero = c.Id_genero where ";
                    conexion.Busqueda(query, this.txtBuscar.Text, cmbFiltro.Text, dgvRegistro);
                }
            }

            if (dgvDocentes.Visible == true)
            {
                if (cmbFiltro.SelectedIndex != -1)
                {
                    String query = "select * from Docentes a inner join Profesiones b on a.Id_Profesion = b.Id_profesion inner join[Estado Civil] c on a.Id_estado = c.Id_estado inner join Genero d on a.Id_genero = d.Id_genero where ";
                    conexion.Busqueda(query, this.txtBuscar.Text, cmbFiltro.Text, dgvDocentes);
                }
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Focus();
        }
    }
}
