using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDocente
{
    public partial class FrmIngresarNotas : Form
    {
        public FrmIngresarNotas()
        {
            InitializeComponent();
        }

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dgvPrimerParcial.Visible == true)
            {
                conexion.cargarNotas(dgvPrimerParcial, cmbClase.Text);
                dgvPrimerParcial.ClearSelection();
            }

            if (dgvSegundoParcial.Visible == true)
            {
                conexion.cargarNotas(dgvSegundoParcial, cmbClase.Text);
                dgvSegundoParcial.ClearSelection();
            }

            if (dgvTercerParcial.Visible == true)
            {
                conexion.cargarNotas(dgvTercerParcial, cmbClase.Text);
                dgvTercerParcial.ClearSelection();
            }

            if (dgvCuartoParcial.Visible == true)
            {
                conexion.cargarNotas(dgvCuartoParcial, cmbClase.Text);
                dgvCuartoParcial.ClearSelection();
            }

            if (dgvRecuperacion.Visible == true)
            {
                conexion.cargarNotas(dgvRecuperacion, cmbClase.Text);
                dgvRecuperacion.ClearSelection();
            }

        }

        private void FrmIngresarNotas_Load(object sender, EventArgs e)
        {
            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
            FrmDocente docente = new FrmDocente();
            conexion.LlenarCombobox(cmbClase, docente.Id);
            dgvPrimerParcial.ClearSelection();
            dgvPrimerParcial.AutoGenerateColumns = false;
            dgvSegundoParcial.ClearSelection();
            dgvSegundoParcial.AutoGenerateColumns = false;
            dgvTercerParcial.ClearSelection();
            dgvTercerParcial.AutoGenerateColumns = false;
            dgvCuartoParcial.ClearSelection();
            dgvCuartoParcial.AutoGenerateColumns = false;
            dgvRecuperacion.ClearSelection();
            dgvRecuperacion.AutoGenerateColumns = false;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar == 48)
                e.Handled = true;
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Validar de que los datos ingresados solo sean números.
            {
                e.Handled = true;
            }
        }

        private void dgvPrimerParcial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvPrimerParcial.Rows[e.RowIndex];

                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                txtIdentidad.Text = Convert.ToString(fila.Cells[1].Value);
                txtIdClase.Text = Convert.ToString(fila.Cells[2].Value);
            }
        }

        private void txtGrado_TextChanged(object sender, EventArgs e)
        {
            if (dgvPrimerParcial.Visible == true)
            {
                if (this.txtGrado.Text != "")
                {
                    conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvPrimerParcial);
                }
                else
                {
                    conexion.cargarNotas(dgvPrimerParcial, cmbClase.Text);
                }
            }

            if (dgvSegundoParcial.Visible == true)
            {
                if (this.txtGrado.Text != "")
                {
                    conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvSegundoParcial);
                }
                else
                {
                    conexion.cargarNotas(dgvSegundoParcial, cmbClase.Text);
                }
            }

            if (dgvTercerParcial.Visible == true)
            {
                if (this.txtGrado.Text != "")
                {
                    conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvTercerParcial);
                }
                else
                {
                    conexion.cargarNotas(dgvTercerParcial, cmbClase.Text);
                }
            }

            if (dgvCuartoParcial.Visible == true)
            {
                if (this.txtGrado.Text != "")
                {
                    conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvCuartoParcial);
                }
                else
                {
                    conexion.cargarNotas(dgvCuartoParcial, cmbClase.Text);
                }
            }

            if (dgvRecuperacion.Visible == true)
            {
                if (this.txtGrado.Text != "")
                {
                    conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvRecuperacion);
                }
                else
                {
                    conexion.cargarNotas(dgvRecuperacion, cmbClase.Text);
                }
            }

        }

        private void txtNota1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnIsertarNota_Click(object sender, EventArgs e)
        {
            if (txtIdentidad.Text == "" || txtNota.Text == "" || txtId.Text == "" || txtIdClase.Text == "")
            {
                MessageBox.Show("¡Error! Llene todos los campos para poder registrar la información.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(txtNota.Text) <= 0 || int.Parse(txtNota.Text) > 100)
                {
                    MessageBox.Show("Ingrese una nota válida.");
                    txtNota.Text = "";
                    txtNota.Focus();
                }
                else
                {
                    if (txtGrado.Text != "")
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 1);
                        conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvPrimerParcial);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
                    else
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 1);
                        conexion.cargarNotas(dgvPrimerParcial, cmbClase.Text);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
  
                }
            }
               
        }

        private void dgvSegundoParcial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvSegundoParcial.Rows[e.RowIndex];

                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                txtIdentidad.Text = Convert.ToString(fila.Cells[1].Value);
                txtIdClase.Text = Convert.ToString(fila.Cells[2].Value);
            }
        }

        private void btnIsertarNota2_Click(object sender, EventArgs e)
        {
            if (txtIdentidad.Text == "" || txtNota.Text == "" || txtId.Text == "" || txtIdClase.Text == "")
            {
                MessageBox.Show("¡Error! Llene todos los campos para poder registrar la información.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(txtNota.Text) <= 0 || int.Parse(txtNota.Text) > 100)
                {
                    MessageBox.Show("Ingrese una nota válida.");
                    txtNota.Text = "";
                    txtNota.Focus();
                }
                else
                {
                    if (txtGrado.Text != "")
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 2);
                        conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvSegundoParcial);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
                    else
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 2);
                        conexion.cargarNotas(dgvSegundoParcial, cmbClase.Text);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
                }
            }
        }

        private void btnIsertarNota3_Click(object sender, EventArgs e)
        {
            if (txtIdentidad.Text == "" || txtNota.Text == "" || txtId.Text == "" || txtIdClase.Text == "")
            {
                MessageBox.Show("¡Error! Llene todos los campos para poder registrar la información.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(txtNota.Text) <= 0 || int.Parse(txtNota.Text) > 100)
                {
                    MessageBox.Show("Ingrese una nota válida.");
                    txtNota.Text = "";
                    txtNota.Focus();
                }
                else
                {
                    if (txtGrado.Text != "")
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 3);
                        conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvTercerParcial);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
                    else
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 3);
                        conexion.cargarNotas(dgvTercerParcial, cmbClase.Text);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }

                }
            }
        }

        private void dgvTercerParcial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvTercerParcial.Rows[e.RowIndex];

                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                txtIdentidad.Text = Convert.ToString(fila.Cells[1].Value);
                txtIdClase.Text = Convert.ToString(fila.Cells[2].Value);
            }
        }

        private void dgvCuartoParcial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvCuartoParcial.Rows[e.RowIndex];

                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                txtIdentidad.Text = Convert.ToString(fila.Cells[1].Value);
                txtIdClase.Text = Convert.ToString(fila.Cells[2].Value);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtIdentidad.Text == "" || txtNota.Text == "" || txtId.Text == "" || txtIdClase.Text == "")
            {
                MessageBox.Show("¡Error! Llene todos los campos para poder registrar la información.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(txtNota.Text) <= 0 || int.Parse(txtNota.Text) > 100)
                {
                    MessageBox.Show("Ingrese una nota válida.");
                    txtNota.Text = "";
                    txtNota.Focus();
                }
                else
                {
                    if (txtGrado.Text != "")
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 4);
                        conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvCuartoParcial);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
                    else
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 4);
                        conexion.cargarNotas(dgvCuartoParcial, cmbClase.Text);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
                }
            }
        }

        private void dgvRecuperacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = dgvRecuperacion.Rows[e.RowIndex];

                txtId.Text = Convert.ToString(fila.Cells[0].Value);
                txtIdentidad.Text = Convert.ToString(fila.Cells[1].Value);
                txtIdClase.Text = Convert.ToString(fila.Cells[2].Value);
            }
        }

        private void btnIsertarRecuperacion_Click(object sender, EventArgs e)
        {
            if (txtIdentidad.Text == "" || txtNota.Text == "" || txtId.Text == "" || txtIdClase.Text == "")
            {
                MessageBox.Show("¡Error! Llene todos los campos para poder registrar la información.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(txtNota.Text) <= 0 || int.Parse(txtNota.Text) > 100)
                {
                    MessageBox.Show("Ingrese una nota válida.");
                    txtNota.Text = "";
                    txtNota.Focus();
                }
                else
                {
                    if (txtGrado.Text != "")
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 5);
                        conexion.Busqueda(cmbClase.Text, Convert.ToInt32(txtGrado.Text), dgvRecuperacion);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
                    else
                    {
                        conexion.Notas(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdClase.Text), Convert.ToInt32(txtNota.Text), 5);
                        conexion.cargarNotas(dgvRecuperacion, cmbClase.Text);
                        txtNota.Clear();
                        txtIdentidad.Clear();
                    }
                }
            }
        }
    }
}