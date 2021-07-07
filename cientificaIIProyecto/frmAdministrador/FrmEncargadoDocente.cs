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
    public partial class FrmEncargadoDocente : Form
    {
        public FrmEncargadoDocente()
        {
            InitializeComponent();
        }

        private int id_encargado;

        public int Id_encargado
        {
            get { return id_encargado;}
        }

        private int id_docente;
        
        public int Id_Docente
        {
            get { return id_docente; }
        }

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEncargadoAlumno_Load(object sender, EventArgs e)
        {
            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

            if(dgvEncargados.Visible == true)
            {
                conexion.cargarEncargado(dgvEncargados);
                dgvEncargados.ClearSelection();
            }

            if (dgvDocentes.Visible == true)
            {
                conexion.cargarDocente(dgvDocentes);
                dgvDocentes.ClearSelection();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void dgvEncargados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvEncargados.Rows[e.RowIndex];

                id_encargado = Convert.ToInt32(fila.Cells[0].Value);
            }
        }

        private void dgvEncargados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dgvEncargados.Visible == true)
            {
                if (cmbFiltro.SelectedIndex != -1)
                {
                    string filtro = cmbFiltro.Text + "_encargado";

                    String query = "select * from Encargados a inner join Genero b on a.Id_genero_encargado = b.Id_genero where ";
                    conexion.Busqueda(query, this.txtBuscar.Text, filtro, dgvEncargados);
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

        private void dgvDocentes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvDocentes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvDocentes.Rows[e.RowIndex];

                id_docente = Convert.ToInt32(fila.Cells[0].Value);
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Focus();
        }

        private void dgvDocentes_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvDocentes.Rows[e.RowIndex];

                id_docente = Convert.ToInt32(fila.Cells[0].Value);
            }

        }
    }
}
