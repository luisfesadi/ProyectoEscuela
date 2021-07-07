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
    public partial class FrmEliminarAlumno : Form
    {
        public FrmEliminarAlumno()
        {
            InitializeComponent();
        }

        int identificador = 0;

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

        cientificaIIProyecto.frmAdministrador.Personas personas = new cientificaIIProyecto.frmAdministrador.Personas();

        private void FrmEliminarAlumno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escuela_BDDDataSet39.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.escuela_BDDDataSet39.Genero);

            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
            conexion.cargarAlumno(dgvAlumnos);
            dgvAlumnos.ClearSelection();
            cmbSexo.SelectedIndex = -1;
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvAlumnos.Rows[e.RowIndex];

                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                txtIdentidad.Text = Convert.ToString(fila.Cells[1].Value);
                txtContraseña.Text = Convert.ToString(fila.Cells[2].Value);
                txtNombres.Text = Convert.ToString(fila.Cells[3].Value);
                txtApellidos.Text = Convert.ToString(fila.Cells[4].Value);

                if (fila.Cells[5].Value != DBNull.Value)
                {
                    byte[] datos = new byte[0];
                    datos = (byte[])fila.Cells[5].Value;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    pictureAlumno.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                else
                {
                    pictureAlumno.Image = pictureAlumno.InitialImage;
                }

                datePickerFechaNacimiento.Value = Convert.ToDateTime(fila.Cells[6].Value.ToString());
                cmbSexo.SelectedValue = Convert.ToInt32(fila.Cells[7].Value);
                txtGrado.Text = Convert.ToString(fila.Cells[9].Value);
                txtCorreo_electronico.Text = Convert.ToString(fila.Cells[10].Value);
                txtIdEncargado.Text = Convert.ToString(fila.Cells[11].Value);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureAlumno.Load(this.openFileDialog1.FileName);
                }

                identificador = 1;

            }
            catch
            {
                MessageBox.Show("No selecciono una imagen");
                identificador = 0;
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            personas.Identidad = txtIdentidad.Text;
            personas.Nombres = txtNombres.Text;
            personas.Apellidos = txtApellidos.Text;
            personas.Genero = cmbSexo.Text;

            cientificaIIProyecto.frmAdministrador.Alumnos alumnos = new cientificaIIProyecto.frmAdministrador.Alumnos(txtContraseña.Text, datePickerFechaNacimiento.Value.Date, int.Parse(txtGrado.Text));

            conexion.Mantenimiento("ELIMINAR", Convert.ToInt32(txtId.Text), pictureAlumno, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtContraseña.Text, Convert.ToInt32(txtGrado.Text), datePickerFechaNacimiento.Value.Date, Convert.ToInt32(cmbSexo.SelectedValue), Convert.ToInt32(txtIdEncargado.Text), identificador, txtCorreo_electronico.Text);

            if (MessageBox.Show("¿Desea ver los datos que acaba de eliminar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show(alumnos.Mensaje(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conexion.cargarAlumno(dgvAlumnos);
            pictureAlumno.Image = pictureAlumno.InitialImage;
            txtId.Clear();
            txtIdentidad.Clear();
            txtContraseña.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtIdEncargado.Clear();
            txtGrado.Clear();
            cmbSexo.SelectedIndex = -1;
            txtCorreo_electronico.Clear();
            datePickerFechaNacimiento.Value = DateTime.Now;
            dgvAlumnos.ClearSelection();
        }

        private void txtIdEncargado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
