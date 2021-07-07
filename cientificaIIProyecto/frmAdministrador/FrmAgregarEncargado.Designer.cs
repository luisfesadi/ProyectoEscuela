namespace Registro
{
    partial class FrmAgregarEncargado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEncargado));
            this.label8 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnAgregarEncargado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEncargados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureRegDoc = new System.Windows.Forms.PictureBox();
            this.txtCorreo_electronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richtxtDireccion = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.escuela_BDDDataSet27 = new cientificaIIProyecto.Escuela_BDDDataSet27();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new cientificaIIProyecto.Escuela_BDDDataSet27TableAdapters.GeneroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(52, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Sexo: ";
            // 
            // btnCargar
            // 
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(815, 389);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(193, 55);
            this.btnCargar.TabIndex = 53;
            this.btnCargar.Text = "Cargar Imagen";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DataSource = this.generoBindingSource;
            this.cmbSexo.DisplayMember = "Descripcion_genero";
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(128, 241);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(151, 29);
            this.cmbSexo.TabIndex = 57;
            this.cmbSexo.ValueMember = "Id_genero";
            // 
            // btnAgregarEncargado
            // 
            this.btnAgregarEncargado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEncargado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEncargado.Location = new System.Drawing.Point(57, 500);
            this.btnAgregarEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarEncargado.Name = "btnAgregarEncargado";
            this.btnAgregarEncargado.Size = new System.Drawing.Size(227, 55);
            this.btnAgregarEncargado.TabIndex = 56;
            this.btnAgregarEncargado.Text = "Agregar Encargado";
            this.btnAgregarEncargado.UseVisualStyleBackColor = true;
            this.btnAgregarEncargado.Click += new System.EventHandler(this.btnAgregarEncargado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(411, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 37);
            this.label7.TabIndex = 55;
            this.label7.Text = "AGREGAR ENCARGADO";
            // 
            // dgvEncargados
            // 
            this.dgvEncargados.AllowUserToAddRows = false;
            this.dgvEncargados.AllowUserToDeleteRows = false;
            this.dgvEncargados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEncargados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEncargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Identidad,
            this.Nombres,
            this.Apellidos,
            this.Id_genero,
            this.Sexo,
            this.Foto,
            this.Correo_electronico,
            this.Direccion,
            this.Telefono});
            this.dgvEncargados.Location = new System.Drawing.Point(52, 583);
            this.dgvEncargados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEncargados.Name = "dgvEncargados";
            this.dgvEncargados.ReadOnly = true;
            this.dgvEncargados.RowHeadersWidth = 51;
            this.dgvEncargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargados.Size = new System.Drawing.Size(1004, 297);
            this.dgvEncargados.TabIndex = 54;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_encargado";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 48;
            // 
            // Identidad
            // 
            this.Identidad.DataPropertyName = "Identidad_encargado";
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.MinimumWidth = 6;
            this.Identidad.Name = "Identidad";
            this.Identidad.ReadOnly = true;
            this.Identidad.Width = 95;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres_encargado";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 94;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos_encargado";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 94;
            // 
            // Id_genero
            // 
            this.Id_genero.DataPropertyName = "Id_genero_encargado";
            this.Id_genero.HeaderText = "Id_genero";
            this.Id_genero.MinimumWidth = 6;
            this.Id_genero.Name = "Id_genero";
            this.Id_genero.ReadOnly = true;
            this.Id_genero.Visible = false;
            this.Id_genero.Width = 80;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Descripcion_genero";
            this.Sexo.HeaderText = "Genero";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 85;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto_encargado";
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 65;
            // 
            // Correo_electronico
            // 
            this.Correo_electronico.DataPropertyName = "Correo_electronico";
            this.Correo_electronico.HeaderText = "Correo Electrónico";
            this.Correo_electronico.MinimumWidth = 6;
            this.Correo_electronico.Name = "Correo_electronico";
            this.Correo_electronico.ReadOnly = true;
            this.Correo_electronico.Width = 141;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 96;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 93;
            // 
            // pictureRegDoc
            // 
            this.pictureRegDoc.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegDoc.Image")));
            this.pictureRegDoc.Location = new System.Drawing.Point(771, 101);
            this.pictureRegDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureRegDoc.Name = "pictureRegDoc";
            this.pictureRegDoc.Size = new System.Drawing.Size(284, 270);
            this.pictureRegDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRegDoc.TabIndex = 52;
            this.pictureRegDoc.TabStop = false;
            // 
            // txtCorreo_electronico
            // 
            this.txtCorreo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo_electronico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo_electronico.Location = new System.Drawing.Point(271, 294);
            this.txtCorreo_electronico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo_electronico.MaxLength = 200;
            this.txtCorreo_electronico.Name = "txtCorreo_electronico";
            this.txtCorreo_electronico.Size = new System.Drawing.Size(263, 23);
            this.txtCorreo_electronico.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Correo electrónico: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(179, 194);
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
            this.txtNombres.Location = new System.Drawing.Point(179, 146);
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
            this.txtIdentidad.Location = new System.Drawing.Point(179, 101);
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
            this.label3.Location = new System.Drawing.Point(52, 101);
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
            this.label2.Location = new System.Drawing.Point(52, 193);
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
            this.label1.Location = new System.Drawing.Point(52, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombres: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 386);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "Dirección: ";
            // 
            // richtxtDireccion
            // 
            this.richtxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtDireccion.Location = new System.Drawing.Point(179, 386);
            this.richtxtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richtxtDireccion.MaxLength = 300;
            this.richtxtDireccion.Name = "richtxtDireccion";
            this.richtxtDireccion.Size = new System.Drawing.Size(355, 90);
            this.richtxtDireccion.TabIndex = 60;
            this.richtxtDireccion.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 61;
            this.label6.Text = "Teléfono: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(163, 341);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(168, 23);
            this.txtTelefono.TabIndex = 62;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // escuela_BDDDataSet27
            // 
            this.escuela_BDDDataSet27.DataSetName = "Escuela_BDDDataSet27";
            this.escuela_BDDDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.escuela_BDDDataSet27;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAgregarEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1112, 922);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richtxtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.btnAgregarEncargado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvEncargados);
            this.Controls.Add(this.pictureRegDoc);
            this.Controls.Add(this.txtCorreo_electronico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAgregarEncargado";
            this.Load += new System.EventHandler(this.FrmAgregarEncargado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnAgregarEncargado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvEncargados;
        private System.Windows.Forms.PictureBox pictureRegDoc;
        private System.Windows.Forms.TextBox txtCorreo_electronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richtxtDireccion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private cientificaIIProyecto.Escuela_BDDDataSet27 escuela_BDDDataSet27;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private cientificaIIProyecto.Escuela_BDDDataSet27TableAdapters.GeneroTableAdapter generoTableAdapter;
    }
}