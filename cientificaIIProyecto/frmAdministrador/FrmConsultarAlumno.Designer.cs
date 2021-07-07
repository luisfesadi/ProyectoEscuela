namespace Registro
{
    partial class FrmConsultarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarAlumno));
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Identidad",
            "Nombres",
            "Apellidos"});
            this.cmbFiltro.Location = new System.Drawing.Point(576, 84);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 59;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(520, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Filtro: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(118, 86);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(280, 19);
            this.txtBuscar.TabIndex = 57;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Buscar: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(282, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 28);
            this.label7.TabIndex = 60;
            this.label7.Text = "CONSULTAR ALUMNO";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Identidad,
            this.Contraseña,
            this.Nombres,
            this.Apellidos,
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
            this.dgvAlumnos.Location = new System.Drawing.Point(50, 134);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(741, 583);
            this.dgvAlumnos.TabIndex = 77;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_alumno";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Identidad
            // 
            this.Identidad.DataPropertyName = "Identidad";
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.Name = "Identidad";
            this.Identidad.ReadOnly = true;
            this.Identidad.Width = 76;
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Width = 86;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 74;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.FillWeight = 110F;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 74;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 53;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.DataPropertyName = "Fecha_nacimiento";
            this.Fecha_nacimiento.HeaderText = "Fecha de nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            this.Fecha_nacimiento.Width = 120;
            // 
            // Id_sexo
            // 
            this.Id_sexo.DataPropertyName = "Id_genero";
            this.Id_sexo.HeaderText = "Id Genero";
            this.Id_sexo.Name = "Id_sexo";
            this.Id_sexo.ReadOnly = true;
            this.Id_sexo.Visible = false;
            this.Id_sexo.Width = 73;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Descripcion_genero";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 56;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            this.Grado.Width = 61;
            // 
            // correo_alumno
            // 
            this.correo_alumno.DataPropertyName = "Correo_electronico_alumno";
            this.correo_alumno.HeaderText = "E-Mail Alumno";
            this.correo_alumno.Name = "correo_alumno";
            this.correo_alumno.ReadOnly = true;
            this.correo_alumno.Width = 91;
            // 
            // Id_encargado
            // 
            this.Id_encargado.DataPropertyName = "Id_encargado";
            this.Id_encargado.HeaderText = "Id_encargado";
            this.Id_encargado.Name = "Id_encargado";
            this.Id_encargado.ReadOnly = true;
            this.Id_encargado.Width = 98;
            // 
            // Nombres_encargado
            // 
            this.Nombres_encargado.DataPropertyName = "Nombres_encargado";
            this.Nombres_encargado.HeaderText = "Nombres encargado";
            this.Nombres_encargado.Name = "Nombres_encargado";
            this.Nombres_encargado.ReadOnly = true;
            this.Nombres_encargado.Width = 117;
            // 
            // Apellidos_encargado
            // 
            this.Apellidos_encargado.DataPropertyName = "Apellidos_encargado";
            this.Apellidos_encargado.HeaderText = "Apellidos encargado";
            this.Apellidos_encargado.Name = "Apellidos_encargado";
            this.Apellidos_encargado.ReadOnly = true;
            this.Apellidos_encargado.Width = 117;
            // 
            // Correo_electronico
            // 
            this.Correo_electronico.DataPropertyName = "Correo_electronico";
            this.Correo_electronico.HeaderText = "E-Mail Encargado";
            this.Correo_electronico.Name = "Correo_electronico";
            this.Correo_electronico.ReadOnly = true;
            this.Correo_electronico.Width = 106;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 74;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 77;
            // 
            // FrmConsultarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 749);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarAlumno";
            this.Text = "FrmConsultarAlumno";
            this.Load += new System.EventHandler(this.FrmConsultarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
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