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
    public partial class FrmEliminarEncargado : Form
    {
        public FrmEliminarEncargado()
        {
            InitializeComponent();
        }

        int identificador = 0;

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
        cientificaIIProyecto.frmAdministrador.Personas personas = new cientificaIIProyecto.frmAdministrador.Personas();

        private void dgvEncargados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvEncargados.Rows[e.RowIndex];

                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                txtIdentidad.Text = Convert.ToString(fila.Cells[1].Value);
                txtNombres.Text = Convert.ToString(fila.Cells[2].Value);
                txtApellidos.Text = Convert.ToString(fila.Cells[3].Value);
                cmbSexo.SelectedValue = Convert.ToInt32(fila.Cells[4].Value);

                if (fila.Cells[6].Value != DBNull.Value)
                {
                    byte[] datos = new byte[0];
                    datos = (byte[])fila.Cells[6].Value;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    pictureRegDoc.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                else
                {
                    pictureRegDoc.Image = pictureRegDoc.InitialImage;
                }

                txtCorreo_electronico.Text = Convert.ToString(fila.Cells[7].Value);
                richtxtDireccion.Text = Convert.ToString(fila.Cells[8].Value);
                txtTelefono.Text = Convert.ToString(fila.Cells[9].Value);
            }
        }

        private void FrmEliminarEncargado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escuela_BDDDataSet43.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.escuela_BDDDataSet43.Genero);

            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

            conexion.cargarEncargado(dgvEncargados);
            dgvEncargados.ClearSelection();
            cmbSexo.SelectedIndex = -1;
        }

        private void btnEliminarEncargado_Click(object sender, EventArgs e)
        {
            personas.Identidad = txtIdentidad.Text;
            personas.Nombres = txtNombres.Text;
            personas.Apellidos = txtApellidos.Text;
            personas.Genero = cmbSexo.Text;

            cientificaIIProyecto.frmAdministrador.Encargado encargados = new cientificaIIProyecto.frmAdministrador.Encargado(richtxtDireccion.Text, txtTelefono.Text, txtCorreo_electronico.Text);

            conexion.Mantenimiento("ELIMINAR", Convert.ToInt32(txtId.Text), pictureRegDoc, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtCorreo_electronico.Text, richtxtDireccion.Text, Convert.ToInt32(cmbSexo.SelectedValue), txtTelefono.Text, identificador);

            if (MessageBox.Show("¿Desea ver los datos que acaba de eliminar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show(encargados.Mensaje(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conexion.cargarEncargado(dgvEncargados);

            pictureRegDoc.Image = pictureRegDoc.InitialImage;
            txtId.Clear();
            txtIdentidad.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo_electronico.Clear();
            richtxtDireccion.Clear();
            cmbSexo.SelectedIndex = -1;
            dgvEncargados.ClearSelection();
            txtTelefono.Clear();
        }

        private void dgvEncargados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
