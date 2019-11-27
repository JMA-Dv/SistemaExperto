namespace Branch
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.areaPorMateria = new System.Windows.Forms.Button();
            this.materiaPorArea = new System.Windows.Forms.Button();
            this.Minijuego = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 129);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(572, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "M.C Rosa Ernestina Pelayo Márquez";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(541, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "PROGRAMACIÓN LÓGICA Y FUNCIONAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // areaPorMateria
            // 
            this.areaPorMateria.FlatAppearance.BorderSize = 0;
            this.areaPorMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areaPorMateria.Image = ((System.Drawing.Image)(resources.GetObject("areaPorMateria.Image")));
            this.areaPorMateria.Location = new System.Drawing.Point(22, 213);
            this.areaPorMateria.Name = "areaPorMateria";
            this.areaPorMateria.Size = new System.Drawing.Size(418, 449);
            this.areaPorMateria.TabIndex = 1;
            this.areaPorMateria.UseVisualStyleBackColor = true;
            this.areaPorMateria.Click += new System.EventHandler(this.AreaPorMateria_Click);
            // 
            // materiaPorArea
            // 
            this.materiaPorArea.FlatAppearance.BorderSize = 0;
            this.materiaPorArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materiaPorArea.Image = ((System.Drawing.Image)(resources.GetObject("materiaPorArea.Image")));
            this.materiaPorArea.Location = new System.Drawing.Point(488, 135);
            this.materiaPorArea.Name = "materiaPorArea";
            this.materiaPorArea.Size = new System.Drawing.Size(468, 467);
            this.materiaPorArea.TabIndex = 2;
            this.materiaPorArea.UseVisualStyleBackColor = true;
            this.materiaPorArea.Click += new System.EventHandler(this.MateriaPorArea_Click);
            // 
            // Minijuego
            // 
            this.Minijuego.FlatAppearance.BorderSize = 0;
            this.Minijuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minijuego.Image = ((System.Drawing.Image)(resources.GetObject("Minijuego.Image")));
            this.Minijuego.Location = new System.Drawing.Point(983, 213);
            this.Minijuego.Name = "Minijuego";
            this.Minijuego.Size = new System.Drawing.Size(433, 454);
            this.Minijuego.TabIndex = 3;
            this.Minijuego.UseVisualStyleBackColor = true;
            this.Minijuego.Click += new System.EventHandler(this.Minijuego_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1430, 43);
            this.panel2.TabIndex = 4;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Minijuego);
            this.Controls.Add(this.materiaPorArea);
            this.Controls.Add(this.areaPorMateria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Menú";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button areaPorMateria;
        private System.Windows.Forms.Button materiaPorArea;
        private System.Windows.Forms.Button Minijuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}