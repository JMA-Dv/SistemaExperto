namespace Branch
{
    partial class Home
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
            System.Windows.Forms.PictureBox cerrarVentana;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.minimizarventana = new System.Windows.Forms.PictureBox();
            this.extenderVentana = new System.Windows.Forms.PictureBox();
            this.barraIzquierda = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bresultados = new System.Windows.Forms.Button();
            this.groupMaterias = new System.Windows.Forms.GroupBox();
            this.cbDispositivos = new System.Windows.Forms.CheckBox();
            this.cbIA = new System.Windows.Forms.CheckBox();
            this.cbGestores = new System.Windows.Forms.CheckBox();
            this.cbAdminRedes = new System.Windows.Forms.CheckBox();
            this.cbWeb = new System.Windows.Forms.CheckBox();
            this.cbAdminServidores = new System.Windows.Forms.CheckBox();
            this.cbProgramacionBD = new System.Windows.Forms.CheckBox();
            this.cbLenguajesAtomatas = new System.Windows.Forms.CheckBox();
            this.cbConmutacion = new System.Windows.Forms.CheckBox();
            this.cbGPS = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.cbSistemasProgramables = new System.Windows.Forms.CheckBox();
            this.cbProlog = new System.Windows.Forms.CheckBox();
            this.cbRedes = new System.Windows.Forms.CheckBox();
            this.cbLenjuages = new System.Windows.Forms.CheckBox();
            this.cbSoftware = new System.Windows.Forms.CheckBox();
            this.cbArquitectura = new System.Windows.Forms.CheckBox();
            this.cbSimulacion = new System.Windows.Forms.CheckBox();
            this.cbTelecom = new System.Windows.Forms.CheckBox();
            this.cbPrincipiosElectricos = new System.Windows.Forms.CheckBox();
            this.cbBD = new System.Windows.Forms.CheckBox();
            this.cbTopicos = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.cbMetNumericos = new System.Windows.Forms.CheckBox();
            this.cbSistemasOperativos = new System.Windows.Forms.CheckBox();
            this.cdEstructuradeDatos = new System.Windows.Forms.CheckBox();
            this.cbPoo = new System.Windows.Forms.CheckBox();
            this.cbMatDiscretas = new System.Windows.Forms.CheckBox();
            this.cbfundamentos = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cerrarVentana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(cerrarVentana)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarventana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extenderVentana)).BeginInit();
            this.barraIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // cerrarVentana
            // 
            cerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("cerrarVentana.Image")));
            cerrarVentana.Location = new System.Drawing.Point(1303, 11);
            cerrarVentana.Name = "cerrarVentana";
            cerrarVentana.Size = new System.Drawing.Size(25, 25);
            cerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            cerrarVentana.TabIndex = 0;
            cerrarVentana.TabStop = false;
            cerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.BarraTitulo.Controls.Add(this.minimizarventana);
            this.BarraTitulo.Controls.Add(this.extenderVentana);
            this.BarraTitulo.Controls.Add(cerrarVentana);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1337, 44);
            this.BarraTitulo.TabIndex = 6;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // minimizarventana
            // 
            this.minimizarventana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarventana.Image = ((System.Drawing.Image)(resources.GetObject("minimizarventana.Image")));
            this.minimizarventana.Location = new System.Drawing.Point(1241, 11);
            this.minimizarventana.Name = "minimizarventana";
            this.minimizarventana.Size = new System.Drawing.Size(25, 25);
            this.minimizarventana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarventana.TabIndex = 2;
            this.minimizarventana.TabStop = false;
            this.minimizarventana.Click += new System.EventHandler(this.Minimizarventana_Click);
            // 
            // extenderVentana
            // 
            this.extenderVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extenderVentana.Image = ((System.Drawing.Image)(resources.GetObject("extenderVentana.Image")));
            this.extenderVentana.Location = new System.Drawing.Point(1272, 11);
            this.extenderVentana.Name = "extenderVentana";
            this.extenderVentana.Size = new System.Drawing.Size(25, 25);
            this.extenderVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.extenderVentana.TabIndex = 1;
            this.extenderVentana.TabStop = false;
            this.extenderVentana.Click += new System.EventHandler(this.ExtenderVentana_Click);
            // 
            // barraIzquierda
            // 
            this.barraIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.barraIzquierda.Controls.Add(this.pictureBox1);
            this.barraIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraIzquierda.Location = new System.Drawing.Point(0, 44);
            this.barraIzquierda.Name = "barraIzquierda";
            this.barraIzquierda.Size = new System.Drawing.Size(200, 608);
            this.barraIzquierda.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarraContenedor
            // 
            this.BarraContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BarraContenedor.BackColor = System.Drawing.Color.Transparent;
            this.BarraContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BarraContenedor.Controls.Add(this.panel1);
            this.BarraContenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarraContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarraContenedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BarraContenedor.Location = new System.Drawing.Point(200, 44);
            this.BarraContenedor.Name = "BarraContenedor";
            this.BarraContenedor.Size = new System.Drawing.Size(1137, 608);
            this.BarraContenedor.TabIndex = 8;
            this.BarraContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraContenedor_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.bresultados);
            this.panel1.Controls.Add(this.groupMaterias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(22)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 604);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint_1);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // bresultados
            // 
            this.bresultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bresultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(217)))), ((int)(((byte)(172)))));
            this.bresultados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bresultados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bresultados.Font = new System.Drawing.Font("Humanst521 Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bresultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.bresultados.Image = ((System.Drawing.Image)(resources.GetObject("bresultados.Image")));
            this.bresultados.Location = new System.Drawing.Point(477, 486);
            this.bresultados.Name = "bresultados";
            this.bresultados.Size = new System.Drawing.Size(208, 46);
            this.bresultados.TabIndex = 1;
            this.bresultados.Text = "Ver resultados";
            this.bresultados.UseVisualStyleBackColor = false;
            this.bresultados.Click += new System.EventHandler(this.Bresultados_Click);
            // 
            // groupMaterias
            // 
            this.groupMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMaterias.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupMaterias.Controls.Add(this.cbDispositivos);
            this.groupMaterias.Controls.Add(this.cbIA);
            this.groupMaterias.Controls.Add(this.cbGestores);
            this.groupMaterias.Controls.Add(this.cbAdminRedes);
            this.groupMaterias.Controls.Add(this.cbWeb);
            this.groupMaterias.Controls.Add(this.cbAdminServidores);
            this.groupMaterias.Controls.Add(this.cbProgramacionBD);
            this.groupMaterias.Controls.Add(this.cbLenguajesAtomatas);
            this.groupMaterias.Controls.Add(this.cbConmutacion);
            this.groupMaterias.Controls.Add(this.cbGPS);
            this.groupMaterias.Controls.Add(this.checkBox6);
            this.groupMaterias.Controls.Add(this.cbSistemasProgramables);
            this.groupMaterias.Controls.Add(this.cbProlog);
            this.groupMaterias.Controls.Add(this.cbRedes);
            this.groupMaterias.Controls.Add(this.cbLenjuages);
            this.groupMaterias.Controls.Add(this.cbSoftware);
            this.groupMaterias.Controls.Add(this.cbArquitectura);
            this.groupMaterias.Controls.Add(this.cbSimulacion);
            this.groupMaterias.Controls.Add(this.cbTelecom);
            this.groupMaterias.Controls.Add(this.cbPrincipiosElectricos);
            this.groupMaterias.Controls.Add(this.cbBD);
            this.groupMaterias.Controls.Add(this.cbTopicos);
            this.groupMaterias.Controls.Add(this.checkBox5);
            this.groupMaterias.Controls.Add(this.cbMetNumericos);
            this.groupMaterias.Controls.Add(this.cbSistemasOperativos);
            this.groupMaterias.Controls.Add(this.cdEstructuradeDatos);
            this.groupMaterias.Controls.Add(this.cbPoo);
            this.groupMaterias.Controls.Add(this.cbMatDiscretas);
            this.groupMaterias.Controls.Add(this.cbfundamentos);
            this.groupMaterias.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.groupMaterias.Location = new System.Drawing.Point(12, 13);
            this.groupMaterias.Name = "groupMaterias";
            this.groupMaterias.Size = new System.Drawing.Size(1109, 373);
            this.groupMaterias.TabIndex = 0;
            this.groupMaterias.TabStop = false;
            this.groupMaterias.Text = "Selecciona 8 Materias de tu agrado";
            this.groupMaterias.Enter += new System.EventHandler(this.GroupMaterias_Enter);
            // 
            // cbDispositivos
            // 
            this.cbDispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDispositivos.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDispositivos.AutoSize = true;
            this.cbDispositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbDispositivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbDispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDispositivos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDispositivos.ForeColor = System.Drawing.Color.White;
            this.cbDispositivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDispositivos.Location = new System.Drawing.Point(796, 264);
            this.cbDispositivos.Name = "cbDispositivos";
            this.cbDispositivos.Size = new System.Drawing.Size(298, 31);
            this.cbDispositivos.TabIndex = 28;
            this.cbDispositivos.Text = "Base de Datos para Dispositivos Móviles";
            this.cbDispositivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDispositivos.UseVisualStyleBackColor = false;
            this.cbDispositivos.CheckedChanged += new System.EventHandler(this.CbDispositivos_CheckedChanged);
            // 
            // cbIA
            // 
            this.cbIA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIA.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbIA.AutoSize = true;
            this.cbIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbIA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbIA.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIA.ForeColor = System.Drawing.Color.White;
            this.cbIA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIA.Location = new System.Drawing.Point(933, 96);
            this.cbIA.Name = "cbIA";
            this.cbIA.Size = new System.Drawing.Size(160, 31);
            this.cbIA.TabIndex = 27;
            this.cbIA.Text = "Inteligencia Artificial";
            this.cbIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbIA.UseVisualStyleBackColor = false;
            this.cbIA.CheckedChanged += new System.EventHandler(this.CbIA_CheckedChanged);
            // 
            // cbGestores
            // 
            this.cbGestores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGestores.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbGestores.AutoSize = true;
            this.cbGestores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbGestores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbGestores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGestores.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGestores.ForeColor = System.Drawing.Color.White;
            this.cbGestores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbGestores.Location = new System.Drawing.Point(830, 38);
            this.cbGestores.Name = "cbGestores";
            this.cbGestores.Size = new System.Drawing.Size(269, 31);
            this.cbGestores.TabIndex = 26;
            this.cbGestores.Text = "Sistemas Gestores de Base de Datos";
            this.cbGestores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbGestores.UseVisualStyleBackColor = false;
            this.cbGestores.CheckedChanged += new System.EventHandler(this.CbGestores_CheckedChanged);
            // 
            // cbAdminRedes
            // 
            this.cbAdminRedes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAdminRedes.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAdminRedes.AutoSize = true;
            this.cbAdminRedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbAdminRedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbAdminRedes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAdminRedes.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdminRedes.ForeColor = System.Drawing.Color.White;
            this.cbAdminRedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAdminRedes.Location = new System.Drawing.Point(512, 320);
            this.cbAdminRedes.Name = "cbAdminRedes";
            this.cbAdminRedes.Size = new System.Drawing.Size(192, 31);
            this.cbAdminRedes.TabIndex = 25;
            this.cbAdminRedes.Text = "Administración de Redes";
            this.cbAdminRedes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAdminRedes.UseVisualStyleBackColor = false;
            this.cbAdminRedes.CheckedChanged += new System.EventHandler(this.CbAdminRedes_CheckedChanged);
            // 
            // cbWeb
            // 
            this.cbWeb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWeb.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbWeb.AutoSize = true;
            this.cbWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbWeb.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWeb.ForeColor = System.Drawing.Color.White;
            this.cbWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbWeb.Location = new System.Drawing.Point(888, 208);
            this.cbWeb.Name = "cbWeb";
            this.cbWeb.Size = new System.Drawing.Size(154, 31);
            this.cbWeb.TabIndex = 24;
            this.cbWeb.Text = "Programación Web";
            this.cbWeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbWeb.UseVisualStyleBackColor = false;
            this.cbWeb.CheckedChanged += new System.EventHandler(this.CbWeb_CheckedChanged);
            // 
            // cbAdminServidores
            // 
            this.cbAdminServidores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAdminServidores.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAdminServidores.AutoSize = true;
            this.cbAdminServidores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbAdminServidores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbAdminServidores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAdminServidores.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdminServidores.ForeColor = System.Drawing.Color.White;
            this.cbAdminServidores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAdminServidores.Location = new System.Drawing.Point(844, 152);
            this.cbAdminServidores.Name = "cbAdminServidores";
            this.cbAdminServidores.Size = new System.Drawing.Size(224, 31);
            this.cbAdminServidores.TabIndex = 23;
            this.cbAdminServidores.Text = "Administración de Servidores";
            this.cbAdminServidores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAdminServidores.UseVisualStyleBackColor = false;
            this.cbAdminServidores.CheckedChanged += new System.EventHandler(this.CbAdminServidores_CheckedChanged);
            // 
            // cbProgramacionBD
            // 
            this.cbProgramacionBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProgramacionBD.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbProgramacionBD.AutoSize = true;
            this.cbProgramacionBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbProgramacionBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbProgramacionBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProgramacionBD.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgramacionBD.ForeColor = System.Drawing.Color.White;
            this.cbProgramacionBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbProgramacionBD.Location = new System.Drawing.Point(540, 264);
            this.cbProgramacionBD.Name = "cbProgramacionBD";
            this.cbProgramacionBD.Size = new System.Drawing.Size(240, 31);
            this.cbProgramacionBD.TabIndex = 22;
            this.cbProgramacionBD.Text = "Programación de Base de Datos";
            this.cbProgramacionBD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbProgramacionBD.UseVisualStyleBackColor = false;
            this.cbProgramacionBD.CheckedChanged += new System.EventHandler(this.CbProgramacionBD_CheckedChanged);
            // 
            // cbLenguajesAtomatas
            // 
            this.cbLenguajesAtomatas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLenguajesAtomatas.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbLenguajesAtomatas.AutoSize = true;
            this.cbLenguajesAtomatas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbLenguajesAtomatas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbLenguajesAtomatas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLenguajesAtomatas.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLenguajesAtomatas.ForeColor = System.Drawing.Color.White;
            this.cbLenguajesAtomatas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbLenguajesAtomatas.Location = new System.Drawing.Point(687, 208);
            this.cbLenguajesAtomatas.Name = "cbLenguajesAtomatas";
            this.cbLenguajesAtomatas.Size = new System.Drawing.Size(182, 31);
            this.cbLenguajesAtomatas.TabIndex = 21;
            this.cbLenguajesAtomatas.Text = "Lenguajes y Automotas";
            this.cbLenguajesAtomatas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbLenguajesAtomatas.UseVisualStyleBackColor = false;
            this.cbLenguajesAtomatas.CheckedChanged += new System.EventHandler(this.CbLenguajesAtomatas_CheckedChanged);
            // 
            // cbConmutacion
            // 
            this.cbConmutacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConmutacion.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbConmutacion.AutoSize = true;
            this.cbConmutacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbConmutacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbConmutacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbConmutacion.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConmutacion.ForeColor = System.Drawing.Color.White;
            this.cbConmutacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbConmutacion.Location = new System.Drawing.Point(731, 320);
            this.cbConmutacion.Name = "cbConmutacion";
            this.cbConmutacion.Size = new System.Drawing.Size(359, 31);
            this.cbConmutacion.TabIndex = 20;
            this.cbConmutacion.Text = "Conmutación y enrutamiendo de Redes de Datos";
            this.cbConmutacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbConmutacion.UseVisualStyleBackColor = false;
            this.cbConmutacion.CheckedChanged += new System.EventHandler(this.CheckBox8_CheckedChanged);
            // 
            // cbGPS
            // 
            this.cbGPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGPS.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbGPS.AutoSize = true;
            this.cbGPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbGPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbGPS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGPS.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGPS.ForeColor = System.Drawing.Color.White;
            this.cbGPS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbGPS.Location = new System.Drawing.Point(235, 320);
            this.cbGPS.Name = "cbGPS";
            this.cbGPS.Size = new System.Drawing.Size(253, 31);
            this.cbGPS.TabIndex = 19;
            this.cbGPS.Text = "Gestión de Proyectos de Software";
            this.cbGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbGPS.UseVisualStyleBackColor = false;
            this.cbGPS.CheckedChanged += new System.EventHandler(this.CbGPS_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.checkBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox6.Location = new System.Drawing.Point(525, 152);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(98, 31);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "Graficación";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // cbSistemasProgramables
            // 
            this.cbSistemasProgramables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSistemasProgramables.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSistemasProgramables.AutoSize = true;
            this.cbSistemasProgramables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbSistemasProgramables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbSistemasProgramables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSistemasProgramables.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSistemasProgramables.ForeColor = System.Drawing.Color.White;
            this.cbSistemasProgramables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSistemasProgramables.Location = new System.Drawing.Point(644, 152);
            this.cbSistemasProgramables.Name = "cbSistemasProgramables";
            this.cbSistemasProgramables.Size = new System.Drawing.Size(183, 31);
            this.cbSistemasProgramables.TabIndex = 17;
            this.cbSistemasProgramables.Text = "Sistemas Programables";
            this.cbSistemasProgramables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSistemasProgramables.UseVisualStyleBackColor = false;
            this.cbSistemasProgramables.CheckedChanged += new System.EventHandler(this.CbSistemasProgramables_CheckedChanged);
            // 
            // cbProlog
            // 
            this.cbProlog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProlog.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbProlog.AutoSize = true;
            this.cbProlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbProlog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbProlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProlog.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProlog.ForeColor = System.Drawing.Color.White;
            this.cbProlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbProlog.Location = new System.Drawing.Point(658, 96);
            this.cbProlog.Name = "cbProlog";
            this.cbProlog.Size = new System.Drawing.Size(254, 31);
            this.cbProlog.TabIndex = 16;
            this.cbProlog.Text = "Programación Lógica  y Funcional";
            this.cbProlog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbProlog.UseVisualStyleBackColor = false;
            this.cbProlog.CheckedChanged += new System.EventHandler(this.CbProlog_CheckedChanged);
            // 
            // cbRedes
            // 
            this.cbRedes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRedes.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbRedes.AutoSize = true;
            this.cbRedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbRedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbRedes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRedes.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRedes.ForeColor = System.Drawing.Color.White;
            this.cbRedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbRedes.Location = new System.Drawing.Point(24, 320);
            this.cbRedes.Name = "cbRedes";
            this.cbRedes.Size = new System.Drawing.Size(190, 31);
            this.cbRedes.TabIndex = 15;
            this.cbRedes.Text = "Redes de Computadoras";
            this.cbRedes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbRedes.UseVisualStyleBackColor = false;
            this.cbRedes.CheckedChanged += new System.EventHandler(this.CbRedes_CheckedChanged);
            // 
            // cbLenjuages
            // 
            this.cbLenjuages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLenjuages.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbLenjuages.AutoSize = true;
            this.cbLenjuages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbLenjuages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbLenjuages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLenjuages.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLenjuages.ForeColor = System.Drawing.Color.White;
            this.cbLenjuages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbLenjuages.Location = new System.Drawing.Point(644, 38);
            this.cbLenjuages.Name = "cbLenjuages";
            this.cbLenjuages.Size = new System.Drawing.Size(167, 31);
            this.cbLenjuages.TabIndex = 14;
            this.cbLenjuages.Text = "Lenguajes de Interfaz";
            this.cbLenjuages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbLenjuages.UseVisualStyleBackColor = false;
            this.cbLenjuages.CheckedChanged += new System.EventHandler(this.CbLenjuages_CheckedChanged);
            // 
            // cbSoftware
            // 
            this.cbSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSoftware.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSoftware.AutoSize = true;
            this.cbSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSoftware.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoftware.ForeColor = System.Drawing.Color.White;
            this.cbSoftware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSoftware.Location = new System.Drawing.Point(450, 38);
            this.cbSoftware.Name = "cbSoftware";
            this.cbSoftware.Size = new System.Drawing.Size(176, 31);
            this.cbSoftware.TabIndex = 13;
            this.cbSoftware.Text = "Ingeniería de Software";
            this.cbSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSoftware.UseVisualStyleBackColor = false;
            this.cbSoftware.CheckedChanged += new System.EventHandler(this.CbSoftware_CheckedChanged);
            // 
            // cbArquitectura
            // 
            this.cbArquitectura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArquitectura.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbArquitectura.AutoSize = true;
            this.cbArquitectura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbArquitectura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbArquitectura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbArquitectura.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArquitectura.ForeColor = System.Drawing.Color.White;
            this.cbArquitectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbArquitectura.Location = new System.Drawing.Point(405, 96);
            this.cbArquitectura.Name = "cbArquitectura";
            this.cbArquitectura.Size = new System.Drawing.Size(234, 31);
            this.cbArquitectura.TabIndex = 12;
            this.cbArquitectura.Text = "Arquitectura de Computadoras";
            this.cbArquitectura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbArquitectura.UseVisualStyleBackColor = false;
            this.cbArquitectura.CheckedChanged += new System.EventHandler(this.CbArquitectura_CheckedChanged);
            // 
            // cbSimulacion
            // 
            this.cbSimulacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSimulacion.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSimulacion.AutoSize = true;
            this.cbSimulacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbSimulacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbSimulacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSimulacion.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSimulacion.ForeColor = System.Drawing.Color.White;
            this.cbSimulacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSimulacion.Location = new System.Drawing.Point(327, 152);
            this.cbSimulacion.Name = "cbSimulacion";
            this.cbSimulacion.Size = new System.Drawing.Size(97, 31);
            this.cbSimulacion.TabIndex = 11;
            this.cbSimulacion.Text = "Simulación";
            this.cbSimulacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSimulacion.UseVisualStyleBackColor = false;
            this.cbSimulacion.CheckedChanged += new System.EventHandler(this.CbSimulacion_CheckedChanged);
            // 
            // cbTelecom
            // 
            this.cbTelecom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTelecom.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbTelecom.AutoSize = true;
            this.cbTelecom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbTelecom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbTelecom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTelecom.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTelecom.ForeColor = System.Drawing.Color.White;
            this.cbTelecom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTelecom.Location = new System.Drawing.Point(382, 208);
            this.cbTelecom.Name = "cbTelecom";
            this.cbTelecom.Size = new System.Drawing.Size(279, 31);
            this.cbTelecom.TabIndex = 10;
            this.cbTelecom.Text = "Fundamentos de Telecomunicaciones";
            this.cbTelecom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTelecom.UseVisualStyleBackColor = false;
            this.cbTelecom.CheckedChanged += new System.EventHandler(this.CbTelecom_CheckedChanged);
            // 
            // cbPrincipiosElectricos
            // 
            this.cbPrincipiosElectricos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPrincipiosElectricos.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPrincipiosElectricos.AutoSize = true;
            this.cbPrincipiosElectricos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbPrincipiosElectricos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbPrincipiosElectricos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPrincipiosElectricos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrincipiosElectricos.ForeColor = System.Drawing.Color.White;
            this.cbPrincipiosElectricos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPrincipiosElectricos.Location = new System.Drawing.Point(197, 264);
            this.cbPrincipiosElectricos.Name = "cbPrincipiosElectricos";
            this.cbPrincipiosElectricos.Size = new System.Drawing.Size(323, 31);
            this.cbPrincipiosElectricos.TabIndex = 9;
            this.cbPrincipiosElectricos.Text = "Principios Electricos y Aplicaciones Digitales";
            this.cbPrincipiosElectricos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPrincipiosElectricos.UseVisualStyleBackColor = false;
            this.cbPrincipiosElectricos.CheckedChanged += new System.EventHandler(this.CbPrincipiosElectricos_CheckedChanged);
            // 
            // cbBD
            // 
            this.cbBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBD.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBD.AutoSize = true;
            this.cbBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBD.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBD.ForeColor = System.Drawing.Color.White;
            this.cbBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbBD.Location = new System.Drawing.Point(242, 208);
            this.cbBD.Name = "cbBD";
            this.cbBD.Size = new System.Drawing.Size(117, 31);
            this.cbBD.TabIndex = 8;
            this.cbBD.Text = "Base de Datos";
            this.cbBD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbBD.UseVisualStyleBackColor = false;
            this.cbBD.CheckedChanged += new System.EventHandler(this.CbBD_CheckedChanged);
            // 
            // cbTopicos
            // 
            this.cbTopicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopicos.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbTopicos.AutoSize = true;
            this.cbTopicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbTopicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbTopicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTopicos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTopicos.ForeColor = System.Drawing.Color.White;
            this.cbTopicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTopicos.Location = new System.Drawing.Point(33, 152);
            this.cbTopicos.Name = "cbTopicos";
            this.cbTopicos.Size = new System.Drawing.Size(275, 31);
            this.cbTopicos.TabIndex = 7;
            this.cbTopicos.Text = "Tópicos Avanzados de Programación";
            this.cbTopicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTopicos.UseVisualStyleBackColor = false;
            this.cbTopicos.CheckedChanged += new System.EventHandler(this.CbTopicos_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.checkBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox5.Location = new System.Drawing.Point(212, 96);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(175, 31);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Matemáticas Discretas";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // cbMetNumericos
            // 
            this.cbMetNumericos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMetNumericos.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMetNumericos.AutoSize = true;
            this.cbMetNumericos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbMetNumericos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbMetNumericos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMetNumericos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetNumericos.ForeColor = System.Drawing.Color.White;
            this.cbMetNumericos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbMetNumericos.Location = new System.Drawing.Point(271, 38);
            this.cbMetNumericos.Name = "cbMetNumericos";
            this.cbMetNumericos.Size = new System.Drawing.Size(161, 31);
            this.cbMetNumericos.TabIndex = 5;
            this.cbMetNumericos.Text = "Métodos Numéricos";
            this.cbMetNumericos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMetNumericos.UseVisualStyleBackColor = false;
            this.cbMetNumericos.CheckedChanged += new System.EventHandler(this.CbMetNumericos_CheckedChanged);
            // 
            // cbSistemasOperativos
            // 
            this.cbSistemasOperativos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSistemasOperativos.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSistemasOperativos.AutoSize = true;
            this.cbSistemasOperativos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbSistemasOperativos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbSistemasOperativos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSistemasOperativos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSistemasOperativos.ForeColor = System.Drawing.Color.White;
            this.cbSistemasOperativos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSistemasOperativos.Location = new System.Drawing.Point(19, 264);
            this.cbSistemasOperativos.Name = "cbSistemasOperativos";
            this.cbSistemasOperativos.Size = new System.Drawing.Size(162, 31);
            this.cbSistemasOperativos.TabIndex = 4;
            this.cbSistemasOperativos.Text = "Sistemas Operativos";
            this.cbSistemasOperativos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSistemasOperativos.UseVisualStyleBackColor = false;
            this.cbSistemasOperativos.CheckedChanged += new System.EventHandler(this.CbSistemasOperativos_CheckedChanged);
            // 
            // cdEstructuradeDatos
            // 
            this.cdEstructuradeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdEstructuradeDatos.Appearance = System.Windows.Forms.Appearance.Button;
            this.cdEstructuradeDatos.AutoSize = true;
            this.cdEstructuradeDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cdEstructuradeDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cdEstructuradeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdEstructuradeDatos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdEstructuradeDatos.ForeColor = System.Drawing.Color.White;
            this.cdEstructuradeDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cdEstructuradeDatos.Location = new System.Drawing.Point(63, 208);
            this.cdEstructuradeDatos.Name = "cdEstructuradeDatos";
            this.cdEstructuradeDatos.Size = new System.Drawing.Size(155, 31);
            this.cdEstructuradeDatos.TabIndex = 3;
            this.cdEstructuradeDatos.Text = "Estructura de Datos";
            this.cdEstructuradeDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cdEstructuradeDatos.UseVisualStyleBackColor = false;
            this.cdEstructuradeDatos.CheckedChanged += new System.EventHandler(this.CdEstructuradeDatos_CheckedChanged);
            // 
            // cbPoo
            // 
            this.cbPoo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPoo.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPoo.AutoSize = true;
            this.cbPoo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbPoo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbPoo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPoo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPoo.ForeColor = System.Drawing.Color.White;
            this.cbPoo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPoo.Location = new System.Drawing.Point(450, 152);
            this.cbPoo.Name = "cbPoo";
            this.cbPoo.Size = new System.Drawing.Size(53, 31);
            this.cbPoo.TabIndex = 2;
            this.cbPoo.Text = "POO";
            this.cbPoo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPoo.UseVisualStyleBackColor = false;
            this.cbPoo.CheckedChanged += new System.EventHandler(this.CbPoo_CheckedChanged);
            // 
            // cbMatDiscretas
            // 
            this.cbMatDiscretas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMatDiscretas.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMatDiscretas.AutoSize = true;
            this.cbMatDiscretas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbMatDiscretas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbMatDiscretas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMatDiscretas.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMatDiscretas.ForeColor = System.Drawing.Color.White;
            this.cbMatDiscretas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbMatDiscretas.Location = new System.Drawing.Point(19, 96);
            this.cbMatDiscretas.Name = "cbMatDiscretas";
            this.cbMatDiscretas.Size = new System.Drawing.Size(175, 31);
            this.cbMatDiscretas.TabIndex = 1;
            this.cbMatDiscretas.Text = "Matemáticas Discretas";
            this.cbMatDiscretas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMatDiscretas.UseVisualStyleBackColor = false;
            this.cbMatDiscretas.CheckedChanged += new System.EventHandler(this.CbMatDiscretas_CheckedChanged);
            // 
            // cbfundamentos
            // 
            this.cbfundamentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbfundamentos.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbfundamentos.AutoSize = true;
            this.cbfundamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(57)))));
            this.cbfundamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbfundamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbfundamentos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfundamentos.ForeColor = System.Drawing.Color.White;
            this.cbfundamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbfundamentos.Location = new System.Drawing.Point(19, 38);
            this.cbfundamentos.Name = "cbfundamentos";
            this.cbfundamentos.Size = new System.Drawing.Size(238, 31);
            this.cbfundamentos.TabIndex = 0;
            this.cbfundamentos.Text = "Fundamentos de programación";
            this.cbfundamentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbfundamentos.UseVisualStyleBackColor = false;
            this.cbfundamentos.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1337, 652);
            this.Controls.Add(this.BarraContenedor);
            this.Controls.Add(this.barraIzquierda);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(cerrarVentana)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizarventana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extenderVentana)).EndInit();
            this.barraIzquierda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupMaterias.ResumeLayout(false);
            this.groupMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox minimizarventana;
        private System.Windows.Forms.PictureBox extenderVentana;
        private System.Windows.Forms.Panel barraIzquierda;
        private System.Windows.Forms.Panel BarraContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupMaterias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbfundamentos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbMatDiscretas;
        private System.Windows.Forms.CheckBox cbProgramacionBD;
        private System.Windows.Forms.CheckBox cbLenguajesAtomatas;
        private System.Windows.Forms.CheckBox cbConmutacion;
        private System.Windows.Forms.CheckBox cbGPS;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox cbSistemasProgramables;
        private System.Windows.Forms.CheckBox cbProlog;
        private System.Windows.Forms.CheckBox cbRedes;
        private System.Windows.Forms.CheckBox cbLenjuages;
        private System.Windows.Forms.CheckBox cbSoftware;
        private System.Windows.Forms.CheckBox cbArquitectura;
        private System.Windows.Forms.CheckBox cbSimulacion;
        private System.Windows.Forms.CheckBox cbTelecom;
        private System.Windows.Forms.CheckBox cbPrincipiosElectricos;
        private System.Windows.Forms.CheckBox cbBD;
        private System.Windows.Forms.CheckBox cbTopicos;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox cbMetNumericos;
        private System.Windows.Forms.CheckBox cbSistemasOperativos;
        private System.Windows.Forms.CheckBox cdEstructuradeDatos;
        private System.Windows.Forms.CheckBox cbPoo;
        private System.Windows.Forms.CheckBox cbAdminRedes;
        private System.Windows.Forms.CheckBox cbWeb;
        private System.Windows.Forms.CheckBox cbAdminServidores;
        private System.Windows.Forms.CheckBox cbIA;
        private System.Windows.Forms.CheckBox cbDispositivos;
        private System.Windows.Forms.CheckBox cbGestores;
        private System.Windows.Forms.Button bresultados;
    }
}

