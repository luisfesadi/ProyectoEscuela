namespace Registro
{
    partial class FrmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.pnlBarraTítulo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlMenúVertical = new System.Windows.Forms.Panel();
            this.SubMenuAlumnos = new System.Windows.Forms.Panel();
            this.btnConsultarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnEditarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SubMenuDocentes = new System.Windows.Forms.Panel();
            this.btnConsultarDocente = new System.Windows.Forms.Button();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnEditarDocente = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.SubMenuRegistro = new System.Windows.Forms.Panel();
            this.btnConsultarRegistro = new System.Windows.Forms.Button();
            this.btnEliminarRegsitro = new System.Windows.Forms.Button();
            this.btnEditarRegistro = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.pnlBarraTítulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.pnlMenúVertical.SuspendLayout();
            this.SubMenuAlumnos.SuspendLayout();
            this.SubMenuDocentes.SuspendLayout();
            this.SubMenuRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTítulo
            // 
            this.pnlBarraTítulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBarraTítulo.Controls.Add(this.panel4);
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
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(226, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 376);
            this.panel4.TabIndex = 4;
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
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(223, 287);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(201, 81);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(223, 251);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(428, 36);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "sabado 21 de Marzo de 2020";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Location = new System.Drawing.Point(226, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(794, 416);
            this.panelContenedor.TabIndex = 4;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pnlMenúVertical
            // 
            this.pnlMenúVertical.AutoScroll = true;
            this.pnlMenúVertical.BackColor = System.Drawing.Color.Teal;
            this.pnlMenúVertical.Controls.Add(this.SubMenuAlumnos);
            this.pnlMenúVertical.Controls.Add(this.button1);
            this.pnlMenúVertical.Controls.Add(this.SubMenuDocentes);
            this.pnlMenúVertical.Controls.Add(this.btnDocentes);
            this.pnlMenúVertical.Controls.Add(this.SubMenuRegistro);
            this.pnlMenúVertical.Controls.Add(this.btnRegistro);
            this.pnlMenúVertical.Controls.Add(this.panelLogo);
            this.pnlMenúVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenúVertical.Location = new System.Drawing.Point(0, 40);
            this.pnlMenúVertical.Name = "pnlMenúVertical";
            this.pnlMenúVertical.Size = new System.Drawing.Size(220, 709);
            this.pnlMenúVertical.TabIndex = 7;
            this.pnlMenúVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenúVertical_Paint_1);
            // 
            // SubMenuAlumnos
            // 
            this.SubMenuAlumnos.BackColor = System.Drawing.Color.PowderBlue;
            this.SubMenuAlumnos.Controls.Add(this.btnConsultarAlumno);
            this.SubMenuAlumnos.Controls.Add(this.btnEliminarAlumno);
            this.SubMenuAlumnos.Controls.Add(this.btnEditarAlumno);
            this.SubMenuAlumnos.Controls.Add(this.btnAgregarAlumno);
            this.SubMenuAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuAlumnos.Location = new System.Drawing.Point(0, 516);
            this.SubMenuAlumnos.Name = "SubMenuAlumnos";
            this.SubMenuAlumnos.Size = new System.Drawing.Size(220, 164);
            this.SubMenuAlumnos.TabIndex = 8;
            // 
            // btnConsultarAlumno
            // 
            this.btnConsultarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarAlumno.FlatAppearance.BorderSize = 0;
            this.btnConsultarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnConsultarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAlumno.Location = new System.Drawing.Point(0, 120);
            this.btnConsultarAlumno.Name = "btnConsultarAlumno";
            this.btnConsultarAlumno.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarAlumno.Size = new System.Drawing.Size(220, 40);
            this.btnConsultarAlumno.TabIndex = 18;
            this.btnConsultarAlumno.Text = "Consultar";
            this.btnConsultarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAlumno.UseVisualStyleBackColor = false;
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarAlumno.FlatAppearance.BorderSize = 0;
            this.btnEliminarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(0, 80);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarAlumno.Size = new System.Drawing.Size(220, 40);
            this.btnEliminarAlumno.TabIndex = 17;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarAlumno.UseVisualStyleBackColor = false;
            // 
            // btnEditarAlumno
            // 
            this.btnEditarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarAlumno.FlatAppearance.BorderSize = 0;
            this.btnEditarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnEditarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnEditarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAlumno.Location = new System.Drawing.Point(0, 40);
            this.btnEditarAlumno.Name = "btnEditarAlumno";
            this.btnEditarAlumno.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditarAlumno.Size = new System.Drawing.Size(220, 40);
            this.btnEditarAlumno.TabIndex = 16;
            this.btnEditarAlumno.Text = "Editar";
            this.btnEditarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAlumno.UseVisualStyleBackColor = false;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarAlumno.Size = new System.Drawing.Size(220, 40);
            this.btnAgregarAlumno.TabIndex = 15;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAlumno.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Alumnos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SubMenuDocentes
            // 
            this.SubMenuDocentes.BackColor = System.Drawing.Color.PowderBlue;
            this.SubMenuDocentes.Controls.Add(this.btnConsultarDocente);
            this.SubMenuDocentes.Controls.Add(this.btnEliminarDocente);
            this.SubMenuDocentes.Controls.Add(this.btnEditarDocente);
            this.SubMenuDocentes.Controls.Add(this.btnAgregarDocente);
            this.SubMenuDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuDocentes.Location = new System.Drawing.Point(0, 307);
            this.SubMenuDocentes.Name = "SubMenuDocentes";
            this.SubMenuDocentes.Size = new System.Drawing.Size(220, 164);
            this.SubMenuDocentes.TabIndex = 6;
            // 
            // btnConsultarDocente
            // 
            this.btnConsultarDocente.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarDocente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarDocente.FlatAppearance.BorderSize = 0;
            this.btnConsultarDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnConsultarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarDocente.ForeColor = System.Drawing.Color.White;
            this.btnConsultarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarDocente.Location = new System.Drawing.Point(0, 120);
            this.btnConsultarDocente.Name = "btnConsultarDocente";
            this.btnConsultarDocente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarDocente.Size = new System.Drawing.Size(220, 40);
            this.btnConsultarDocente.TabIndex = 18;
            this.btnConsultarDocente.Text = "Consultar";
            this.btnConsultarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarDocente.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarDocente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarDocente.FlatAppearance.BorderSize = 0;
            this.btnEliminarDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnEliminarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDocente.Location = new System.Drawing.Point(0, 80);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarDocente.Size = new System.Drawing.Size(220, 40);
            this.btnEliminarDocente.TabIndex = 17;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDocente.UseVisualStyleBackColor = false;
            // 
            // btnEditarDocente
            // 
            this.btnEditarDocente.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarDocente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarDocente.FlatAppearance.BorderSize = 0;
            this.btnEditarDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnEditarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDocente.ForeColor = System.Drawing.Color.White;
            this.btnEditarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarDocente.Location = new System.Drawing.Point(0, 40);
            this.btnEditarDocente.Name = "btnEditarDocente";
            this.btnEditarDocente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditarDocente.Size = new System.Drawing.Size(220, 40);
            this.btnEditarDocente.TabIndex = 16;
            this.btnEditarDocente.Text = "Editar";
            this.btnEditarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarDocente.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDocente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDocente.FlatAppearance.BorderSize = 0;
            this.btnAgregarDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDocente.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarDocente.Size = new System.Drawing.Size(220, 40);
            this.btnAgregarDocente.TabIndex = 15;
            this.btnAgregarDocente.Text = "Agregar";
            this.btnAgregarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDocente.UseVisualStyleBackColor = false;
            // 
            // btnDocentes
            // 
            this.btnDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnDocentes.Image")));
            this.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.Location = new System.Drawing.Point(0, 262);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(220, 45);
            this.btnDocentes.TabIndex = 5;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // SubMenuRegistro
            // 
            this.SubMenuRegistro.BackColor = System.Drawing.Color.PowderBlue;
            this.SubMenuRegistro.Controls.Add(this.btnConsultarRegistro);
            this.SubMenuRegistro.Controls.Add(this.btnEliminarRegsitro);
            this.SubMenuRegistro.Controls.Add(this.btnEditarRegistro);
            this.SubMenuRegistro.Controls.Add(this.btnAgregarRegistro);
            this.SubMenuRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuRegistro.Location = new System.Drawing.Point(0, 98);
            this.SubMenuRegistro.Name = "SubMenuRegistro";
            this.SubMenuRegistro.Size = new System.Drawing.Size(220, 164);
            this.SubMenuRegistro.TabIndex = 4;
            // 
            // btnConsultarRegistro
            // 
            this.btnConsultarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarRegistro.FlatAppearance.BorderSize = 0;
            this.btnConsultarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnConsultarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnConsultarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarRegistro.Location = new System.Drawing.Point(0, 120);
            this.btnConsultarRegistro.Name = "btnConsultarRegistro";
            this.btnConsultarRegistro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarRegistro.Size = new System.Drawing.Size(220, 40);
            this.btnConsultarRegistro.TabIndex = 18;
            this.btnConsultarRegistro.Text = "Consultar";
            this.btnConsultarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarRegistro.UseVisualStyleBackColor = false;
            // 
            // btnEliminarRegsitro
            // 
            this.btnEliminarRegsitro.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarRegsitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarRegsitro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarRegsitro.FlatAppearance.BorderSize = 0;
            this.btnEliminarRegsitro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnEliminarRegsitro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRegsitro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegsitro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegsitro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegsitro.Location = new System.Drawing.Point(0, 80);
            this.btnEliminarRegsitro.Name = "btnEliminarRegsitro";
            this.btnEliminarRegsitro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarRegsitro.Size = new System.Drawing.Size(220, 40);
            this.btnEliminarRegsitro.TabIndex = 17;
            this.btnEliminarRegsitro.Text = "Eliminar";
            this.btnEliminarRegsitro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegsitro.UseVisualStyleBackColor = false;
            // 
            // btnEditarRegistro
            // 
            this.btnEditarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarRegistro.FlatAppearance.BorderSize = 0;
            this.btnEditarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnEditarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnEditarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarRegistro.Location = new System.Drawing.Point(0, 40);
            this.btnEditarRegistro.Name = "btnEditarRegistro";
            this.btnEditarRegistro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditarRegistro.Size = new System.Drawing.Size(220, 40);
            this.btnEditarRegistro.TabIndex = 16;
            this.btnEditarRegistro.Text = "Editar";
            this.btnEditarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarRegistro.UseVisualStyleBackColor = false;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarRegistro.FlatAppearance.BorderSize = 0;
            this.btnAgregarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarRegistro.Size = new System.Drawing.Size(220, 40);
            this.btnAgregarRegistro.TabIndex = 15;
            this.btnAgregarRegistro.Text = "Agregar";
            this.btnAgregarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 53);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(220, 45);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 53);
            this.panelLogo.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(272, 652);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(56, 56);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.TabStop = false;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 749);
            this.Controls.Add(this.pnlMenúVertical);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnlBarraTítulo);
            this.Controls.Add(this.btnCerrarSesion);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAdministrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.pnlBarraTítulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.pnlMenúVertical.ResumeLayout(false);
            this.SubMenuAlumnos.ResumeLayout(false);
            this.SubMenuDocentes.ResumeLayout(false);
            this.SubMenuRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTítulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnlMenúVertical;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SubMenuDocentes;
        private System.Windows.Forms.Button btnConsultarDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnEditarDocente;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Panel SubMenuRegistro;
        private System.Windows.Forms.Button btnConsultarRegistro;
        private System.Windows.Forms.Button btnEliminarRegsitro;
        private System.Windows.Forms.Button btnEditarRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.Panel SubMenuAlumnos;
        private System.Windows.Forms.Button btnConsultarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnEditarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
    }
}

