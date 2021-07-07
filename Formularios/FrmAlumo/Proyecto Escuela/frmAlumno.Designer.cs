namespace Proyecto_Escuela
{
    partial class frmAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumno));
            this.pnlBarraTítulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.pnlMenúVertical = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.btnInformación = new System.Windows.Forms.Button();
            this.pnlSubmenúInformación = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.btnVerInformación = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnNotas = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlSubmenúNotas = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnVerNotas = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlBarraTítulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.pnlMenúVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.pnlSubmenúInformación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSubmenúNotas.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraTítulo
            // 
            this.pnlBarraTítulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBarraTítulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTítulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTítulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTítulo.Controls.Add(this.btnRestaurar);
            this.pnlBarraTítulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTítulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTítulo.Name = "pnlBarraTítulo";
            this.pnlBarraTítulo.Size = new System.Drawing.Size(1020, 40);
            this.pnlBarraTítulo.TabIndex = 0;
            this.pnlBarraTítulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTítulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(915, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(19, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(952, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(19, 40);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(989, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 40);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(952, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(19, 40);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pnlMenúVertical
            // 
            this.pnlMenúVertical.BackColor = System.Drawing.Color.Teal;
            this.pnlMenúVertical.Controls.Add(this.pnl3);
            this.pnlMenúVertical.Controls.Add(this.btnCerrarSesion);
            this.pnlMenúVertical.Controls.Add(this.btnInformación);
            this.pnlMenúVertical.Controls.Add(this.pnlSubmenúInformación);
            this.pnlMenúVertical.Controls.Add(this.pnl1);
            this.pnlMenúVertical.Controls.Add(this.btnNotas);
            this.pnlMenúVertical.Controls.Add(this.picLogo);
            this.pnlMenúVertical.Controls.Add(this.pnlSubmenúNotas);
            this.pnlMenúVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenúVertical.Location = new System.Drawing.Point(0, 40);
            this.pnlMenúVertical.Name = "pnlMenúVertical";
            this.pnlMenúVertical.Size = new System.Drawing.Size(220, 718);
            this.pnlMenúVertical.TabIndex = 1;
            this.pnlMenúVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenúVertical_Paint);
            this.pnlMenúVertical.MouseHover += new System.EventHandler(this.pnlMenúVertical_MouseHover);
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.PowderBlue;
            this.pnl3.Location = new System.Drawing.Point(0, 248);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(6, 36);
            this.pnl3.TabIndex = 20;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 650);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(56, 56);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.TabStop = false;
            // 
            // btnInformación
            // 
            this.btnInformación.BackColor = System.Drawing.Color.Transparent;
            this.btnInformación.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInformación.FlatAppearance.BorderSize = 0;
            this.btnInformación.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnInformación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformación.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformación.ForeColor = System.Drawing.Color.White;
            this.btnInformación.Image = ((System.Drawing.Image)(resources.GetObject("btnInformación.Image")));
            this.btnInformación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformación.Location = new System.Drawing.Point(3, 248);
            this.btnInformación.Name = "btnInformación";
            this.btnInformación.Size = new System.Drawing.Size(217, 36);
            this.btnInformación.TabIndex = 21;
            this.btnInformación.Text = "     Información";
            this.btnInformación.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformación.UseVisualStyleBackColor = false;
            this.btnInformación.MouseHover += new System.EventHandler(this.btnInformación_MouseHover);
            // 
            // pnlSubmenúInformación
            // 
            this.pnlSubmenúInformación.BackColor = System.Drawing.Color.Transparent;
            this.pnlSubmenúInformación.Controls.Add(this.pnl4);
            this.pnlSubmenúInformación.Controls.Add(this.btnVerInformación);
            this.pnlSubmenúInformación.Location = new System.Drawing.Point(39, 248);
            this.pnlSubmenúInformación.Name = "pnlSubmenúInformación";
            this.pnlSubmenúInformación.Size = new System.Drawing.Size(181, 85);
            this.pnlSubmenúInformación.TabIndex = 22;
            this.pnlSubmenúInformación.Visible = false;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.PowderBlue;
            this.pnl4.Location = new System.Drawing.Point(0, 42);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(6, 32);
            this.pnl4.TabIndex = 12;
            // 
            // btnVerInformación
            // 
            this.btnVerInformación.BackColor = System.Drawing.Color.Transparent;
            this.btnVerInformación.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerInformación.FlatAppearance.BorderSize = 0;
            this.btnVerInformación.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnVerInformación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerInformación.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInformación.ForeColor = System.Drawing.Color.White;
            this.btnVerInformación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerInformación.Location = new System.Drawing.Point(3, 42);
            this.btnVerInformación.Name = "btnVerInformación";
            this.btnVerInformación.Size = new System.Drawing.Size(178, 32);
            this.btnVerInformación.TabIndex = 13;
            this.btnVerInformación.Text = "Ver información";
            this.btnVerInformación.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerInformación.UseVisualStyleBackColor = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.PowderBlue;
            this.pnl1.Location = new System.Drawing.Point(0, 157);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(6, 36);
            this.pnl1.TabIndex = 7;
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnNotas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnNotas.Image")));
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(3, 157);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(217, 36);
            this.btnNotas.TabIndex = 10;
            this.btnNotas.Text = "     Notas";
            this.btnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.MouseHover += new System.EventHandler(this.btnNotas_MouseHover);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(55, 19);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(113, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // pnlSubmenúNotas
            // 
            this.pnlSubmenúNotas.BackColor = System.Drawing.Color.Transparent;
            this.pnlSubmenúNotas.Controls.Add(this.pnl2);
            this.pnlSubmenúNotas.Controls.Add(this.btnVerNotas);
            this.pnlSubmenúNotas.Location = new System.Drawing.Point(39, 157);
            this.pnlSubmenúNotas.Name = "pnlSubmenúNotas";
            this.pnlSubmenúNotas.Size = new System.Drawing.Size(181, 85);
            this.pnlSubmenúNotas.TabIndex = 19;
            this.pnlSubmenúNotas.Visible = false;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.PowderBlue;
            this.pnl2.Location = new System.Drawing.Point(0, 42);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(6, 32);
            this.pnl2.TabIndex = 12;
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerNotas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerNotas.FlatAppearance.BorderSize = 0;
            this.btnVerNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnVerNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerNotas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerNotas.ForeColor = System.Drawing.Color.White;
            this.btnVerNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerNotas.Location = new System.Drawing.Point(3, 42);
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Size = new System.Drawing.Size(178, 32);
            this.btnVerNotas.TabIndex = 13;
            this.btnVerNotas.Text = "Ver notas";
            this.btnVerNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerNotas.UseVisualStyleBackColor = false;
            this.btnVerNotas.Click += new System.EventHandler(this.btnVerNotas_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(3, 673);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(428, 36);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "sabado 21 de Marzo de 2020";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(6, 592);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(201, 81);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "00:00";
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.lblFecha);
            this.pnlContenedor.Controls.Add(this.lblHora);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(220, 40);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 718);
            this.pnlContenedor.TabIndex = 4;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 758);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenúVertical);
            this.Controls.Add(this.pnlBarraTítulo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.pnlBarraTítulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.pnlMenúVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.pnlSubmenúInformación.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSubmenúNotas.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTítulo;
        private System.Windows.Forms.Panel pnlMenúVertical;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Panel pnlSubmenúNotas;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnVerNotas;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Button btnInformación;
        private System.Windows.Forms.Panel pnlSubmenúInformación;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Button btnVerInformación;
    }
}

