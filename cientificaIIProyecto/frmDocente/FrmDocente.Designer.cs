namespace FrmDocente
{
    partial class FrmDocente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocente));
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SubmenuNotas = new System.Windows.Forms.Panel();
            this.btnRecuperacion = new System.Windows.Forms.Button();
            this.btn4toParcial = new System.Windows.Forms.Button();
            this.btn3erParcial = new System.Windows.Forms.Button();
            this.btn2doParcial = new System.Windows.Forms.Button();
            this.btn1erParcial = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureUsuario = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Buho = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelHoraFecha = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenuVertical.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SubmenuNotas.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buho)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panelHoraFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.AutoScroll = true;
            this.panelMenuVertical.BackColor = System.Drawing.Color.DarkCyan;
            this.panelMenuVertical.Controls.Add(this.panel1);
            this.panelMenuVertical.Controls.Add(this.SubmenuNotas);
            this.panelMenuVertical.Controls.Add(this.btnNotas);
            this.panelMenuVertical.Controls.Add(this.panelLogo);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(250, 749);
            this.panelMenuVertical.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 5;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(17, 14);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(64, 66);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // SubmenuNotas
            // 
            this.SubmenuNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SubmenuNotas.Controls.Add(this.btnRecuperacion);
            this.SubmenuNotas.Controls.Add(this.btn4toParcial);
            this.SubmenuNotas.Controls.Add(this.btn3erParcial);
            this.SubmenuNotas.Controls.Add(this.btn2doParcial);
            this.SubmenuNotas.Controls.Add(this.btn1erParcial);
            this.SubmenuNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuNotas.Location = new System.Drawing.Point(0, 180);
            this.SubmenuNotas.Name = "SubmenuNotas";
            this.SubmenuNotas.Size = new System.Drawing.Size(250, 168);
            this.SubmenuNotas.TabIndex = 1;
            // 
            // btnRecuperacion
            // 
            this.btnRecuperacion.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuperacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecuperacion.FlatAppearance.BorderSize = 0;
            this.btnRecuperacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRecuperacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRecuperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperacion.ForeColor = System.Drawing.Color.White;
            this.btnRecuperacion.Location = new System.Drawing.Point(0, 128);
            this.btnRecuperacion.Name = "btnRecuperacion";
            this.btnRecuperacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRecuperacion.Size = new System.Drawing.Size(250, 32);
            this.btnRecuperacion.TabIndex = 5;
            this.btnRecuperacion.Text = "Nota Recuperación";
            this.btnRecuperacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecuperacion.UseVisualStyleBackColor = false;
            this.btnRecuperacion.Click += new System.EventHandler(this.btnRecuperacion_Click);
            // 
            // btn4toParcial
            // 
            this.btn4toParcial.BackColor = System.Drawing.Color.Transparent;
            this.btn4toParcial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn4toParcial.FlatAppearance.BorderSize = 0;
            this.btn4toParcial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn4toParcial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn4toParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4toParcial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4toParcial.ForeColor = System.Drawing.Color.White;
            this.btn4toParcial.Location = new System.Drawing.Point(0, 96);
            this.btn4toParcial.Name = "btn4toParcial";
            this.btn4toParcial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn4toParcial.Size = new System.Drawing.Size(250, 32);
            this.btn4toParcial.TabIndex = 4;
            this.btn4toParcial.Text = "Nota 4to Parcial";
            this.btn4toParcial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4toParcial.UseVisualStyleBackColor = false;
            this.btn4toParcial.Click += new System.EventHandler(this.btn4toParcial_Click);
            // 
            // btn3erParcial
            // 
            this.btn3erParcial.BackColor = System.Drawing.Color.Transparent;
            this.btn3erParcial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn3erParcial.FlatAppearance.BorderSize = 0;
            this.btn3erParcial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn3erParcial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn3erParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3erParcial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3erParcial.ForeColor = System.Drawing.Color.White;
            this.btn3erParcial.Location = new System.Drawing.Point(0, 64);
            this.btn3erParcial.Name = "btn3erParcial";
            this.btn3erParcial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn3erParcial.Size = new System.Drawing.Size(250, 32);
            this.btn3erParcial.TabIndex = 3;
            this.btn3erParcial.Text = "Nota 3er Parcial";
            this.btn3erParcial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3erParcial.UseVisualStyleBackColor = false;
            this.btn3erParcial.Click += new System.EventHandler(this.btn3erParcial_Click);
            // 
            // btn2doParcial
            // 
            this.btn2doParcial.BackColor = System.Drawing.Color.Transparent;
            this.btn2doParcial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn2doParcial.FlatAppearance.BorderSize = 0;
            this.btn2doParcial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn2doParcial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn2doParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2doParcial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2doParcial.ForeColor = System.Drawing.Color.White;
            this.btn2doParcial.Location = new System.Drawing.Point(0, 32);
            this.btn2doParcial.Name = "btn2doParcial";
            this.btn2doParcial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn2doParcial.Size = new System.Drawing.Size(250, 32);
            this.btn2doParcial.TabIndex = 2;
            this.btn2doParcial.Text = "Nota 2do Parcial";
            this.btn2doParcial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2doParcial.UseVisualStyleBackColor = false;
            this.btn2doParcial.Click += new System.EventHandler(this.btnListarNotas_Click);
            // 
            // btn1erParcial
            // 
            this.btn1erParcial.BackColor = System.Drawing.Color.Transparent;
            this.btn1erParcial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1erParcial.FlatAppearance.BorderSize = 0;
            this.btn1erParcial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn1erParcial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn1erParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1erParcial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1erParcial.ForeColor = System.Drawing.Color.White;
            this.btn1erParcial.Location = new System.Drawing.Point(0, 0);
            this.btn1erParcial.Name = "btn1erParcial";
            this.btn1erParcial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn1erParcial.Size = new System.Drawing.Size(250, 32);
            this.btn1erParcial.TabIndex = 1;
            this.btn1erParcial.Text = "Nota 1er Parcial";
            this.btn1erParcial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1erParcial.UseVisualStyleBackColor = false;
            this.btn1erParcial.Click += new System.EventHandler(this.btnIngresarNotas_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(0, 140);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNotas.Size = new System.Drawing.Size(250, 40);
            this.btnNotas.TabIndex = 0;
            this.btnNotas.Text = "Notas";
            this.btnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.pictureUsuario);
            this.panelLogo.Controls.Add(this.lblId);
            this.panelLogo.Controls.Add(this.lblApellido);
            this.panelLogo.Controls.Add(this.lblIdentidad);
            this.panelLogo.Controls.Add(this.lblNombre);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureUsuario
            // 
            this.pictureUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureUsuario.Image")));
            this.pictureUsuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureUsuario.InitialImage")));
            this.pictureUsuario.Location = new System.Drawing.Point(26, 27);
            this.pictureUsuario.Name = "pictureUsuario";
            this.pictureUsuario.Size = new System.Drawing.Size(81, 84);
            this.pictureUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsuario.TabIndex = 4;
            this.pictureUsuario.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblId.Location = new System.Drawing.Point(126, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 17);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "1";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Location = new System.Drawing.Point(126, 92);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(87, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Lopez Borjas";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdentidad.Location = new System.Drawing.Point(125, 48);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(99, 17);
            this.lblIdentidad.TabIndex = 1;
            this.lblIdentidad.Text = "0801200006012";
            this.lblIdentidad.Click += new System.EventHandler(this.lblIdentidad_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(125, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Hector Daniel ";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // Buho
            // 
            this.Buho.Image = ((System.Drawing.Image)(resources.GetObject("Buho.Image")));
            this.Buho.Location = new System.Drawing.Point(249, 170);
            this.Buho.Name = "Buho";
            this.Buho.Size = new System.Drawing.Size(321, 292);
            this.Buho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Buho.TabIndex = 1;
            this.Buho.TabStop = false;
            this.Buho.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.Buho);
            this.panelContenedor.Controls.Add(this.panelHoraFecha);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(834, 749);
            this.panelContenedor.TabIndex = 4;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelHoraFecha
            // 
            this.panelHoraFecha.Controls.Add(this.lblFecha);
            this.panelHoraFecha.Controls.Add(this.lblHora);
            this.panelHoraFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHoraFecha.Location = new System.Drawing.Point(0, 617);
            this.panelHoraFecha.Name = "panelHoraFecha";
            this.panelHoraFecha.Size = new System.Drawing.Size(834, 132);
            this.panelHoraFecha.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(0, 81);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(428, 36);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "sabado 21 de Marzo de 2020";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(0, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(201, 81);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(786, 630);
            this.Name = "FrmDocente";
            this.Text = "Docente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDocente_FormClosed);
            this.Load += new System.EventHandler(this.FrmDocente_Load);
            this.panelMenuVertical.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SubmenuNotas.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buho)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelHoraFecha.ResumeLayout(false);
            this.panelHoraFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SubmenuNotas;
        private System.Windows.Forms.Button btn2doParcial;
        private System.Windows.Forms.Button btn1erParcial;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Buho;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.PictureBox pictureUsuario;
        private System.Windows.Forms.Panel panelHoraFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnRecuperacion;
        private System.Windows.Forms.Button btn4toParcial;
        private System.Windows.Forms.Button btn3erParcial;
        public System.Windows.Forms.Label lblId;
    }
}

