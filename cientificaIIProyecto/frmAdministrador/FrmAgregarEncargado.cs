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
    public partial class FrmAgregarEncargado : Form
    {
        public FrmAgregarEncargado()
        {
            InitializeComponent();
        }

        int identificador = 0;

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
        cientificaIIProyecto.frmAdministrador.Personas personas = new cientificaIIProyecto.frmAdministrador.Personas();

        private void FrmAgregarEncargado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuela_BDDDataSet27.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.escuela_BDDDataSet27.Genero);
            
            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

            conexion.cargarEncargado(dgvEncargados);
            dgvEncargados.ClearSelection();
            cmbSexo.SelectedIndex = -1;
        }

        private void btnAgregarEncargado_Click(object sender, EventArgs e)
        {

            if (txtIdentidad.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || cmbSexo.Text == "" || txtCorreo_electronico.Text == "" || txtTelefono.Text == "" || richtxtDireccion.Text == "")
                MessageBox.Show("¡Error! Llene todos los campos para poder registrar la información.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (txtIdentidad.TextLength < 13)
                {
                    MessageBox.Show("¡Error! El número de identidad debe de tener trece dígitos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdentidad.Focus();
                }
                else
                {
                    personas.Identidad = txtIdentidad.Text;
                    personas.Nombres = txtNombres.Text;
                    personas.Apellidos = txtApellidos.Text;
                    personas.Genero = cmbSexo.Text;

                    cientificaIIProyecto.frmAdministrador.Encargado encargado = new cientificaIIProyecto.frmAdministrador.Encargado(richtxtDireccion.Text, txtTelefono.Text, txtCorreo_electronico.Text);

                    if (conexion.personaRegistrada(txtIdentidad.Text) == 0)
                    {
                        conexion.Mantenimiento("INSERTAR", 0, pictureRegDoc, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtCorreo_electronico.Text, richtxtDireccion.Text, Convert.ToInt32(cmbSexo.SelectedValue), txtTelefono.Text, identificador);

                        if (MessageBox.Show("¿Desea ver un resumen de los datos ingresado?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            MessageBox.Show(encargado.Mensaje(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conexion.cargarEncargado(dgvEncargados);
                        txtIdentidad.Clear();
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtCorreo_electronico.Clear();
                        richtxtDireccion.Clear();
                        cmbSexo.SelectedIndex = -1;
                        txtTelefono.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Este número de identidad ya existe");
                    }
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureRegDoc.Load(this.openFileDialog1.FileName);
                }

                identificador = 1;
            }
            catch 
            {
                MessageBox.Show("No selecciono una imagen");
                identificador = 0;
            }
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Validar de que los datos ingresados solo sean números.
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) // Validar que el campo de los nombres solo se puedan ingresar letras (mayúsculas o minúsculas) y espacios.
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) // Validar que el campo de los apellidos solo se puedan ingresar letras (mayúsculas o minúsculas) y espacios.
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '+')) //Este es para validar el número de teléfono, en el cual solo podrá ingresar números, espacios, símbolos de más y guiones medios.
            {
                e.Handled = true;
            }
        }
    }
}
