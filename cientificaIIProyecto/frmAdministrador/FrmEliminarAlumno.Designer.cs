namespace Registro
{
    partial class FrmEliminarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarAlumno));
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdEncargado = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuela_BDDDataSet39 = new cientificaIIProyecto.Escuela_BDDDataSet39();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.pictureAlumno = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generoTableAdapter = new cientificaIIProyecto.Escuela_BDDDataSet39TableAdapters.GeneroTableAdapter();
            this.txtCorreo_electronico = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.correo_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres_encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos_encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(141, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(53, 19);
            this.txtId.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(96, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Id: ";
            // 
            // txtIdEncargado
            // 
            this.txtIdEncargado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEncargado.Enabled = false;
            this.txtIdEncargado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEncargado.Location = new System.Drawing.Point(171, 423);
            this.txtIdEncargado.Name = "txtIdEncargado";
            this.txtIdEncargado.Size = new System.Drawing.Size(60, 19);
            this.txtIdEncargado.TabIndex = 125;
            this.txtIdEncargado.TextChanged += new System.EventHandler(this.txtIdEncargado_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Enabled = false;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(141, 157);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(197, 19);
            this.txtNombres.TabIndex = 111;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(158, 235);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(180, 19);
            this.txtContraseña.TabIndex = 128;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(45, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 127;
            this.label10.Text = "Contraseña:  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(45, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 124;
            this.label9.Text = "Id encargado: ";
            // 
            // txtGrado
            // 
            this.txtGrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrado.Enabled = false;
            this.txtGrado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(122, 354);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(97, 19);
            this.txtGrado.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 121;
            this.label6.Text = "Grado: ";
            // 
            // datePickerFechaNacimiento
            // 
            this.datePickerFechaNacimiento.Enabled = false;
            this.datePickerFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFechaNacimiento.Location = new System.Drawing.Point(225, 268);
            this.datePickerFechaNacimiento.Name = "datePickerFechaNacimiento";
            this.datePickerFechaNacimiento.Size = new System.Drawing.Size(321, 26);
            this.datePickerFechaNacimiento.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 120;
            this.label8.Text = "Sexo: ";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DataSource = this.generoBindingSource;
            this.cmbSexo.DisplayMember = "Descripcion_genero";
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Enabled = false;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(105, 312);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(114, 25);
            this.cmbSexo.TabIndex = 119;
            this.cmbSexo.ValueMember = "Id_genero";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.escuela_BDDDataSet39;
            // 
            // escuela_BDDDataSet39
            // 
            this.escuela_BDDDataSet39.DataSetName = "Escuela_BDDDataSet39";
            this.escuela_BDDDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(50, 460);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(169, 47);
            this.btnAgregarAlumno.TabIndex = 118;
            this.btnAgregarAlumno.Text = "Eliminar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(343, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 28);
            this.label7.TabIndex = 117;
            this.label7.Text = "ELIMINAR ALUMNO";
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
            this.correo_alumno,
            this.Id_encargado,
            this.Nombres_encargado,
            this.Apellidos_encargado,
            this.Correo_electronico,
            this.Telefono,
            this.Direccion});
            this.dgvAlumnos.Location = new System.Drawing.Point(49, 523);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.Size = new System.Drawing.Size(741, 197);
            this.dgvAlumnos.TabIndex = 116;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // pictureAlumno
            // 
            this.pictureAlumno.Image = ((System.Drawing.Image)(resources.GetObject("pictureAlumno.Image")));
            this.pictureAlumno.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureAlumno.InitialImage")));
            this.pictureAlumno.Location = new System.Drawing.Point(590, 85);
            this.pictureAlumno.Name = "pictureAlumno";
            this.pictureAlumno.Size = new System.Drawing.Size(200, 200);
            this.pictureAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAlumno.TabIndex = 115;
            this.pictureAlumno.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Fecha de nacimiento: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(141, 196);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(197, 19);
            this.txtApellidos.TabIndex = 112;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidad.Enabled = false;
            this.txtIdentidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(141, 120);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(197, 19);
            this.txtIdentidad.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 109;
            this.label3.Text = "Identidad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 108;
            this.label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Nombres: ";
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // txtCorreo_electronico
            // 
            this.txtCorreo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo_electronico.Enabled = false;
            this.txtCorreo_electronico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo_electronico.Location = new System.Drawing.Point(210, 388);
            this.txtCorreo_electronico.MaxLength = 200;
            this.txtCorreo_electronico.Name = "txtCorreo_electronico";
            this.txtCorreo_electronico.Size = new System.Drawing.Size(197, 19);
            this.txtCorreo_electronico.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(46, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 131;
            this.label11.Text = "Correo electrónico: ";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_alumno";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Identidad
            // 
            this.Identidad.DataPropertyName = "Identidad";
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.Name = "Identidad";
            this.Identidad.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.FillWeight = 110F;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 125;
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.DataPropertyName = "Fecha_nacimiento";
            this.Fecha_nacimiento.HeaderText = "Fecha de nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            // 
            // Id_sexo
            // 
            this.Id_sexo.DataPropertyName = "Id_genero";
            this.Id_sexo.HeaderText = "Id Genero";
            this.Id_sexo.Name = "Id_sexo";
            this.Id_sexo.ReadOnly = true;
            this.Id_sexo.Visible = false;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Descripcion_genero";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 80;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            this.Grado.Width = 80;
            // 
            // correo_alumno
            // 
            this.correo_alumno.DataPropertyName = "Correo_electronico_alumno";
            this.correo_alumno.HeaderText = "E-Mail Alumno";
            this.correo_alumno.Name = "correo_alumno";
            this.correo_alumno.ReadOnly = true;
            // 
            // Id_encargado
            // 
            this.Id_encargado.DataPropertyName = "Id_encargado";
            this.Id_encargado.HeaderText = "Id_encargado";
            this.Id_encargado.Name = "Id_encargado";
            this.Id_encargado.ReadOnly = true;
            // 
            // Nombres_encargado
            // 
            this.Nombres_encargado.DataPropertyName = "Nombres_encargado";
            this.Nombres_encargado.HeaderText = "Nombres encargado";
            this.Nombres_encargado.Name = "Nombres_encargado";
            this.Nombres_encargado.ReadOnly = true;
            // 
            // Apellidos_encargado
            // 
            this.Apellidos_encargado.DataPropertyName = "Apellidos_encargado";
            this.Apellidos_encargado.HeaderText = "Apellidos encargado";
            this.Apellidos_encargado.Name = "Apellidos_encargado";
            this.Apellidos_encargado.ReadOnly = true;
            // 
            // Correo_electronico
            // 
            this.Correo_electronico.DataPropertyName = "Correo_electronico";
            this.Correo_electronico.HeaderText = "E-Mail Encargado";
            this.Correo_electronico.Name = "Correo_electronico";
            this.Correo_electronico.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // FrmEliminarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 749);
            this.Controls.Add(this.txtCorreo_electronico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdEncargado);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePickerFechaNacimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.pictureAlumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarAlumno";
            this.Text = "FrmEliminarAlumno";
            this.Load += new System.EventHandler(this.FrmEliminarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdEncargado;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerFechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.PictureBox pictureAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private cientificaIIProyecto.Escuela_BDDDataSet39 escuela_BDDDataSet39;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private cientificaIIProyecto.Escuela_BDDDataSet39TableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.TextBox txtCorreo_electronico;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres_encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos_encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}