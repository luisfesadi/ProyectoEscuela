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
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.lblTotalClasesAprobadas = new System.Windows.Forms.Label();
            this.lblTotalClasesReprobadas = new System.Windows.Forms.Label();
            this.lblPromedioTotal = new System.Windows.Forms.Label();
            this.txtTotalClasesAprobadas = new System.Windows.Forms.TextBox();
            this.txtTotalClasesReprobadas = new System.Windows.Forms.TextBox();
            this.txtPromedioTotal = new System.Windows.Forms.TextBox();
            this.clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercerParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuartoParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recuperación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNotasTítulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotas
            // 
            this.dgvNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clase,
            this.primerParcial,
            this.segundoParcial,
            this.tercerParcial,
            this.cuartoParcial,
            this.promedio,
            this.recuperación});
            this.dgvNotas.Location = new System.Drawing.Point(47, 146);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(701, 322);
            this.dgvNotas.TabIndex = 0;
            // 
            // lblTotalClasesAprobadas
            // 
            this.lblTotalClasesAprobadas.AutoSize = true;
            this.lblTotalClasesAprobadas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalClasesAprobadas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClasesAprobadas.ForeColor = System.Drawing.Color.White;
            this.lblTotalClasesAprobadas.Location = new System.Drawing.Point(68, 500);
            this.lblTotalClasesAprobadas.Name = "lblTotalClasesAprobadas";
            this.lblTotalClasesAprobadas.Size = new System.Drawing.Size(205, 18);
            this.lblTotalClasesAprobadas.TabIndex = 12;
            this.lblTotalClasesAprobadas.Text = "Total de clases aprobadas:";
            // 
            // lblTotalClasesReprobadas
            // 
            this.lblTotalClasesReprobadas.AutoSize = true;
            this.lblTotalClasesReprobadas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalClasesReprobadas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClasesReprobadas.ForeColor = System.Drawing.Color.White;
            this.lblTotalClasesReprobadas.Location = new System.Drawing.Point(87, 530);
            this.lblTotalClasesReprobadas.Name = "lblTotalClasesReprobadas";
            this.lblTotalClasesReprobadas.Size = new System.Drawing.Size(186, 18);
            this.lblTotalClasesReprobadas.TabIndex = 13;
            this.lblTotalClasesReprobadas.Text = "Total clases reprobadas:";
            // 
            // lblPromedioTotal
            // 
            this.lblPromedioTotal.AutoSize = true;
            this.lblPromedioTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedioTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioTotal.ForeColor = System.Drawing.Color.White;
            this.lblPromedioTotal.Location = new System.Drawing.Point(154, 560);
            this.lblPromedioTotal.Name = "lblPromedioTotal";
            this.lblPromedioTotal.Size = new System.Drawing.Size(119, 18);
            this.lblPromedioTotal.TabIndex = 14;
            this.lblPromedioTotal.Text = "Promedio total:";
            // 
            // txtTotalClasesAprobadas
            // 
            this.txtTotalClasesAprobadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalClasesAprobadas.Enabled = false;
            this.txtTotalClasesAprobadas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalClasesAprobadas.Location = new System.Drawing.Point(279, 500);
            this.txtTotalClasesAprobadas.Name = "txtTotalClasesAprobadas";
            this.txtTotalClasesAprobadas.Size = new System.Drawing.Size(90, 19);
            this.txtTotalClasesAprobadas.TabIndex = 15;
            // 
            // txtTotalClasesReprobadas
            // 
            this.txtTotalClasesReprobadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalClasesReprobadas.Enabled = false;
            this.txtTotalClasesReprobadas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalClasesReprobadas.Location = new System.Drawing.Point(279, 530);
            this.txtTotalClasesReprobadas.Name = "txtTotalClasesReprobadas";
            this.txtTotalClasesReprobadas.Size = new System.Drawing.Size(90, 19);
            this.txtTotalClasesReprobadas.TabIndex = 16;
            // 
            // txtPromedioTotal
            // 
            this.txtPromedioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPromedioTotal.Enabled = false;
            this.txtPromedioTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedioTotal.Location = new System.Drawing.Point(279, 560);
            this.txtPromedioTotal.Name = "txtPromedioTotal";
            this.txtPromedioTotal.Size = new System.Drawing.Size(90, 19);
            this.txtPromedioTotal.TabIndex = 17;
            // 
            // clase
            // 
            this.clase.HeaderText = "Clase";
            this.clase.Name = "clase";
            this.clase.Width = 150;
            // 
            // primerParcial
            // 
            this.primerParcial.HeaderText = "1er Parcial";
            this.primerParcial.Name = "primerParcial";
            this.primerParcial.Width = 85;
            // 
            // segundoParcial
            // 
            this.segundoParcial.HeaderText = "2do Parcial";
            this.segundoParcial.Name = "segundoParcial";
            this.segundoParcial.Width = 85;
            // 
            // tercerParcial
            // 
            this.tercerParcial.HeaderText = "3er Parcial";
            this.tercerParcial.Name = "tercerParcial";
            this.tercerParcial.Width = 85;
            // 
            // cuartoParcial
            // 
            this.cuartoParcial.HeaderText = "4to Parcial";
            this.cuartoParcial.Name = "cuartoParcial";
            this.cuartoParcial.Width = 85;
            // 
            // promedio
            // 
            this.promedio.HeaderText = "Promedio";
            this.promedio.Name = "promedio";
            this.promedio.Width = 85;
            // 
            // recuperación
            // 
            this.recuperación.HeaderText = "Recuperación";
            this.recuperación.Name = "recuperación";
            this.recuperación.Width = 85;
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
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 718);
            this.Controls.Add(this.lblNotasTítulo);
            this.Controls.Add(this.txtPromedioTotal);
            this.Controls.Add(this.txtTotalClasesReprobadas);
            this.Controls.Add(this.txtTotalClasesAprobadas);
            this.Controls.Add(this.lblPromedioTotal);
            this.Controls.Add(this.lblTotalClasesReprobadas);
            this.Controls.Add(this.lblTotalClasesAprobadas);
            this.Controls.Add(this.dgvNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn tercerParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuartoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn recuperación;
        private System.Windows.Forms.Label lblTotalClasesAprobadas;
        private System.Windows.Forms.Label lblTotalClasesReprobadas;
        private System.Windows.Forms.Label lblPromedioTotal;
        private System.Windows.Forms.TextBox txtTotalClasesAprobadas;
        private System.Windows.Forms.TextBox txtTotalClasesReprobadas;
        private System.Windows.Forms.TextBox txtPromedioTotal;
        private System.Windows.Forms.Label lblNotasTítulo;
    }
}