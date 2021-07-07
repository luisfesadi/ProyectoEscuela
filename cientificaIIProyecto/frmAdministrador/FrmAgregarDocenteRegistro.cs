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
    public partial class FrmAgregarDocenteRegistro : Form
    {
        public FrmAgregarDocenteRegistro()
        {
            InitializeComponent();
        }

        int identificador=0;
        bool contraseñaAceptable = false;

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
        cientificaIIProyecto.frmAdministrador.Personas personas = new cientificaIIProyecto.frmAdministrador.Personas();

        private void FrmAgregarDocente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuela_BDDDataSet26.Profesiones' Puede moverla o quitarla según sea necesario.
            this.profesionesTableAdapter.Fill(this.escuela_BDDDataSet26.Profesiones);
            // TODO: esta línea de código carga datos en la tabla 'escuela_BDDDataSet16.Estado_Civil' Puede moverla o quitarla según sea necesario.
            this.estado_CivilTableAdapter.Fill(this.escuela_BDDDataSet16.Estado_Civil);
            // TODO: esta línea de código carga datos en la tabla 'escuela_BDDDataSet14.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.escuela_BDDDataSet14.Genero);
            // TODO: This line of code loads data into the 'escuela_BDDDataSet30.Profesiones' table. You can move, or remove it, as needed.

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarRegs_Click(object sender, EventArgs e)
        {

            if (txtIdentidad.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtContraseña.Text == "" || cmbSexo.Text == "" || cmbEstadoCivil.Text == "" || txtCorreo_electronico.Text == "" || txtSueldo.Text == "")
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

                        cientificaIIProyecto.frmAdministrador.Registro registro = new cientificaIIProyecto.frmAdministrador.Registro(txtContraseña.Text, datePickerFechaNacimiento.Value.Date, txtCorreo_electronico.Text, cmbEstadoCivil.Text);

                        if (conexion.personaRegistrada(txtIdentidad.Text) == 0)
                        {
                            MessageBox.Show(conexion.Mantenimiento("INSERTAR", 0, pictureRegDoc, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtContraseña.Text, datePickerFechaNacimiento.Value.Date, Convert.ToInt32(cmbSexo.SelectedValue), Convert.ToInt32(cmbEstadoCivil.SelectedValue), txtCorreo_electronico.Text, Convert.ToDouble(txtSueldo.Text), identificador));

                            if (MessageBox.Show("¿Desea ver un resumen de los datos ingresado?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                MessageBox.Show(registro.Mensaje(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            conexion.cargarRegistro(dgvRegistro);
                            txtIdentidad.Clear();
                            pictureRegDoc.Image = pictureRegDoc.InitialImage;
                            txtContraseña.Clear();
                            txtNombres.Clear();
                            txtApellidos.Clear();
                            txtSueldo.Clear();
                            txtCorreo_electronico.Clear();
                            cmbSexo.SelectedIndex = -1;
                            cmbEstadoCivil.SelectedIndex = -1;
                            cmbProfesion.SelectedIndex = -1;
                            datePickerFechaNacimiento.Value = DateTime.Now;
                            lblAdvertencia.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Este numero de identidad ya existe");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            if (txtIdentidad.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtContraseña.Text == "" || cmbSexo.Text == "" || cmbEstadoCivil.Text == "" || cmbProfesion.Text == "" || txtCorreo_electronico.Text == "" || txtSueldo.Text == "")
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
                        cientificaIIProyecto.frmAdministrador.Docentes docentes = new cientificaIIProyecto.frmAdministrador.Docentes(txtContraseña.Text, datePickerFechaNacimiento.Value.Date, txtCorreo_electronico.Text, cmbProfesion.Text, cmbEstadoCivil.Text);

                        //public string Mantenimiento(string accion, int id, string identidad, string nombres, string apellidos, string contraseña, DateTime fecha_nacimiento, int genero, int estado_civil, int profesion, string correo_electronico, double sueldo)
                        if (conexion.personaRegistrada((txtIdentidad.Text)) == 0)
                        {
                            MessageBox.Show(conexion.Mantenimiento("INSERTAR", 0, pictureRegDoc, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtContraseña.Text, datePickerFechaNacimiento.Value.Date, Convert.ToInt32(cmbSexo.SelectedValue), Convert.ToInt32(cmbEstadoCivil.SelectedValue), Convert.ToInt32(cmbProfesion.SelectedValue), txtCorreo_electronico.Text, Convert.ToDouble(txtSueldo.Text), identificador));

                            if (MessageBox.Show("¿Desea ver un resumen de los datos ingresado?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                MessageBox.Show(docentes.Mensaje(), "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            conexion.cargarDocente(dgvDocentes);
                            pictureRegDoc.Image = pictureRegDoc.InitialImage;
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
                            lblAdvertencia.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Este número de identidad ya existe");
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
                lblAdvertencia.Text = "Debe tener 8 caracteres o +.";
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
                            lblAdvertencia.Text = "Debe tener una letra mayús.";
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

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Validar de que los datos ingresados solo sean números.
            {
                e.Handled = true;
            }
        }
    }
}
