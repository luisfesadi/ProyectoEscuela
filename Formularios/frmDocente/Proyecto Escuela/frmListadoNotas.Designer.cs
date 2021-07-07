namespace Proyecto_Escuela
{
    partial class frmListadoNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoNotas));
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListadoNotas = new System.Windows.Forms.DataGridView();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarNotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClase
            // 
            this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClase.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(199, 145);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(198, 29);
            this.cmbClase.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Clase:";
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
            this.lblTitulo.Size = new System.Drawing.Size(257, 40);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Listar Notas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListadoNotas
            // 
            this.dgvListadoNotas.AllowUserToAddRows = false;
            this.dgvListadoNotas.AllowUserToDeleteRows = false;
            this.dgvListadoNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumno,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4});
            this.dgvListadoNotas.Location = new System.Drawing.Point(34, 256);
            this.dgvListadoNotas.Name = "dgvListadoNotas";
            this.dgvListadoNotas.ReadOnly = true;
            this.dgvListadoNotas.RowHeadersWidth = 51;
            this.dgvListadoNotas.RowTemplate.Height = 24;
            this.dgvListadoNotas.Size = new System.Drawing.Size(656, 408);
            this.dgvListadoNotas.TabIndex = 19;
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
            // btnListarNotas
            // 
            this.btnListarNotas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarNotas.ForeColor = System.Drawing.Color.Black;
            this.btnListarNotas.Location = new System.Drawing.Point(463, 138);
            this.btnListarNotas.Name = "btnListarNotas";
            this.btnListarNotas.Size = new System.Drawing.Size(117, 44);
            this.btnListarNotas.TabIndex = 20;
            this.btnListarNotas.Text = "Listar";
            this.btnListarNotas.UseVisualStyleBackColor = true;
            // 
            // frmListadoNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 709);
            this.Controls.Add(this.btnListarNotas);
            this.Controls.Add(this.dgvListadoNotas);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoNotas";
            this.Text = "frmListadoNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvListadoNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
        private System.Windows.Forms.Button btnListarNotas;
    }
}