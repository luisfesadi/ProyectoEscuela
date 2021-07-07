namespace Proyecto_Escuela
{
    partial class frmNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotas));
            this.lblNotasTítulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Clases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recuperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.txtAprobados = new System.Windows.Forms.TextBox();
            this.txtReprobados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotasTítulo
            // 
            this.lblNotasTítulo.AutoSize = true;
            this.lblNotasTítulo.BackColor = System.Drawing.Color.Transparent;
            this.lblNotasTítulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotasTítulo.ForeColor = System.Drawing.Color.White;
            this.lblNotasTítulo.Image = ((System.Drawing.Image)(resources.GetObject("lblNotasTítulo.Image")));
            this.lblNotasTítulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotasTítulo.Location = new System.Drawing.Point(41, 23);
            this.lblNotasTítulo.Name = "lblNotasTítulo";
            this.lblNotasTítulo.Size = new System.Drawing.Size(138, 32);
            this.lblNotasTítulo.TabIndex = 18;
            this.lblNotasTítulo.Text = "      Notas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(287, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Calificaciones";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clases,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4,
            this.Recuperacion,
            this.Promedio});
            this.dgv.Location = new System.Drawing.Point(24, 127);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(735, 389);
            this.dgv.TabIndex = 20;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Clases
            // 
            this.Clases.DataPropertyName = "Descripcion";
            this.Clases.HeaderText = "Clase";
            this.Clases.Name = "Clases";
            this.Clases.ReadOnly = true;
            // 
            // Nota1
            // 
            this.Nota1.DataPropertyName = "Nota1";
            this.Nota1.HeaderText = "Nota 1";
            this.Nota1.Name = "Nota1";
            this.Nota1.ReadOnly = true;
            // 
            // Nota2
            // 
            this.Nota2.DataPropertyName = "Nota2";
            this.Nota2.HeaderText = "Nota 2";
            this.Nota2.Name = "Nota2";
            this.Nota2.ReadOnly = true;
            // 
            // Nota3
            // 
            this.Nota3.DataPropertyName = "Nota3";
            this.Nota3.HeaderText = "Nota 3";
            this.Nota3.Name = "Nota3";
            this.Nota3.ReadOnly = true;
            // 
            // Nota4
            // 
            this.Nota4.DataPropertyName = "Nota4";
            this.Nota4.HeaderText = "Nota 4";
            this.Nota4.Name = "Nota4";
            this.Nota4.ReadOnly = true;
            // 
            // Recuperacion
            // 
            this.Recuperacion.DataPropertyName = "Recuperacion";
            this.Recuperacion.HeaderText = "Recuperacion";
            this.Recuperacion.Name = "Recuperacion";
            this.Recuperacion.ReadOnly = true;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.BackColor = System.Drawing.Color.Transparent;
            this.lblAprobados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprobados.ForeColor = System.Drawing.Color.White;
            this.lblAprobados.Location = new System.Drawing.Point(97, 538);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(104, 19);
            this.lblAprobados.TabIndex = 21;
            this.lblAprobados.Text = "Aprobados: ";
            // 
            // lblReprobados
            // 
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.BackColor = System.Drawing.Color.Transparent;
            this.lblReprobados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReprobados.ForeColor = System.Drawing.Color.White;
            this.lblReprobados.Location = new System.Drawing.Point(514, 538);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(111, 19);
            this.lblReprobados.TabIndex = 22;
            this.lblReprobados.Text = "Reprobados: ";
            // 
            // txtAprobados
            // 
            this.txtAprobados.Enabled = false;
            this.txtAprobados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAprobados.Location = new System.Drawing.Point(207, 538);
            this.txtAprobados.Name = "txtAprobados";
            this.txtAprobados.Size = new System.Drawing.Size(43, 23);
            this.txtAprobados.TabIndex = 23;
            this.txtAprobados.Text = "0";
            this.txtAprobados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReprobados
            // 
            this.txtReprobados.Enabled = false;
            this.txtReprobados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReprobados.Location = new System.Drawing.Point(631, 538);
            this.txtReprobados.Name = "txtReprobados";
            this.txtReprobados.Size = new System.Drawing.Size(43, 23);
            this.txtReprobados.TabIndex = 24;
            this.txtReprobados.Text = "0";
            this.txtReprobados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.txtReprobados);
            this.Controls.Add(this.txtAprobados);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotasTítulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmNotas_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNotasTítulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clases;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recuperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.TextBox txtAprobados;
        private System.Windows.Forms.TextBox txtReprobados;
    }
}