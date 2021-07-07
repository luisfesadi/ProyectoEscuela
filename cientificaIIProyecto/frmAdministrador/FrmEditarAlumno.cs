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
    public partial class FrmEditarAlumno : Form
    {
        public FrmEditarAlumno()
        {
            InitializeComponent();
        }

        int identificador = 0;
        bool contraseñaAceptable = false;
        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
        cientificaIIProyecto.frmAdministrador.Personas personas = new cientificaIIProyecto.frmAdministrador.Personas();

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEncargadoDocente Encargado_alumno = new FrmEncargadoDocente();
            Encargado_alumno.Show();
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

        private void FrmEditarAlumno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escuela_BDDDataSet32.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter2.Fill(this.escuela_BDDDataSet32.Genero);

            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();

            conexion.cargarAlumno(dgvAlumnos);
            dgvAlumnos.ClearSelection();
            cmbSexo.SelectedIndex = -1;
        }

        private void btnAsignarEncargado_Click(object sender, EventArgs e)
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
                MessageBox.Show("No se guardaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdEncargado.Clear();
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            
            if (txtNombres.Text == "" || txtApellidos.Text == "" || txtContraseña.Text == "" || cmbSexo.Text == "" || txtGrado.Text == "" || txtIdEncargado.Text == "")
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
                        personas.Genero = cmbSexo.Text;
                        personas.Apellidos = txtApellidos.Text;

                        cientificaIIProyecto.frmAdministrador.Alumnos alumnos = new cientificaIIProyecto.frmAdministrador.Alumnos(txtContraseña.Text, datePickerFechaNacimiento.Value.Date, int.Parse(txtGrado.Text));

                        conexion.Mantenimiento("ACTUALIZAR", Convert.ToInt32(txtId.Text), pictureAlumno, txtIdentidad.Text, txtNombres.Text, txtApellidos.Text, txtContraseña.Text, Convert.ToInt32(txtGrado.Text), datePickerFechaNacimiento.Value.Date, Convert.ToInt32(cmbSexo.SelectedValue), Convert.ToInt32(txtIdEncargado.Text), identificador, txtCorreo_electronico.Text);

                        if (MessageBox.Show("¿Desea ver un resumen de los datos modificados?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                        lblAdvertencia.Text = "";
                    }
                }
            }
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
                    identificador = 1;
                }
                else
                {
                    pictureAlumno.Image = pictureAlumno.InitialImage;
                    identificador = 0;
                }

                datePickerFechaNacimiento.Value = Convert.ToDateTime(fila.Cells[6].Value.ToString());
                cmbSexo.SelectedValue = Convert.ToInt32(fila.Cells[7].Value);
                txtGrado.Text = Convert.ToString(fila.Cells[9].Value);
                txtCorreo_electronico.Text = Convert.ToString(fila.Cells[10].Value);
                txtIdEncargado.Text = Convert.ToString(fila.Cells[11].Value);
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

        private void pictureAlumno_Click(object sender, EventArgs e)
        {

        }
    }
}
