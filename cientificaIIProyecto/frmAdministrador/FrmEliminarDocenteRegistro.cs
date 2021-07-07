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
    public partial class FrmEliminarDocenteRegistro : Form
    {
        public FrmEliminarDocenteRegistro()
        {
            InitializeComponent();
        }

        int identificador = 0;

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

        cientificaIIProyecto.frmAdministrador.Personas personas = new cientificaIIProyecto.frmAdministrador.Personas();

        private void FrmEliminarDocenteRegistro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escuela_BDDDataSet42.Profesiones' table. You can move, or remove it, as needed.
            this.profesionesTableAdapter.Fill(this.escuela_BDDDataSet42.Profesiones);
            // TODO: This line of code loads data into the 'escuela_BDDDataSet41.Estado_Civil' table. You can move, or remove it, as needed.
            this.estado_CivilTableAdapter.Fill(this.escuela_BDDDataSet41.Estado_Civil);
            // TODO: This line of code loads data into the 'escuela_BDDDataSet40.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.escuela_BDDDataSet40.Genero);

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

            cmbEstadoCivil.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            cmbProfesion.SelectedIndex = -1;
        }

        private void btnEliminarRegs_Click(object sender, EventArgs e)
        {
            personas.Identidad = txtIdentidad.Text;
            personas.Nombres = txtNombres.Text;
            personas.Apellidos = txtApellidos.Text;
            personas.Genero = cmbSexo.Text;

            cientificaIIProyecto.frmAdministrador.Registro registro = new cientificaIIProyecto.frmAdministrador.Registro(txtContraseña.Text, datePickerFechaNacimiento.Value.Date, txtCorreo_electronico.Text, cmbEstadoCivil.Text);

            MessageBox.Show(conexion.Mantenimiento("ELIMINAR", Convert.ToInt32(txtId.Text), pictureRegDoc, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtContraseña.Text, datePickerFechaNacimiento.Value.Date, Convert.ToInt32(cmbSexo.SelectedValue), Convert.ToInt32(cmbEstadoCivil.SelectedValue), txtCorreo_electronico.Text, Convert.ToDouble(txtSueldo.Text), identificador));

            if (MessageBox.Show("¿Desea ver los datos que acaba de eliminar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show(registro.Mensaje(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conexion.cargarRegistro(dgvRegistro);
            pictureRegDoc.Image = pictureRegDoc.InitialImage;
            txtId.Clear();
            txtIdentidad.Clear();
            txtContraseña.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtSueldo.Clear();
            txtCorreo_electronico.Clear();
            cmbSexo.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            datePickerFechaNacimiento.Value = DateTime.Now;
            dgvRegistro.ClearSelection();
        }

        private void dgvRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvRegistro.Rows[e.RowIndex];

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
                pictureRegDoc.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            else
            {
                pictureRegDoc.Image = pictureRegDoc.InitialImage;
            }

            datePickerFechaNacimiento.Value = Convert.ToDateTime(fila.Cells[6].Value.ToString());
            cmbEstadoCivil.SelectedValue = Convert.ToInt32(fila.Cells[7].Value);
            cmbSexo.SelectedValue = Convert.ToInt32(fila.Cells[9].Value);
            txtCorreo_electronico.Text = Convert.ToString(fila.Cells[11].Value);
            txtSueldo.Text = Convert.ToString(fila.Cells[12].Value);
        }

        private void btnEliminarDoc_Click(object sender, EventArgs e)
        {

            personas.Identidad = txtIdentidad.Text;
            personas.Nombres = txtNombres.Text;
            personas.Apellidos = txtApellidos.Text;
            personas.Genero = cmbSexo.Text;

            cientificaIIProyecto.frmAdministrador.Docentes docentes = new cientificaIIProyecto.frmAdministrador.Docentes(txtContraseña.Text, datePickerFechaNacimiento.Value.Date, txtCorreo_electronico.Text, cmbProfesion.Text, cmbEstadoCivil.Text);

            MessageBox.Show(conexion.Mantenimiento("ELIMINAR", Convert.ToInt32(txtId.Text), pictureRegDoc, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtContraseña.Text, datePickerFechaNacimiento.Value.Date, Convert.ToInt32(cmbSexo.SelectedValue), Convert.ToInt32(cmbEstadoCivil.SelectedValue), Convert.ToInt32(cmbProfesion.SelectedValue), txtCorreo_electronico.Text, Convert.ToDouble(txtSueldo.Text), identificador));

            if (MessageBox.Show("¿Desea ver los datos que acaba de eliminar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show(docentes.Mensaje(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conexion.cargarDocente(dgvDocentes);
            pictureRegDoc.Image = pictureRegDoc.InitialImage;
            txtId.Clear();
            txtIdentidad.Clear();
            txtContraseña.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtSueldo.Clear();
            txtCorreo_electronico.Clear();
            cmbSexo.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            cmbProfesion.SelectedIndex = -1;
            datePickerFechaNacimiento.Value = DateTime.Now;
            dgvDocentes.ClearSelection();
        }

        private void dgvDocentes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvDocentes.Rows[e.RowIndex];

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
                    pictureRegDoc.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                else
                {
                    pictureRegDoc.Image = pictureRegDoc.InitialImage;
                }

                datePickerFechaNacimiento.Value = Convert.ToDateTime(fila.Cells[6].Value.ToString());
                cmbEstadoCivil.SelectedValue = Convert.ToInt32(fila.Cells[7].Value);
                cmbSexo.SelectedValue = Convert.ToInt32(fila.Cells[9].Value);
                cmbProfesion.SelectedValue = Convert.ToInt32(fila.Cells[11].Value);
                txtCorreo_electronico.Text = Convert.ToString(fila.Cells[13].Value);
                txtSueldo.Text = Convert.ToString(fila.Cells[14].Value);
            }
        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
