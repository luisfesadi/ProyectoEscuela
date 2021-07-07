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
    public partial class FrmAgregarAlumno : Form
    {
        public FrmAgregarAlumno()
        {
            InitializeComponent();
        }

        int identificador = 0;
        bool contraseñaAceptable = false;

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
        cientificaIIProyecto.frmAdministrador.Personas personas = new cientificaIIProyecto.frmAdministrador.Personas();

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEncargadoDocente frm_encargado = new FrmEncargadoDocente();
            frm_encargado.dgvEncargados.Visible = true;
            frm_encargado.dgvDocentes.Visible = false;

            DialogResult ResultadoEncargado = frm_encargado.ShowDialog();

            if (ResultadoEncargado == DialogResult.OK)
            {
                txtIdEncargado.Text = Convert.ToString(frm_encargado.Id_encargado);
            }

            if (ResultadoEncargado == DialogResult.Cancel)
            {
                MessageBox.Show("No se guardaron los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdEncargado.Clear();
            }
        }

        private void FrmAgregarAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuela_BDDDataSet46.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter3.Fill(this.escuela_BDDDataSet46.Genero);
            

            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

            conexion.cargarAlumno(dgvAlumnos);
            dgvAlumnos.ClearSelection();
            cmbSexo.SelectedIndex = -1;
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtIdentidad.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtContraseña.Text == "" || cmbSexo.Text == "" || txtGrado.Text == "" || txtIdEncargado.Text == "")
                MessageBox.Show("¡Error! Llene todos los campos para poder registrar la información.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (contraseñaAceptable == false)
                {
                    MessageBox.Show("¡Error! La contraseña debe de complir con los requisitos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Focus();
                }
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

                        cientificaIIProyecto.frmAdministrador.Alumnos alumnos = new cientificaIIProyecto.frmAdministrador.Alumnos(txtContraseña.Text, datePickerFechaNacimiento.Value.Date, int.Parse(txtGrado.Text));

                        if (conexion.personaRegistrada((txtIdentidad.Text)) == 0)
                        {

                            conexion.Mantenimiento("INSERTAR", 0, pictureAlumno, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtContraseña.Text, Convert.ToInt32(txtGrado.Text), datePickerFechaNacimiento.Value.Date, Convert.ToInt32(cmbSexo.SelectedValue), Convert.ToInt32(txtIdEncargado.Text), identificador, txtCorreo_electronico.Text);

                            if (MessageBox.Show("¿Desea ver un resumen de los datos ingresado?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                MessageBox.Show(alumnos.Mensaje(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            conexion.cargarAlumno(dgvAlumnos);
                            pictureAlumno.Image = pictureAlumno.InitialImage;
                            txtIdentidad.Clear();
                            txtContraseña.Clear();
                            txtNombres.Clear();
                            txtApellidos.Clear();
                            txtIdEncargado.Clear();
                            txtGrado.Clear();
                            txtCorreo_electronico.Clear();
                            cmbSexo.SelectedIndex = -1;
                            datePickerFechaNacimiento.Value = DateTime.Now;
                            lblAdvertencia.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Este número de identidad ya existe.");
                        }
                    }
                }
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

        string caracteresEspeciales = "%$#@"; // Caracteres que deven de tener la contraseña.
        
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.TextLength < 8)
            {
                lblAdvertencia.ForeColor = Color.Red;
                lblAdvertencia.Text = "Debe tener 8 caracteres o más.";
                contraseñaAceptable = false;
            }
            else
            {
                string contraseña = txtContraseña.Text;
                if (contraseña.Contains("@") != true && contraseña.Contains("%") != true && contraseña.Contains("$") != true && contraseña.Contains("#") != true)
                {
                    lblAdvertencia.ForeColor = Color.Red;
                    lblAdvertencia.Text = "Debe de tener: \"" + caracteresEspeciales + "\".";
                    contraseñaAceptable = false;
                }
                else
                {
                    bool número = false;
                    for (int i = 0; i < contraseña.Length; i++)
                    {
                        if (char.IsDigit(contraseña[i]))
                            número = true;
                    }

                    if (número != true)
                    {
                        lblAdvertencia.ForeColor = Color.Red;
                        lblAdvertencia.Text = "Debe contener un número.";
                        contraseñaAceptable = false;
                    }
                    else
                    {
                        bool mayúscula = false;
                        for (int i = 0; i < contraseña.Length; i++)
                        {
                            if (char.IsUpper(contraseña[i]))
                                mayúscula = true;
                        }

                        if (mayúscula != true)
                        {
                            lblAdvertencia.ForeColor = Color.Red;
                            lblAdvertencia.Text = "Debe tener una letra mayúsc.";
                            contraseñaAceptable = false;
                        }
                        else
                        {
                            lblAdvertencia.ForeColor = Color.Blue;
                            lblAdvertencia.Text = "Contraseña aceptable.";
                            contraseñaAceptable = true;
                        }
                    }
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                MessageBox.Show("No se permiten espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar == 48)
                e.Handled = true;
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
