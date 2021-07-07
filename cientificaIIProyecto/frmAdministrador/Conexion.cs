using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cientificaIIProyecto.frmAdministrador
{
    public class Conexion
    {

        SqlConnection cn;
        SqlCommand command;
        SqlDataReader dataReader;
        DataTable dataTable;
        SqlDataAdapter dataAdapter;
        DataRow dataRow;
        DataSet data;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=DESKTOP-K7UHKA1;Initial Catalog=Escuela_BDD;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        //VALIDACION 2 NUMEROS DE IDENTIDAD NO SEAN IGUALES

        public int personaRegistrada(string identidad)
        {
            int contador = 0;

            try
            {
                command = new SqlCommand("Select * from Usuarios where Identidad = @identidad", cn);
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    contador++;
                }

                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //ASIGNACION DE CLASES

        public void Mantenimiento(int codigo_docente, string descripcion)
        {
            String query = "exec[dbo].[Mantenimiento_Asignacion]@id_docente ,@descripcion";

            command = new SqlCommand(query, cn);

            command.Parameters.Add("@id_docente", SqlDbType.Int).Value = codigo_docente;
            command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = descripcion;

            command.ExecuteNonQuery();
        }

        //ASIGNACION DE NOTAS

        public void Notas (int id_alumno, int id_clase, int nota, int parcial)
        {
            String query = "exec[dbo].[Asignacion_Notas]@id_alumno, @id_clase, @nota, @parcial";

            command = new SqlCommand(query, cn);

            command.Parameters.Add("@id_alumno", SqlDbType.Int).Value = id_alumno;
            command.Parameters.Add("@id_clase", SqlDbType.Int).Value = id_clase;
            command.Parameters.Add("@nota", SqlDbType.Int).Value = nota;
            command.Parameters.Add("@parcial", SqlDbType.Int).Value = parcial;

            command.ExecuteNonQuery();
        }

        //MANTENIMIENTO REGISTRO

        public string Mantenimiento(string accion, int id, PictureBox imagen, string identidad, string nombres, string apellidos, string contraseña, DateTime fecha_nacimiento, int genero, int estado_civil, string correo_electronico, double sueldo, int identificador)
        {
            string salida = "La operación se ejecutó correctamente.";

            try
            {

                String query = "exec[dbo].[Mantenimiento_Registro]@accion ,@id_administrador, @foto, @identidad, @contraseña, @fecha_nacimiento, @nombres, @apellidos, @correo_electronico, @sueldo, @id_estado, @id_genero";

                command = new SqlCommand(query, cn);

                if (identificador == 1)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    command.Parameters.Add("@foto", SqlDbType.Image).Value = ms.GetBuffer();
                }

                if (identificador == 0)
                {
                    command.Parameters.Add("@foto", SqlDbType.Image).Value = DBNull.Value;
                }

                command.Parameters.Add("@accion", SqlDbType.NVarChar).Value = accion;
                command.Parameters.Add("@id_administrador", SqlDbType.Int).Value = id;
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                command.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = contraseña;
                command.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = fecha_nacimiento;
                command.Parameters.Add("@nombres", SqlDbType.NVarChar).Value = nombres;
                command.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = apellidos;
                command.Parameters.Add("@correo_electronico", SqlDbType.NVarChar).Value = correo_electronico;
                command.Parameters.Add("@sueldo", SqlDbType.Money).Value = sueldo;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = estado_civil;
                command.Parameters.Add("@id_genero", SqlDbType.Int).Value = genero;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error ejecutando la operación: " + ex.ToString();
            }

            return salida;
        }

        //MANTENIMIENTO DOCENTES

        public string Mantenimiento(string accion, int id, PictureBox imagen, string identidad, string nombres, string apellidos, string contraseña, DateTime fecha_nacimiento, int genero, int estado_civil, int profesion, string correo_electronico, double sueldo, int identificador)
        {
            string salida = "La operación se ejecutó correctamente.";

            try
            {
                String query = "exec[dbo].[Matenimiento_Docentes]@accion ,@id_docente, @foto, @identidad, @contraseña, @fecha_nacimiento, @nombres, @apellidos, @correo_electronico, @sueldo, @id_profesion, @id_genero, @id_estado";

                command = new SqlCommand(query, cn);

                if (identificador == 1)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    command.Parameters.Add("@foto", SqlDbType.Image).Value = ms.GetBuffer();
                }

                if (identificador == 0)
                {
                    command.Parameters.Add("@foto", SqlDbType.Image).Value = DBNull.Value;
                }

                command.Parameters.Add("@accion", SqlDbType.NVarChar).Value = accion;
                command.Parameters.Add("@id_docente", SqlDbType.Int).Value = id;
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                command.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = contraseña;
                command.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = fecha_nacimiento;
                command.Parameters.Add("@nombres", SqlDbType.NVarChar).Value = nombres;
                command.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = apellidos;
                command.Parameters.Add("@correo_electronico", SqlDbType.NVarChar).Value = correo_electronico;
                command.Parameters.Add("@sueldo", SqlDbType.Money).Value = sueldo;
                command.Parameters.Add("@id_profesion", SqlDbType.Int).Value = profesion;
                command.Parameters.Add("@id_genero", SqlDbType.Int).Value = genero;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = estado_civil;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error ejecutando la operación: " + ex.ToString();
            }

            return salida;
        }

        //MANTENIMIENTO ALUMNOS

        public void Mantenimiento(string accion, int id, PictureBox imagen, string identidad, string nombres, string apellidos, string contraseña, int grado, DateTime fecha_nacimiento, int genero, int encargado, int identificador, string correo)
        {

            try
            {
                String query = "exec[dbo].[Mantenimiento_Alumnos]@accion ,@id_alumno, @foto, @identidad, @contraseña, @fecha_nacimiento, @nombres, @apellidos, @grado, @id_genero, @id_encargado, @correo_electronico";

                command = new SqlCommand(query, cn);

                if (identificador == 1)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    command.Parameters.Add("@foto", SqlDbType.Image).Value = ms.GetBuffer();
                }

                if (identificador == 0)
                {
                    command.Parameters.Add("@foto", SqlDbType.Image).Value = DBNull.Value;
                }

                if (encargado == 0)
                {
                    command.Parameters.Add("@id_encargado", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    command.Parameters.Add("@id_encargado", SqlDbType.Int).Value = encargado;
                }

                command.Parameters.Add("@accion", SqlDbType.NVarChar).Value = accion;
                command.Parameters.Add("@id_alumno", SqlDbType.Int).Value = id;
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                command.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = contraseña;
                command.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = fecha_nacimiento;
                command.Parameters.Add("@nombres", SqlDbType.NVarChar).Value = nombres;
                command.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = apellidos;
                command.Parameters.Add("@grado", SqlDbType.Int).Value = grado;
                command.Parameters.Add("@id_genero", SqlDbType.Int).Value = genero;
                command.Parameters.Add("@correo_electronico", SqlDbType.NVarChar).Value = correo;

                command.ExecuteNonQuery();

                MessageBox.Show("La operación se ejecutó correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ejecutando la operación: " + ex.ToString());
            }
        }

        //Mantenimiento Encargados

        public void Mantenimiento(string accion, int id, PictureBox imagen, string identidad, string nombres, string apellidos, string correo_electronico, string direccion, int genero, string telefono, int identificador)
        {

            try
            {
                String query = "exec[dbo].[Mantenimiento_Encargados]@accion ,@id_encargado, @foto, @identidad, @nombres, @apellidos, @correo_electronico, @direccion, @id_genero, @telefono";

                command = new SqlCommand(query, cn);

                if (identificador == 1)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    command.Parameters.Add("@foto", SqlDbType.Image).Value = ms.GetBuffer();
                }

                if (identificador == 0)
                {
                    command.Parameters.Add("@foto", SqlDbType.Image).Value = DBNull.Value;
                }

                command.Parameters.Add("@accion", SqlDbType.NVarChar).Value = accion;
                command.Parameters.Add("@id_encargado", SqlDbType.Int).Value = id;
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                command.Parameters.Add("@nombres", SqlDbType.NVarChar).Value = nombres;
                command.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = apellidos;
                command.Parameters.Add("@correo_electronico", SqlDbType.NVarChar).Value = correo_electronico;
                command.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
                command.Parameters.Add("@id_genero", SqlDbType.Int).Value = genero;
                command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = telefono;

                command.ExecuteNonQuery();

                MessageBox.Show("La operación se ejecutó correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ejecutando la operación: " + ex.ToString());
            }
        }

        //Calculo Promedio 

        public double Promedio(int id_alum, int id_clas)
        {
            double salida = 0; 

            try
            {
                String query = "exec[dbo].[Calculo_Promedio] @id_alumno, @id_clase";

                command = new SqlCommand(query, cn);
                command.Parameters.Add("@id_alumno", SqlDbType.Int).Value = id_alum;
                command.Parameters.Add("@id_clase", SqlDbType.Int).Value = id_clas;

                if (command.ExecuteScalar()!=DBNull.Value)
                {
                    salida = Convert.ToDouble(command.ExecuteScalar());
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error ejecutando la operación: " + ex.ToString());
            }

            return salida;
        }

        //CARGAR REGISTRO

        public void cargarRegistro(DataGridView dgv)
        {
            try
            {
                String query = "select * from Administradores a inner join [Estado Civil] b on a.Id_estado = b.Id_estado inner join Genero c on a.Id_genero = c.Id_genero";
                dataAdapter = new SqlDataAdapter(query, cn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //CARGAR ENCARGADO

        public void cargarEncargado(DataGridView dgv)
        {
            try
            {
                String query = "select * from Encargados a inner join Genero b on a.Id_genero_encargado = b.Id_genero ";
                dataAdapter = new SqlDataAdapter(query, cn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //CARGAR ALUMNO

        public void cargarAlumno(DataGridView dgv)
        {
            try
            {
                String query = "select * from Alumnos a inner join Genero b on a.Id_genero = b.Id_genero left join Encargados c on a.Id_encargado = c.Id_encargado ";
                dataAdapter = new SqlDataAdapter(query, cn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //CARGAR DOCENTE

        public void cargarDocente(DataGridView dgv)
        {
            try
            {
                String query = "select * from Docentes a inner join Profesiones b on a.Id_Profesion = b.Id_profesion inner join[Estado Civil] c on a.Id_estado = c.Id_estado inner join Genero d on a.Id_genero = d.Id_genero";
                dataAdapter = new SqlDataAdapter(query, cn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //CARGAR NOTAS DEL ALUMNO
        public void cargarNotasAlumno(DataGridView dgv, int id)
        {
            try
            {
                command = new SqlCommand("select Descripcion, Nota1, Nota2, Nota3, Nota4, Recuperacion from Alumnos a inner join Alumnos_Clases b on a.Id_alumno = b.Id_alumno inner join Clases c on b.Id_clase = c.Id_clase where a.Id_alumno = @id_alumno", cn);
                command.Parameters.Add("@id_alumno", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
                dgv.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //CARGAR ASIGNACION 

        public void cargarAsignacion(DataGridView dgv)
        {
            try
            {
                String query = "select * from Clases a left join Docentes b on a.Id_docente = b.Id_docente";
                dataAdapter = new SqlDataAdapter(query, cn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        //CARGAR NOTAS
        public void cargarNotas(DataGridView dgv, string clase)
        {
            command = new SqlCommand("Select * from Alumnos a inner join Alumnos_Clases b on a.Id_alumno = b.Id_alumno inner join Clases c on b.Id_clase = c.Id_clase where c.Descripcion = @clase", cn);
            command.Parameters.Add("@clase", SqlDbType.NVarChar).Value = clase;
            command.ExecuteNonQuery();
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }

        //Llenar Combobox con Query

        public void LlenarCombobox(ComboBox cmb, int id)
        {
            command = new SqlCommand("select Descripcion from Docentes a inner join Clases b on a.Id_docente = b.Id_docente where a.Id_docente = @id_docente", cn);
            command.Parameters.Add("@id_docente", SqlDbType.Int).Value = id;
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                cmb.Items.Add(dataReader["Descripcion"].ToString());
            }

            dataReader.Close();
        }

        //CONSULTAR GENERAL
        public void Busqueda(String query, string text, string filtro, DataGridView dgv)
        {
            try
            {
                command = new SqlCommand(query + filtro + " like ('%" + text + "%')", cn);
                command.ExecuteNonQuery();
                dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //CONSULTAR NOTAS
        public void Busqueda(string clase, int grado, DataGridView dgv)
        {
            try
            {
                command = new SqlCommand("Select * from Alumnos a inner join Alumnos_Clases b on a.Id_alumno = b.Id_alumno inner join Clases c on b.Id_clase = c.Id_clase where c.Descripcion = @clase and a.Grado = @grado", cn);
                command.Parameters.Add("@clase", SqlDbType.NVarChar).Value = clase;
                command.Parameters.Add("@grado", SqlDbType.Int).Value = grado;
                command.ExecuteNonQuery();
                dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //INICIO DE SESIÓN

        public int ingresar(string usuario, string contra)
        {
            int salida = 0;

            try
            {
                String query = "SELECT Id_rol FROM Usuarios WHERE Identidad = @usuario and Contraseña = @contra";

                command = new SqlCommand(query, cn);
                command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                command.Parameters.Add("@contra", SqlDbType.NVarChar).Value = contra;
                salida = Convert.ToInt32(command.ExecuteScalar());
                //MessageBox.Show(Convert.ToString(salida));
            }
            catch
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos.", "Advertencia", MessageBoxButtons.OK);
            }

            return salida;
        }

        //JALAR CONTRASEÑA

        public string contra(string identidad, string correo)
        {
            string resp = "";

            try
            {
                String query = "[dbo].[Recuperacion_contraseña]";

                command = new SqlCommand(query, cn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                command.Parameters.Add("@correo_electronico", SqlDbType.NVarChar).Value = correo;

                SqlDataReader rdr = command.ExecuteReader(CommandBehavior.SingleResult);
                rdr.Read();
                resp = rdr.GetString(rdr.GetOrdinal("Contraseña"));
            }
            catch
            {
                MessageBox.Show("El correo y/o identidad no se encuentra dentro del sistema.", "Advertencia", MessageBoxButtons.OK);
            }

            return resp;
        }

        //JALAR CORREO

        public string Correo (string identidad)
        {
            string resp = "";

            try
            {
               
                string query = "[dbo].[Recuperacion_Correo]@identidad";
                command = new SqlCommand(query, cn);
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                dataReader = command.ExecuteReader(CommandBehavior.SingleResult);

                if (dataReader != null)
                {
                    while (dataReader.Read())
                    {
                        resp = dataReader.GetString(0);
                    } 
                }

                dataReader.Close();
                dataReader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.ToString(), "Error!", MessageBoxButtons.OK);
            }
              
            return resp;

        }

        //Jalar Datos al Iniciar Sesion

        public void Datos(string identidad, int identificador)
        {
            frmLogin login = new frmLogin();


            if (identificador == 1)
            {
                String query = "Select Id_administrador, Nombres, Apellidos, Foto from Administradores where Identidad = @identidad";
                command = new SqlCommand(query, cn);
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        login.Id = reader.GetInt32(0);
                        login.Nombre = reader.GetString(1);
                        login.Apellido = reader.GetString(2);

                        if (reader.GetValue(3) != DBNull.Value)
                        {
                            byte[] datos = new byte[0];
                            datos = (byte[])reader.GetValue(3);
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                            login.Imagen = System.Drawing.Bitmap.FromStream(ms);
                        }
                    }
                }
            }

            if (identificador == 2)
            {
                String query = "select Id_docente, Nombres, Apellidos, Foto from Docentes where Identidad = @identidad";
                command = new SqlCommand(query, cn);
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        login.Id = reader.GetInt32(0);
                        login.Nombre = reader.GetString(1);
                        login.Apellido = reader.GetString(2);

                        if (reader.GetValue(3) != DBNull.Value)
                        {
                            byte[] datos = new byte[0];
                            datos = (byte[])reader.GetValue(3);
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                            login.Imagen = System.Drawing.Bitmap.FromStream(ms);
                        }
                    }
                }
            }

            if (identificador == 3)
            {
                String query = "Select Id_alumno, Nombres, Apellidos, Foto from Alumnos where Identidad = @identidad";
                command = new SqlCommand(query, cn);
                command.Parameters.Add("@identidad", SqlDbType.NVarChar).Value = identidad;
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        login.Id = reader.GetInt32(0);
                        login.Nombre = reader.GetString(1);
                        login.Apellido = reader.GetString(2);

                        if (reader.GetValue(3) != DBNull.Value)
                        {
                            byte[] datos = new byte[0];
                            datos = (byte[])reader.GetValue(3);
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                            login.Imagen = System.Drawing.Bitmap.FromStream(ms);
                        }
                    }
                }
            }
        }
    }
}


