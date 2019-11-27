namespace Branch
{
    partial class winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winner));
            this.label1 = new System.Windows.Forms.Label();
            this.nombreGanador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("\"Call Me\", (Maybe)?", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(355, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "WINNER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreGanador
            // 
            this.nombreGanador.AutoSize = true;
            this.nombreGanador.BackColor = System.Drawing.Color.Transparent;
            this.nombreGanador.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGanador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nombreGanador.Location = new System.Drawing.Point(398, 284);
            this.nombreGanador.Name = "nombreGanador";
            this.nombreGanador.Size = new System.Drawing.Size(120, 50);
            this.nombreGanador.TabIndex = 1;
            this.nombreGanador.Text = "label2";
            this.nombreGanador.Click += new System.EventHandler(this.NombreGanador_Click);
            // 
            // winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(905, 514);
            this.Controls.Add(this.nombreGanador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "winner";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Winner_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreGanador;
    }
}