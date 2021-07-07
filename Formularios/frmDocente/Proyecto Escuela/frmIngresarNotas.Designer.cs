namespace Proyecto_Escuela
{
    partial class frmIngresarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresarNotas));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIngresoNotas = new System.Windows.Forms.DataGridView();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIngresarNota = new System.Windows.Forms.Button();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Image = ((System.Drawing.Image)(resources.GetObject("lblTitulo.Image")));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(47, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingresar Notas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clase:";
            // 
            // dgvIngresoNotas
            // 
            this.dgvIngresoNotas.AllowUserToAddRows = false;
            this.dgvIngresoNotas.AllowUserToDeleteRows = false;
            this.dgvIngresoNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngresoNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumno,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4});
            this.dgvIngresoNotas.Location = new System.Drawing.Point(31, 388);
            this.dgvIngresoNotas.Name = "dgvIngresoNotas";
            this.dgvIngresoNotas.ReadOnly = true;
            this.dgvIngresoNotas.RowHeadersWidth = 51;
            this.dgvIngresoNotas.RowTemplate.Height = 24;
            this.dgvIngresoNotas.Size = new System.Drawing.Size(656, 257);
            this.dgvIngresoNotas.TabIndex = 2;
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdAlumno.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAlumno.Location = new System.Drawing.Point(273, 196);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(198, 23);
            this.txtIdAlumno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identidad Alumno:";
            // 
            // txtNota1
            // 
            this.txtNota1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(166, 236);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(49, 23);
            this.txtNota1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota 1:";
            // 
            // txtNota2
            // 
            this.txtNota2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(313, 236);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(49, 23);
            this.txtNota2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(231, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota 2:";
            // 
            // txtNota3
            // 
            this.txtNota3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(469, 236);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(49, 23);
            this.txtNota3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(387, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota 3:";
            // 
            // txtNota4
            // 
            this.txtNota4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota4.Location = new System.Drawing.Point(617, 236);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(49, 23);
            this.txtNota4.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(535, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nota 4:";
            // 
            // btnIngresarNota
            // 
            this.btnIngresarNota.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarNota.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarNota.Location = new System.Drawing.Point(303, 304);
            this.btnIngresarNota.Name = "btnIngresarNota";
            this.btnIngresarNota.Size = new System.Drawing.Size(117, 44);
            this.btnIngresarNota.TabIndex = 14;
            this.btnIngresarNota.Text = "Ingresar";
            this.btnIngresarNota.UseVisualStyleBackColor = true;
            // 
            // cmbClase
            // 
            this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClase.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(273, 152);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(198, 29);
            this.cmbClase.TabIndex = 15;
            // 
            // IdAlumno
            // 
            this.IdAlumno.HeaderText = "Identidad Alumno";
            this.IdAlumno.MinimumWidth = 6;
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.ReadOnly = true;
            this.IdAlumno.Width = 140;
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
            // frmIngresarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 709);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.btnIngresarNota);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvIngresoNotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresarNotas";
            this.Text = "frmIngresarNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIngresoNotas;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIngresarNota;
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
    }
}