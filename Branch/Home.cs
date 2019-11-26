using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Branch
{
    public partial class Home : Form
    {

        int contador = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            load();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        void load()
        {
            try
            {
                Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\pl");
                Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\pl\bin");
                string[] data = { "-q", "-f", @"base_de_conocimiento.pl" };
                PlEngine.Initialize(data);
            }
            catch (Exception e)
            {

            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExtenderVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            extenderVentana.Visible = false;
            minimizarventana.Visible = true;

        }

        private void Minimizarventana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            minimizarventana.Visible = false;
            extenderVentana.Visible = true;
        }

        private void GroupMaterias_Enter(object sender, EventArgs e)
        {

        }

        private void BarraContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

      
        private void Bresultados_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuCards1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BunifuCards1_Click(object sender, EventArgs e)
        {
            Form1 res = new Form1();
            res.Show();
        }
    }
}

