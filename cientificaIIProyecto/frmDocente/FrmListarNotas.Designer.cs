namespace FrmDocente
{
    partial class FrmListarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarNotas));
            this.btnListarNotas = new System.Windows.Forms.Button();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvIngresoNotas = new System.Windows.Forms.DataGridView();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarNotas
            // 
            this.btnListarNotas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarNotas.ForeColor = System.Drawing.Color.Black;
            this.btnListarNotas.Location = new System.Drawing.Point(899, 156);
            this.btnListarNotas.Name = "btnListarNotas";
            this.btnListarNotas.Size = new System.Drawing.Size(117, 44);
            this.btnListarNotas.TabIndex = 25;
            this.btnListarNotas.Text = "Listar";
            this.btnListarNotas.UseVisualStyleBackColor = true;
            // 
            // cmbClase
            // 
            this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClase.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(137, 165);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(198, 29);
            this.cmbClase.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Clase:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Image = ((System.Drawing.Image)(resources.GetObject("lblTitulo.Image")));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(58, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 40);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Listar Notas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvIngresoNotas
            // 
            this.dgvIngresoNotas.AllowUserToAddRows = false;
            this.dgvIngresoNotas.AllowUserToDeleteRows = false;
            this.dgvIngresoNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngresoNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumno,
            this.Nombre,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4});
            this.dgvIngresoNotas.Enabled = false;
            this.dgvIngresoNotas.Location = new System.Drawing.Point(65, 244);
            this.dgvIngresoNotas.Name = "dgvIngresoNotas";
            this.dgvIngresoNotas.ReadOnly = true;
            this.dgvIngresoNotas.RowHeadersWidth = 51;
            this.dgvIngresoNotas.RowTemplate.Height = 24;
            this.dgvIngresoNotas.Size = new System.Drawing.Size(951, 528);
            this.dgvIngresoNotas.TabIndex = 26;
            // 
            // IdAlumno
            // 
            this.IdAlumno.HeaderText = "Identidad Alumno";
            this.IdAlumno.MinimumWidth = 6;
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.ReadOnly = true;
            this.IdAlumno.Width = 140;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Alumno";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Nota1
            // 
            this.Nota1.HeaderText = "Nota 1";
            this.Nota1.MinimumWidth = 6;
            this.Nota1.Name = "Nota1";
            this.Nota1.ReadOnly = true;
            this.Nota1.Width = 70;
            // 
            // Nota2
            // 
            this.Nota2.HeaderText = "Nota 2";
            this.Nota2.MinimumWidth = 6;
            this.Nota2.Name = "Nota2";
            this.Nota2.ReadOnly = true;
            this.Nota2.Width = 70;
            // 
            // Nota3
            // 
            this.Nota3.HeaderText = "Nota 3";
            this.Nota3.MinimumWidth = 6;
            this.Nota3.Name = "Nota3";
            this.Nota3.ReadOnly = true;
            this.Nota3.Width = 70;
            // 
            // Nota4
            // 
            this.Nota4.HeaderText = "Nota 4";
            this.Nota4.MinimumWidth = 6;
            this.Nota4.Name = "Nota4";
            this.Nota4.ReadOnly = true;
            this.Nota4.Width = 70;
            // 
            // FrmListarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1112, 922);
            this.Controls.Add(this.dgvIngresoNotas);
            this.Controls.Add(this.btnListarNotas);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarNotas";
            this.Text = "FrmListarNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarNotas;
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvIngresoNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
    }
}