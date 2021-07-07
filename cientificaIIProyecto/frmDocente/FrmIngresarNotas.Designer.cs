namespace FrmDocente
{
    partial class FrmIngresarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresarNotas));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPrimerParcial = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.escuela_BDDDataSet44 = new cientificaIIProyecto.Escuela_BDDDataSet44();
            this.escuelaBDDDataSet44BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuelaBDDDataSet44BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.escuela_BDDDataSet45 = new cientificaIIProyecto.Escuela_BDDDataSet45();
            this.docentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docentesTableAdapter = new cientificaIIProyecto.Escuela_BDDDataSet45TableAdapters.DocentesTableAdapter();
            this.btnIsertarNota1 = new System.Windows.Forms.Button();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdClase = new System.Windows.Forms.TextBox();
            this.dgvSegundoParcial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIsertarNota2 = new System.Windows.Forms.Button();
            this.btnIsertarNota3 = new System.Windows.Forms.Button();
            this.dgvTercerParcial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIsertarNota4 = new System.Windows.Forms.Button();
            this.dgvCuartoParcial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIsertarRecuperacion = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecuperacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaBDDDataSet44BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaBDDDataSet44BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundoParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTercerParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuartoParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecuperacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Image = ((System.Drawing.Image)(resources.GetObject("lblTitulo.Image")));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(223, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(432, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ingreso de Notas 1er Parcial";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // cmbClase
            // 
            this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClase.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(209, 99);
            this.cmbClase.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(150, 27);
            this.cmbClase.TabIndex = 17;
            this.cmbClase.SelectedIndexChanged += new System.EventHandler(this.cmbClase_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Clase:";
            // 
            // dgvPrimerParcial
            // 
            this.dgvPrimerParcial.AllowUserToAddRows = false;
            this.dgvPrimerParcial.AllowUserToDeleteRows = false;
            this.dgvPrimerParcial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrimerParcial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrimerParcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimerParcial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdAlumno,
            this.Id_clase,
            this.Nombre,
            this.Apellido_alumno,
            this.Grado,
            this.Nota1});
            this.dgvPrimerParcial.Location = new System.Drawing.Point(115, 299);
            this.dgvPrimerParcial.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPrimerParcial.Name = "dgvPrimerParcial";
            this.dgvPrimerParcial.ReadOnly = true;
            this.dgvPrimerParcial.RowHeadersWidth = 51;
            this.dgvPrimerParcial.RowTemplate.Height = 24;
            this.dgvPrimerParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrimerParcial.Size = new System.Drawing.Size(556, 416);
            this.dgvPrimerParcial.TabIndex = 18;
            this.dgvPrimerParcial.Visible = false;
            this.dgvPrimerParcial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrimerParcial_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_alumno";
            this.Id.HeaderText = "Id_alumno";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // IdAlumno
            // 
            this.IdAlumno.DataPropertyName = "Identidad";
            this.IdAlumno.HeaderText = "Identidad Alumno";
            this.IdAlumno.MinimumWidth = 6;
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.ReadOnly = true;
            // 
            // Id_clase
            // 
            this.Id_clase.DataPropertyName = "Id_clase";
            this.Id_clase.HeaderText = "Id_clase";
            this.Id_clase.Name = "Id_clase";
            this.Id_clase.ReadOnly = true;
            this.Id_clase.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombres";
            this.Nombre.HeaderText = "Nombre Alumno";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido_alumno
            // 
            this.Apellido_alumno.DataPropertyName = "Apellidos";
            this.Apellido_alumno.HeaderText = "Apellido del Alumno";
            this.Apellido_alumno.Name = "Apellido_alumno";
            this.Apellido_alumno.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // Nota1
            // 
            this.Nota1.DataPropertyName = "Nota1";
            this.Nota1.HeaderText = "Nota 1";
            this.Nota1.MinimumWidth = 6;
            this.Nota1.Name = "Nota1";
            this.Nota1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Grado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGrado
            // 
            this.txtGrado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(209, 147);
            this.txtGrado.MaxLength = 1;
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(73, 26);
            this.txtGrado.TabIndex = 21;
            this.txtGrado.TextChanged += new System.EventHandler(this.txtGrado_TextChanged);
            this.txtGrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrado_KeyPress);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.White;
            this.lblNota.Location = new System.Drawing.Point(141, 197);
            this.lblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(50, 19);
            this.lblNota.TabIndex = 22;
            this.lblNota.Text = "Nota:";
            this.lblNota.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(209, 194);
            this.txtNota.MaxLength = 3;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(73, 26);
            this.txtNota.TabIndex = 23;
            this.txtNota.TextChanged += new System.EventHandler(this.FrmIngresarNotas_Load);
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            this.txtNota.MouseLeave += new System.EventHandler(this.txtNota1_MouseLeave);
            // 
            // escuela_BDDDataSet44
            // 
            this.escuela_BDDDataSet44.DataSetName = "Escuela_BDDDataSet44";
            this.escuela_BDDDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // escuelaBDDDataSet44BindingSource
            // 
            this.escuelaBDDDataSet44BindingSource.DataSource = this.escuela_BDDDataSet44;
            this.escuelaBDDDataSet44BindingSource.Position = 0;
            // 
            // escuelaBDDDataSet44BindingSource1
            // 
            this.escuelaBDDDataSet44BindingSource1.DataSource = this.escuela_BDDDataSet44;
            this.escuelaBDDDataSet44BindingSource1.Position = 0;
            // 
            // escuela_BDDDataSet45
            // 
            this.escuela_BDDDataSet45.DataSetName = "Escuela_BDDDataSet45";
            this.escuela_BDDDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docentesBindingSource
            // 
            this.docentesBindingSource.DataMember = "Docentes";
            this.docentesBindingSource.DataSource = this.escuela_BDDDataSet45;
            // 
            // docentesTableAdapter
            // 
            this.docentesTableAdapter.ClearBeforeFill = true;
            // 
            // btnIsertarNota1
            // 
            this.btnIsertarNota1.FlatAppearance.BorderSize = 0;
            this.btnIsertarNota1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsertarNota1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsertarNota1.Location = new System.Drawing.Point(498, 158);
            this.btnIsertarNota1.Name = "btnIsertarNota1";
            this.btnIsertarNota1.Size = new System.Drawing.Size(170, 45);
            this.btnIsertarNota1.TabIndex = 57;
            this.btnIsertarNota1.Text = "Insertar Nota 1";
            this.btnIsertarNota1.UseVisualStyleBackColor = true;
            this.btnIsertarNota1.Visible = false;
            this.btnIsertarNota1.Click += new System.EventHandler(this.btnIsertarNota_Click);
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidad.ForeColor = System.Drawing.Color.White;
            this.lblIdentidad.Location = new System.Drawing.Point(115, 243);
            this.lblIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(89, 19);
            this.lblIdentidad.TabIndex = 58;
            this.lblIdentidad.Text = "Identidad:";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Enabled = false;
            this.txtIdentidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(209, 242);
            this.txtIdentidad.MaxLength = 1;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(150, 26);
            this.txtIdentidad.TabIndex = 59;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(498, 83);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 60;
            // 
            // txtIdClase
            // 
            this.txtIdClase.Location = new System.Drawing.Point(568, 83);
            this.txtIdClase.Name = "txtIdClase";
            this.txtIdClase.Size = new System.Drawing.Size(50, 20);
            this.txtIdClase.TabIndex = 61;
            // 
            // dgvSegundoParcial
            // 
            this.dgvSegundoParcial.AllowUserToAddRows = false;
            this.dgvSegundoParcial.AllowUserToDeleteRows = false;
            this.dgvSegundoParcial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSegundoParcial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSegundoParcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegundoParcial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvSegundoParcial.Location = new System.Drawing.Point(115, 299);
            this.dgvSegundoParcial.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSegundoParcial.Name = "dgvSegundoParcial";
            this.dgvSegundoParcial.ReadOnly = true;
            this.dgvSegundoParcial.RowHeadersWidth = 51;
            this.dgvSegundoParcial.RowTemplate.Height = 24;
            this.dgvSegundoParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSegundoParcial.Size = new System.Drawing.Size(556, 416);
            this.dgvSegundoParcial.TabIndex = 62;
            this.dgvSegundoParcial.Visible = false;
            this.dgvSegundoParcial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSegundoParcial_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_alumno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_alumno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Identidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Identidad Alumno";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_clase";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_clase";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre Alumno";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellido del Alumno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Grado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Grado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nota2";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nota 2";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btnIsertarNota2
            // 
            this.btnIsertarNota2.FlatAppearance.BorderSize = 0;
            this.btnIsertarNota2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsertarNota2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsertarNota2.Location = new System.Drawing.Point(498, 158);
            this.btnIsertarNota2.Name = "btnIsertarNota2";
            this.btnIsertarNota2.Size = new System.Drawing.Size(170, 45);
            this.btnIsertarNota2.TabIndex = 63;
            this.btnIsertarNota2.Text = "Insertar Nota 2";
            this.btnIsertarNota2.UseVisualStyleBackColor = true;
            this.btnIsertarNota2.Visible = false;
            this.btnIsertarNota2.Click += new System.EventHandler(this.btnIsertarNota2_Click);
            // 
            // btnIsertarNota3
            // 
            this.btnIsertarNota3.FlatAppearance.BorderSize = 0;
            this.btnIsertarNota3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsertarNota3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsertarNota3.Location = new System.Drawing.Point(498, 158);
            this.btnIsertarNota3.Name = "btnIsertarNota3";
            this.btnIsertarNota3.Size = new System.Drawing.Size(170, 45);
            this.btnIsertarNota3.TabIndex = 64;
            this.btnIsertarNota3.Text = "Insertar Nota 3";
            this.btnIsertarNota3.UseVisualStyleBackColor = true;
            this.btnIsertarNota3.Visible = false;
            this.btnIsertarNota3.Click += new System.EventHandler(this.btnIsertarNota3_Click);
            // 
            // dgvTercerParcial
            // 
            this.dgvTercerParcial.AllowUserToAddRows = false;
            this.dgvTercerParcial.AllowUserToDeleteRows = false;
            this.dgvTercerParcial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTercerParcial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTercerParcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTercerParcial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvTercerParcial.Location = new System.Drawing.Point(115, 299);
            this.dgvTercerParcial.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTercerParcial.Name = "dgvTercerParcial";
            this.dgvTercerParcial.ReadOnly = true;
            this.dgvTercerParcial.RowHeadersWidth = 51;
            this.dgvTercerParcial.RowTemplate.Height = 24;
            this.dgvTercerParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTercerParcial.Size = new System.Drawing.Size(556, 416);
            this.dgvTercerParcial.TabIndex = 65;
            this.dgvTercerParcial.Visible = false;
            this.dgvTercerParcial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTercerParcial_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id_alumno";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id_alumno";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Identidad";
            this.dataGridViewTextBoxColumn9.HeaderText = "Identidad Alumno";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id_clase";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id_clase";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn11.HeaderText = "Nombre Alumno";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn12.HeaderText = "Apellido del Alumno";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Grado";
            this.dataGridViewTextBoxColumn13.HeaderText = "Grado";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Nota3";
            this.dataGridViewTextBoxColumn14.HeaderText = "Nota 3";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // btnIsertarNota4
            // 
            this.btnIsertarNota4.FlatAppearance.BorderSize = 0;
            this.btnIsertarNota4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsertarNota4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsertarNota4.Location = new System.Drawing.Point(498, 158);
            this.btnIsertarNota4.Name = "btnIsertarNota4";
            this.btnIsertarNota4.Size = new System.Drawing.Size(170, 45);
            this.btnIsertarNota4.TabIndex = 66;
            this.btnIsertarNota4.Text = "Insertar Nota 4";
            this.btnIsertarNota4.UseVisualStyleBackColor = true;
            this.btnIsertarNota4.Visible = false;
            this.btnIsertarNota4.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCuartoParcial
            // 
            this.dgvCuartoParcial.AllowUserToAddRows = false;
            this.dgvCuartoParcial.AllowUserToDeleteRows = false;
            this.dgvCuartoParcial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuartoParcial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuartoParcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuartoParcial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.dgvCuartoParcial.Location = new System.Drawing.Point(115, 299);
            this.dgvCuartoParcial.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCuartoParcial.Name = "dgvCuartoParcial";
            this.dgvCuartoParcial.ReadOnly = true;
            this.dgvCuartoParcial.RowHeadersWidth = 51;
            this.dgvCuartoParcial.RowTemplate.Height = 24;
            this.dgvCuartoParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuartoParcial.Size = new System.Drawing.Size(556, 416);
            this.dgvCuartoParcial.TabIndex = 67;
            this.dgvCuartoParcial.Visible = false;
            this.dgvCuartoParcial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuartoParcial_CellClick);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Id_alumno";
            this.dataGridViewTextBoxColumn15.HeaderText = "Id_alumno";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Identidad";
            this.dataGridViewTextBoxColumn16.HeaderText = "Identidad Alumno";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Id_clase";
            this.dataGridViewTextBoxColumn17.HeaderText = "Id_clase";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn18.HeaderText = "Nombre Alumno";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn19.HeaderText = "Apellido del Alumno";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Grado";
            this.dataGridViewTextBoxColumn20.HeaderText = "Grado";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Nota4";
            this.dataGridViewTextBoxColumn21.HeaderText = "Nota 4";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // btnIsertarRecuperacion
            // 
            this.btnIsertarRecuperacion.FlatAppearance.BorderSize = 0;
            this.btnIsertarRecuperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsertarRecuperacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsertarRecuperacion.Location = new System.Drawing.Point(498, 153);
            this.btnIsertarRecuperacion.Name = "btnIsertarRecuperacion";
            this.btnIsertarRecuperacion.Size = new System.Drawing.Size(170, 55);
            this.btnIsertarRecuperacion.TabIndex = 69;
            this.btnIsertarRecuperacion.Text = "Insertar Nota Recuperacion";
            this.btnIsertarRecuperacion.UseVisualStyleBackColor = true;
            this.btnIsertarRecuperacion.Visible = false;
            this.btnIsertarRecuperacion.Click += new System.EventHandler(this.btnIsertarRecuperacion_Click);
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Recuperacion";
            this.dataGridViewTextBoxColumn28.HeaderText = "Recuperación";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Grado";
            this.dataGridViewTextBoxColumn27.HeaderText = "Grado";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn26.HeaderText = "Apellido del Alumno";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn25.HeaderText = "Nombre Alumno";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Id_clase";
            this.dataGridViewTextBoxColumn24.HeaderText = "Id_clase";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Identidad";
            this.dataGridViewTextBoxColumn23.HeaderText = "Identidad Alumno";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Id_alumno";
            this.dataGridViewTextBoxColumn22.HeaderText = "Id_alumno";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dgvRecuperacion
            // 
            this.dgvRecuperacion.AllowUserToAddRows = false;
            this.dgvRecuperacion.AllowUserToDeleteRows = false;
            this.dgvRecuperacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecuperacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecuperacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecuperacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dgvRecuperacion.Location = new System.Drawing.Point(115, 299);
            this.dgvRecuperacion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRecuperacion.Name = "dgvRecuperacion";
            this.dgvRecuperacion.ReadOnly = true;
            this.dgvRecuperacion.RowHeadersWidth = 51;
            this.dgvRecuperacion.RowTemplate.Height = 24;
            this.dgvRecuperacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecuperacion.Size = new System.Drawing.Size(556, 416);
            this.dgvRecuperacion.TabIndex = 68;
            this.dgvRecuperacion.Visible = false;
            this.dgvRecuperacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecuperacion_CellClick);
            // 
            // FrmIngresarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(778, 749);
            this.Controls.Add(this.btnIsertarRecuperacion);
            this.Controls.Add(this.dgvRecuperacion);
            this.Controls.Add(this.dgvCuartoParcial);
            this.Controls.Add(this.btnIsertarNota4);
            this.Controls.Add(this.dgvTercerParcial);
            this.Controls.Add(this.btnIsertarNota3);
            this.Controls.Add(this.btnIsertarNota2);
            this.Controls.Add(this.dgvSegundoParcial);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.lblIdentidad);
            this.Controls.Add(this.btnIsertarNota1);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrimerParcial);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIdClase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmIngresarNotas";
            this.Load += new System.EventHandler(this.FrmIngresarNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaBDDDataSet44BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaBDDDataSet44BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundoParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTercerParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuartoParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecuperacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvPrimerParcial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtNota;
        private cientificaIIProyecto.Escuela_BDDDataSet44 escuela_BDDDataSet44;
        private System.Windows.Forms.BindingSource escuelaBDDDataSet44BindingSource;
        private System.Windows.Forms.BindingSource escuelaBDDDataSet44BindingSource1;
        private cientificaIIProyecto.Escuela_BDDDataSet45 escuela_BDDDataSet45;
        private System.Windows.Forms.BindingSource docentesBindingSource;
        private cientificaIIProyecto.Escuela_BDDDataSet45TableAdapters.DocentesTableAdapter docentesTableAdapter;
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.TextBox txtIdClase;
        public System.Windows.Forms.DataGridView dgvSegundoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public System.Windows.Forms.Button btnIsertarNota1;
        public System.Windows.Forms.Button btnIsertarNota2;
        public System.Windows.Forms.Label lblNota;
        public System.Windows.Forms.Button btnIsertarNota3;
        public System.Windows.Forms.DataGridView dgvTercerParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Button btnIsertarNota4;
        public System.Windows.Forms.DataGridView dgvCuartoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        public System.Windows.Forms.Button btnIsertarRecuperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        public System.Windows.Forms.DataGridView dgvRecuperacion;
    }
}