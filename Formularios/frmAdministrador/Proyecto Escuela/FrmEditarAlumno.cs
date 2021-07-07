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

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEncargadoAlumno Encargado_alumno = new FrmEncargadoAlumno();
            Encargado_alumno.Show();
        }
    }
}
