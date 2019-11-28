namespace Branch
{
    partial class juego
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
            System.Windows.Forms.PictureBox cerrarVentana;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(juego));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.arquitecturaBox = new System.Windows.Forms.CheckBox();
            this.telecomunicacionesBox = new System.Windows.Forms.CheckBox();
            this.fundamentosIngenieriaBox = new System.Windows.Forms.CheckBox();
            this.baseDeDatoBox = new System.Windows.Forms.CheckBox();
            this.conmutacionBox = new System.Windows.Forms.CheckBox();
            this.gestionBox = new System.Windows.Forms.CheckBox();
            this.webBox = new System.Windows.Forms.CheckBox();
            this.prologBox = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jugarButton = new System.Windows.Forms.Button();
            cerrarVentana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(cerrarVentana)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cerrarVentana
            // 
            cerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("cerrarVentana.Image")));
            cerrarVentana.Location = new System.Drawing.Point(1160, 9);
            cerrarVentana.Name = "cerrarVentana";
            cerrarVentana.Size = new System.Drawing.Size(25, 25);
            cerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            cerrarVentana.TabIndex = 1;
            cerrarVentana.TabStop = false;
            cerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(cerrarVentana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 42);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // arquitecturaBox
            // 
            this.arquitecturaBox.Image = ((System.Drawing.Image)(resources.GetObject("arquitecturaBox.Image")));
            this.arquitecturaBox.Location = new System.Drawing.Point(132, 46);
            this.arquitecturaBox.Name = "arquitecturaBox";
            this.arquitecturaBox.Size = new System.Drawing.Size(209, 138);
            this.arquitecturaBox.TabIndex = 2;
            this.arquitecturaBox.UseVisualStyleBackColor = true;
            this.arquitecturaBox.CheckedChanged += new System.EventHandler(this.arquitecturaBox_CheckedChanged);
            // 
            // telecomunicacionesBox
            // 
            this.telecomunicacionesBox.Image = ((System.Drawing.Image)(resources.GetObject("telecomunicacionesBox.Image")));
            this.telecomunicacionesBox.Location = new System.Drawing.Point(28, 190);
            this.telecomunicacionesBox.Name = "telecomunicacionesBox";
            this.telecomunicacionesBox.Size = new System.Drawing.Size(238, 138);
            this.telecomunicacionesBox.TabIndex = 3;
            this.telecomunicacionesBox.UseVisualStyleBackColor = true;
            this.telecomunicacionesBox.CheckedChanged += new System.EventHandler(this.telecomunicacionesBox_CheckedChanged);
            // 
            // fundamentosIngenieriaBox
            // 
            this.fundamentosIngenieriaBox.Image = ((System.Drawing.Image)(resources.GetObject("fundamentosIngenieriaBox.Image")));
            this.fundamentosIngenieriaBox.Location = new System.Drawing.Point(28, 344);
            this.fundamentosIngenieriaBox.Name = "fundamentosIngenieriaBox";
            this.fundamentosIngenieriaBox.Size = new System.Drawing.Size(225, 127);
            this.fundamentosIngenieriaBox.TabIndex = 4;
            this.fundamentosIngenieriaBox.UseVisualStyleBackColor = true;
            this.fundamentosIngenieriaBox.Click += new System.EventHandler(this.fundamentosIngenieriaBox_Click);
            // 
            // baseDeDatoBox
            // 
            this.baseDeDatoBox.Image = ((System.Drawing.Image)(resources.GetObject("baseDeDatoBox.Image")));
            this.baseDeDatoBox.Location = new System.Drawing.Point(132, 489);
            this.baseDeDatoBox.Name = "baseDeDatoBox";
            this.baseDeDatoBox.Size = new System.Drawing.Size(226, 126);
            this.baseDeDatoBox.TabIndex = 5;
            this.baseDeDatoBox.UseVisualStyleBackColor = true;
            this.baseDeDatoBox.Click += new System.EventHandler(this.baseDeDatoBox_Click);
            // 
            // conmutacionBox
            // 
            this.conmutacionBox.Image = ((System.Drawing.Image)(resources.GetObject("conmutacionBox.Image")));
            this.conmutacionBox.Location = new System.Drawing.Point(814, 46);
            this.conmutacionBox.Name = "conmutacionBox";
            this.conmutacionBox.Size = new System.Drawing.Size(250, 138);
            this.conmutacionBox.TabIndex = 6;
            this.conmutacionBox.UseVisualStyleBackColor = true;
            this.conmutacionBox.Click += new System.EventHandler(this.conmutacionBox_Click);
            // 
            // gestionBox
            // 
            this.gestionBox.Image = ((System.Drawing.Image)(resources.GetObject("gestionBox.Image")));
            this.gestionBox.Location = new System.Drawing.Point(881, 190);
            this.gestionBox.Name = "gestionBox";
            this.gestionBox.Size = new System.Drawing.Size(250, 138);
            this.gestionBox.TabIndex = 7;
            this.gestionBox.UseVisualStyleBackColor = true;
            this.gestionBox.Click += new System.EventHandler(this.gestionBox_Click);
            // 
            // webBox
            // 
            this.webBox.Image = ((System.Drawing.Image)(resources.GetObject("webBox.Image")));
            this.webBox.Location = new System.Drawing.Point(881, 344);
            this.webBox.Name = "webBox";
            this.webBox.Size = new System.Drawing.Size(233, 127);
            this.webBox.TabIndex = 8;
            this.webBox.UseVisualStyleBackColor = true;
            this.webBox.Click += new System.EventHandler(this.webBox_Click);
            // 
            // prologBox
            // 
            this.prologBox.Image = ((System.Drawing.Image)(resources.GetObject("prologBox.Image")));
            this.prologBox.Location = new System.Drawing.Point(798, 491);
            this.prologBox.Name = "prologBox";
            this.prologBox.Size = new System.Drawing.Size(227, 124);
            this.prologBox.TabIndex = 9;
            this.prologBox.UseVisualStyleBackColor = true;
            this.prologBox.Click += new System.EventHandler(this.prologBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(488, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 257);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.jugarButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 65);
            this.panel2.TabIndex = 12;
            // 
            // jugarButton
            // 
            this.jugarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jugarButton.BackgroundImage")));
            this.jugarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jugarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugarButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.jugarButton.Location = new System.Drawing.Point(428, 17);
            this.jugarButton.Name = "jugarButton";
            this.jugarButton.Size = new System.Drawing.Size(292, 36);
            this.jugarButton.TabIndex = 13;
            this.jugarButton.Text = "JUGAR";
            this.jugarButton.UseVisualStyleBackColor = true;
            this.jugarButton.Click += new System.EventHandler(this.jugarButton_Click);
            // 
            // juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.prologBox);
            this.Controls.Add(this.webBox);
            this.Controls.Add(this.gestionBox);
            this.Controls.Add(this.conmutacionBox);
            this.Controls.Add(this.baseDeDatoBox);
            this.Controls.Add(this.fundamentosIngenieriaBox);
            this.Controls.Add(this.arquitecturaBox);
            this.Controls.Add(this.telecomunicacionesBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "juego";
            this.Text = "juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(cerrarVentana)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox prologBox;
        private System.Windows.Forms.CheckBox webBox;
        private System.Windows.Forms.CheckBox gestionBox;
        private System.Windows.Forms.CheckBox conmutacionBox;
        private System.Windows.Forms.CheckBox baseDeDatoBox;
        private System.Windows.Forms.CheckBox fundamentosIngenieriaBox;
        private System.Windows.Forms.CheckBox arquitecturaBox;
        private System.Windows.Forms.CheckBox telecomunicacionesBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button jugarButton;
    }
}