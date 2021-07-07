namespace Registro
{
    partial class FrmEliminarEncargado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarEncargado));
            this.txtId = new System.Windows.Forms.TextBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnEliminarEncargado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richtxtDireccion = new System.Windows.Forms.RichTextBox();
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.escuela_BDDDataSet43 = new cientificaIIProyecto.Escuela_BDDDataSet43();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new cientificaIIProyecto.Escuela_BDDDataSet43TableAdapters.GeneroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(131, 81);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(53, 19);
            this.txtId.TabIndex = 103;
            // 
            // pictureRegDoc
            // 
            this.pictureRegDoc.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegDoc.Image")));
            this.pictureRegDoc.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureRegDoc.InitialImage")));
            this.pictureRegDoc.Location = new System.Drawing.Point(576, 81);
            this.pictureRegDoc.Name = "pictureRegDoc";
            this.pictureRegDoc.Size = new System.Drawing.Size(213, 219);
            this.pictureRegDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRegDoc.TabIndex = 94;
            this.pictureRegDoc.TabStop = false;
            // 
            // txtCorreo_electronico
            // 
            this.txtCorreo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo_electronico.Enabled = false;
            this.txtCorreo_electronico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo_electronico.Location = new System.Drawing.Point(200, 273);
            this.txtCorreo_electronico.Name = "txtCorreo_electronico";
            this.txtCorreo_electronico.Size = new System.Drawing.Size(197, 19);
            this.txtCorreo_electronico.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Correo electrónico: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(131, 192);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(197, 19);
            this.txtApellidos.TabIndex = 91;
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Enabled = false;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(131, 153);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(197, 19);
            this.txtNombres.TabIndex = 90;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidad.Enabled = false;
            this.txtIdentidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(131, 116);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(197, 19);
            this.txtIdentidad.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Identidad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Nombres: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "Dirección: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 100;
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
            this.cmbSexo.Location = new System.Drawing.Point(93, 230);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(114, 25);
            this.cmbSexo.TabIndex = 99;
            this.cmbSexo.ValueMember = "Id_genero";
            // 
            // btnEliminarEncargado
            // 
            this.btnEliminarEncargado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEncargado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEncargado.Location = new System.Drawing.Point(38, 441);
            this.btnEliminarEncargado.Name = "btnEliminarEncargado";
            this.btnEliminarEncargado.Size = new System.Drawing.Size(169, 47);
            this.btnEliminarEncargado.TabIndex = 98;
            this.btnEliminarEncargado.Text = "Eliminar Encargado";
            this.btnEliminarEncargado.UseVisualStyleBackColor = true;
            this.btnEliminarEncargado.Click += new System.EventHandler(this.btnEliminarEncargado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(289, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 28);
            this.label7.TabIndex = 97;
            this.label7.Text = "ELIMINAR ENCARGADO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(86, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 104;
            this.label10.Text = "Id: ";
            // 
            // richtxtDireccion
            // 
            this.richtxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtDireccion.Enabled = false;
            this.richtxtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtDireccion.Location = new System.Drawing.Point(131, 350);
            this.richtxtDireccion.Name = "richtxtDireccion";
            this.richtxtDireccion.Size = new System.Drawing.Size(266, 73);
            this.richtxtDireccion.TabIndex = 102;
            this.richtxtDireccion.Text = "";
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
            this.dgvEncargados.Location = new System.Drawing.Point(36, 508);
            this.dgvEncargados.Name = "dgvEncargados";
            this.dgvEncargados.ReadOnly = true;
            this.dgvEncargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargados.Size = new System.Drawing.Size(753, 209);
            this.dgvEncargados.TabIndex = 105;
            this.dgvEncargados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncargados_CellClick);
            this.dgvEncargados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncargados_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_encargado";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Identidad
            // 
            this.Identidad.DataPropertyName = "Identidad_encargado";
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.Name = "Identidad";
            this.Identidad.ReadOnly = true;
            this.Identidad.Width = 76;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres_encargado";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 74;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos_encargado";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 74;
            // 
            // Id_genero
            // 
            this.Id_genero.DataPropertyName = "Id_genero_encargado";
            this.Id_genero.HeaderText = "Id_genero";
            this.Id_genero.Name = "Id_genero";
            this.Id_genero.ReadOnly = true;
            this.Id_genero.Visible = false;
            this.Id_genero.Width = 80;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Descripcion_genero";
            this.Sexo.HeaderText = "Genero";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 67;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto_encargado";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 53;
            // 
            // Correo_electronico
            // 
            this.Correo_electronico.DataPropertyName = "Correo_electronico";
            this.Correo_electronico.HeaderText = "Correo Electrónico";
            this.Correo_electronico.Name = "Correo_electronico";
            this.Correo_electronico.ReadOnly = true;
            this.Correo_electronico.Width = 109;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 77;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 74;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(121, 312);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(126, 19);
            this.txtTelefono.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 106;
            this.label6.Text = "Teléfono: ";
            // 
            // escuela_BDDDataSet43
            // 
            this.escuela_BDDDataSet43.DataSetName = "Escuela_BDDDataSet43";
            this.escuela_BDDDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.escuela_BDDDataSet43;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEliminarEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 749);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvEncargados);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pictureRegDoc);
            this.Controls.Add(this.txtCorreo_electronico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.btnEliminarEncargado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richtxtDireccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarEncargado";
            this.Text = "FrmEliminarEncargado";
            this.Load += new System.EventHandler(this.FrmEliminarEncargado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnEliminarEncargado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richtxtDireccion;
        private System.Windows.Forms.DataGridView dgvEncargados;
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
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private cientificaIIProyecto.Escuela_BDDDataSet43 escuela_BDDDataSet43;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private cientificaIIProyecto.Escuela_BDDDataSet43TableAdapters.GeneroTableAdapter generoTableAdapter;
    }
}