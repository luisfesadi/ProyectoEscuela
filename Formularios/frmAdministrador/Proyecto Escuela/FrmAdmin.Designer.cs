namespace Registro
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.btnAsignacion = new System.Windows.Forms.Button();
            this.SubmenuDocentes = new System.Windows.Forms.Panel();
            this.btnConsultarDocentes = new System.Windows.Forms.Button();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnEditarDocentes = new System.Windows.Forms.Button();
            this.btnAgregarDocentes = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.SubmenuRegistro = new System.Windows.Forms.Panel();
            this.btnConsultarRegistro = new System.Windows.Forms.Button();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnEditarRegistro = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnEditarAsignacion = new System.Windows.Forms.Button();
            this.btnAgregarAsignacion = new System.Windows.Forms.Button();
            this.SubmenuAsignacion = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SubmenuEncargados = new System.Windows.Forms.Panel();
            this.btnConsultarEncargados = new System.Windows.Forms.Button();
            this.btnEliminarEncargados = new System.Windows.Forms.Button();
            this.btnEditarEncargados = new System.Windows.Forms.Button();
            this.btnAgregarEncargados = new System.Windows.Forms.Button();
            this.btnEncargados = new System.Windows.Forms.Button();
            this.btnAgregarAlumnos = new System.Windows.Forms.Button();
            this.btnEditarAlumnos = new System.Windows.Forms.Button();
            this.btnEliminarAlumnos = new System.Windows.Forms.Button();
            this.btnConsultarAlumnos = new System.Windows.Forms.Button();
            this.SubmenuAlumnos = new System.Windows.Forms.Panel();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenuVertical.SuspendLayout();
            this.SubmenuDocentes.SuspendLayout();
            this.SubmenuRegistro.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SubmenuAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SubmenuEncargados.SuspendLayout();
            this.SubmenuAlumnos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.AutoScroll = true;
            this.panelMenuVertical.BackColor = System.Drawing.Color.DarkCyan;
            this.panelMenuVertical.Controls.Add(this.panel1);
            this.panelMenuVertical.Controls.Add(this.SubmenuEncargados);
            this.panelMenuVertical.Controls.Add(this.btnEncargados);
            this.panelMenuVertical.Controls.Add(this.SubmenuAlumnos);
            this.panelMenuVertical.Controls.Add(this.btnAlumnos);
            this.panelMenuVertical.Controls.Add(this.SubmenuAsignacion);
            this.panelMenuVertical.Controls.Add(this.btnAsignacion);
            this.panelMenuVertical.Controls.Add(this.SubmenuDocentes);
            this.panelMenuVertical.Controls.Add(this.btnDocentes);
            this.panelMenuVertical.Controls.Add(this.SubmenuRegistro);
            this.panelMenuVertical.Controls.Add(this.btnRegistro);
            this.panelMenuVertical.Controls.Add(this.panelLogo);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(250, 749);
            this.panelMenuVertical.TabIndex = 0;
            this.panelMenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuVertical_Paint);
            // 
            // btnAsignacion
            // 
            this.btnAsignacion.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignacion.FlatAppearance.BorderSize = 0;
            this.btnAsignacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAsignacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignacion.ForeColor = System.Drawing.Color.White;
            this.btnAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignacion.Location = new System.Drawing.Point(0, 588);
            this.btnAsignacion.Name = "btnAsignacion";
            this.btnAsignacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsignacion.Size = new System.Drawing.Size(233, 40);
            this.btnAsignacion.TabIndex = 4;
            this.btnAsignacion.Text = "Asignacion de Clases";
            this.btnAsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignacion.UseVisualStyleBackColor = false;
            this.btnAsignacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubmenuDocentes
            // 
            this.SubmenuDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SubmenuDocentes.Controls.Add(this.btnConsultarDocentes);
            this.SubmenuDocentes.Controls.Add(this.btnEliminarDocentes);
            this.SubmenuDocentes.Controls.Add(this.btnEditarDocentes);
            this.SubmenuDocentes.Controls.Add(this.btnAgregarDocentes);
            this.SubmenuDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuDocentes.Location = new System.Drawing.Point(0, 468);
            this.SubmenuDocentes.Name = "SubmenuDocentes";
            this.SubmenuDocentes.Size = new System.Drawing.Size(233, 120);
            this.SubmenuDocentes.TabIndex = 3;
            // 
            // btnConsultarDocentes
            // 
            this.btnConsultarDocentes.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarDocentes.FlatAppearance.BorderSize = 0;
            this.btnConsultarDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarDocentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarDocentes.Location = new System.Drawing.Point(0, 84);
            this.btnConsultarDocentes.Name = "btnConsultarDocentes";
            this.btnConsultarDocentes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarDocentes.Size = new System.Drawing.Size(233, 28);
            this.btnConsultarDocentes.TabIndex = 4;
            this.btnConsultarDocentes.Text = "Consultar";
            this.btnConsultarDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarDocentes.UseVisualStyleBackColor = false;
            this.btnConsultarDocentes.Click += new System.EventHandler(this.btnConsultarDocentes_Click);
            // 
            // btnEliminarDocentes
            // 
            this.btnEliminarDocentes.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarDocentes.FlatAppearance.BorderSize = 0;
            this.btnEliminarDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDocentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDocentes.Location = new System.Drawing.Point(0, 56);
            this.btnEliminarDocentes.Name = "btnEliminarDocentes";
            this.btnEliminarDocentes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarDocentes.Size = new System.Drawing.Size(233, 28);
            this.btnEliminarDocentes.TabIndex = 3;
            this.btnEliminarDocentes.Text = "Eliminar";
            this.btnEliminarDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDocentes.UseVisualStyleBackColor = false;
            this.btnEliminarDocentes.Click += new System.EventHandler(this.btnEliminarDocentes_Click);
            // 
            // btnEditarDocentes
            // 
            this.btnEditarDocentes.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarDocentes.FlatAppearance.BorderSize = 0;
            this.btnEditarDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDocentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnEditarDocentes.Location = new System.Drawing.Point(0, 28);
            this.btnEditarDocentes.Name = "btnEditarDocentes";
            this.btnEditarDocentes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditarDocentes.Size = new System.Drawing.Size(233, 28);
            this.btnEditarDocentes.TabIndex = 2;
            this.btnEditarDocentes.Text = "Editar";
            this.btnEditarDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarDocentes.UseVisualStyleBackColor = false;
            this.btnEditarDocentes.Click += new System.EventHandler(this.btnEditarDocentes_Click);
            // 
            // btnAgregarDocentes
            // 
            this.btnAgregarDocentes.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDocentes.FlatAppearance.BorderSize = 0;
            this.btnAgregarDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDocentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDocentes.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarDocentes.Name = "btnAgregarDocentes";
            this.btnAgregarDocentes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarDocentes.Size = new System.Drawing.Size(233, 28);
            this.btnAgregarDocentes.TabIndex = 1;
            this.btnAgregarDocentes.Text = "Agregar";
            this.btnAgregarDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDocentes.UseVisualStyleBackColor = false;
            this.btnAgregarDocentes.Click += new System.EventHandler(this.btnAgregarDocentes_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.BackColor = System.Drawing.Color.Transparent;
            this.btnDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.Location = new System.Drawing.Point(0, 428);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDocentes.Size = new System.Drawing.Size(233, 40);
            this.btnDocentes.TabIndex = 2;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.UseVisualStyleBackColor = false;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // SubmenuRegistro
            // 
            this.SubmenuRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SubmenuRegistro.Controls.Add(this.btnConsultarRegistro);
            this.SubmenuRegistro.Controls.Add(this.btnEliminarRegistro);
            this.SubmenuRegistro.Controls.Add(this.btnEditarRegistro);
            this.SubmenuRegistro.Controls.Add(this.btnAgregarRegistro);
            this.SubmenuRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuRegistro.Location = new System.Drawing.Point(0, 308);
            this.SubmenuRegistro.Name = "SubmenuRegistro";
            this.SubmenuRegistro.Size = new System.Drawing.Size(233, 120);
            this.SubmenuRegistro.TabIndex = 1;
            // 
            // btnConsultarRegistro
            // 
            this.btnConsultarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarRegistro.FlatAppearance.BorderSize = 0;
            this.btnConsultarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnConsultarRegistro.Location = new System.Drawing.Point(0, 84);
            this.btnConsultarRegistro.Name = "btnConsultarRegistro";
            this.btnConsultarRegistro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarRegistro.Size = new System.Drawing.Size(233, 28);
            this.btnConsultarRegistro.TabIndex = 4;
            this.btnConsultarRegistro.Text = "Consultar";
            this.btnConsultarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarRegistro.UseVisualStyleBackColor = false;
            this.btnConsultarRegistro.Click += new System.EventHandler(this.btnConsultarRegistro_Click);
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarRegistro.FlatAppearance.BorderSize = 0;
            this.btnEliminarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(0, 56);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarRegistro.Size = new System.Drawing.Size(233, 28);
            this.btnEliminarRegistro.TabIndex = 3;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnEditarRegistro
            // 
            this.btnEditarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarRegistro.FlatAppearance.BorderSize = 0;
            this.btnEditarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnEditarRegistro.Location = new System.Drawing.Point(0, 28);
            this.btnEditarRegistro.Name = "btnEditarRegistro";
            this.btnEditarRegistro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditarRegistro.Size = new System.Drawing.Size(233, 28);
            this.btnEditarRegistro.TabIndex = 2;
            this.btnEditarRegistro.Text = "Editar";
            this.btnEditarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarRegistro.UseVisualStyleBackColor = false;
            this.btnEditarRegistro.Click += new System.EventHandler(this.btnEditarRegistro_Click);
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
            this.btnAgregarRegistro.Size = new System.Drawing.Size(233, 28);
            this.btnAgregarRegistro.TabIndex = 1;
            this.btnAgregarRegistro.Text = "Agregar";
            this.btnAgregarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 268);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegistro.Size = new System.Drawing.Size(233, 40);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 268);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(834, 749);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // btnEditarAsignacion
            // 
            this.btnEditarAsignacion.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAsignacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarAsignacion.FlatAppearance.BorderSize = 0;
            this.btnEditarAsignacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarAsignacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAsignacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAsignacion.ForeColor = System.Drawing.Color.White;
            this.btnEditarAsignacion.Location = new System.Drawing.Point(0, 28);
            this.btnEditarAsignacion.Name = "btnEditarAsignacion";
            this.btnEditarAsignacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditarAsignacion.Size = new System.Drawing.Size(233, 28);
            this.btnEditarAsignacion.TabIndex = 2;
            this.btnEditarAsignacion.Text = "Editar";
            this.btnEditarAsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAsignacion.UseVisualStyleBackColor = false;
            this.btnEditarAsignacion.Click += new System.EventHandler(this.btnEditarAsignacion_Click);
            // 
            // btnAgregarAsignacion
            // 
            this.btnAgregarAsignacion.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAsignacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarAsignacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarAsignacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarAsignacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAsignacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAsignacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAsignacion.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarAsignacion.Name = "btnAgregarAsignacion";
            this.btnAgregarAsignacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarAsignacion.Size = new System.Drawing.Size(233, 28);
            this.btnAgregarAsignacion.TabIndex = 1;
            this.btnAgregarAsignacion.Text = "Agregar";
            this.btnAgregarAsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAsignacion.UseVisualStyleBackColor = false;
            this.btnAgregarAsignacion.Click += new System.EventHandler(this.btnAgregarAsignacion_Click);
            // 
            // SubmenuAsignacion
            // 
            this.SubmenuAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SubmenuAsignacion.Controls.Add(this.btnEditarAsignacion);
            this.SubmenuAsignacion.Controls.Add(this.btnAgregarAsignacion);
            this.SubmenuAsignacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuAsignacion.Location = new System.Drawing.Point(0, 628);
            this.SubmenuAsignacion.Name = "SubmenuAsignacion";
            this.SubmenuAsignacion.Size = new System.Drawing.Size(233, 65);
            this.SubmenuAsignacion.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // SubmenuEncargados
            // 
            this.SubmenuEncargados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SubmenuEncargados.Controls.Add(this.btnConsultarEncargados);
            this.SubmenuEncargados.Controls.Add(this.btnEliminarEncargados);
            this.SubmenuEncargados.Controls.Add(this.btnEditarEncargados);
            this.SubmenuEncargados.Controls.Add(this.btnAgregarEncargados);
            this.SubmenuEncargados.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuEncargados.Location = new System.Drawing.Point(0, 893);
            this.SubmenuEncargados.Name = "SubmenuEncargados";
            this.SubmenuEncargados.Size = new System.Drawing.Size(233, 120);
            this.SubmenuEncargados.TabIndex = 16;
            // 
            // btnConsultarEncargados
            // 
            this.btnConsultarEncargados.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarEncargados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarEncargados.FlatAppearance.BorderSize = 0;
            this.btnConsultarEncargados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultarEncargados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultarEncargados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEncargados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEncargados.ForeColor = System.Drawing.Color.White;
            this.btnConsultarEncargados.Location = new System.Drawing.Point(0, 84);
            this.btnConsultarEncargados.Name = "btnConsultarEncargados";
            this.btnConsultarEncargados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarEncargados.Size = new System.Drawing.Size(233, 28);
            this.btnConsultarEncargados.TabIndex = 4;
            this.btnConsultarEncargados.Text = "Consultar";
            this.btnConsultarEncargados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEncargados.UseVisualStyleBackColor = false;
            this.btnConsultarEncargados.Click += new System.EventHandler(this.btnConsultarEncargados_Click_1);
            // 
            // btnEliminarEncargados
            // 
            this.btnEliminarEncargados.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarEncargados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarEncargados.FlatAppearance.BorderSize = 0;
            this.btnEliminarEncargados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminarEncargados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminarEncargados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEncargados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEncargados.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEncargados.Location = new System.Drawing.Point(0, 56);
            this.btnEliminarEncargados.Name = "btnEliminarEncargados";
            this.btnEliminarEncargados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarEncargados.Size = new System.Drawing.Size(233, 28);
            this.btnEliminarEncargados.TabIndex = 3;
            this.btnEliminarEncargados.Text = "Eliminar";
            this.btnEliminarEncargados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEncargados.UseVisualStyleBackColor = false;
            this.btnEliminarEncargados.Click += new System.EventHandler(this.btnEliminarEncargados_Click_1);
            // 
            // btnEditarEncargados
            // 
            this.btnEditarEncargados.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarEncargados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarEncargados.FlatAppearance.BorderSize = 0;
            this.btnEditarEncargados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarEncargados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarEncargados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEncargados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEncargados.ForeColor = System.Drawing.Color.White;
            this.btnEditarEncargados.Location = new System.Drawing.Point(0, 28);
            this.btnEditarEncargados.Name = "btnEditarEncargados";
            this.btnEditarEncargados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditarEncargados.Size = new System.Drawing.Size(233, 28);
            this.btnEditarEncargados.TabIndex = 2;
            this.btnEditarEncargados.Text = "Editar";
            this.btnEditarEncargados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEncargados.UseVisualStyleBackColor = false;
            this.btnEditarEncargados.Click += new System.EventHandler(this.btnEditarEncargados_Click_1);
            // 
            // btnAgregarEncargados
            // 
            this.btnAgregarEncargados.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEncargados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarEncargados.FlatAppearance.BorderSize = 0;
            this.btnAgregarEncargados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarEncargados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarEncargados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEncargados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEncargados.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEncargados.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarEncargados.Name = "btnAgregarEncargados";
            this.btnAgregarEncargados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarEncargados.Size = new System.Drawing.Size(233, 28);
            this.btnAgregarEncargados.TabIndex = 1;
            this.btnAgregarEncargados.Text = "Agregar";
            this.btnAgregarEncargados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEncargados.UseVisualStyleBackColor = false;
            this.btnAgregarEncargados.Click += new System.EventHandler(this.btnAgregarEncargados_Click_1);
            // 
            // btnEncargados
            // 
            this.btnEncargados.BackColor = System.Drawing.Color.Transparent;
            this.btnEncargados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncargados.FlatAppearance.BorderSize = 0;
            this.btnEncargados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEncargados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEncargados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncargados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncargados.ForeColor = System.Drawing.Color.White;
            this.btnEncargados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncargados.Location = new System.Drawing.Point(0, 853);
            this.btnEncargados.Name = "btnEncargados";
            this.btnEncargados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEncargados.Size = new System.Drawing.Size(233, 40);
            this.btnEncargados.TabIndex = 15;
            this.btnEncargados.Text = "Encargados";
            this.btnEncargados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncargados.UseVisualStyleBackColor = false;
            this.btnEncargados.Click += new System.EventHandler(this.button18_Click);
            // 
            // btnAgregarAlumnos
            // 
            this.btnAgregarAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumnos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAlumnos.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarAlumnos.Name = "btnAgregarAlumnos";
            this.btnAgregarAlumnos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarAlumnos.Size = new System.Drawing.Size(233, 28);
            this.btnAgregarAlumnos.TabIndex = 1;
            this.btnAgregarAlumnos.Text = "Agregar";
            this.btnAgregarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAlumnos.UseVisualStyleBackColor = false;
            this.btnAgregarAlumnos.Click += new System.EventHandler(this.btnAgregarAlumnos_Click);
            // 
            // btnEditarAlumnos
            // 
            this.btnEditarAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnEditarAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEditarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAlumnos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnEditarAlumnos.Location = new System.Drawing.Point(0, 28);
            this.btnEditarAlumnos.Name = "btnEditarAlumnos";
            this.btnEditarAlumnos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditarAlumnos.Size = new System.Drawing.Size(233, 28);
            this.btnEditarAlumnos.TabIndex = 2;
            this.btnEditarAlumnos.Text = "Editar";
            this.btnEditarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAlumnos.UseVisualStyleBackColor = false;
            this.btnEditarAlumnos.Click += new System.EventHandler(this.btnEditarAlumnos_Click);
            // 
            // btnEliminarAlumnos
            // 
            this.btnEliminarAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnEliminarAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlumnos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAlumnos.Location = new System.Drawing.Point(0, 56);
            this.btnEliminarAlumnos.Name = "btnEliminarAlumnos";
            this.btnEliminarAlumnos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarAlumnos.Size = new System.Drawing.Size(233, 28);
            this.btnEliminarAlumnos.TabIndex = 3;
            this.btnEliminarAlumnos.Text = "Eliminar";
            this.btnEliminarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarAlumnos.UseVisualStyleBackColor = false;
            this.btnEliminarAlumnos.Click += new System.EventHandler(this.btnEliminarAlumnos_Click);
            // 
            // btnConsultarAlumnos
            // 
            this.btnConsultarAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnConsultarAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAlumnos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAlumnos.Location = new System.Drawing.Point(0, 84);
            this.btnConsultarAlumnos.Name = "btnConsultarAlumnos";
            this.btnConsultarAlumnos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarAlumnos.Size = new System.Drawing.Size(233, 28);
            this.btnConsultarAlumnos.TabIndex = 4;
            this.btnConsultarAlumnos.Text = "Consultar";
            this.btnConsultarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAlumnos.UseVisualStyleBackColor = false;
            this.btnConsultarAlumnos.Click += new System.EventHandler(this.btnConsultarAlumnos_Click);
            // 
            // SubmenuAlumnos
            // 
            this.SubmenuAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SubmenuAlumnos.Controls.Add(this.btnConsultarAlumnos);
            this.SubmenuAlumnos.Controls.Add(this.btnEliminarAlumnos);
            this.SubmenuAlumnos.Controls.Add(this.btnEditarAlumnos);
            this.SubmenuAlumnos.Controls.Add(this.btnAgregarAlumnos);
            this.SubmenuAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuAlumnos.Location = new System.Drawing.Point(0, 733);
            this.SubmenuAlumnos.Name = "SubmenuAlumnos";
            this.SubmenuAlumnos.Size = new System.Drawing.Size(233, 120);
            this.SubmenuAlumnos.TabIndex = 14;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 693);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAlumnos.Size = new System.Drawing.Size(233, 40);
            this.btnAlumnos.TabIndex = 13;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.UseVisualStyleBackColor = false;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1013);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 100);
            this.panel1.TabIndex = 5;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuVertical);
            this.MinimumSize = new System.Drawing.Size(787, 718);
            this.Name = "FrmAdmin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panelMenuVertical.ResumeLayout(false);
            this.SubmenuDocentes.ResumeLayout(false);
            this.SubmenuRegistro.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SubmenuAsignacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SubmenuEncargados.ResumeLayout(false);
            this.SubmenuAlumnos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel SubmenuRegistro;
        private System.Windows.Forms.Button btnConsultarRegistro;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button btnEditarRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Panel SubmenuDocentes;
        private System.Windows.Forms.Button btnConsultarDocentes;
        private System.Windows.Forms.Button btnEliminarDocentes;
        private System.Windows.Forms.Button btnEditarDocentes;
        private System.Windows.Forms.Button btnAgregarDocentes;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnAsignacion;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel SubmenuEncargados;
        private System.Windows.Forms.Button btnConsultarEncargados;
        private System.Windows.Forms.Button btnEliminarEncargados;
        private System.Windows.Forms.Button btnEditarEncargados;
        private System.Windows.Forms.Button btnAgregarEncargados;
        private System.Windows.Forms.Button btnEncargados;
        private System.Windows.Forms.Panel SubmenuAsignacion;
        private System.Windows.Forms.Button btnEditarAsignacion;
        private System.Windows.Forms.Button btnAgregarAsignacion;
        private System.Windows.Forms.Panel SubmenuAlumnos;
        private System.Windows.Forms.Button btnConsultarAlumnos;
        private System.Windows.Forms.Button btnEliminarAlumnos;
        private System.Windows.Forms.Button btnEditarAlumnos;
        private System.Windows.Forms.Button btnAgregarAlumnos;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Panel panel1;
    }
}