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
    public partial class FrmConsultarEncargado : Form
    {
        public FrmConsultarEncargado()
        {
            InitializeComponent();
        }

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

        private void FrmConsultarEncargado_Load(object sender, EventArgs e)
        {
            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

            conexion.cargarEncargado(dgvEncargados);
            dgvEncargados.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltro.Text + "_encargado";
            if (cmbFiltro.SelectedIndex != -1)
            {
                String query = "select * from Encargados a inner join Genero b on a.Id_genero_encargado = b.Id_genero where ";
                conexion.Busqueda(query, this.txtBuscar.Text, filtro, dgvEncargados);
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Focus();
        }
    }
}
