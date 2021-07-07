using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escuela
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        double prom1, prom2, prom3, prom4, prom5, prom6, prom7;
        int c_aprobados = 0, c_reprobados = 0;

        cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
        frmAlumno alumno = new frmAlumno();

        private void frmNotas_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            cientificaIIProyecto.frmAdministrador.Conexion conexion = new cientificaIIProyecto.frmAdministrador.Conexion();
            conexion.cargarNotasAlumno(dgv, Convert.ToInt32(alumno.Id));
            prom1 = conexion.Promedio(alumno.Id, 1);
            prom2 = conexion.Promedio(alumno.Id, 2);
            prom3 = conexion.Promedio(alumno.Id, 3);
            prom4 = conexion.Promedio(alumno.Id, 4);
            prom5 = conexion.Promedio(alumno.Id, 5);
            prom6 = conexion.Promedio(alumno.Id, 6);
            prom7 = conexion.Promedio(alumno.Id, 7);

            if (prom1 >= 70)
                c_aprobados++;
            else if (prom1 < 70 && prom1 != 0)
                c_reprobados++;

            if (prom2 >= 70)
                c_aprobados++;
            else if (prom2 < 70 && prom2 != 0)
                c_reprobados++;

            if (prom3 >= 70)
                c_aprobados++;
            else if (prom3 < 70 && prom3 != 0)
                c_reprobados++;

            if (prom4 >= 70)
                c_aprobados++;
            else if (prom4 < 70 && prom4 != 0)
                c_reprobados++;

            if (prom5 >= 70)
                c_aprobados++;
            else if (prom5 < 70 && prom5 != 0)
                c_reprobados++;

            if (prom6 >= 70)
                c_aprobados++;
            else if(prom6 < 70 && prom6 != 0)
                c_reprobados++;

            if (prom7 >= 70)
                c_aprobados++;
            else if (prom7 < 70 && prom7 != 0)
                c_reprobados++;

            txtAprobados.Text = Convert.ToString(c_aprobados);
            txtReprobados.Text = Convert.ToString(c_reprobados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void frmNotas_MouseMove(object sender, MouseEventArgs e)
        {
            dgv.Rows[0].Cells[6].Value = prom1;
            dgv.Rows[1].Cells[6].Value = prom2;
            dgv.Rows[2].Cells[6].Value = prom3;
            dgv.Rows[3].Cells[6].Value = prom4;
            dgv.Rows[4].Cells[6].Value = prom5;
            dgv.Rows[5].Cells[6].Value = prom6;
            dgv.Rows[6].Cells[6].Value = prom7;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
