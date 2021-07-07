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
    public partial class FrmAsignacionClases : Form
    {
        public FrmAsignacionClases()
        {
            InitializeComponent();
        }

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

        private void FrmAsignacionClases_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escuela_BDDDataSet15.Docentes' table. You can move, or remove it, as needed.
            this.docentesTableAdapter.Fill(this.escuela_BDDDataSet15.Docentes);
            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
            conexion.cargarAsignacion(dgvAsignacion);
            dgvAsignacion.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtClase_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAsignacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAsignacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvAsignacion.Rows[e.RowIndex];

                txtClase.Text = Convert.ToString(fila.Cells[1].Value);
                txtIdDocente.Text = Convert.ToString(fila.Cells[2].Value);
                
            }
        }

        private void btnAsignarEncargado_Click(object sender, EventArgs e)
        {
            FrmEncargadoDocente frm_docente = new FrmEncargadoDocente();
            frm_docente.dgvEncargados.Visible = false;
            frm_docente.dgvDocentes.Visible = true;

            DialogResult ResultadoDocente = frm_docente.ShowDialog();

            if (ResultadoDocente == DialogResult.OK)
            {
                txtIdDocente.Text = Convert.ToString(frm_docente.Id_Docente);
            }

            if (ResultadoDocente == DialogResult.Cancel)
            {
                MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdDocente.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtIdDocente.Text == "")
                MessageBox.Show("¡Error! Llene todos los campos para poder registrar la información.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conexion.Mantenimiento(Convert.ToInt32(txtIdDocente.Text), txtClase.Text);
                conexion.cargarAsignacion(dgvAsignacion);
            }

        }
    }
}
