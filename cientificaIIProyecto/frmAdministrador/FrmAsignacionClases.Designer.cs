namespace Registro
{
    partial class FrmAsignacionClases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionClases));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAsignacion = new System.Windows.Forms.DataGridView();
            this.Id_clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignarClase = new System.Windows.Forms.Button();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.escuela_BDDDataSet15 = new cientificaIIProyecto.Escuela_BDDDataSet15();
            this.docentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docentesTableAdapter = new cientificaIIProyecto.Escuela_BDDDataSet15TableAdapters.DocentesTableAdapter();
            this.btnAsignarDocente = new System.Windows.Forms.Button();
            this.txtIdDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(273, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 28);
            this.label7.TabIndex = 56;
            this.label7.Text = " ASIGNACIÓN DE CLASES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(163, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Clase: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgvAsignacion
            // 
            this.dgvAsignacion.AllowUserToAddRows = false;
            this.dgvAsignacion.AllowUserToDeleteRows = false;
            this.dgvAsignacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_clase,
            this.Nombre,
            this.Id_docente,
            this.Identidad,
            this.Nombres,
            this.Apellidos});
            this.dgvAsignacion.Location = new System.Drawing.Point(136, 277);
            this.dgvAsignacion.Name = "dgvAsignacion";
            this.dgvAsignacion.ReadOnly = true;
            this.dgvAsignacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignacion.Size = new System.Drawing.Size(562, 351);
            this.dgvAsignacion.TabIndex = 59;
            this.dgvAsignacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignacion_CellClick);
            this.dgvAsignacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignacion_CellContentClick);
            // 
            // Id_clase
            // 
            this.Id_clase.DataPropertyName = "Id_clase";
            this.Id_clase.HeaderText = "Id Clase";
            this.Id_clase.Name = "Id_clase";
            this.Id_clase.ReadOnly = true;
            this.Id_clase.Width = 65;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Descripcion";
            this.Nombre.HeaderText = "Nombre de la Clase";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 90;
            // 
            // Id_docente
            // 
            this.Id_docente.DataPropertyName = "Id_docente";
            this.Id_docente.HeaderText = "Id del Docente";
            this.Id_docente.Name = "Id_docente";
            this.Id_docente.ReadOnly = true;
            this.Id_docente.Visible = false;
            this.Id_docente.Width = 94;
            // 
            // Identidad
            // 
            this.Identidad.DataPropertyName = "Identidad";
            this.Identidad.HeaderText = "Identidad del Docente";
            this.Identidad.Name = "Identidad";
            this.Identidad.ReadOnly = true;
            this.Identidad.Width = 125;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombre del Docente";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 119;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos del Docente";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Docente: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAsignarClase
            // 
            this.btnAsignarClase.FlatAppearance.BorderSize = 0;
            this.btnAsignarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarClase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarClase.Location = new System.Drawing.Point(529, 180);
            this.btnAsignarClase.Name = "btnAsignarClase";
            this.btnAsignarClase.Size = new System.Drawing.Size(169, 47);
            this.btnAsignarClase.TabIndex = 62;
            this.btnAsignarClase.Text = "Asignar Clase";
            this.btnAsignarClase.UseVisualStyleBackColor = true;
            this.btnAsignarClase.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtClase
            // 
            this.txtClase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClase.Enabled = false;
            this.txtClase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClase.Location = new System.Drawing.Point(227, 171);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(201, 19);
            this.txtClase.TabIndex = 63;
            this.txtClase.TextChanged += new System.EventHandler(this.txtClase_TextChanged);
            // 
            // escuela_BDDDataSet15
            // 
            this.escuela_BDDDataSet15.DataSetName = "Escuela_BDDDataSet15";
            this.escuela_BDDDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docentesBindingSource
            // 
            this.docentesBindingSource.DataMember = "Docentes";
            this.docentesBindingSource.DataSource = this.escuela_BDDDataSet15;
            // 
            // docentesTableAdapter
            // 
            this.docentesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAsignarDocente
            // 
            this.btnAsignarDocente.FlatAppearance.BorderSize = 0;
            this.btnAsignarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarDocente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarDocente.Location = new System.Drawing.Point(303, 213);
            this.btnAsignarDocente.Name = "btnAsignarDocente";
            this.btnAsignarDocente.Size = new System.Drawing.Size(125, 34);
            this.btnAsignarDocente.TabIndex = 64;
            this.btnAsignarDocente.Text = "Asignar Docente";
            this.btnAsignarDocente.UseVisualStyleBackColor = true;
            this.btnAsignarDocente.Click += new System.EventHandler(this.btnAsignarEncargado_Click);
            // 
            // txtIdDocente
            // 
            this.txtIdDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdDocente.Enabled = false;
            this.txtIdDocente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDocente.Location = new System.Drawing.Point(227, 219);
            this.txtIdDocente.Name = "txtIdDocente";
            this.txtIdDocente.Size = new System.Drawing.Size(59, 19);
            this.txtIdDocente.TabIndex = 65;
            // 
            // FrmAsignacionClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 749);
            this.Controls.Add(this.txtIdDocente);
            this.Controls.Add(this.btnAsignarDocente);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.btnAsignarClase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAsignacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsignacionClases";
            this.Text = "FrmAsignacionClases";
            this.Load += new System.EventHandler(this.FrmAsignacionClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAsignacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignarClase;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private cientificaIIProyecto.Escuela_BDDDataSet15 escuela_BDDDataSet15;
        private System.Windows.Forms.BindingSource docentesBindingSource;
        private cientificaIIProyecto.Escuela_BDDDataSet15TableAdapters.DocentesTableAdapter docentesTableAdapter;
        private System.Windows.Forms.Button btnAsignarDocente;
        private System.Windows.Forms.TextBox txtIdDocente;
    }
}