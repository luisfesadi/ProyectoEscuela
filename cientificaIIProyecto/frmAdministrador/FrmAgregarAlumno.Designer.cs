namespace Registro
{
    partial class FrmAgregarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarAlumno));
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres_encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos_encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureAlumno = new System.Windows.Forms.PictureBox();
            this.datePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.btnAsignarEncargado = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdEncargado = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.txtCorreo_electronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.escuela_BDDDataSet46 = new cientificaIIProyecto.Escuela_BDDDataSet46();
            this.generoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter3 = new cientificaIIProyecto.Escuela_BDDDataSet46TableAdapters.GeneroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Sexo: ";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DataSource = this.generoBindingSource3;
            this.cmbSexo.DisplayMember = "Descripcion_genero";
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(139, 336);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(151, 29);
            this.cmbSexo.TabIndex = 57;
            this.cmbSexo.ValueMember = "Id_genero";
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(344, 523);
            this.btnAgregarAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(227, 55);
            this.btnAgregarAlumno.TabIndex = 56;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(423, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 37);
            this.label7.TabIndex = 55;
            this.label7.Text = "AGREGAR ALUMNO";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Identidad,
            this.Nombres,
            this.Apellidos,
            this.Contraseña,
            this.Foto,
            this.Fecha_nacimiento,
            this.Id_sexo,
            this.Sexo,
            this.Grado,
            this.Correo_alumno,
            this.Id_encargado,
            this.Nombres_encargado,
            this.Apellidos_encargado,
            this.Correo_electronico,
            this.Telefono,
            this.Direccion});
            this.dgvAlumnos.Location = new System.Drawing.Point(61, 599);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.Size = new System.Drawing.Size(985, 282);
            this.dgvAlumnos.TabIndex = 54;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_alumno";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Identidad
            // 
            this.Identidad.DataPropertyName = "Identidad";
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.MinimumWidth = 6;
            this.Identidad.Name = "Identidad";
            this.Identidad.ReadOnly = true;
            this.Identidad.Width = 125;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.FillWeight = 110F;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 125;
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MinimumWidth = 6;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Width = 125;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 125;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.DataPropertyName = "Fecha_nacimiento";
            this.Fecha_nacimiento.HeaderText = "Fecha de nacimiento";
            this.Fecha_nacimiento.MinimumWidth = 6;
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            this.Fecha_nacimiento.Width = 125;
            // 
            // Id_sexo
            // 
            this.Id_sexo.DataPropertyName = "Id_genero";
            this.Id_sexo.HeaderText = "Id Genero";
            this.Id_sexo.MinimumWidth = 6;
            this.Id_sexo.Name = "Id_sexo";
            this.Id_sexo.ReadOnly = true;
            this.Id_sexo.Visible = false;
            this.Id_sexo.Width = 125;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Descripcion_genero";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 80;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.MinimumWidth = 6;
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            this.Grado.Width = 80;
            // 
            // Correo_alumno
            // 
            this.Correo_alumno.DataPropertyName = "Correo_electronico_alumno";
            this.Correo_alumno.HeaderText = "E-Mail Alumno";
            this.Correo_alumno.MinimumWidth = 6;
            this.Correo_alumno.Name = "Correo_alumno";
            this.Correo_alumno.ReadOnly = true;
            this.Correo_alumno.Width = 125;
            // 
            // Id_encargado
            // 
            this.Id_encargado.DataPropertyName = "Id_encargado";
            this.Id_encargado.HeaderText = "Id_encargado";
            this.Id_encargado.MinimumWidth = 6;
            this.Id_encargado.Name = "Id_encargado";
            this.Id_encargado.ReadOnly = true;
            this.Id_encargado.Visible = false;
            this.Id_encargado.Width = 125;
            // 
            // Nombres_encargado
            // 
            this.Nombres_encargado.DataPropertyName = "Nombres_encargado";
            this.Nombres_encargado.HeaderText = "Nombres encargado";
            this.Nombres_encargado.MinimumWidth = 6;
            this.Nombres_encargado.Name = "Nombres_encargado";
            this.Nombres_encargado.ReadOnly = true;
            this.Nombres_encargado.Width = 125;
            // 
            // Apellidos_encargado
            // 
            this.Apellidos_encargado.DataPropertyName = "Apellidos_encargado";
            this.Apellidos_encargado.HeaderText = "Apellidos encargado";
            this.Apellidos_encargado.MinimumWidth = 6;
            this.Apellidos_encargado.Name = "Apellidos_encargado";
            this.Apellidos_encargado.ReadOnly = true;
            this.Apellidos_encargado.Width = 125;
            // 
            // Correo_electronico
            // 
            this.Correo_electronico.DataPropertyName = "Correo_electronico";
            this.Correo_electronico.HeaderText = "E-Mail Encargado";
            this.Correo_electronico.MinimumWidth = 6;
            this.Correo_electronico.Name = "Correo_electronico";
            this.Correo_electronico.ReadOnly = true;
            this.Correo_electronico.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // pictureAlumno
            // 
            this.pictureAlumno.Image = ((System.Drawing.Image)(resources.GetObject("pictureAlumno.Image")));
            this.pictureAlumno.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureAlumno.InitialImage")));
            this.pictureAlumno.Location = new System.Drawing.Point(780, 100);
            this.pictureAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureAlumno.Name = "pictureAlumno";
            this.pictureAlumno.Size = new System.Drawing.Size(267, 246);
            this.pictureAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAlumno.TabIndex = 52;
            this.pictureAlumno.TabStop = false;
            // 
            // datePickerFechaNacimiento
            // 
            this.datePickerFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFechaNacimiento.Location = new System.Drawing.Point(299, 282);
            this.datePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePickerFechaNacimiento.Name = "datePickerFechaNacimiento";
            this.datePickerFechaNacimiento.Size = new System.Drawing.Size(427, 30);
            this.datePickerFechaNacimiento.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fecha de nacimiento: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(187, 193);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.MaxLength = 150;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(263, 23);
            this.txtApellidos.TabIndex = 45;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(187, 145);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.MaxLength = 150;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(263, 23);
            this.txtNombres.TabIndex = 44;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(187, 100);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdentidad.MaxLength = 13;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(263, 23);
            this.txtIdentidad.TabIndex = 43;
            this.txtIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Identidad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombres: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 59;
            this.label6.Text = "Grado: ";
            // 
            // txtGrado
            // 
            this.txtGrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(161, 388);
            this.txtGrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrado.MaxLength = 1;
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(129, 23);
            this.txtGrado.TabIndex = 60;
            this.txtGrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrado_KeyPress);
            // 
            // btnAsignarEncargado
            // 
            this.btnAsignarEncargado.FlatAppearance.BorderSize = 0;
            this.btnAsignarEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarEncargado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarEncargado.Location = new System.Drawing.Point(65, 523);
            this.btnAsignarEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsignarEncargado.Name = "btnAsignarEncargado";
            this.btnAsignarEncargado.Size = new System.Drawing.Size(227, 55);
            this.btnAsignarEncargado.TabIndex = 61;
            this.btnAsignarEncargado.Text = "Asignar Encargado";
            this.btnAsignarEncargado.UseVisualStyleBackColor = true;
            this.btnAsignarEncargado.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 474);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 22);
            this.label9.TabIndex = 62;
            this.label9.Text = "Id encargado: ";
            // 
            // txtIdEncargado
            // 
            this.txtIdEncargado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEncargado.Enabled = false;
            this.txtIdEncargado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEncargado.Location = new System.Drawing.Point(228, 475);
            this.txtIdEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdEncargado.MaxLength = 5;
            this.txtIdEncargado.Name = "txtIdEncargado";
            this.txtIdEncargado.Size = new System.Drawing.Size(80, 23);
            this.txtIdEncargado.TabIndex = 63;
            // 
            // btnCargar
            // 
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(816, 363);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(193, 55);
            this.btnCargar.TabIndex = 64;
            this.btnCargar.Text = "Cargar Imagen";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(209, 238);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña.MaxLength = 150;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(240, 23);
            this.txtContraseña.TabIndex = 66;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(59, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 22);
            this.label10.TabIndex = 65;
            this.label10.Text = "Contraseña:  ";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvertencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.White;
            this.lblAdvertencia.Location = new System.Drawing.Point(457, 236);
            this.lblAdvertencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(0, 22);
            this.lblAdvertencia.TabIndex = 67;
            // 
            // txtCorreo_electronico
            // 
            this.txtCorreo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo_electronico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo_electronico.Location = new System.Drawing.Point(279, 430);
            this.txtCorreo_electronico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo_electronico.MaxLength = 200;
            this.txtCorreo_electronico.Name = "txtCorreo_electronico";
            this.txtCorreo_electronico.Size = new System.Drawing.Size(263, 23);
            this.txtCorreo_electronico.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 22);
            this.label5.TabIndex = 68;
            this.label5.Text = "Correo electrónico: ";
            // 
            // escuela_BDDDataSet46
            // 
            this.escuela_BDDDataSet46.DataSetName = "Escuela_BDDDataSet46";
            this.escuela_BDDDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource3
            // 
            this.generoBindingSource3.DataMember = "Genero";
            this.generoBindingSource3.DataSource = this.escuela_BDDDataSet46;
            // 
            // generoTableAdapter3
            // 
            this.generoTableAdapter3.ClearBeforeFill = true;
            // 
            // FrmAgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1112, 922);
            this.Controls.Add(this.txtCorreo_electronico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtIdEncargado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAsignarEncargado);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.pictureAlumno);
            this.Controls.Add(this.datePickerFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAgregarAlumno";
            this.Text = "FrmAgregarAlumno";
            this.Load += new System.EventHandler(this.FrmAgregarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.PictureBox pictureAlumno;
        private System.Windows.Forms.DateTimePicker datePickerFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Button btnAsignarEncargado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdEncargado;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.TextBox txtCorreo_electronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres_encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos_encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private cientificaIIProyecto.Escuela_BDDDataSet46 escuela_BDDDataSet46;
        private System.Windows.Forms.BindingSource generoBindingSource3;
        private cientificaIIProyecto.Escuela_BDDDataSet46TableAdapters.GeneroTableAdapter generoTableAdapter3;
    }
}