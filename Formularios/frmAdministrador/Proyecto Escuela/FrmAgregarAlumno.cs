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

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEncargadoAlumno frm_encargado = new FrmEncargadoAlumno();

            frm_encargado.Show();
        }
    }
}
