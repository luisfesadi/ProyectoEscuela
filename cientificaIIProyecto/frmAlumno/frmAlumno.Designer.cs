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
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureUsuario = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.panelSubMenu1 = new System.Windows.Forms.Panel();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.pnlMenúVertical = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).BeginInit();
            this.panelSubMenu1.SuspendLayout();
            this.pnlMenúVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(236, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(784, 631);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(18, 578);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(428, 36);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "sabado 21 de Marzo de 2020";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(21, 497);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(201, 81);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "00:00";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 556);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(56, 56);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureUsuario);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Controls.Add(this.lblApellido);
            this.panel2.Controls.Add(this.lblIdentidad);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 142);
            this.panel2.TabIndex = 3;
            // 
            // pictureUsuario
            // 
            this.pictureUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureUsuario.Image")));
            this.pictureUsuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureUsuario.InitialImage")));
            this.pictureUsuario.Location = new System.Drawing.Point(18, 27);
            this.pictureUsuario.Name = "pictureUsuario";
            this.pictureUsuario.Size = new System.Drawing.Size(81, 82);
            this.pictureUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsuario.TabIndex = 14;
            this.pictureUsuario.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblId.Location = new System.Drawing.Point(118, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 17);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "1";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Location = new System.Drawing.Point(118, 92);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(87, 17);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Lopez Borjas";
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdentidad.Location = new System.Drawing.Point(117, 48);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(99, 17);
            this.lblIdentidad.TabIndex = 11;
            this.lblIdentidad.Text = "0801200006012";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(117, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 17);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Hector Daniel ";
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnCalificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnCalificaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.ForeColor = System.Drawing.Color.White;
            this.btnCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaciones.Location = new System.Drawing.Point(0, 142);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalificaciones.Size = new System.Drawing.Size(236, 45);
            this.btnCalificaciones.TabIndex = 4;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaciones.UseVisualStyleBackColor = false;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // panelSubMenu1
            // 
            this.panelSubMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panelSubMenu1.Controls.Add(this.btnAgregarRegistro);
            this.panelSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu1.Location = new System.Drawing.Point(0, 187);
            this.panelSubMenu1.Name = "panelSubMenu1";
            this.panelSubMenu1.Size = new System.Drawing.Size(236, 42);
            this.panelSubMenu1.TabIndex = 5;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarRegistro.FlatAppearance.BorderSize = 0;
            this.btnAgregarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarRegistro.Size = new System.Drawing.Size(236, 34);
            this.btnAgregarRegistro.TabIndex = 1;
            this.btnAgregarRegistro.Text = "Ver Calificaciones";
            this.btnAgregarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // pnlMenúVertical
            // 
            this.pnlMenúVertical.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlMenúVertical.Controls.Add(this.panelSubMenu1);
            this.pnlMenúVertical.Controls.Add(this.btnCalificaciones);
            this.pnlMenúVertical.Controls.Add(this.panel2);
            this.pnlMenúVertical.Controls.Add(this.btnCerrarSesion);
            this.pnlMenúVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenúVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenúVertical.Name = "pnlMenúVertical";
            this.pnlMenúVertical.Size = new System.Drawing.Size(236, 631);
            this.pnlMenúVertical.TabIndex = 1;
            this.pnlMenúVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenúVertical_Paint);
            this.pnlMenúVertical.MouseHover += new System.EventHandler(this.pnlMenúVertical_MouseHover);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 631);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnlMenúVertical);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAlumno_FormClosed);
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).EndInit();
            this.panelSubMenu1.ResumeLayout(false);
            this.pnlMenúVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureUsuario;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Panel panelSubMenu1;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Panel pnlMenúVertical;
    }
}

